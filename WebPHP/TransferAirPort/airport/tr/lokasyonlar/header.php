
<?php 
ob_start();
include '../../nedmin/netting/baglan.php';
$loksor=$db->prepare("SELECT *FROM lokasyon where ID='".$_GET['lokasyon']."'");
$loksor->execute(array());

$loksor1=$db->prepare("SELECT *FROM lokasyon");
$loksor1->execute(array());


$fiyatsor=$db->prepare("SELECT *FROM lokasyon where ID='".$_GET['lokasyon']."'");
$fiyatsor->execute(array());

$aracsor=$db->prepare("SELECT *FROM arac where ID='".$_GET['arac']."'");
$aracsor->execute(array());

$aracsor1=$db->prepare("SELECT *FROM arac");
$aracsor1->execute(array());

$ayarsor=$db->prepare("SELECT *FROM ayar where ID=?");
$ayarsor->execute(array(0));
$ayarcek=$ayarsor->fetch(PDO::FETCH_ASSOC);


?>
<!DOCTYPE html>
<html lang="tr-TR" prefix="og: http://ogp.me/ns#">
<!-- Added by HTTrack --><meta http-equiv="content-type" content="text/html;charset=UTF-8" /><!-- /Added by HTTrack -->
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />
	<title>Gazipasa Havaalanı Transfer</title>
	<link rel="pingback" href="http://www.gazipasa-airport724.com/xmlrpc.php" />
	<script type="text/javascript">
		window.themePath = 'http://www.gazipasa-airport724.com/wp-content/themes/transfers';
		window.siteUrl = 'http://www.gazipasa-airport724.com/';

		window.currentUserId = 0;
		window.currentUserLogin = null;
		window.currentLanguage = 'tr';

		window.datepickerDateFormat = "MM d, yy";
		window.datepickerAltFormat = "yy-mm-dd";
	</script>
	<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
	<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="http://www.gazipasa-airport724.com/wp-content/themes/transfers/js/html5shiv.min.js"></script>
    <script src="http://www.gazipasa-airport724.com/wp-content/themes/transfers/js/respond.min.js"></script>
<![endif]-->

<!-- This site is optimized with the Yoast SEO plugin v7.4.2 - https://yoast.com/wordpress/plugins/seo/ -->
<link rel="canonical" href="kizilot.html" />
<meta property="og:locale" content="tr_TR" />
<meta property="og:type" content="article" />
<meta property="og:title" content="KIZILOT - Gazipasa airport transfer" />
<meta property="og:url" content="http://www.gazipasa-airport724.com/lokasyonlar/kizilot" />
<meta property="og:site_name" content="Gazipasa airport transfer" />
<meta property="og:image" content="http://www.gazipasa-airport724.com/wp-content/uploads/2017/11/Kizilot.jpg" />
<meta property="og:image:width" content="900" />
<meta property="og:image:height" content="675" />
<meta name="twitter:card" content="summary_large_image" />
<meta name="twitter:title" content="KIZILOT - Gazipasa airport transfer" />
<meta name="twitter:site" content="@muhamme20963874" />
<meta name="twitter:image" content="http://www.gazipasa-airport724.com/wp-content/uploads/2017/11/Kizilot.jpg" />
<meta name="twitter:creator" content="@muhamme20963874" />
<!-- / Yoast SEO plugin. -->

