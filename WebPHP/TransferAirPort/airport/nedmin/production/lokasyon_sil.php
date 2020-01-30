<?php 
ob_start();
include '../netting/baglan.php';
if ($_GET['sil']=="ok") 
{



	$sil=$db->prepare("DELETE FROM lokasyon where ID='".$_GET['lokasyon_id']."'");
 	$sil->execute();


	if ($sil) 
	{
		header("Location:lokasyonlar.php?islem=ok");
	}
	else
	{
		header("Location:lokasyonlar.php?islem=no");
	}
}
?>