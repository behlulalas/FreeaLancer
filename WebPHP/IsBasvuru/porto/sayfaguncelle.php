<?php 
ob_start();
include '../netting/baglan.php';
$ayarsor=$db->prepare("SELECT *FROM ayar where ayar_id=?");
$ayarsor->execute(array(0));
$ayarcek=$ayarsor->fetch(PDO::FETCH_ASSOC);
if (isset($_POST['guncelle33'])) 
{

	$ayarkaydet1=$db->prepare("UPDATE ayar SET 
		bizkimiz=:bizkim,
		kurulus_amac=:amac,
		ekip1=:ekipp,
		ekip2=:ekiip,
		meslek=:meslek,
		meslek1=:meslek1,
		bilgi_1=:bilgi1,
		bilgi_2=:bilgi2,
		bilgi_3=:bilgi3,
		bilgi_4=:bilgi4
		WHERE ayar_id=0");
	
	$guncel1=$ayarkaydet1->execute(array(
		'bizkim'=>$_POST['kimiz'],
		'amac'=>$_POST['amacımız'],
		'ekipp'=>$_POST['ekipe'],
		'ekiip'=>$_POST['ekipk'],
		'meslek'=>$_POST['meslek'],
		'meslek1'=>$_POST['meslek1'],
		'bilgi1'=>$_POST['bilgi1'],
		'bilgi2'=>$_POST['bilgi2'],
		'bilgi3'=>$_POST['bilgi3'],
		'bilgi4'=>$_POST['bilgi4']
	));


	if ($guncel1) 
	{
		header("Location:sayfaicerik.php?islem1=ok");
	}
	else
		{
		header("Location:sayfaicerik.php?islem1=no");
	}
}
?>