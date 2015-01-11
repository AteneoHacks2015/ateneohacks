<?php


class ChikkaSMS {

 
    private $clientId = '';
    private $secretKey = '';
    private $shortCode = '';
    private $sslVerify = false;
    

    private $chikkaSendUrl = 'https://post.chikka.com/smsapi/request';
    
    private $sendRequest = 'send';
    private $receiveRequest = 'incoming';
    private $replyRequest = 'reply';
    private $notificationRequest = 'outgoing';

    private $requestCost = array(
        'free' => 'FREE', 
        '1' =>1, 
        '2.5'=> 2.5, 
        '5'=> 5, 
        '10' => 10, 
        '15' => 15
        );
    
    
    private $expectedChikkaResponse = array(
        'message_type'=>'',
        'short_code' => '',
        'message_id' => '',
        'status' => '',
        'credits_cost' => '',
        'timestamp' => '');
    
    private $responseAccepted = array(
        'status' => 'Accepted',
        'message' => 'Message has been successfully processed.',
        'code' => 202
        );
    
    private $responseDenied = array(
        'status' => 'Error',
        'message' => 'Message has not been processed.',
        'code' => 400
        );
    

    public function __construct($clientId, $secretKey, $shortCode){
        $this->clientId = $clientId;
        $this->secretKey = $secretKey;
        $this->shortCode = $shortCode;
    }



    
    public function sendText($messageID, $to, $message) {
        $messageID = strip_tags($messageID);

        if(strlen($messageID) < 1){
            trigger_error('Message ID is required');
            return false;
        }
        
        if (!is_numeric($to) && !mb_check_encoding($to, 'UTF-8')) {
            trigger_error('TO needs to be a valid UTF-8 encoded string');
            return false;
        }

        if (!mb_check_encoding($message, 'UTF-8')) {
            trigger_error('Message needs to be a valid UTF-8 encoded string');
            return false;
        }
        
        //$message = urlencode($message);

        $sendData = array(
            'message_type' => $this->sendRequest,
            'mobile_number' => $to,
            'shortcode' => $this->shortCode,
            'message_id' => $messageID,
            'message' => $message
            );
        
        return $this->sendApiRequest($sendData);
    }

    public function receiveText() {
        
    }


   
    public function reply($requestID, $messageID, $to, $cost, $message) {
        if(strlen($messageID) < 1){
            trigger_error('Message ID is required');
            return false;
        }
        
        if (!is_numeric($to) && !mb_check_encoding($to, 'UTF-8')) {
            trigger_error('TO needs to be a valid UTF-8 encoded string');
            return false;
        }

        if (!mb_check_encoding($message, 'UTF-8')) {
            trigger_error('Message needs to be a valid UTF-8 encoded string');
            return false;
        }

        if (array_key_exists($cost, $this->requestCost)){
            trigger_error('The cost value only allows FREE, 1, 2.5, 5, 10, and 15');
            return false;
        }

        $message = urlencode($message);

        $replyData = array(
            'message_type' => $this->ReplyRequest,
            'mobile_number' => $to,
            'shortcode' => $this->shortCode,
            'message_id' => $messageID,
            'message' => $message,
            'cost' => $this->requestCost[$cost],
            'request_id' => $requestID
            );
        
        return $this->sendApiRequest($replyData);
    }

   
    public function receiveNotifications() {
        $fromChikka = $_POST;
        
        if (count(array_diff_key($this->expectedChikkaResponse, $fromChikka)) != 0) {

            $fromChikka = null;
        }

        
        return $fromChikka;
    }

  
    private function sendApiRequest($data){
        $data = array_merge($data, array('client_id'=>$this->clientId, 'secret_key' => $this->secretKey));
        $post = http_build_query($data);

        if (function_exists('curl_version')) {

            $to_chikka = curl_init( $this->chikkaSendUrl );
            curl_setopt( $to_chikka, CURLOPT_POST, true );
            curl_setopt( $to_chikka, CURLOPT_RETURNTRANSFER, true );
            curl_setopt( $to_chikka, CURLOPT_POSTFIELDS, $post );

            if (!$this->sslVerify) {
                curl_setopt( $to_chikka, CURLOPT_SSL_VERIFYPEER, false);
            }

            $from_chikka = curl_exec( $to_chikka );
            curl_close ( $to_chikka );

        } elseif (ini_get('allow_url_fopen')) {
            $opts = array('http' =>
                array(
                    'method'  => 'POST',
                    'header'  => 'Content-type: application/x-www-form-urlencoded',
                    'content' => $post
                )
            );
            $context = stream_context_create($opts);
            $from_chikka = file_get_contents($this->chikkaSendUrl, false, $context);

        } else {
            return false;
        }

        return $this->parseApiResponse($from_chikka, $data['message_type']);
    }


    private function parseApiResponse($response, $requestType = null){
        var_dump($response);
        $response = json_decode($response,true);
        if($requestType){
            $response['request_type'] = $requestType;
        }
        
        return json_decode(json_encode($response));;
    }

}

?>