<?php 
ob_start();
include '../netting/baglan.php';
if ($_GET['sil']=="ok") 
{



	$sil=$db->prepare("DELETE FROM arac where ID='".$_GET['arac_id']."'");
 	$sil->execute();


	if ($sil) 
	{
		header("Location:araclar.php?islem=ok");
	}
	else
	{
		header("Location:araclar.php?islem=no");
	}
}
?>