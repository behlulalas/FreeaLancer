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
            <h2 style="color:black;">Sayfa İçerik Ayarları<small><b style="color:orange;">İÇERİK DEĞİŞTİR</b></small></h2>
            <ul class="nav navbar-right panel_toolbox">
              <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
              </li>
              <li><a class="close-link"><i class="fa fa-close"></i></a>
              </li>
            </ul>
            <div class="clearfix"></div>
          </div>

          <div class="x_content">
            <b style="color:green;">ANASAYFA AYARLARI</b>
            <hr style="border:0.5px solid;color:black;">

            <form action="sayfaguncelle.php" method="POST">
              <div class="row">
                <div class="col-sm-6" align="center">
                 <b>Biz Kimiz</b> <br>
                 <textarea name="kimiz" align="right" class="form-control" rows="3" ><?php echo $ayarcek['bizkimiz'] ?></textarea>
               </div>
               <div class="col-sm-6" align="center">
                 <b>Kuruluş Amacı</b> <br>
                 <textarea name="amacımız" align="right" class="form-control" rows="3" ><?php echo $ayarcek['kurulus_amac'] ?></textarea>
               </div>
             </div>
             <br>
             <b style="color:green;">ÇALIŞMA EKİBİ AYARLARI </b>
             <hr style="border:0.5px solid;color:black;"> 

             <div class="row">
               <div class="col-sm-6" align="center">
                 <b>Yönetici 1</b><br>  
                 <input type="text" class="form-control" name="ekipe" value="<?php echo $ayarcek['ekip1'] ?>">
               </div>

               <div class="col-sm-6" align="center">
                <b>Yönetici 2</b><br>
                <input type="text" class="form-control" name="ekipk" value="<?php echo $ayarcek['ekip2'] ?>">
              </div>    
              <div class="col-sm-6" align="center">
               <b>Pozisyon </b><br>  
               <input type="text" class="form-control" name="meslek" value="<?php echo $ayarcek['meslek'] ?>">
             </div>
             <div class="col-sm-6" align="center">
               <b>Pozisyon</b><br>  
               <input type="text" class="form-control" name="meslek1" value="<?php echo $ayarcek['meslek1'] ?>">
             </div>      
           </div>
           <hr style="border:0.5px solid;color:black;">
           <b style="color:green;">HAKKIMIZDA AYARLARI </b>
           <hr style="border:0.5px solid;color:black;"> 
           <div class="row">
               <div class="col-sm-6" align="center">
                 <b>Bilgi 1</b><br>  
                <textarea name="bilgi1" align="right" class="form-control" rows="3" ><?php echo $ayarcek['bilgi_1'] ?></textarea>
               </div>
               <div class="col-sm-6" align="center">
                <b>Bilgi 2</b><br>
                <textarea name="bilgi2" align="right" class="form-control" rows="3" ><?php echo $ayarcek['bilgi_2'] ?></textarea>
              </div>    
              <div class="col-sm-6" align="center">
               <b>Bilgi 3 </b><br>  
              <textarea name="bilgi3" align="right" class="form-control" rows="3" ><?php echo $ayarcek['bilgi_3'] ?></textarea>
             </div>
             <div class="col-sm-6" align="center">
               <b>Bilgi 4</b><br>  
               <textarea name="bilgi4" align="right" class="form-control" rows="3" ><?php echo $ayarcek['bilgi_4'] ?></textarea>
             </div>      
           </div>

          <hr style="border:0.5px solid;color:black;"> 

          <div class="row">
            <div align="center" class="col-sm-12">    
              <input type="submit" name="guncelle33" value="GÜNCELLE" class="btn btn-success">
            </div>
          </div>
        </form>
        <?php 
        if ($_GET[islem1]=='ok')
        {
          echo '<br><b style="color:green; font-size:20px;"><i>GÜNCELLEME BAŞARILI</i></b>' ;
        }
        if($_GET[islem1]=='no')
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