<?php 
ob_start();
include '../netting/baglan.php';
include 'header.php';
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
            <h2 style="color:black;">Genel Ayarlar<small><b style="color:orange;">İÇERİK DEĞİŞTİR</b></small></h2>
            <ul class="nav navbar-right panel_toolbox">
              <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
              </li>
              <li><a class="close-link"><i class="fa fa-close"></i></a>
              </li>
            </ul>
            <div class="clearfix"></div>
          </div>

          <div class="x_content">
            <b style="color:green;">Lokasyon Ekleme Ayarları</b>
            <hr style="border:0.5px solid;color:black;">

            <form action="ekle.php" method="POST" enctype="multipart/form-data">
              <div class="row">
                <div class="col-sm-4">
                 <b>Eklenecek lokasyon Adı</b> <br>
                 <input type="text" class="form-control" name="ladi" value="" placeholder="(Örnek:)" required >   
               </div>
               <div class="col-sm-4">
                 <b>Antalya Hava Alanı Fiyatı</b> <br>
                 <input type="text" class="form-control" name="afiyat" value="" placeholder="(Örnek:500)" required>  
               </div>
               <div class="col-sm-4">
                 <b>Gazipaşa Hava Alanı Fiyatı</b> <br>
                 <input type="text" class="form-control" name="gfiyat" value="" placeholder="(Örnek:120)" required>  
               </div> 
               <div class="col-sm-4">
                <br> <b>Resim Ekle</b> <br>
                 <input type="file"  name="resim" value="" required>  
               </div>

             </div>
             <hr style="border:0.5px solid;color:black;">
             <div class="row">
              <div align="center" class="col-sm-12">    
                <input type="submit" name="ekle" value="Ekle" class="btn btn-success">
              </div>
            </div>
          </form>
          <?php 
          if ($_GET[islem]=='ok')
          {
            echo '<br><b style="color:green; font-size:20px;"><i class="fa fa-check-circle"></i> Lokasyon başarıyla eklendi.</b>' ;
          }
          if($_GET[islem]=='no')
          {
           echo '<br><b style="color:red; font-size:20px;"><i>Lokasyon Eklenemedi</i></b>' ;
         }

         ?>
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