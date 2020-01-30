<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['guncelle2'])) 
{
	$ayarkaydet=$db->prepare("UPDATE ayar SET 
		
		yazi10=:y10,
		yazi11=:y11,
		yazi12=:y12,
		transferadi=:tadi,
		transferaciklama=:taciklama,
		gsm1=:gsm1,
		mail=:mail
		
		where ID=0");
	$ekle=$ayarkaydet->execute(array(
		
		'y10'=>$_POST['y10'],
		'y11'=>$_POST['y11'],
		'y12'=>$_POST['y12'],
		'tadi'=>$_POST['tadi'],
		'taciklama'=>$_POST['taciklama'],
		'gsm1'=>$_POST['gsm1'],
		'mail'=>$_POST['mail']
		
	));


	if ($ekle) 
	{
		header("Location:sayfaicerik.php?islem=ok");
	}
	else
	{
		header("Location:sayfaicerik.php?islem=no");
	}
}
?>