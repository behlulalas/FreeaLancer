<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['kaydet'])) 
{
$ayarkaydet=$db->prepare("INSERT INTO adminler SET
kadi=:kadi,
sifre=:sifre,
admin_adi=:adi
");
$guncelle=$ayarkaydet->execute(array(
'kadi'=>$_POST['kadi'],
'sifre'=>md5($_POST['sifre']),
'adi'=>$_POST['adi']
));

if ($guncelle) 
{
	header("Location:admin.php?islem=ok");
}
else
{
	header("Location:admin.php?islem=no");
}

}
?>
