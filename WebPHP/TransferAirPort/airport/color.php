<!DOCTYPE html>
<html>
<head>
	<title>Deneme</title>
</head>
<body>
	<form method="POST" action="">
		<input type="color" name="color">
		<input type="submit" name="gonder">
	</form>
	<?php 
		if (isset($_POST['color'])) 
		{
			$renkkodu=$_POST['color'];
			echo $renkkodu;
		}


	 ?>
</body>
</html>