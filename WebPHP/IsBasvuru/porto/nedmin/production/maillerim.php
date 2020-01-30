<?php 

include 'header.php';
$mailsor=$db->prepare("SELECT *FROM mailler");
$mailsor->execute();
?>


<!-- page content -->
<div class="right_col" role="main">
  <div class="">

    <div class="clearfix"></div>
    <div class="row">
      <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
          <div class="x_title">
            <h2>Başvurular<small>

              <?php 

              if ($_GET['durum']=="ok") {?>

              <b style="color:green;">İşlem Başarılı...</b>

              <?php } elseif ($_GET['durum']=="no") {?>

              <b style="color:red;">İşlem Başarısız...</b>

              <?php }

              ?>


            </small></h2>

            <div class="clearfix"></div>
          </div>
          <div class="x_content">


            <!-- Div İçerik Başlangıç -->

            <table id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" width="100%">
              <thead>
                <tr>
                  <th>Mail NO</th>
                  <th>İsim</th>
                  <th>Eposta</th>
                  <th>Mesaj</th>
                  
                </tr>
              </thead>
              <tbody>
                <?php 
                while ($mailcek=$mailsor->fetch(PDO::FETCH_ASSOC)) {?>
                
                

                <tr>
                  <td><?php echo $mailcek['mail_id']; ?></td>
                  <td><?php echo $mailcek['mail_isim']; ?></td>
                  <td><?php echo $mailcek['mail_eposta']; ?></td>
                  <td><?php echo $mailcek['mail_mesaj']; ?></td>
                </tr>
                <?php } ?>
              </tbody>
            </table>

            <!-- Div İçerik Bitişi -->


          </div>
        </div>
      </div>
    </div>




  </div>
</div>
<!-- /page content -->

<?php include 'footer.php'; ?>
