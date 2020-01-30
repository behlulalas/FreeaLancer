<?php 
include "header.php";
?>
<!-- Main -->
<main class="main " role="main">	<!--- Content -->
	<div class="full-width">
		<section class="home-content-sidebar">
			<ul>
				<li class="widget widget-sidebar transfers_advanced_search_widget">		<!-- Advanced search -->
					<?php include "search.php"; ?>
					<!-- // Advanced search -->
				</li><li class="widget widget-sidebar transfers_hero_unit_widget">		<!-- Intro -->
					<div class="intro" style="background-image:url(nedmin/production/<?php echo $resimcek['a_resim1']; ?>);">
						<div class="wrap">
							<div class="textwidget">
								<h1 class="wow fadeInDown"><?php echo $ayarcek['yazi1']; ?></h1>
								<h2 class="wow fadeInUp"><?php echo $ayarcek['yazi2']; ?></h2>
								<div class="actions">
									<a href="#services" title="Servislerimiz" class="btn large white wow fadeInLeft anchor"><?php echo $ayarcek['a_yazi1']; ?></a>
									<a href="#booking" title="Rezervasyon" class="btn large color wow fadeInRight anchor"><?php echo $ayarcek['a_yazi2']; ?></a>
								</div>
							</div>
						</div>
					</div>
					<!-- //Intro -->
				</li>
				<li class="widget widget-sidebar transfers_iconic_features_widget">		
					<!-- Services iconic -->
					<div class="services iconic white">
						<div class="wrap">
							<div class="row">
								<!-- Item -->
								<div class="one-third">
									<span class="circle">
										<span class="icon icon-themeenergy_balloons">

										</span>
									</span>
									<h3><?php echo $ayarcek['baslik1']; ?></h3>
									<p>
										<?php echo $ayarcek['yazi3']; ?>							

									</p>
								</div>
								<!-- //Item -->
								<!-- Item -->
								<div class="one-third">
									<span class="circle">
										<span class="icon icon-themeenergy_diamond">

										</span>
									</span>
									<h3><?php echo $ayarcek['baslik2']; ?></h3>
									<p>
										<?php echo $ayarcek['yazi4']; ?>							

									</p>
								</div>
								<!-- //Item -->
								<!-- Item -->
								<div class="one-third">
									<span class="circle">
										<span class="icon icon-themeenergy_sunset">

										</span>
									</span>
									<h3><?php echo $ayarcek['baslik3']; ?></h3>
									<p>
										<?php echo $ayarcek['yazi5']; ?>							

									</p>
								</div>
								<!-- //Item -->
								<!-- Item -->
								<div class="one-third">
									<span class="circle">
										<span class="icon icon-themeenergy_umbrella">

										</span>
									</span>
									<h3><?php echo $ayarcek['baslik4']; ?></h3>
									<p>
										<?php echo $ayarcek['yazi6']; ?>							

									</p>
								</div>
								<!-- //Item -->
								<!-- Item -->
								<div class="one-third">
									<span class="circle">
										<span class="icon icon-themeenergy_city-train"></span>
									</span>
									<h3><?php echo $ayarcek['baslik5']; ?></h3>
									<p>
										<?php echo $ayarcek['yazi7']; ?>							

									</p>
								</div>
								<!-- //Item -->
								<!-- Item -->
								<div class="one-third">
									<span class="circle">
										<span class="icon icon-themeenergy_phone-phone-call"></span>
									</span>
									<h3><?php echo $ayarcek['baslik6']; ?></h3>
									<p>
										<?php echo $ayarcek['yazi8']; ?>							

									</p>
								</div>
								<!-- //Item -->


							</div>
						</div>
					</div>
					<!-- //Services iconic -->

				</li>
				<li class="widget widget-sidebar transfers_call_to_action_widget">		<!-- Call to action -->
					<div class="color cta">
						<div class="wrap">
							<p class="fadeInLeft">
								Sorularınız mı var? Size yardımcı olabiliriz.				
							</p>
							<a href="iletisim.php" class="btn huge black right fadeInRight">Bize Ulaşın</a>
						</div>
					</div>
					<!-- //Call to action -->
				</li>
				<li class="widget widget-sidebar transfers_featured_services_widget">		
					<div class="services boxed white">
						<!-- Item -->
						<article class="one-fourth fadeIn">
							<figure class="featured-image">
								<img src="nedmin/production/<?php echo $resimcek['a_resim2']; ?>" alt="Side Transfer" />
								<div class="overlay">
									<a href=" servislerimiz.html" title="Side Transfer" class="expand">+</a>
								</div>
							</figure>
							<div class="details">
								<h4><a href=" servislerimiz.html" title="Side Transfer"><?php echo $ayarcek['a_baslik3']; ?></a></h4>
								<p>
									<?php echo $ayarcek['a_yazi3']; ?>		
								</p>
								<a href=" servislerimiz.html" title="Detaylar" class="more">Detaylar</a>
							</div>
						</article>
						<!-- //Item --><!-- Item -->
						<article class="one-fourth fadeIn">
							<figure class="featured-image">
								<img src="nedmin/production/<?php echo $resimcek['a_resim3']; ?>" alt="gazipasa transfer" />
								<div class="overlay">
									<a href=" servislerimiz.html" title="gazipasa transfer" class="expand">+</a>
								</div>
							</figure>
							<div class="details">
								<h4><a href=" servislerimiz.html" title="gazipasa transfer"><?php echo $ayarcek['a_baslik4']; ?></a></h4>
								<p>
									<?php echo $ayarcek['a_yazi4']; ?>	
								</p>
								<a href=" servislerimiz.html" title="Detaylar" class="more">Detaylar</a>
							</div>
						</article>
						<!-- //Item --><!-- Item -->
						<article class="one-fourth fadeIn">
							<figure class="featured-image">
								<img src="nedmin/production/<?php echo $resimcek['a_resim4']; ?>" alt="Gazipaşa Havalimanı Transfer" />
								<div class="overlay">
									<a href=" servislerimiz.html" title="Gazipaşa Havalimanı Transfer" class="expand">+</a>
								</div>
							</figure>
							<div class="details">
								<h4><a href=" servislerimiz.html" title="Gazipaşa Havalimanı Transfer"><?php echo $ayarcek['a_baslik5']; ?></a></h4>
								<p>
									Ga<?php echo $ayarcek['a_yazi5']; ?>		
								</p>
								<a href=" servislerimiz.html" title="Detaylar" class="more">Detaylar</a>
							</div>
						</article>
						<!-- //Item --><!-- Item -->
						<article class="one-fourth fadeIn">
							<figure class="featured-image">
								<img src="nedmin/production/<?php echo $resimcek['a_resim5'];?>" alt="GAZİPAŞA HAVALİMANI TRANSFER SERVİSİ" />
								<div class="overlay">
									<a href=" servislerimiz.html" title="GAZİPAŞA HAVALİMANI TRANSFER SERVİSİ" class="expand">+</a>
								</div>
							</figure>
							<div class="details">
								<h4><a href=" servislerimiz.html" title="GAZİPAŞA HAVALİMANI TRANSFER SERVİSİ"><?php echo $ayarcek['a_baslik6']; ?></a></h4>
								<p>
									<?php echo $ayarcek['a_yazi6']; ?>		
								</p>
								<a href=" servislerimiz.html" title="Detaylar" class="more">Detaylar</a>
							</div>
						</article>
						<!-- //Item -->
					</div>
				</li>
				<li class="widget widget-sidebar transfers_featured_testimonial_widget">		<!-- Testimonials -->
					<div class="testimonials center black" style="background:url(nedmin/production/<?php echo $resimcek['a_resim6']; ?>) 50% 100% no-repeat;">
						<div class="wrap">
							<h6 class="wow fadeInDown"><?php echo $ayarcek['yazi10']; ?></h6>
							<p class="wow fadeInUp">
								<?php echo $ayarcek['yazi11']; ?>				</p>
								<p class="meta wow fadeInUp"><?php echo $ayarcek['yazi12']; ?></p>
							</div>
						</div>
						<!-- //Testimonials -->
					</li>
					<li id="text-2" class="widget widget-sidebar widget_text">			
						<div class="textwidget"></div>
					</li>		
				</ul>
			</section><!-- #secondary -->
		</div>
		<!--- //Content -->
	</main>
	<div id="above-footer-sidebar" class="above-footer-sidebar widget-area clearfix" role="complementary">
		<ul>
		</ul>
	</div><!-- #secondary -->
	<!-- //Main -->
	<!-- Footer -->
	<?php include  'footer.php';?>
	<!-- //Footer -->

	<script type='text/javascript'>
		/* <![CDATA[ */
		var wpcf7 = {"apiSettings":{"root":"http:\/\/www.gazipasa-airport724.com\/wp-json\/contact-form-7\/v1","namespace":"contact-form-7\/v1"},"recaptcha":{"messages":{"empty":"L\u00fctfen robot olmad\u0131\u011f\u0131n\u0131z\u0131 do\u011frulay\u0131n."}}};
		/* ]]> */
	</script>
	<script type='text/javascript' src='wp-content/plugins/contact-form-7/includes/js/scripts972f.js?ver=5.0.1'></script>
	<script type='text/javascript' src='wp-includes/js/jquery/ui/core.mine899.js?ver=1.11.4'></script>
	<script type='text/javascript' src='wp-includes/js/jquery/ui/widget.mine899.js?ver=1.11.4'></script>
	<script type='text/javascript' src='wp-includes/js/jquery/ui/mouse.mine899.js?ver=1.11.4'></script>
	<script type='text/javascript' src='wp-includes/js/jquery/ui/slider.mine899.js?ver=1.11.4'></script>
	<script type='text/javascript' src='wp-includes/js/jquery/ui/button.mine899.js?ver=1.11.4'></script>
	<script type='text/javascript' src='wp-includes/js/jquery/ui/datepicker.mine899.js?ver=1.11.4'></script>
	<script type='text/javascript'>
		jQuery(document).ready(function(jQuery){jQuery.datepicker.setDefaults({"closeText":"Kapat","currentText":"Bug\u00fcn","monthNames":["Ocak","\u015eubat","Mart","Nisan","May\u0131s","Haziran","Temmuz","A\u011fustos","Eyl\u00fcl","Ekim","Kas\u0131m","Aral\u0131k"],"monthNamesShort":["Oca","\u015eub","Mar","Nis","May","Haz","Tem","A\u011fu","Eyl","Eki","Kas","Ara"],"nextText":"Sonraki","prevText":"\u00d6nceki","dayNames":["Pazar","Pazartesi","Sal\u0131","\u00c7ar\u015famba","Per\u015fembe","Cuma","Cumartesi"],"dayNamesShort":["Paz","Pts","Sal","\u00c7ar","Per","Cum","Cts"],"dayNamesMin":["P","P","S","\u00c7","P","C","C"],"dateFormat":"MM d, yy","firstDay":1,"isRTL":false});});
	</script>
	<script type='text/javascript' src='wp-content/plugins/transfers-plugin/js/jquery.validate.min5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-content/plugins/transfers-plugin/js/i18n/datepicker-tr5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-content/plugins/transfers-plugin/js/jquery-ui-sliderAccess5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-content/plugins/transfers-plugin/js/jquery-ui-timepicker-addon5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-content/plugins/transfers-plugin/js/search5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-content/plugins/transfers-plugin/js/i18n/jquery-ui-timepicker-tr5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-includes/js/comment-reply.min55fe.js?ver=4.9.5'></script>
	<script type='text/javascript' src='wp-includes/js/jquery/ui/effect.mine899.js?ver=1.11.4'></script>
	<script type='text/javascript' src='wp-content/themes/transfers/js/jquery.uniform.min5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-content/themes/transfers/js/respond.min5152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-content/themes/transfers/js/jquery.slicknav.min5152.js?ver=1.0'></script>
	<script type='text/javascript'>
		/* <![CDATA[ */
		var TransfersAjax = {"ajaxurl":"http:\/\/www.gazipasa-airport724.com\/wp-admin\/admin-ajax.php","nonce":"11400feff6"};
		/* ]]> */
	</script>
	<script type='text/javascript' src='wp-content/themes/transfers/js/scripts5152.js?ver=1.0'></script>
	<script type='text/javascript' src='../use.fontawesome.com/e808bf93975152.js?ver=1.0'></script>
	<script type='text/javascript' src='wp-includes/js/wp-embed.min55fe.js?ver=4.9.5'></script>
</body>
</html>