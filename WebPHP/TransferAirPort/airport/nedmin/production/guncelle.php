<?php 
ob_start();
include '../netting/baglan.php';
if (isset($_POST['guncelle1'])) 
{



	$ayarkaydet=$db->prepare("UPDATE ayar SET 
		menu1=:m1,
		menu2=:m2,
		menu3=:m3,
		menu4=:m4,
		menu5=:m5,
		yazi1=:y1,
		yazi2=:y2,
		yazi3=:y3,
		yazi4=:y4,
		yazi5=:y5,
		yazi6=:y6,
		yazi7=:y7,
		yazi8=:y8,
		baslik1=:b1,
		baslik2=:b2,
		baslik3=:b3,
		baslik4=:b4,
		baslik5=:b5,
		baslik6=:b6,
		
		a_yazi1=:ayazi1,
		a_yazi2=:ayazi2,
		a_baslik3=:baslik3,
		a_baslik4=:baslik4,
		a_baslik5=:baslik5,
		a_baslik6=:baslik6,
		a_yazi3=:yazi3,
		a_yazi4=:yazi4,
		a_yazi5=:yazi5,
		a_yazi6=:yazi6
		
		where ID=0");
	$ekle=$ayarkaydet->execute(array(
		'm1'=>$_POST['m1'],
		'm2'=>$_POST['m2'],
		'm3'=>$_POST['m3'],
		'm4'=>$_POST['m4'],
		'm5'=>$_POST['m5'],
		'y1'=>$_POST['y1'],
		'y2'=>$_POST['y2'],
		'y3'=>$_POST['y3'],
		'y4'=>$_POST['y4'],
		'y5'=>$_POST['y5'],
		'y6'=>$_POST['y6'],
		'y7'=>$_POST['y7'],
		'y8'=>$_POST['y8'],
		'b1'=>$_POST['b1'],
		'b2'=>$_POST['b2'],
		'b3'=>$_POST['b3'],
		'b4'=>$_POST['b4'],
		'b5'=>$_POST['b5'],
		'b6'=>$_POST['b6'],
		
		'ayazi1'=>$_POST['ayazi1'],
		'ayazi2'=>$_POST['ayazi2'],
		'baslik3'=>$_POST['baslik3'],
		'baslik4'=>$_POST['baslik4'],
		'baslik5'=>$_POST['baslik5'],
		'baslik6'=>$_POST['baslik6'],
		'yazi3'=>$_POST['yazi3'],
		'yazi4'=>$_POST['yazi4'],
		'yazi5'=>$_POST['yazi5'],
		'yazi6'=>$_POST['yazi6']
	));


	if ($ekle) 
	{
		header("Location:genel-ayar.php?islem=ok");
	}
	else
	{
		header("Location:genel-ayar.php?islem=no");
	}
}
?>