<?php 
ob_start();
include '../netting/baglan.php';
include 'header.php';

$ayarsor=$db->prepare("SELECT *FROM ayar where ID=?");
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
            <h2 style="color:black;">Genel Ayarlar<small><b style="color:orange;"><?php 
            if ($_GET[islem]=='ok')
            {
              echo '<br><b style="color:green; font-size:14px;"><i class="fa fa-check-circle"></i> Güncelleme Başarılı..</b>' ;
            }
            if($_GET[islem]=='no')
            {
             echo '<br><b style="color:red; font-size:14px;"><i>GÜNCELLEME BAŞARILI DEĞİL</i></b>' ;
           }

           ?></b></small></h2>
           <ul class="nav navbar-right panel_toolbox">
            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
            </li>
            <li><a class="close-link"><i class="fa fa-close"></i></a>
            </li>
          </ul>
          <div class="clearfix"></div>
        </div>

        <div class="x_content">
          <b style="color:green;">Alt Menü Ayarları</b>
          <hr style="border:0.5px solid;color:black;">

          <form action="guncelle2.php" method="POST">
            <div class="row">
              <div class="col-sm-4">
               <b>Transfer Adı</b> <br>
               <input type="text" class="form-control" name="tadi" value="<?php echo $ayarcek['transferadi'] ?>">  
             </div>
             <div class="col-sm-8" align="center">
               <b>Açıklama</b> <br>
               <textarea name="taciklama" align="right" class="form-control" rows="3" ><?php echo $ayarcek['transferaciklama'] ?></textarea>
             </div>
           </div>
           <b style="color:green;">Alt Yazı  Ayarları </b>
           <hr style="border:0.5px solid;color:black;">

           <div class="row">
             <div class="col-sm-4">

              <b>Yazı 1</b> <br>
              <input type="text" class="form-control" name="y10" value="<?php echo $ayarcek['yazi10'] ?>">
              
            </div>
            <div class="col-sm-4">
             <b>Yazı 2</b>  <br>
             <input type="text"  class="form-control" name="y11" value="<?php echo $ayarcek['yazi11'] ?>">
           </div>
           <div class="col-sm-4">
            <b>Yazı 3</b> <br>
            <input type="text" class="form-control" name="y12" value="<?php echo $ayarcek['yazi12'] ?>">
          </div>
        </div><br>

        <b style="color:green;">İLETİŞİM AYARLARI </b>
        <hr style="border:0.5px solid;color:black;">

        <div class="row">
         <div class="col-sm-4">

          <b>GSM 1</b> <br>
          <input type="text" class="form-control" name="gsm1" value="<?php echo $ayarcek['gsm1'] ?>">

        </div>
        <div class="col-sm-4">
         <b>GSM 2</b>  <br>
         <input type="text"  class="form-control" name="gsm2" value="<?php echo $ayarcek['gsm2'] ?>">
       </div>
       <div class="col-sm-4">
        <b>MAİL</b> <br>
        <input type="text" class="form-control" name="mail" value="<?php echo $ayarcek['mail'] ?>">
      </div>
    </div><br>
    <b style="color:green;">ADRES AYARLARI</b>
    <hr style="border:0.5px solid;color:black;">
    <div class="row">
     <div class="col-sm-4">
       <b>ADRES</b> <br>
       <textarea class="form-control" name="adres"><?php echo $ayarcek['adres'] ?></textarea>  
     </div>
     <div class="col-sm-4">
       <b>İLÇE</b>  <br>
       <input type="text" class="form-control" name="ilce" value="<?php echo $ayarcek['ilce'] ?>">
     </div>
     <div class="col-sm-4">
      <b>İL</b><br>
      <input type="text" class="form-control" name="il" value="<?php echo $ayarcek['il'] ?>">
    </div>
  </div>
  <hr style="border:0.5px solid;color:black;">
  <div class="row">
    <div align="center" class="col-sm-12">    
      <input type="submit" name="guncelle2" value="GÜNCELLE" class="btn btn-success">
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