<link rel='dns-prefetch' href='http://use.fontawesome.com/' />
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css" integrity="sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ" crossorigin="anonymous">
<link rel='dns-prefetch' href='http://fonts.googleapis.com/' />
<link rel='dns-prefetch' href='http://s.w.org/' />
<link rel="alternate" type="application/rss+xml" title="Gazipasa airport transfer &raquo; beslemesi" href="http://www.gazipasa-airport724.com/feed" />
<link rel="alternate" type="application/rss+xml" title="Gazipasa airport transfer &raquo; yorum beslemesi" href="http://www.gazipasa-airport724.com/comments/feed" />
<script type="text/javascript">
	window._wpemojiSettings = {"baseUrl":"https:\/\/s.w.org\/images\/core\/emoji\/2.4\/72x72\/","ext":".png","svgUrl":"https:\/\/s.w.org\/images\/core\/emoji\/2.4\/svg\/","svgExt":".svg","source":{"concatemoji":"http:\/\/www.gazipasa-airport724.com\/wp-includes\/js\/wp-emoji-release.min.js?ver=4.9.5"}};
	!function(a,b,c){function d(a,b){var c=String.fromCharCode;l.clearRect(0,0,k.width,k.height),l.fillText(c.apply(this,a),0,0);var d=k.toDataURL();l.clearRect(0,0,k.width,k.height),l.fillText(c.apply(this,b),0,0);var e=k.toDataURL();return d===e}function e(a){var b;if(!l||!l.fillText)return!1;switch(l.textBaseline="top",l.font="600 32px Arial",a){case"flag":return!(b=d([55356,56826,55356,56819],[55356,56826,8203,55356,56819]))&&(b=d([55356,57332,56128,56423,56128,56418,56128,56421,56128,56430,56128,56423,56128,56447],[55356,57332,8203,56128,56423,8203,56128,56418,8203,56128,56421,8203,56128,56430,8203,56128,56423,8203,56128,56447]),!b);case"emoji":return b=d([55357,56692,8205,9792,65039],[55357,56692,8203,9792,65039]),!b}return!1}function f(a){var c=b.createElement("script");c.src=a,c.defer=c.type="text/javascript",b.getElementsByTagName("head")[0].appendChild(c)}var g,h,i,j,k=b.createElement("canvas"),l=k.getContext&&k.getContext("2d");for(j=Array("flag","emoji"),c.supports={everything:!0,everythingExceptFlag:!0},i=0;i<j.length;i++)c.supports[j[i]]=e(j[i]),c.supports.everything=c.supports.everything&&c.supports[j[i]],"flag"!==j[i]&&(c.supports.everythingExceptFlag=c.supports.everythingExceptFlag&&c.supports[j[i]]);c.supports.everythingExceptFlag=c.supports.everythingExceptFlag&&!c.supports.flag,c.DOMReady=!1,c.readyCallback=function(){c.DOMReady=!0},c.supports.everything||(h=function(){c.readyCallback()},b.addEventListener?(b.addEventListener("DOMContentLoaded",h,!1),a.addEventListener("load",h,!1)):(a.attachEvent("onload",h),b.attachEvent("onreadystatechange",function(){"complete"===b.readyState&&c.readyCallback()})),g=c.source||{},g.concatemoji?f(g.concatemoji):g.wpemoji&&g.twemoji&&(f(g.twemoji),f(g.wpemoji)))}(window,document,window._wpemojiSettings);
</script>
<style type="text/css">
img.wp-smiley,
img.emoji {
	display: inline !important;
	border: none !important;
	box-shadow: none !important;
	height: 1em !important;
	width: 1em !important;
	margin: 0 .07em !important;
	vertical-align: -0.1em !important;
	background: none !important;
	padding: 0 !important;
}
</style>
<link rel='stylesheet' id='contact-form-7-css'  href='http://www.gazipasa-airport724.com/wp-content/plugins/contact-form-7/includes/css/styles.css?ver=5.0.1' type='text/css' media='all' />
<link rel='stylesheet' id='rs-plugin-settings-css'  href='http://www.gazipasa-airport724.com/wp-content/plugins/revslider/public/assets/css/settings.css?ver=5.3.0.2' type='text/css' media='all' />
<style id='rs-plugin-settings-inline-css' type='text/css'>
#rs-demo-id {}
</style>
<link rel='stylesheet' id='transfers-font-style-css'  href='https://fonts.googleapis.com/css?family=Montserrat%3A400%2C700%7CRaleway%3A400%2C500%2C600%2C700&amp;subset=latin%2Clatin-ext&amp;ver=4.9.5' type='text/css' media='all' />
<link rel='stylesheet' id='transfers-style-main-css'  href='http://www.gazipasa-airport724.com/wp-content/themes/transfers/css/style.css?ver=1.0' type='text/css' media='all' />
<link rel='stylesheet' id='transfers-style-css'  href='http://www.gazipasa-airport724.com/wp-content/themes/transfers/style.css?ver=1.0' type='text/css' media='all' />
<link rel='stylesheet' id='transfers-style-ui-css'  href='http://www.gazipasa-airport724.com/wp-content/themes/transfers/css/jquery-ui.theme.min.css?ver=1.0' type='text/css' media='all' />
<link rel='stylesheet' id='transfers-fonts-css'  href='http://www.gazipasa-airport724.com/wp-content/themes/transfers/css/fonts.css?ver=1.0' type='text/css' media='all' />

