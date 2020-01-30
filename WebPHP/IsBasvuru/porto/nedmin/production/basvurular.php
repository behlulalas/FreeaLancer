<?php 

include 'header.php';
$basvurusor=$db->prepare("SELECT *FROM basvurular");
$basvurusor->execute();
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
                	<th style="width:40px;">No</th>
                  <th>Adı</th>
                  <th>Yaş</th>
                  <th>Cinsiyet</th>
                  <th>Telefon</th>
                  <th>Email</th>
                </tr>
              </thead>
              <tbody>
                <?php 
                while ($basvurucek=$basvurusor->fetch(PDO::FETCH_ASSOC)) {?>
                
                

                <tr>
                  <td><?php echo $basvurucek['basvuru_id']; ?></td>
                  <td><?php echo $basvurucek['ad_soyad']; ?></td>
                  <td><?php echo $basvurucek['yas']; ?></td>
                  <td><?php echo $basvurucek['cinsiyet']; ?></td>
                  <td><?php echo $basvurucek['basvur_tel']; ?></td>
                  <td><?php echo $basvurucek['basvur_mail']; ?></td>
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
