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
    <h2>Renk Değiştirme Sayfası</h2>
    <small> </small>
    <!-- form color picker -->
    <div class="col-md-3"></div>
    <div class="col-md-6 col-sm-12 col-xs-12">
      <div class="x_panel">
        <div class="x_title">
          <h2>Renk Ayarları</h2>
          <ul class="nav navbar-right panel_toolbox">
            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
            </li>
            <li class="dropdown">
              <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>

            </li>
            <li><a class="close-link"><i class="fa fa-close"></i></a>
            </li>
          </ul>
          <div class="clearfix"></div>
        </div>
        <div class="x_content">
          <br />
          <form class="form-horizontal form-label-left" action="renkguncelle.php" method="POST">


            <div class="form-group">
              <label class="control-label col-md-3 col-sm-3 col-xs-12">Renk Seç</label>
              <div class="col-md-9 col-sm-9 col-xs-12">
                <div class="input-group demo2">
                  <input type="text" name="renk" value="<?php echo$ayarcek['renkkodu']; ?>" class="form-control" />
                  <span class="input-group-addon"><i></i></span>
                </div>
              </div>
            </div>
            <div class="form-group">
              <center><input type="submit" name="degistir" value="Güncelle" class="btn btn-success"></center>
              <div class="col-md-9 col-sm-9 col-xs-12">
                <div class="input-group demo2">


                </div>
              </div>
            </div>
            <div class="form-group">

              <div class="col-md-9 col-sm-9 col-xs-12">
                <div class="input-group demo2">


                </div>
              </div>
            </div>
            <div class="form-group">
              <center><?php 
              if ($_GET[islem]=='ok')
              {
                echo '<span style="color:green;"><i class="fa fa-check-circle fa-2x"></i></span><b style="color:green;font-size:20px;"> Renk Değiştirildi..</b>';
              }
              if($_GET[islem]=='no')
              {
               echo '<br><b style="color:red; font-size:20px;"><i>GÜNCELLEME BAŞARILI DEĞİL</i></b>' ;
             }

             ?></center>
             <div class="col-md-9 col-sm-9 col-xs-12">
              <div class="input-group demo2">


              </div>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
  <!-- /form color picker -->
</div>
</div>


<!-- /page content -->

<!-- footer content -->
<?php include 'footer.php'; ?>