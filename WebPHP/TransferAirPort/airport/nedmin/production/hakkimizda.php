<?php 
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

      </div>

      <div class="title_right">
        <div class="col-md-5 col-sm-5 col-xs-12 form-group pull-right top_search">

        </div>
      </div>
    </div>

    <div class="clearfix"></div>
    <h2>Hakkımızda Ayarları</h2>
    <small> <?php 
    if ($_GET[islem]=='ok')
    {
      echo '<br><b style="color:green; font-size:14px;"><i class="fa fa-check-circle"></i> Güncelleme Başarılı..</b>' ;
    }
    if($_GET[islem]=='no')
    {
     echo '<br><b style="color:red; font-size:14px;"><i>GÜNCELLEME BAŞARILI DEĞİL</i></b>' ;
   }

   ?></small>
   <div class="row">
    <div class="col-md-12 col-sm-12 col-xs-12">
      <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="col-sm-12" align="center">
          <b>Hakkımızda</b> <br>
          <form action="hguncelle.php" method="POST">
            <textarea rows="10" class="form-control" name="hakkimizda"><?php echo $ayarcek['hakkimizda']; ?></textarea> <br><br>
            <input type="submit" name="guncelle44" value="Güncelle" class="btn btn-success">
          </form>
        </div>
      </div>
    </div>
  </div>
</div>
</div>


<!-- /page content -->

<!-- footer content -->
<?php include 'footer.php'; ?>