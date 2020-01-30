<?php include 'header.php'; ?>
<div role="main" class="main">
	<div class="container">
		<div class="row pt-xl">
			<div class="col-md-7">
				<h1 class="mt-xl mb-none">BİZİMLE İLETİŞİME GEÇİN</h1>
				<div class="divider divider-primary divider-small mb-xl">
					<hr>
				</div>
				<p class="lead mb-xl mt-lg">Sorularınızı rahatlıkla yönlendirin..</p>
				
				<?php 

				if (isset($_POST['iletisimform']))
				{

					$kaydet=$db->prepare("INSERT INTO mailler SET
						mail_isim=:isim,
						mail_eposta=:eposta,
						mail_mesaj=:mesaj
					");

					$insert=$kaydet->execute(array(
						'isim' => $_POST['adsoyad'],
						'eposta' =>  $_POST['eposta'],
						'mesaj'=>$_POST['mesaj']
					));

					if ($insert)
					{

						echo'<br><div class="alert alert-success" role="alert">
						<span><i class="fa fa-user-plus fa-2x"></i></span>
						<span class="sr-only">Error:</span>
						Mesajınız başarıyla iletildi...
						</div>';
					}
					else
					{

						echo'<br><div class="alert alert-danger" role="alert">
						<span><i class="fa fa-times fa-2x"></i></span>
						<span class="sr-only">Error:</span>
						Gönderim Başarısız. !
						</div>';

					}


				}
				?>

				<form  action="" method="POST">
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<input type="text" placeholder="Adınız Soyadınız" value="" data-msg-required=" Lütfen Adınızı giriniz." maxlength="100" class="form-control input-lg" name="adsoyad" id="adsoyad" required>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<input type="email" placeholder="E-mail" value="" data-msg-required="Lütfen Email adresinizi giriniz." data-msg-email="Lütfen var olan bir mail giriniz." maxlength="100" class="form-control input-lg" name="eposta" id="eposta" required>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<textarea maxlength="5000" placeholder="Mesaj" data-msg-required="Mesajınızı yazınız." rows="5" class="form-control input-lg" name="mesaj" id="mesaj" required></textarea>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="col-md-12">
							<input type="submit" name="iletisimform" value="Gönder" class="btn btn-primary">
						</div>
					</div>
				</form>
				
			</div>
			<div class="col-md-4 col-md-offset-1">

				<h4 class="mt-xl mb-none">Ofisimiz</h4>
				<div class="divider divider-primary divider-small mb-xl">
					<hr>
				</div>

				<ul class="list list-icons list-icons-style-3 mt-xlg mb-xlg">
					<li><i class="fa fa-map-marker"></i> <strong>Adres:</strong> Kosova/Mamushe</li>
					<li><i class="fa fa-phone"></i> <strong>Telefon:</strong> 044 336 965</li>
					<li><i class="fa fa-envelope"></i> <strong>Email:</strong> <a href="mailto:sanimetal@hotmail.com">sanimetal@hotmail.com</a></li>
				</ul>

				<h4 class="pt-xl mb-none">Çalışma Saatleri</h4>
				<div class="divider divider-primary divider-small mb-xl">
					<hr>
				</div>

				<ul class="list list-icons list-dark mt-xlg">
					<li><i class="fa fa-clock-o"></i> Hafta içi / Hafta Sonu -> 08:00 - 18:00</li>
					<li><i class="fa fa-clock-o"></i> Hafta içi / Hafta Sonu -> 12:00 - 22:00</li>
					<li><i class="fa fa-clock-o"></i> Hafta içi / Hafta Sonu -> 14:00 - 00:00</li>
				</ul>

			</div>
		</div>
	</div>

	<!-- Google Maps - Go to the bottom of the page to change settings and map location. -->
	<div id="googlemaps" class="google-map google-map-footer" style="overflow-x: hidden;">
		<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3021.4625946705282!2d30.398713815306966!3d40.773843179325205!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14ccb32df75044c7%3A0xce31666fd11f4a08!2sSemerciler+Mahallesi%2C+Sait+Faik+Sk.%2C+54100+Adapazar%C4%B1%2FSakarya!5e0!3m2!1str!2str!4v1523657775678" width="1800" height="600" frameborder="0" style="border:0" allowfullscreen></iframe>
	</div>
</div>
<?php include 'footer.php'; ?>
