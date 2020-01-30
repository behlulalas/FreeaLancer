<?php 
ob_start();
include '../netting/baglan.php';
$ayarsor=$db->prepare("SELECT *FROM ayar where ayar_id=?");
$ayarsor->execute(array(0));
$ayarcek=$ayarsor->fetch(PDO::FETCH_ASSOC);
if (isset($_POST['guncelle'])) 
{

	$ayarkaydet=$db->prepare("UPDATE ayar SET 
		ayar_title=:ayarbaslik,
		ayar_tel=:ayartel,
		ayar_gsm=:ayargsm,
		ayar_tel2=:ayartel2,
		ayar_adres=:ayaradres,
		ayar_ilce=:ayarilce,
		ayar_il=:ayaril,
		ayar_mail=:mail,
		ayar_aciklama=:aciklama
		WHERE ayar_id=0");
	$guncel=$ayarkaydet->execute(array(
		'ayarbaslik'=>$_POST['baslik'],
		'ayartel'=>$_POST['tel'],
		'ayargsm'=>$_POST['gsm'],
		'ayartel2'=>$_POST['tel2'],
		'ayaradres'=>$_POST['adres'],
		'ayarilce'=>$_POST['ilce'],
		'ayaril'=>$_POST['il'],
		'mail'=>$_POST['mail'],
		'aciklama'=>$_POST['aciklama']
	));


	if ($guncel) 
	{
		header("Location:genel-ayar.php?islem=ok");
	}
	else
		{
		header("Location:genel-ayar.php?islem=no");
	}
}
?>