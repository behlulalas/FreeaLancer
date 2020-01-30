
<?php 

try
{
	$db=new PDO("mysql:host=localhost;dbname=sanimetal",'root','mamusa123');
	//echo"BAŞARILI";
}
catch(PDOExpception $e)
{		
	echo $e->getmessage();
}
?>