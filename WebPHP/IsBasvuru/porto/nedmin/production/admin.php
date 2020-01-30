<?php 

include 'header.php'; 

?>
<?php 

$ayarsor=$db->prepare("SELECT * FROM ayarlar where ayar_id=?");
$ayarsor->execute(array(0));
$ayarcek=$ayarsor->fetch(PDO::FETCH_ASSOC);

?>

<!-- page content -->
<div class="right_col" role="main">
  <div class="">

    <div class="clearfix"></div>
    <div class="row">
      <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
          <div class="x_title">
            <h2><b style="color:black; text-align: center; "> Admin Ekle</b><small>
            </small></h2>

            <div class="clearfix"></div>
          </div>
          <div class="x_content">


            <!-- Div İçerik Başlangıç -->
            <form action="admin-ekle.php" method="post">
              <div class="row">
                <div class="col-sm-5"></div>
                <div class="col-sm-2">
                 <div class="form-group" >
                  <input type="text" name="kadi" class="form-control"  placeholder="Kullanıcı Adı"><br>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-5"></div>
              <div class="col-sm-2">
                 <div class="form-group" >
                  <input type="password" name="sifre" class="form-control"  placeholder="Şifre"><br>
                </div>
              </div>
            </div>
             <div class="row">
              <div class="col-sm-5"></div>
              <div class="col-sm-2">
                 <div class="form-group" >
                  <input type="text" name="adi" class="form-control"  placeholder="Admin Adı"><br>
                </div>
              </div>
            </div>         
            <div class="col-sm-12 text-center">
              <div class="form-group">
                <input class="btn btn-success" type="submit" name="kaydet" value="Admin Ekle">
              </div>
            </div>
          </form>
          <?php if ($_GET[islem]=='ok')
          {
            echo '<span style="color:green;"><i class="fa fa-check-circle fa-2x"></i></span><b style="color:green;font-size:20px;">  Admin Eklendi..</b>';

          }
          elseif ($_GET[islem]=='no') 
          {
            echo '<span style="color:red;"><i class="fa fa-close fa-2x"></i></span><b style="color:red;font-size:20px;">  Admin ekleme Başarısız..</b>';
          }


          ?>
          <!-- Div İçerik Bitişi -->


        </div>
      </div>
    </div>
  </div>




</div>
</div>
<!-- /page content -->

<?php include 'footer.php'; ?>
