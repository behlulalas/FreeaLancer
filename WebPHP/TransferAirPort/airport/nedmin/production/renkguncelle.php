<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['degistir'])) 
{



	$ayarkaydet=$db->prepare("UPDATE ayar SET 
		renkkodu=:r1
		
		where ID=0");
	$ekle=$ayarkaydet->execute(array(
		'r1'=>$_POST['renk']

	));


	if ($ekle) 
	{
		header("Location:renkler.php?islem=ok");
	}
	else
	{
		header("Location:renkler.php?islem=no");
	}
}
?>