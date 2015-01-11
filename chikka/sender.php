<?php
/**
 * This file will show a simple implementation of Chikka API SMS library
 * @author Ronald Allan Mojica
 * 
 */

define("DRUPAL_ROOT",     "/var/www/st/");

//require the bootstrap include
require_once '/var/www/st/includes/bootstrap.inc';
include('ChikkaSMS.php');
//Load Drupal
drupal_bootstrap(DRUPAL_BOOTSTRAP_FULL); 
//(loads everything, but doesn't render anything)
$con = mysqli_connect("localhost", "root", "root", "ateneohacks");
$name = $_POST['name'];

$sql = "SELECT * FROM  `users` WHERE name='".$name."'";
while($row = mysqli_fetch_array($result))
	{
			$uid = $row['uid'];
	}

$sql = "SELECT * FROM  `field_data_field_surname` WHERE entity_id = ".$uid;
while($row = mysqli_fetch_array($result))
	{
			$prof = $row['field_surname_value'];
	}






$message = "Your Class with Professor ".$prof." will Start in 15mins."

$sql = "SELECT * FROM  `field_data_field_contact_number`";
mysqli_query($con, $sql);
while($row = mysqli_fetch_array($result))
	{
			$telNo = $row['field_contact_number_value'];
			$randNumber = rand (0, 999999999);
//echo $randNumber;
			$clientId = '58bc7572756657360769097a0df58a41571fdc0d07fd2bad9373826e2397bc59';
			$secretKey = '75bd7ac664488b4c252004d94442dfc00a1a4f270e3f0664cb8ebaadc6652e31';
			$shortCode = '29290769463';
			$chikkaAPI = new ChikkaSMS($clientId,$secretKey,$shortCode);
			$response = $chikkaAPI->sendText($randNumber, $telNo, $message);
	}

//$message = $_GET['message'];
$randNumber = rand (0, 999999999);
//echo $randNumber;
$clientId = '58bc7572756657360769097a0df58a41571fdc0d07fd2bad9373826e2397bc59';
$secretKey = '75bd7ac664488b4c252004d94442dfc00a1a4f270e3f0664cb8ebaadc6652e31';
$shortCode = '29290769463';
$chikkaAPI = new ChikkaSMS($clientId,$secretKey,$shortCode);
$response = $chikkaAPI->sendText($randNumber, '639164478314', "Hi babe. wag kang gumawa ng OS\n\n\n hello world");
//$response = $chikkaAPI->sendText($randNumber, $num, $message."\n\n");


//if($response->status != 200){
	header("HTTP/1.1 " . $response->status . " " . $response->message);
//}

echo $response->description;

?>