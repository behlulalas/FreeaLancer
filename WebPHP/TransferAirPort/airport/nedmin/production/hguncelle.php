<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['guncelle44'])) 
{



	$ayarkaydet=$db->prepare("UPDATE ayar SET 
		hakkimizda=:h1
		
		where ID=0");
	$ekle=$ayarkaydet->execute(array(
		'h1'=>$_POST['hakkimizda']
	
	));


	if ($ekle) 
	{
		header("Location:hakkimizda.php?islem=ok");
	}
	else
	{
		header("Location:hakkimizda.php?islem=no");
	}
}
?>