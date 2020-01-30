<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['rguncelle1'])) 
{
	$dosyar1=$_FILES['aresim1']['tmp_name'];
	if(!empty($dosyar1))
	{
		$dosyayolur1="images";
		$dosyaismir1=$_FILES['aresim1']['name'];
		$yolr1=$dosyayolur1."/".$dosyaismir1;
		move_uploaded_file($dosyar1, $dosyayolur1."/".$dosyaismir1);


		$ayarkaydet=$db->prepare("UPDATE anasayfa_resimler SET 
			a_resim1=:arkaplan1
			where ID=0");
		$ekle=$ayarkaydet->execute(array(
			'arkaplan1'=>$yolr1
		));

	}
	if ($ekle) 
	{
		header("Location:anasayfaresim.php?islem=ok");
	}
	else
	{
		header("Location:anasayfaresim.php?islem=no");
	}
}
if (isset($_POST['rguncelle2'])) 
{
	$dosyar2=$_FILES['aresim2']['tmp_name'];
	if(!empty($dosyar2))
	{
		$dosyayolur2="images";
		$dosyaismir2=$_FILES['aresim2']['name'];
		$yolr2=$dosyayolur2."/".$dosyaismir2;
		move_uploaded_file($dosyar2, $dosyayolur2."/".$dosyaismir2);


		$ayarkaydet=$db->prepare("UPDATE anasayfa_resimler SET 
			a_resim2=:arkaplan2
			where ID=0");
		$ekle=$ayarkaydet->execute(array(
			'arkaplan2'=>$yolr2
		));
	}

	if ($ekle) 
	{
		header("Location:anasayfaresim.php?islem=ok");
	}
	else
	{
		header("Location:anasayfaresim.php?islem=no");
	}
}
if (isset($_POST['rguncelle3'])) 
{
	$dosyar3=$_FILES['aresim3']['tmp_name'];
	if(!empty($dosyar3))
	{
		$dosyayolur3="images";
		$dosyaismir3=$_FILES['aresim3']['name'];
		$yolr3=$dosyayolur3."/".$dosyaismir3;
		move_uploaded_file($dosyar3, $dosyayolur3."/".$dosyaismir3);


		$ayarkaydet=$db->prepare("UPDATE anasayfa_resimler SET 
			a_resim3=:arkaplan3
			where ID=0");
		$ekle=$ayarkaydet->execute(array(
			'arkaplan3'=>$yolr3
		));
	}

	if ($ekle) 
	{
		header("Location:anasayfaresim.php?islem=ok");
	}
	else
	{
		header("Location:anasayfaresim.php?islem=no");
	}
}
if (isset($_POST['rguncelle4'])) 
{
	$dosyar4=$_FILES['aresim4']['tmp_name'];
	if(!empty($dosyar4))
	{
		$dosyayolur4="images";
		$dosyaismir4=$_FILES['aresim4']['name'];
		$yolr4=$dosyayolur4."/".$dosyaismir4;
		move_uploaded_file($dosyar4, $dosyayolur4."/".$dosyaismir4);


		$ayarkaydet=$db->prepare("UPDATE anasayfa_resimler SET 
			a_resim4=:arkaplan4
			where ID=0");
		$ekle=$ayarkaydet->execute(array(
			'arkaplan4'=>$yolr4
		));
	}

	if ($ekle) 
	{
		header("Location:anasayfaresim.php?islem=ok");
	}
	else
	{
		header("Location:anasayfaresim.php?islem=no");
	}
}
if (isset($_POST['rguncelle5'])) 
{
	$dosyar5=$_FILES['aresim5']['tmp_name'];
	if(!empty($dosyar5))
	{
		$dosyayolur5="images";
		$dosyaismir5=$_FILES['aresim5']['name'];
		$yolr5=$dosyayolur5."/".$dosyaismir5;
		move_uploaded_file($dosyar5, $dosyayolur5."/".$dosyaismir5);


		$ayarkaydet=$db->prepare("UPDATE anasayfa_resimler SET 
			a_resim5=:arkaplan5
			where ID=0");
		$ekle=$ayarkaydet->execute(array(
			'arkaplan5'=>$yolr5
		));
	}

	if ($ekle) 
	{
		header("Location:anasayfaresim.php?islem=ok");
	}
	else
	{
		header("Location:anasayfaresim.php?islem=no");
	}
}
if (isset($_POST['rguncelle6'])) 
{

	$dosyar6=$_FILES['aresim6']['tmp_name'];
	if(!empty($dosyar6))
	{

		$dosyayolur6="images";
		$dosyaismir6=$_FILES['aresim6']['name'];
		$yolr6=$dosyayolur6."/".$dosyaismir6;
		move_uploaded_file($dosyar6, $dosyayolur6."/".$dosyaismir6);


		$ayarkaydet=$db->prepare("UPDATE anasayfa_resimler SET 
			a_resim6=:arkaplan6
			where ID=0");
		$ekle=$ayarkaydet->execute(array(
			'arkaplan6'=>$yolr6
		));

	}
	if ($ekle) 
	{
		header("Location:anasayfaresim.php?islem=ok");
	}
	else
	{
		header("Location:anasayfaresim.php?islem=no");
	}
}
?>