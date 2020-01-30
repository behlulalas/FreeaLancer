<?php

ob_start();

session_start();

include '../netting/baglan.php';

$basuvurusor=$db->prepare("SELECT * FROM basvurular");

$basuvurusor->execute();
$say3=$basuvurusor->rowCount();
$mailsor=$db->prepare("SELECT * FROM mailler");
$mailsor->execute();
$say4=$mailsor->rowCount();


if (!isset($_SESSION['adminadi']))
{
 header("Location:admin-giris.php");
}

?>



<!DOCTYPE html>

<html lang="en">

<head>

  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

  <!-- Meta, title, CSS, favicons, etc. -->

  <meta charset="utf-8">

  <meta http-equiv="X-UA-Compatible" content="IE=edge">

  <meta name="viewport" content="width=device-width, initial-scale=1">



  <title>B&B Developers | Admin Paneli </title>


  <!-- bootstrap-daterangepicker -->
  <link href="../vendors/bootstrap-daterangepicker/daterangepicker.css" rel="stylesheet">
  <!-- Ion.RangeSlider -->
  <link href="../vendors/normalize-css/normalize.css" rel="stylesheet">
  <link href="../vendors/ion.rangeSlider/css/ion.rangeSlider.css" rel="stylesheet">
  <link href="../vendors/ion.rangeSlider/css/ion.rangeSlider.skinFlat.css" rel="stylesheet">
  <!-- Bootstrap Colorpicker -->
  <link href="../vendors/mjolnic-bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css" rel="stylesheet">

  <link href="../vendors/cropper/dist/cropper.min.css" rel="stylesheet">



  <!-- Bootstrap -->

  <link href="../vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">

  <!-- Font Awesome -->

  <link href="../vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">

  <!-- NProgress -->

  <link href="../vendors/nprogress/nprogress.css" rel="stylesheet">

  <!-- iCheck -->

  <link href="../vendors/iCheck/skins/flat/green.css" rel="stylesheet">

  <!-- Datatables -->

  <link href="../vendors/datatables.net-bs/css/dataTables.bootstrap.min.css" rel="stylesheet">

  <link href="../vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css" rel="stylesheet">

  <link href="../vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css" rel="stylesheet">

  <link href="../vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css" rel="stylesheet">

  <link href="../vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css" rel="stylesheet">





  <!-- Dropzone.js -->



  <link href="../vendors/dropzone/dist/min/dropzone.min.css" rel="stylesheet">







  <!-- Dropzone.js -->



  <script src="../vendors/dropzone/dist/min/dropzone.min.js"></script>

  <!-- Ck Editör -->

  <script src="https://cdn.ckeditor.com/4.7.1/standard/ckeditor.js"></script>

  <style type="text/css">



</style>



<!-- Custom Theme Style -->

<link href="../build/css/custom.min.css" rel="stylesheet">

</head>



<body class="nav-md">

  <div class="container body">

    <div class="main_container">

      <div class="col-md-3 left_col">

        <div class="left_col scroll-view">

          <div class="navbar nav_title" style="border: 0;">

            <a href="index.html" class="site_title"><i class="fa fa-code"  style="border: none;"></i> <span>B&B Developers </span></a>

          </div>



          <div class="clearfix"></div>



          <!-- menu profile quick info -->

          <div class="profile clearfix">

            <div class="profile_pic">

              <img style="border-radius:200px;" src="images/user.png" alt="..." class="img-circle profile_img">

            </div>

            <div class="profile_info">

              <?php 

              $kullanicisor=$db->prepare("SELECT * FROM adminler");

              $kullanicisor->execute(array());

              $kullanicicek=$kullanicisor->fetch(PDO::FETCH_ASSOC);

              $kullanici_adi = $_SESSION['adminadi'];

              ?>

              <span>Hoşgeldin</span>

              <h2><?php echo $kullanici_adi ?></h2>

            </div>

          </div>

          <!-- /menu profile quick info -->



          <br />



          <!-- sidebar menu -->

          <div id="sidebar-menu" class="main_menu_side hidden-print main_menu">

            <div class="menu_section">

              <h3>Menüler</h3>

              <ul class="nav side-menu">

                <li><a href="index.php"><i class="fa fa-home"></i> Anasayfa </a></li>

                

                <li><a><i class="fa fa-edit"></i>İçerikleri Değiştir<span class="fa fa-chevron-down"></span></a>

                  <ul class="nav child_menu">

                    <li><a href="genel-ayar.php">Genel Ayarlar</a></li>

                    <li><a href="sayfaicerik.php">Sayfa İçerik Değiştir</a></li> 
                    <li><a href="anasayfaresim.php">Anasayfa Resim Değiştir</a></li> 
                    <li><a href="hakkimizda.php">Hakkımızda Değiştir </a></li> 



                  </ul>

                </li>
                <li><a><i class="fa fa-plus"></i>İçerik Ekle<span class="fa fa-chevron-down"></span></a>
                  <ul class="nav child_menu">
                    <li><a href="icerik-ekle.php"> Lokasyon Ekle</a></li>
                    <li><a href="arac-ekle.php">Araç Ekle</a></li> 

                  </ul>


                  <li><a href="logo.php"><i class="fa fa-image"></i> Logo Değiştir</a></li>
                  <li><a href="araclar.php"><i class="fa fa-car"></i> Araçlarımız</a></li>
                  <li><a href="lokasyonlar.php"><i class="fa fa-map-marker"></i> Lokasyonlarımız</a></li>
                  <li><a href="renkler.php"><i class="fa fa-paint-brush"></i> Sayfa Renklerini Değiştir</a></li>







                  <li><a href="admin.php"><i class="fa fa-user-plus"></i> Admin Ekle</a></li>
                  <li><a href="adminler.php"><i class="fa fa-user-secret"></i> Adminler</a></li>

                </ul>

              </div>







            </div>

            <!-- /sidebar menu -->



            <!-- /menu footer buttons -->

            <div class="sidebar-footer hidden-small">

              <a data-toggle="tooltip" data-placement="top" title="Settings">

                <span class="glyphicon glyphicon-cog" aria-hidden="true"></span>

              </a>

              <a data-toggle="tooltip" data-placement="top" title="FullScreen">

                <span class="glyphicon glyphicon-fullscreen" aria-hidden="true"></span>

              </a>

              <a data-toggle="tooltip" data-placement="top" title="Lock">

                <span class="glyphicon glyphicon-eye-close" aria-hidden="true"></span>

              </a>

              <a data-toggle="tooltip" data-placement="top" title="Logout">

                <span class="glyphicon glyphicon-off" aria-hidden="true"></span>

              </a>

            </div>

            <!-- /menu footer buttons -->

          </div>

        </div>



        <!-- top navigation -->

        <div class="top_nav">

          <div class="nav_menu">

            <nav>

              <div class="nav toggle">

                <a id="menu_toggle"><i class="fa fa-bars"></i></a>

              </div>



              <ul class="nav navbar-nav navbar-right">

                <li class="">

                  <a href="javascript:;" class="user-profile dropdown-toggle" data-toggle="dropdown" aria-expanded="false">

                    <img src="images/user.png" alt=""><?php echo $kullanici_adi ?>

                    <span class=" fa fa-angle-down"></span>

                  </a>

                  <ul class="dropdown-menu dropdown-usermenu pull-right">

                    <li><a href="javascript:;"> Profil Bilgilerim</a></li>





                    <li><a href="logout.php"><i class="fa fa-sign-out pull-right"></i> Güvenli Çıkış</a></li>

                  </ul>

                </li>





              </ul>

            </nav>

          </div>

        </div>

        <!-- /top navigation -->