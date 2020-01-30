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

					$adsoyad = htmlspecialchars(trim($_POST['adsoyad'])); 
					$konu = htmlspecialchars(trim($_POST['konu'])); 
					$eposta = htmlspecialchars(trim($_POST['eposta'])); 
					$mesaj = htmlspecialchars(trim($_POST['mesaj'])); 
					require 'mail/PHPMailerAutoload.php';
					$epostal="dem.ik@yandex.com";
					$mail = new PHPMailer(true);
					$mail->IsSMTP();
					$mail->SMTPDebug = 0; // hata ayiklama: 1 = hata ve mesaj, 2 = sadece mesaj
					$mail->SMTPAuth = true;
					$mail->SMTPSecure = 'tls'; // Güvenli baglanti icin ssl normal baglanti icin tls
					$mail->Host = "smtp.yandex.com"; // Mail sunucusuna ismi
					$mail->Port = 587; // Guvenli baglanti icin 465 Normal baglanti icin 587
					$mail->IsHTML(true);
					$mail->SetLanguage("tr", "phpmailer/language");
					$mail->CharSet  ="utf-8";
					$mail->Username = "dem.ik@yandex.com"; // Mail adresimizin kullanicı adi
					$mail->Password = "mamusa123"; // Mail adresimizin sifresi
					$mail->SetFrom($epostal, $adsoyad); // Mail attigimizda gorulecek ismimiz
					$mail->AddAddress("demir_organizasyon@hotmail.com");
					$mail->Subject = $konu; // Konu basligi
					$mail->Body = $mesaj; // Mailin icerigi

					if(!$mail->Send())
					{
						echo "Mailer Error: ".$mail->ErrorInfo;
					} 
					else 
					{
						echo'<br><div class="alert alert-success" role="alert">
						<span><i class="fa fa-check-square fa-2x"></i></span>
						<span class="sr-only">Error:</span>
						Mesajınız iletilmiştir ...
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
								<input type="text" placeholder="Konu" value="" data-msg-required="Konuyu giriniz." maxlength="100" class="form-control input-lg" name="konu" id="konu" required>
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
					<li><i class="fa fa-map-marker"></i> <strong>Adres:</strong> <?php echo $ayarcek['ayar_adres']; ?> <?php echo $ayarcek['ayar_ilce']; ?>/ <?php echo $ayarcek['ayar_il']; ?></li>
					<li><i class="fa fa-phone"></i> <strong>Telefon:</strong> <?php echo $ayarcek['ayar_tel']; ?></li>
					<li><i class="fa fa-envelope"></i> <strong>Email:</strong> <a href="mailto:demir_organizasyon@hotmail.com"><?php echo $ayarcek['ayar_mail']; ?></a></li>
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
