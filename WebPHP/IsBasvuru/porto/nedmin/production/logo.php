<?php 

include 'header.php';

$ayarsor=$db->prepare("SELECT * FROM ayar where ayar_id=?");
$ayarsor->execute(array(0));
$ayarcek=$ayarsor->fetch(PDO::FETCH_ASSOC);
?>



<!-- page content -->
<div class="right_col" role="main">
  <div class="">
    <div class="page-title">


    </div>

    <div class="col-md-12">
      <div class="title_right">

      </div>
    </div>


    <div class="clearfix"></div>

    <div class="row">
      <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="col-md-12 col-sm-12 col-xs-12">
          <div class="x_panel">
            <div class="x_title">

              <div class="row">
                <div class="col-md-12 col-sm-12 col-xs-12">
                  <div class="x_panel">
                    <div class="x_title">
                      <h2>Logo Değiştirme</h2><br>


                      <div align="right" class="col-md-9">


                      </div>

                      <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                      <p>Yükleyeceğiniz resimi seçip veya sürükleyip brakabilirsiniz logo otomatik olarak değişecektir...</p>
                      
                      <b>Şuanki Logo</b><br>
                      <img  width="120" src="<?php echo "../../".$ayarcek['ayar_logo'] ?>" style="border: 2px solid black; padding: 5px; ">
                      <form action="logo-degistir.php" class="dropzone" >

                        <input type="hidden" name="makine_id" value="<?php echo $_GET['makine_id'];  ?>">
                        
                      </form>

                    </div>
                  </div>
                </div>
              </div>
            </div>

            <?php if ($_GET[islem]=='ok')
            {
              echo '<span style="color:green;"><i class="fa fa-check-circle fa-2x"></i></span><b style="color:green;font-size:20px;">  Güncelleme Başarılı..</b>';

            }
            elseif ($_GET[islem]=='no') 
            {
              echo '<span style="color:red;"><i class="fa fa-close fa-2x"></i></span><b style="color:red;font-size:20px;">  Güncelleme Başarısız..</b>';
            }?>

          </div>
        </div>
      </div>

    </div>
  </div>
</div>
</div>
<!-- /page content -->



<?php include 'footer.php'; ?>
