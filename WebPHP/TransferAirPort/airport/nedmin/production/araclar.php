<?php 

include 'header.php';
$basvurusor=$db->prepare("SELECT *FROM arac");
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
            <h2>Araçlarımız<small>

              <?php 

              if ($_GET['islem']=="ok") {?>

                <b style="color:green;"><i class="fa fa-check-circle"></i> Silme Başarılı...</b>

              <?php } elseif ($_GET['islem']=="no") {?>

                <b style="color:red;">Silme Başarısız...</b>

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
                  <th>Araç Adı</th>
                  <th>Araç Açıklama</th>
                  <th>Araç Resim</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                <?php 
                while ($basvurucek=$basvurusor->fetch(PDO::FETCH_ASSOC)) {?>



                  <tr>
                    <td><?php echo $basvurucek['ID']; ?></td>
                    <td><?php echo $basvurucek['aracadi']; ?></td>
                    <td><?php echo $basvurucek['araacaciklama']; ?></td>
                    <td><img width="100" src="<?php echo $basvurucek['resim_yol1']; ?>"></td>
                    <td><a href="arac_sil.php?arac_id=<?php echo $basvurucek['ID']; ?>&sil=ok"><input type="submit" name="sil" class="btn btn-danger" value="Sil"></a></td>
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