<style type="text/css">
::-moz-selection 	
{
	background:<?php echo $ayarcek['renkkodu']; ?>;color:#fff;
}
::selection
{
	background:<?php echo $ayarcek['renkkodu']; ?>;color:#fff;
}

html
{
	-webkit-tap-highlight-color:<?php echo $ayarcek['renkkodu']; ?>;
}

a,
.more,
.services.boxed .details h4 a:hover,
.services.iconic h3,
.content a,.description a:hover,
.description a:focus,.microlocations p a:hover,
.microlocations p a:focus,
.hentry .entry-content h2 a:hover,
.hentry .entry-content h2 a:focus,
.footer .contact-data a:hover,
.footer .contact-data a:focus,
.xdsoft_datetimepicker  .xdsoft_calendar td.xdsoft_today,
.faqs .expanded,
.faqs .expanded:after,
.black .ico,
.icon,
.testimonials h6:before,
blockquote:before 		
{
	color:<?php echo $ayarcek['renkkodu']; ?>;
}
.color,
.pager a
.current,
.pager a:hover,
.pager a:focus,
table.hover tr:hover td,
.tabs li.active a,
.social li:hover,
.data th,
.tabs li a:hover,
.tabs li a:focus,
.xdsoft_datetimepicker  .xdsoft_calendar td.xdsoft_default,
.xdsoft_datetimepicker  .xdsoft_calendar td.xdsoft_current,
.xdsoft_datetimepicker  .xdsoft_timepicker .xdsoft_time_box >div >div.xdsoft_current,
.xdsoft_datetimepicker  .xdsoft_label > .xdsoft_select > div > .xdsoft_option.xdsoft_current,
.xdsoft_datetimepicker  .xdsoft_label > .xdsoft_select > div > .xdsoft_option:hover,
.slicknav_menu .slicknav_icon-bar			
{
	background-color:<?php echo $ayarcek['renkkodu']; ?> !important;
}
.xdsoft_datetimepicker  .xdsoft_calendar td:hover,
.xdsoft_datetimepicker  .xdsoft_timepicker .xdsoft_time_box >div >div:hover,
button, 
input[type="button"], 
input[type="reset"], 
input[type="submit"],#wp-calendar #today,.woocommerce .woocommerce-breadcrumb,
.woocommerce #respond input#submit,
.woocommerce a.button, 
.woocommerce button.button, 
.woocommerce input.button,
.woocommerce #respond input#submit.alt,
.woocommerce a.button.alt, .woocommerce button.button.alt,
.woocommerce input.button.alt 
{
	background:<?php echo $ayarcek['renkkodu']; ?> !important;
}
.btn:hover,
.btn:focus,
button,
input[type="button"], 
input[type="reset"], 
input[type="submit"] 		
{
	background:<?php echo $ayarcek['renkkodu']; ?> !important;
	color:#fff !important;
}
.more:after,
.single a:after,
.main .static-content 
.entry-content a:after 	
{
	border-bottom:2px dotted <?php echo $ayarcek['renkkodu']; ?>;
}
.tabs li.active a:after		{
	border-color:<?php echo $ayarcek['renkkodu']; ?> transparent transparent transparent;
}


