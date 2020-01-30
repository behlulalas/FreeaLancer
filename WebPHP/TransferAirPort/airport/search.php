<?php 
ob_start();
include 'nedmin/netting/baglan.php';




$loksor5=$db->prepare("SELECT *FROM lokasyon ");
$loksor5->execute(array());
$loksor6=$db->prepare("SELECT *FROM lokasyon ");
$loksor6->execute(array());
$loksor7=$db->prepare("SELECT *FROM lokasyon ");
$loksor7->execute(array());
$loksor8=$db->prepare("SELECT *FROM lokasyon ");
$loksor8->execute(array());

?>

<div class="advanced-search color" id="booking">
	<div class="wrap">
		<form role="form" action="#" method="post">
			<!-- Row -->
			<div class="f-row">
				<div class="form-group datepicker one-third">
					<label for="departure-date">Hareket tarihi ve saati</label>
					<input type="text" class="departure-date" id="departure-date">
					<input type="hidden" name="dep" id="dep" value="2018-07-24 09:03" />
					<script>
						window.datepickerDepartureDateValue = '2018-07-24 09:03';
					</script>
				</div>
				<div class="form-group select one-third">
					<label>Kalkış yeri</label>
					<select id="pickup1" name="p1">
						<option value="">Kalkış yerinizi seçin</option>
						<?php while ($lokcek5=$loksor5->fetch(PDO::FETCH_ASSOC)) { ?> 
						
						<option value="453"><?php echo $lokcek5['ladi']; ?></option>
						<?php } ?>
					</select>						
				</div>
				<div class="form-group select one-third">
					<label>Varış yeri</label>
					<select id="dropoff1" name="d1">
						<option value="">Varış yerinizi seçin</option>
						<?php while ($lokcek6=$loksor6->fetch(PDO::FETCH_ASSOC)) { ?> 
						
						<option value="453"><?php echo $lokcek6['ladi']; ?></option>
						<?php } ?>
					</select>						
				</div>
			</div>
			<!-- //Row -->
			<!-- Row -->
			<div class="f-row"  style="display: none;">
				<div class="form-group datepicker one-third">
					<label for="return-date">Dönüş tarihi ve saati</label>
					<input type="text" class="return-date" id="return-date"  disabled>
					<input type="hidden" name="ret" id="ret"  disabled value="" />
				</div>
				<div class="form-group select one-third">
					<label>Kalkış yeri</label>
					<select id="pickup2" name="p2">
						<option value="">Kalkış yerinizi seçin</option>
						<?php while ($lokcek7=$loksor7->fetch(PDO::FETCH_ASSOC)) { ?> 
						
						<option value="453"><?php echo $lokcek7['ladi']; ?></option>
						<?php } ?>
					</select>						
				</div>
				<div class="form-group select one-third">
					<label>Varış yeri</label>
					<select id="dropoff2" name="d2">
						<option value="">Varış yerinizi seçin</option>
						<?php while ($lokcek8=$loksor8->fetch(PDO::FETCH_ASSOC)) { ?> 
						
						<option value="453"><?php echo $lokcek8['ladi']; ?></option>
						<?php } ?>
					</select>						
				</div>
			</div>
			<!-- Row -->
			<div class="f-row">
				<div class="form-group spinner">
					<label for="people">Kaç kişi <small>(çocuklar dahil)</small>?</label>
					<input type="number" id="people" name="ppl" min="1" class="uniform-input number" value="">
				</div>
				<div class="form-group radios">
					<div>
						<div class="radio" id="uniform-return">
							<span>
								<input type="radio" name="trip" id="return" value="2" >
							</span>
						</div>
						<label for="return">Gidiş dönüş</label>
					</div>
					<div>
						<div class="radio" id="uniform-oneway">
							<span class="checked">
								<input type="radio" name="trip" id="oneway" value="1" checked>
							</span>
						</div>
						<label for="oneway">Tek yön</label>
					</div>
				</div>
				<div class="form-group right">
					<button type="submit" class="btn large black">Transfer bul</button>
				</div>
			</div>
			<!--// Row -->
		</form>
	</div>
</div>