<?php 
ob_start();
include '../netting/baglan.php';
if ($_GET['sil']=="ok") 
{



	$sil=$db->prepare("DELETE FROM adminler where ID='".$_GET['admin_id']."'");
	$sil->execute();


	if ($sil) 
	{
		header("Location:adminler.php?islem=ok");
	}
	else
	{
		header("Location:adminler.php?islem=no");
	}
}
?>