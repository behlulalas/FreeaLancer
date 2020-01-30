<?php 

ob_start();
session_start();

include '../netting/baglan.php';

if (!empty($_FILES)) {



	$uploads_dir = 'images';
	@$tmp_name = $_FILES['file']["tmp_name"];
	@$name = $_FILES['file']["name"];
	$refimgyol=$uploads_dir."/".$name;
	@move_uploaded_file($tmp_name, "$uploads_dir/$benzersizad$name");

	$kaydet=$db->prepare("UPDATE ayar SET
		logo=:resimyol	where ID=0");
	$insert=$kaydet->execute(array(
		'resimyol' => $refimgyol
		
	));




}
if ($insert) 
{
	header("Location:logo.php?islem=ok");
}
else
{
	header("Location:logo.php?islem=no");
}





?>