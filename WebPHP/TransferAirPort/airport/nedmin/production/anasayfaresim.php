<?php 
ob_start();
include '../netting/baglan.php';
include 'header.php';

$ayarsor=$db->prepare("SELECT *FROM ayar where ID=?");
$ayarsor->execute(array(0));
$ayarcek=$ayarsor->fetch(PDO::FETCH_ASSOC);

$resimsor=$db->prepare("SELECT * FROM anasayfa_resimler where ID=?");
$resimsor->execute(array(0));
$resimcek=$resimsor->fetch(PDO::FETCH_ASSOC);
?>

<!-- page content -->
<div class="right_col" role="main">
  <div class="">
    <div class="page-title">
      <div class="title_left">
        <h3>AYARLAR</h3>
      </div>

      <div class="title_right">
        <div class="col-md-5 col-sm-5 col-xs-12 form-group pull-right top_search">
          <div class="input-group">
            <input type="text" class="form-control" placeholder="Anahtar Kelimeniz">
            <span class="input-group-btn">
              <button class="btn btn-default" type="button">Ara!</button>
            </span>
          </div>
        </div>
      </div>
    </div>

    <div class="clearfix"></div>

    <div class="row">
      <div class="col-md-12 col-sm-12 col-xs-12">
       <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
          <div class="x_title">
            <h2 style="color:black;">Genel Ayarlar <br><br><small><?php 
            if ($_GET[islem]=='ok')
            {
              echo '<br><b style="color:green; font-size:14px;"><i class="fa fa-check-circle"></i> Güncelleme Başarılı..</b>' ;
            }
            if($_GET[islem]=='no')
            {
             echo '<br><b style="color:red; font-size:14px;"><i class="fa fa-close"></i> Fotoğraf seçmeden güncelleyemessiniz. !</b>' ;
           }

           ?></small></h2>
           <ul class="nav navbar-right panel_toolbox">
            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
            </li>
            <li><a class="close-link"><i class="fa fa-close"></i></a>
            </li>
          </ul>
          <div class="clearfix"></div>
        </div>

        <div class="x_content">
          <b style="color:orange;">Resim 1 Güncelle</b>
          <hr style="border:0.5px solid;color:black;">
          
          <form action="resimguncelle.php" method="POST"  enctype="multipart/form-data">
            <div class="row">
              <div class="col-sm-4">
               <b>Seçilecek Resim 1 </b> <br>
               <input type="file" name="aresim1">  
             </div>
             <div class="col-sm-8" align="center">
               <b>Şuan ki Resim</b> <br>
               <img  width="120" src="<?php echo $resimcek['a_resim1']; ?>">
             </div>

             <div align="center" class="col-sm-12">    
              <input type="submit" name="rguncelle1" value="GÜNCELLE" class="btn btn-success">
            </div>
          </div>
          <br><b style="color:orange;">Resim 2 Güncelle</b>
          <hr style="border:0.5px solid;color:black;">

          <form action="resimguncelle.php" method="POST"  enctype="multipart/form-data">
            <div class="row">
              <div class="col-sm-4">
               <b>Seçilecek Resim 2 </b> <br>
               <input type="file" name="aresim2">  
             </div>
             <div class="col-sm-8" align="center">
               <b>Şuan ki Resim</b> <br>
               <img width="120" src="<?php echo $resimcek['a_resim2']; ?>">
             </div>
             <div align="center" class="col-sm-12">    
              <input type="submit" name="rguncelle2" value="GÜNCELLE" class="btn btn-success">
            </div>
          </div>
          <br><b style="color:orange;">Resim 3 Güncelle</b>
          <hr style="border:0.5px solid;color:black;">

          <form action="resimguncelle.php" method="POST"  enctype="multipart/form-data">
            <div class="row">
              <div class="col-sm-4">
               <b>Seçilecek Resim 3</b> <br>
               <input type="file" name="aresim3">  
             </div>
             <div class="col-sm-8" align="center">
               <b>Şuan ki Resim</b> <br>
               <img width="120" src="<?php echo $resimcek['a_resim3']; ?>">
             </div>
             <div align="center" class="col-sm-12">    
              <input type="submit" name="rguncelle3" value="GÜNCELLE" class="btn btn-success">
            </div>
          </div>
          <br><b style="color:orange;">Resim 4 Güncelle</b>
          <hr style="border:0.5px solid;color:black;">

          <form action="resimguncelle.php" method="POST"  enctype="multipart/form-data">
            <div class="row">
              <div class="col-sm-4">
               <b>Seçilecek Resim 4 </b> <br>
               <input type="file" name="aresim4">  
             </div>
             <div class="col-sm-8" align="center">
               <b>Şuan ki Resim</b> <br>
               <img width="120" src="<?php echo $resimcek['a_resim4'];?>">
             </div>
             <div align="center" class="col-sm-12">    
              <input type="submit" name="rguncelle4" value="GÜNCELLE" class="btn btn-success">
            </div>
          </div>
          <br> <b style="color:orange;">Resim 5 Güncelle</b>
          <hr style="border:0.5px solid;color:black;">

          <form action="resimguncelle.php" method="POST"  enctype="multipart/form-data">
            <div class="row">
              <div class="col-sm-4">
               <b>Seçilecek Resim 5</b> <br>
               <input type="file" name="aresim5">  
             </div>
             <div class="col-sm-8" align="center">
               <b>Şuan ki Resim</b> <br>
               <img  width="120" src="<?php echo $resimcek['a_resim5'];?>">
             </div>
             <div align="center" class="col-sm-12">    
              <input type="submit" name="rguncelle5" value="GÜNCELLE" class="btn btn-success">
            </div>
          </div>
          <br><b style="color:orange;">Resim 6 Güncelle</b>
          <hr style="border:0.5px solid;color:black;">

          <form action="resimguncelle.php" method="POST"  enctype="multipart/form-data">
            <div class="row">
              <div class="col-sm-4">
               <b>Seçilecek Resim 6 </b> <br>
               <input type="file" name="aresim6">  
             </div>
             <div class="col-sm-8" align="center">
               <b>Şuan ki Resim</b> <br>
               <img width="120" src="<?php echo $resimcek['a_resim6'];?>">
             </div>
             <div align="center" class="col-sm-12">    
              <input type="submit" name="rguncelle6" value="GÜNCELLE" class="btn btn-success">
            </div>
          </div>

          <hr style="border:0.5px solid;color:black;">

        </form>

      </div>
    </div>
  </div>
</div>
</div>
</div>
</div>


<!-- /page content -->

<!-- footer content -->
<?php include 'footer.php'; ?>