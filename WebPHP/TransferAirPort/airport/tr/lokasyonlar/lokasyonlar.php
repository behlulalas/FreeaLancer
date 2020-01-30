 <?php 
 include 'header.php';

  ?>
	<!-- Main -->
	<main class="main " role="main">	<!-- Page info -->
		<header class="site-title color">
			<div class="wrap">
				<div class="container">
					<?php 

					while ($lokcek=$loksor->fetch(PDO::FETCH_ASSOC)) { ?>
						<h1><?php echo $lokcek['ladi'];?></h1>

					</div>
				</div>
			</header>

			<div class="keyvisual" style="background-image:url(../../nedmin/production/<?php echo $lokcek['resim_yol'];?>)"></div>
			<!-- Advanced search -->
			<?php include "../../search.php"; ?>
						<!-- // Advanced search -->

						<div class="wrap">
							<div class="row">
								<!--- Content -->
								<article id="post-457" class="one-half content textongrey post-457 destination type-destination status-publish has-post-thumbnail hentry">
								</article>		
								<!--- // Content -->
								<div class="one-half content offset">
									<table class="hover">
										<tbody>
											<tr>
												<th>Lokasyonlar</th>
												<th>Özel</th>
											</tr>
											<tr>
												<td>Antalya Havaalanı</td>
												<td>
													<a href="http://www.gazipasa-airport724.com/search-results?ppl=1&amp;trip=1&amp;p1=457&amp;dep=2018-07-25&amp;d1=781">
														<h1><?php echo $lokcek['a_fiyat'];?>€</h1>
													</a>
												</td>
											</tr>
											<tr>
												<td>GAZİPAŞA HAVAALANI</td>
												<td>
													<a href="http://www.gazipasa-airport724.com/search-results?ppl=1&amp;trip=1&amp;p1=457&amp;dep=2018-07-25&amp;d1=781">
														<h1><?php echo $lokcek['g_fiyat'];?>€</h1>
													</a>
												<?php  } ?>
											</td>
										</tr>
									</tbody>
								</table>
							</div>
						</div>
					</div>

				</main>
				<div id="above-footer-sidebar" class="above-footer-sidebar widget-area clearfix" role="complementary">
					<ul>
					</ul>
				</div><!-- #secondary -->	
				<!-- //Main -->
				<!-- Footer -->
				<?php include 'footer.php'; ?>
				<!-- //Footer -->

				<script type='text/javascript'>
					/* <![CDATA[ */
					var wpcf7 = {"apiSettings":{"root":"http:\/\/www.gazipasa-airport724.com\/wp-json\/contact-form-7\/v1","namespace":"contact-form-7\/v1"},"recaptcha":{"messages":{"empty":"L\u00fctfen robot olmad\u0131\u011f\u0131n\u0131z\u0131 do\u011frulay\u0131n."}}};
					/* ]]> */
				</script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/contact-form-7/includes/js/scripts.js?ver=5.0.1'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/ui/core.min.js?ver=1.11.4'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/ui/widget.min.js?ver=1.11.4'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/ui/mouse.min.js?ver=1.11.4'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/ui/slider.min.js?ver=1.11.4'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/ui/button.min.js?ver=1.11.4'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/ui/datepicker.min.js?ver=1.11.4'></script>
				<script type='text/javascript'>
					jQuery(document).ready(function(jQuery){jQuery.datepicker.setDefaults({"closeText":"Kapat","currentText":"Bug\u00fcn","monthNames":["Ocak","\u015eubat","Mart","Nisan","May\u0131s","Haziran","Temmuz","A\u011fustos","Eyl\u00fcl","Ekim","Kas\u0131m","Aral\u0131k"],"monthNamesShort":["Oca","\u015eub","Mar","Nis","May","Haz","Tem","A\u011fu","Eyl","Eki","Kas","Ara"],"nextText":"Sonraki","prevText":"\u00d6nceki","dayNames":["Pazar","Pazartesi","Sal\u0131","\u00c7ar\u015famba","Per\u015fembe","Cuma","Cumartesi"],"dayNamesShort":["Paz","Pts","Sal","\u00c7ar","Per","Cum","Cts"],"dayNamesMin":["P","P","S","\u00c7","P","C","C"],"dateFormat":"MM d, yy","firstDay":1,"isRTL":false});});
				</script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/transfers-plugin/js/jquery.validate.min.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/transfers-plugin/js/i18n/datepicker-tr.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/transfers-plugin/js/jquery-ui-sliderAccess.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/transfers-plugin//js/jquery-ui-timepicker-addon.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/transfers-plugin//js/search.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/transfers-plugin/js/i18n/jquery-ui-timepicker-tr.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/ui/effect.min.js?ver=1.11.4'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/themes/transfers/js/jquery.uniform.min.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/themes/transfers/js/respond.min.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/themes/transfers/js/jquery.slicknav.min.js?ver=1.0'></script>
				<script type='text/javascript'>
					/* <![CDATA[ */
					var TransfersAjax = {"ajaxurl":"http:\/\/www.gazipasa-airport724.com\/wp-admin\/admin-ajax.php","nonce":"4f98e7d95f"};
					/* ]]> */
				</script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/themes/transfers/js/scripts.js?ver=1.0'></script>
				<script type='text/javascript' src='../../use.fontawesome.com/e808bf93975152.js?ver=1.0'></script>
				<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/wp-embed.min.js?ver=4.9.5'></script>
			</body>
			</html>