<?php 
ob_start();
include '../netting/baglan.php';
include 'header.php';
if (!isset($_SESSION['adminadi']))
{
 header("Location:admin-giris.php");
}

$ayarsor=$db->prepare("SELECT *FROM ayar where ayar_id=?");
$ayarsor->execute(array(0));
$ayarcek=$ayarsor->fetch(PDO::FETCH_ASSOC);
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
            <b style="color:green;">İÇERİK AYARLARI</b>
            <hr style="border:0.5px solid;color:black;">

            <form action="guncelle.php" method="POST">
              <div class="row">
                <div class="col-sm-4">
                 <b>SİTE BAŞLIK</b> <br>
                 <input type="text" class="form-control" name="baslik" value="<?php echo $ayarcek['ayar_title'] ?>">  
               </div>
               <div class="col-sm-8" align="center">
                 <b>AÇIKLAMA</b> <br>
                 <textarea name="aciklama" align="right" class="form-control" rows="3" ><?php echo $ayarcek['ayar_aciklama'] ?></textarea>
               </div>
             </div>
             <b style="color:green;">İLETİŞİM AYARLARI </b>
             <hr style="border:0.5px solid;color:black;">

             <div class="row">
               <div class="col-sm-4">

                <b>GSM 1</b> <br>
                <input type="text" class="form-control" name="gsm" value="<?php echo $ayarcek['ayar_gsm'] ?>">
                
              </div>
              <div class="col-sm-4">
               <b>GSM 2</b>  <br>
               <input type="text"  class="form-control" name="tel2" value="<?php echo $ayarcek['ayar_tel2'] ?>">
             </div>
             <div class="col-sm-4">
              <b>TELEFON</b> <br>
              <input type="text" class="form-control" name="tel" value="<?php echo $ayarcek['ayar_tel'] ?>">
            </div>
          </div><br>
          <div class="row"> 
            <div class="col-sm-4">
            </div>
            <div class="col-sm-4">
              <b>MAİL</b> <br>
              <input type="text" class="form-control" name="mail" value="<?php echo $ayarcek['ayar_mail'] ?>">
            </div>
          </div>
          <b style="color:green;">ADRES AYARLARI</b>
          <hr style="border:0.5px solid;color:black;">
          <div class="row">
           <div class="col-sm-4">
             <b>ADRES</b> <br>
             <textarea class="form-control" name="adres"><?php echo $ayarcek['ayar_adres'] ?></textarea>  
           </div>
           <div class="col-sm-4">
             <b>İLÇE</b>  <br>
             <input type="text" class="form-control" name="ilce" value="<?php echo $ayarcek['ayar_ilce'] ?>">
           </div>
           <div class="col-sm-4">
            <b>İL</b><br>
            <input type="text" class="form-control" name="il" value="<?php echo $ayarcek['ayar_il'] ?>">
          </div>
        </div>
        <hr style="border:0.5px solid;color:black;">
        <div class="row">
          <div align="center" class="col-sm-12">    
            <input type="submit" name="guncelle" value="GÜNCELLE" class="btn btn-success">
          </div>
        </div>
      </form>
      <?php 
      if ($_GET[islem]=='ok')
      {
        echo '<br><b style="color:green; font-size:20px;"><i>GÜNCELLEME BAŞARILI</i></b>' ;
      }
      if($_GET[islem]=='no')
      {
       echo '<br><b style="color:red; font-size:20px;"><i>GÜNCELLEME BAŞARILI DEĞİL</i></b>' ;
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