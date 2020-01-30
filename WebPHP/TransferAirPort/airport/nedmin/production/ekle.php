<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['ekle'])) 
	{ 

$dosya1=$_FILES['resim']['tmp_name'];
$dosyayolu1="images";
$dosyaismi1=$_FILES['resim']['name'];
$yol1=$dosyayolu1."/".$dosyaismi1;
move_uploaded_file($dosya1, $dosyayolu1."/".$dosyaismi1);



$ayarkaydet=$db->prepare("INSERT lokasyon SET 
	ladi=:l1,
	a_fiyat=:afiyat,
	g_fiyat=:gfiyat,
	resim_yol=:ryol
	");
$ekle=$ayarkaydet->execute(array(
	'l1'=>$_POST['ladi'],
	'afiyat'=>$_POST['afiyat'],
	'gfiyat'=>$_POST['gfiyat'],
	'ryol'=>$yol1

));


if ($ekle) 
{
	header("Location:icerik-ekle.php?islem=ok");
}
else
{
	header("Location:icerik-ekle.php?islem=no");
}
}
?>


