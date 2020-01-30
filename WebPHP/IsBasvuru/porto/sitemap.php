<?php header('Content-type: application/xml; charset="utf8"',true); ?>
<urlset 
xmlns="http://www.sitemaps.org/schemas/sitemap/0.9"
xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
xsi:schemaLocation="http://www.sitemaps.org/schemas/sitemap/0.9
http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd"
>
<?php 
function seo($s) {
	$tr = array('ş','Ş','ı','I','İ','ğ','Ğ','ü','Ü','ö','Ö','Ç','ç','(',')','/',' ',',','?');
	$eng = array('s','s','i','i','i','g','g','u','u','o','o','c','c','','','-','-','','');
	$s = str_replace($tr,$eng,$s);
	$s = strtolower($s);
	$s = preg_replace('/&amp;amp;amp;amp;amp;amp;amp;amp;amp;.+?;/', '', $s);
	$s = preg_replace('/\s+/', '-', $s);
	$s = preg_replace('|-+|', '-', $s);
	$s = preg_replace('/#/', '', $s);
	$s = str_replace('.', '', $s);
	$s = trim($s, '-');
	return $s;
}
	$tarih=Date("Y-m-d");
 ?>
 <url>
 	<loc>http://www.demirorganizasyon.com/index</loc>
 	<lastmod><?php echo $tarih; ?></lastmod>
 	<changefreq>daily</changefreq>
 	<priority>1.00</priority>
 </url>
  <url>
 	<loc>http://www.demirorganizasyon.com/iletisim</loc>
 	<lastmod><?php echo $tarih; ?></lastmod>
 	<changefreq>daily</changefreq>
 	<priority>1.00</priority>
 </url>
  <url>
 	<loc>http://www.demirorganizasyon.com/basvuru</loc>
 	<lastmod><?php echo $tarih; ?></lastmod>
 	<changefreq>daily</changefreq>
 	<priority>1.00</priority>
 </url>
  <url>
 	<loc>http://www.demirorganizasyon.com/ekip</loc>
 	<lastmod><?php echo $tarih; ?></lastmod>
 	<changefreq>daily</changefreq>
 	<priority>1.00</priority>
 </url>
</urlset>