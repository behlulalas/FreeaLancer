<?php include 'header.php'; ?>
<?php include 'nedmin/netting/baglan.php'; ?>
<div role="main" class="main">
	<div class="container">
		<div class="row pt-xl">
			<div class="col-md-3">
				
			</div>
			<div class="col-md-6">
				<h1 class="mt-xl mb-none">BİZİMLE ÇALIŞMAK İSTER MİSİNİZ?</h1>
				<div class="divider divider-primary divider-small mb-x7">
					<center><hr></center>
				</div>
				<p class="lead mb-xl mt-lg" align="center"><b>Formu Doldurun..</b></p>

				
				<?php
				if (isset($_POST['basvur'])) {

					$kaydet=$db->prepare("INSERT INTO basvurular SET
						ad_soyad=:kadi,
						yas=:yas,
						cinsiyet=:cinsiyet,
						basvur_tel=:tel,
						basvur_mail=:mail,
						basvur_ekbilgi=:ekbilgi
						");

					$insert=$kaydet->execute(array(
						'kadi' => $_POST['name'],
						'yas' =>  $_POST['yas'],
						'cinsiyet'=>$_POST['cinsiyet'],
						'tel' =>  $_POST['tel'],
						'mail' =>  $_POST['mail'],
						'ekbilgi' =>$_POST['message']
					));

					if ($insert)
					{

						echo'<br><div class="alert alert-success" role="alert">
						<span><i class="fa fa-user-plus fa-2x"></i></span>
						<span class="sr-only">Error:</span>
						Başvuru Gönderildi...
						</div>';
					}
					else
					{

						echo'<br><div class="alert alert-danger" role="alert">
						<span><i class="fa fa-times fa-2x"></i></span>
						<span class="sr-only">Error:</span>
						Başvuru Gönderilemedi !.
						</div>';

					}
				}
				?>

				<form  action="" method="POST">
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<input type="text" placeholder="Adınız Soyadınız" value="" data-msg-required=" Lütfen Adınızı giriniz." maxlength="100" class="form-control input-lg" name="name" id="name" required style="border: 1px solid;">
							</div>
						</div>
					</div>
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<input type="number" placeholder="Yasınız "  data-msg-required="Yasınızı giriniz." class="form-control input-lg" name="yas" id="tel" required style="border: 1px solid";>
							</div>
						</div>
					</div>

					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<select data-msg-required="Yasınızı giriniz." required class="form-control input-lg" name="cinsiyet" style="border: 1px solid";>
									
									<option value="no-value" selected="true" disabled="disabled" >CİNSİYET</option>
									<option value="KADIN">KADIN</option>
									<option value="ERKEK">ERKEK</option>
								</select> 
							</div>
						</div>
					</div>
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<input type="tel" maxlength="11"  minlength="11" placeholder="Telefon " value="" data-msg-required="Telefon numaranızı giriniz." class="form-control input-lg" name="tel" id="tel" required style="border: 1px solid";>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<input type="email" placeholder="E-mail" value="" data-msg-required="Lütfen Email adresinizi giriniz." data-msg-email="Lütfen var olan bir mail giriniz." maxlength="100" class="form-control input-lg" name="mail" id="email" required style="border: 1px solid;">
							</div>
						</div>
					</div>
					<div class="row">
						<div class="form-group">
							<div class="col-md-12">
								<textarea maxlength="5000" placeholder="Başka Eklemek İstediğiniz.." data-msg-required="Mesajınızı yazınız." rows="3" class="form-control input-lg" name="message" id="message" required style="border: 1px solid";></textarea>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="col-md-12" align="center">
							<input type="submit" name="basvur" value="BAŞVUR" class="btn btn-primary btn-lg mb-xlg" >
						</div>
					</div>
				</form>




			</div>

		</div>
	</div>

	<!-- Google Maps - Go to the bottom of the page to change settings and map location. -->

</div>
<?php include 'footer.php' ?>