</style>
<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/jquery.js?ver=1.12.4'></script>
<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-includes/js/jquery/jquery-migrate.min.js?ver=1.4.1'></script>
<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/revslider/public/assets/js/jquery.themepunch.tools.min.js?ver=5.3.0.2'></script>
<script type='text/javascript' src='http://www.gazipasa-airport724.com/wp-content/plugins/revslider/public/assets/js/jquery.themepunch.revolution.min.js?ver=5.3.0.2'></script>
<link rel='https://api.w.org/' href='http://www.gazipasa-airport724.com/wp-json/' />
<link rel="EditURI" type="application/rsd+xml" title="RSD" href="http://www.gazipasa-airport724.com/xmlrpc.php?rsd" />
<link rel="wlwmanifest" type="application/wlwmanifest+xml" href="http://www.gazipasa-airport724.com/wp-includes/wlwmanifest.xml" /> 
<meta name="generator" content="WordPress 4.9.5" />
<link rel='shortlink' href='http://www.gazipasa-airport724.com/?p=457' />
<link rel="alternate" type="application/json+oembed" href="http://www.gazipasa-airport724.com/wp-json/oembed/1.0/embed?url=http%3A%2F%2Fwww.gazipasa-airport724.com%2Flokasyonlar%2Fkizilot" />
<link rel="alternate" type="text/xml+oembed" href="http://www.gazipasa-airport724.com/wp-json/oembed/1.0/embed?url=http%3A%2F%2Fwww.gazipasa-airport724.com%2Flokasyonlar%2Fkizilot&amp;format=xml" />
<link hreflang="x-default" href="kizilot.html" rel="alternate" />
<meta name="generator" content="qTranslate-X 3.4.6.8" />
<style type="text/css">.recentcomments a{display:inline !important;padding:0 !important;margin:0 !important;}</style>
<meta name="generator" content="Powered by Slider Revolution 5.3.0.2 - responsive, Mobile-Friendly Slider Plugin for WordPress with comfortable drag and drop interface." />
<link rel="icon" href="http://www.gazipasa-airport724.com/wp-content/uploads/2015/08/cropped-vip-32x32.jpg" sizes="32x32" />
<link rel="icon" href="http://www.gazipasa-airport724.com/wp-content/uploads/2015/08/cropped-vip-192x192.jpg" sizes="192x192" />
<link rel="apple-touch-icon-precomposed" href="http://www.gazipasa-airport724.com/wp-content/uploads/2015/08/cropped-vip-180x180.jpg" />
<meta name="msapplication-TileImage" content="http://www.gazipasa-airport724.com/wp-content/uploads/2015/08/cropped-vip-270x270.jpg" />
<style type="text/css" id="wp-custom-css">
body   {
	background:grey
}		</style>
</head>  
<body class="destination-template-default single single-destination postid-457">
	<!-- Preloader -->
	<div class="preloader">
		<div id="followingBallsG">
			<div id="followingBallsG_1" class="followingBallsG"></div>
			<div id="followingBallsG_2" class="followingBallsG"></div>
			<div id="followingBallsG_3" class="followingBallsG"></div>
			<div id="followingBallsG_4" class="followingBallsG"></div>
		</div>
	</div>
	<!-- //Preloader -->
	<!-- Header -->
	<header class="header" role="banner">
		<div class="wrap">
			<!-- Logo -->
			<div class="logo">
				<a href="#" title="Gazipasa airport transfer"><img src="http://www.gazipasa-airport724.com/wp-content/uploads/2017/12/GAZİPASA.png" alt="Gazipasa airport transfer" /></a>
			</div>
			<!-- //Logo -->
			<!--primary navigation-->
			<nav id="nav" class="main-nav"><ul id="menu-footer" class=""><li id="menu-item-595" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-595"><a href="../../hakkimizda.php">Hakkımızda</a></li>
				<li id="menu-item-571" class="menu-item menu-item-type-post_type menu-item-object-page current-menu-ancestor current-menu-parent current_page_parent current_page_ancestor menu-item-has-children menu-item-571"><a href="#">Lokasyonlar</a>
					<ul class="sub-menu">
							<?php 

							while ($lokcek1=$loksor1->fetch(PDO::FETCH_ASSOC)) { ?>

								<li id="menu-item-579" class="menu-item menu-item-type-post_type menu-item-object-destination menu-item-579">
									<a href="../lokasyonlar/lokasyonlar.php?lokasyon=<?php echo $lokcek1['ID'];?>"><?php echo $lokcek1['ladi'];?></a>
								</li>
							<?php }?>
						</ul>
				</li>
				<li id="menu-item-591" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-has-children menu-item-591"><a href="#">ARAÇLARIMIZ</a>
					<ul class="sub-menu">
						<?php 

							while ($araccek1=$aracsor1->fetch(PDO::FETCH_ASSOC)) { ?>
						<li id="menu-item-593" class="menu-item menu-item-type-post_type menu-item-object-transport_type menu-item-593"><a href="../araclar/araclar.php?arac=<?php echo $araccek1['ID']; ?>"><?php echo $araccek1['aracadi']; ?></a></li>
						<?php } ?>
					</ul>
				</li>
				<li id="menu-item-839" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-839"><a href="#">Blog</a></li>
				<li id="menu-item-588" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-588"><a href="#">SSS</a></li>
				
			</ul></nav>			<!--//primary navigation-->
		</div>
	</header>
	<!-- //Header -->