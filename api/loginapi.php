<?php
//$name = "phiber";
//$password = "x123972";
//set the working directory to your Drupal root
define("DRUPAL_ROOT",     "/var/www/st/");

//require the bootstrap include
require_once '/var/www/st/includes/bootstrap.inc';

//Load Drupal
drupal_bootstrap(DRUPAL_BOOTSTRAP_FULL); 
//(loads everything, but doesn't render anything)

$name = $_POST['name'];
$password = $_POST['pass'];


//$name = "vivi";
//$password = "1234";
//use drupal user_authenticate function
if(!user_authenticate($name, $password)){
    echo '0:0:0:0';
}
else
{
	
	
    	$con = mysqli_connect("localhost", "root", "root", "ateneohacks");
	$uid = user_authenticate($name, $password);
	//echo $uid;
	$sql = "SELECT * from field_data_field_account_type WHERE entity_id = ".$uid." "; 
	$result = mysqli_query($con, $sql);
	while($row = mysqli_fetch_array($result))
	{
		$ret_val = $uid;
		$ret_val = $ret_val.":".$row["field_account_type_value"];
	}

	$sql = "SELECT * from field_data_field_surname WHERE entity_id = ".$uid." "; 
	$result = mysqli_query($con, $sql);
	while($row = mysqli_fetch_array($result))
	{
		$ret_val = $ret_val.":".$row["field_surname_value"];
	}

	$sql = "SELECT * from field_data_field_first_name WHERE entity_id = ".$uid." "; 
	$result = mysqli_query($con, $sql);
	while($row = mysqli_fetch_array($result))
	{
		$ret_val = $ret_val.":".$row["field_first_name_value"];
	}
	
	//echo mysqli_error($con);
	
	
	echo $ret_val;
}





?>

