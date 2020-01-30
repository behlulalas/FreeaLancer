<?php include '../lokasyonlar/header.php';?>
	<!-- //Header -->
	<!-- Main -->
	<main class="main " role="main">		<!-- Page info -->
	<header class="site-title color">
		<div class="wrap">
			<div class="container">
				<?php 

					while ($araccek=$aracsor->fetch(PDO::FETCH_ASSOC)) { ?>
						<h1><?php echo $araccek['aracadi'];?></h1>
				
							</div>
		</div>
	</header>
	<div class="wrap">
		<div class="row">

			<!--- Content -->
			<div class="content three-fourth">
				<article id="post-255" class="single post-255 transport_type type-transport_type status-publish has-post-thumbnail hentry">
										<figure class="entry-featured">						
						<img width="870" height="600" src="../../nedmin/production/<?php echo $araccek['resim_yol1'];?>" sizes="(max-width: 870px) 100vw, 870px" />						<div class="overlay">
							<a href="#">+</a>
						</div>
					</figure>
										<div class="entry-content">
						<p class="entry-meta">
							<span class="date"></span> 
							
							<span class="tags"></span>
							<span class="comments">
								<a href="#" rel="nofollow">
																</a>
							</span>
						</p>
						<p><?php echo $araccek['araacaciklama']; ?></p>
<?php } ?>
											</div>
				</article>				
				<!--comments-->
<div class="comments" id="comments">
		 
		<!-- If comments are closed. -->
	<p class="nocomments"></p>
	 
			
		
</div><!--comments-->
<!--bottom navigation-->		
			</div>
			<!--- // Content -->
					</div>
	</div>
		
	</main>
		<div id="above-footer-sidebar" class="above-footer-sidebar widget-area clearfix" role="complementary">
		<ul>
				</ul>
	</div><!-- #secondary -->
	<!-- //Main -->
	<!-- Footer -->
	<?php include '../lokasyonlar/footer.php'; ?>
	
	<script type='text/javascript'>
/* <![CDATA[ */
var wpcf7 = {"apiSettings":{"root":"http:\/\/www.gazipasa-airport724.com\/de\/wp-json\/contact-form-7\/v1","namespace":"contact-form-7\/v1"},"recaptcha":{"messages":{"empty":"Bitte best\u00e4tige, dass du keine Maschine bist."}}};
/* ]]> */
</script>
<script type='text/javascript' src='../../wp-content/plugins/contact-form-7/includes/js/scripts972f.js?ver=5.0.1'></script>
<script type='text/javascript' src='../../wp-includes/js/jquery/ui/core.mine899.js?ver=1.11.4'></script>
<script type='text/javascript' src='../../wp-includes/js/jquery/ui/widget.mine899.js?ver=1.11.4'></script>
<script type='text/javascript' src='../../wp-includes/js/jquery/ui/mouse.mine899.js?ver=1.11.4'></script>
<script type='text/javascript' src='../../wp-includes/js/jquery/ui/slider.mine899.js?ver=1.11.4'></script>
<script type='text/javascript' src='../../wp-includes/js/jquery/ui/button.mine899.js?ver=1.11.4'></script>
<script type='text/javascript' src='../../wp-includes/js/jquery/ui/datepicker.mine899.js?ver=1.11.4'></script>
<script type='text/javascript'>
jQuery(document).ready(function(jQuery){jQuery.datepicker.setDefaults({"closeText":"Schlie\u00dfen","currentText":"Heute","monthNames":["Januar","Februar","M\u00e4rz","April","Mai","Juni","Juli","August","September","Oktober","November","Dezember"],"monthNamesShort":["Jan","Feb","Mrz","Apr","Mai","Jun","Jul","Aug","Sep","Okt","Nov","Dez"],"nextText":"Weiter","prevText":"Vorherige","dayNames":["Sonntag","Montag","Dienstag","Mittwoch","Donnerstag","Freitag","Samstag"],"dayNamesShort":["So","Mo","Di","Mi","Do","Fr","Sa"],"dayNamesMin":["S","M","D","M","D","F","S"],"dateFormat":"MM d, yy","firstDay":1,"isRTL":false});});
</script>
<script type='text/javascript' src='../../wp-content/plugins/transfers-plugin/js/jquery.validate.min5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-content/plugins/transfers-plugin/js/i18n/datepicker-de5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-content/plugins/transfers-plugin/js/jquery-ui-sliderAccess5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-content/plugins/transfers-plugin/js/jquery-ui-timepicker-addon5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-content/plugins/transfers-plugin/js/search5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-content/plugins/transfers-plugin/js/i18n/jquery-ui-timepicker-de5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-includes/js/jquery/ui/effect.mine899.js?ver=1.11.4'></script>
<script type='text/javascript' src='../../wp-content/themes/transfers/js/jquery.uniform.min5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-content/themes/transfers/js/respond.min5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-content/themes/transfers/js/jquery.slicknav.min5152.js?ver=1.0'></script>
<script type='text/javascript'>
/* <![CDATA[ */
var TransfersAjax = {"ajaxurl":"http:\/\/www.gazipasa-airport724.com\/wp-admin\/admin-ajax.php","nonce":"11400feff6"};
/* ]]> */
</script>
<script type='text/javascript' src='../../wp-content/themes/transfers/js/scripts5152.js?ver=1.0'></script>
<script type='text/javascript' src='../../../use.fontawesome.com/e808bf93975152.js?ver=1.0'></script>
<script type='text/javascript' src='../../wp-includes/js/wp-embed.min55fe.js?ver=4.9.5'></script>
</body>
</html>