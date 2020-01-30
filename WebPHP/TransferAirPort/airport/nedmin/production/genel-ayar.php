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
          <b style="color:green;">Üst Menü</b>
          <hr style="border:0.5px solid;color:black;">

          <form action="guncelle.php" method="POST" enctype="multipart/form-data">
            <div class="row">
              <div class="col-sm-4">
               <b>Menü 1</b> <br>
               <input type="text" class="form-control" name="m1" value="<?php echo $ayarcek['menu1']; ?>">  
             </div>
             <div class="col-sm-4" align="center">
               <b>Menü 2</b> <br>
               <input  type="text" name="m2" align="right" class="form-control" rows="3" value="<?php echo $ayarcek['menu2']; ?>" >
             </div>
             <div class="col-sm-4">
               <b>Menü 3</b> <br>
               <input type="text" class="form-control" name="m3" value="<?php echo $ayarcek['menu3']; ?>" >  
             </div>
             <div class="col-sm-2">

             </div>
             <div class="col-sm-4">
               <b>Menü 4</b> <br>
               <input type="text" class="form-control" name="m4" value="<?php echo $ayarcek['menu4']; ?>">  
             </div>
             <div class="col-sm-4">
               <b>Menü 5</b> <br>
               <input type="text" class="form-control" name="m5" value="<?php echo $ayarcek['menu5']; ?>" >  
             </div>


           </div>
         </div>
         <b style="color:green;">Anasayfa Yazı Ayarları </b>
         <hr style="border:0.5px solid;color:black;">

         <div class="row">
           <div class="col-sm-6">

            <b>Yazı 1</b> <br>
            <input type="text" class="form-control" name="y1" value="<?php echo $ayarcek['yazi1']; ?>">

          </div>
          <div class="col-sm-6">
           <b>Yazı 2</b>  <br>
           <input type="text"  class="form-control" name="y2" value="<?php echo $ayarcek['yazi2']; ?>">
         </div>
         <div class="col-sm-6">

          <b>Yazı 3</b> <br>
          <input type="text" class="form-control" name="ayazi1" value="<?php echo $ayarcek['a_yazi1']; ?>">

        </div>
        <div class="col-sm-6">

          <b>Yazı 4</b> <br>
          <input type="text" class="form-control" name="ayazi2" value="<?php echo $ayarcek['a_yazi2']; ?>">

        </div>
      </div><br>
      <b style="color:green;">Services Ayarları</b>
      <hr style="border:0.5px solid;color:black;">
      <div class="row">
       <div class="col-sm-6">
        <b>Başlık 1 / Yazı 1</b> <br>
        <input type="text" class="form-control" name="b1" value="<?php echo $ayarcek['baslik1']; ?>">
        <textarea name="y3" align="right" class="form-control" rows="4" ><?php echo $ayarcek['yazi3']; ?> </textarea>
      </div>
      <div class="col-sm-6">
        <b>Başlık 2 / Yazı 2</b> <br>
        <input type="text" class="form-control" name="b2" value="<?php echo $ayarcek['baslik2']; ?>">
        <textarea name="y4" align="right" class="form-control" rows="4"><?php echo $ayarcek['yazi4']; ?></textarea>
      </div>
      <div class="col-sm-6">
        <b>Başlık 3 / Yazı 3</b> <br>
        <input type="text" class="form-control" name="b3" value="<?php echo $ayarcek['baslik3']; ?>">
        <textarea name="y5" align="right" class="form-control" rows="4"><?php echo $ayarcek['yazi5']; ?></textarea>
      </div>
      <div class="col-sm-6">
        <b>Başlık 4 / Yazı 4</b> <br>
        <input type="text" class="form-control" name="b4" value="<?php echo $ayarcek['baslik4']; ?>">
        <textarea name="y6" align="right" class="form-control" rows="4"><?php echo $ayarcek['yazi6']; ?></textarea>
      </div>
      <div class="col-sm-6">
        <b>Başlık 5 / Yazı 5</b> <br>
        <input type="text" class="form-control" name="b5" value="<?php echo $ayarcek['baslik5']; ?>">
        <textarea name="y7" align="right" class="form-control" rows="4"><?php echo $ayarcek['yazi7']; ?></textarea>
      </div>
      <div class="col-sm-6">
        <b>Başlık 6 / Yazı 6</b> <br>
        <input type="text" class="form-control" name="b6" value="<?php echo $ayarcek['baslik6']; ?>">
        <textarea name="y8" align="right" class="form-control" rows="4"><?php echo $ayarcek['yazi8']; ?></textarea>
      </div>

    </div><br>
    <b style="color:green;">Transfer Ayarları</b>
    <hr style="border:0.5px solid;color:black;">
    <div class="row">
     <div class="col-sm-6">
      <b>Transfer Adı 1 / Transfer Açıklaması 1</b> <br>
      <input type="text" class="form-control" name="baslik3" value="<?php echo $ayarcek['a_baslik3']; ?>">
      <textarea name="yazi3" align="right" class="form-control" rows="4" ><?php echo $ayarcek['a_yazi3']; ?> </textarea>
    </div>
    <div class="col-sm-6">
      <b>Transfer Adı 2 / Transfer Açıklaması 2</b> <br>
      <input type="text" class="form-control" name="baslik4" value="<?php echo $ayarcek['a_baslik4']; ?>">
      <textarea name="yazi4" align="right" class="form-control" rows="4"><?php echo $ayarcek['a_yazi4']; ?></textarea>
    </div>
    <div class="col-sm-6">
      <b>Transfer Adı 3 / Transfer Açıklaması 3</b> <br>
      <input type="text" class="form-control" name="baslik5" value="<?php echo $ayarcek['a_baslik5']; ?>">
      <textarea name="yazi5" align="right" class="form-control" rows="4"><?php echo $ayarcek['a_yazi5']; ?></textarea>
    </div>
    <div class="col-sm-6">
      <b>Transfer Adı 4 / Transfer Açıklaması 4</b> <br>
      <input type="text" class="form-control" name="baslik6" value="<?php echo $ayarcek['a_baslik6']; ?>">
      <textarea name="yazi6" align="right" class="form-control" rows="4"><?php echo $ayarcek['a_yazi6']; ?></textarea>
    </div>

  </div><br>
  <hr style="border:0.5px solid;color:black;">
  <div class="row">
    <div align="center" class="col-sm-12">    
      <input type="submit" name="guncelle1" value="GÜNCELLE" class="btn btn-success">
    </div>
  </div>
</form>

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