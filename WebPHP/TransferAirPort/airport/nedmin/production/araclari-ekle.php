<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['aracekle'])) 
	{ 

$dosya1=$_FILES['aracresim']['tmp_name'];
$dosyayolu1="images";
$dosyaismi1=$_FILES['aracresim']['name'];
$yol1=$dosyayolu1."/".$dosyaismi1;
move_uploaded_file($dosya1, $dosyayolu1."/".$dosyaismi1);



$ayarkaydet=$db->prepare("INSERT arac SET 
	aracadi=:a1,
	araacaciklama=:aciklama1,
	resim_yol1=:ryol
	");
$ekle=$ayarkaydet->execute(array(
	'a1'=>$_POST['aracadi'],
	'aciklama1'=>$_POST['aracaciklama'],
	'ryol'=>$yol1

));


if ($ekle) 
{
	header("Location:arac-ekle.php?islem=ok");
}
else
{
	header("Location:arac-ekle.php?islem=no");
}
}
?>


