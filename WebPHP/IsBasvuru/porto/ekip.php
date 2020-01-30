<?php include 'header.php'; 
$deneme=$_POST['tarih'];
$basvurusor=$db->prepare("SELECT *FROM rezervasyonlar where rezervasyon_tarih='".$deneme."'");
$basvurusor->execute();
?>

<div class="container">
  <div class="row pt-xl">
   <div class="col-md-7">
    <form  action="" method="POST" style="position: center;">
     <div class="row">
      <div class="form-group">
       <div class="col-md-7">
        <input type="date" placeholder="tarih" value="<?php 
          if($_POST['ara'])
          {
            echo $_POST['tarih'];
          }
          else
          {
           echo @date("Y-m-d");
          }
        ?>" name="tarih" id="telefon" maxlength="11" class="form-control input-lg">

      </div>
      <input type="submit" name="ara" value="Rezervasyon Ara" class="btn btn-primary">
    </div>
  </div>
  <div class="row">
    <div class="form-group">
     <div class="col-md-7">
      <input type="text" placeholder="Adınız Soyadınız" value="<?php 
          if($_POST['ara'])
          {
            echo $_POST['adsoyad'];
          }
          else
          {
           echo"";
          }
        ?>" maxlength="100" class="form-control input-lg" name="adsoyad" id="adsoyad">
    </div>
  </div>
</div>
<div class="row">
 <div class="form-group">
   <div class="col-md-7">
    <input type="phone" placeholder="Cep telefonu" value="" name="telefon" maxlength="15" class="form-control input-lg">
  </div>
</div>
</div>


<table id="datatable" class="table table-striped table-bordered">
  <thead>
    <tr>
      <th>Saat</th>
      <th>Takım İsim</th>
      <th>Durum</th>
    </tr>
  </thead>


  <tbody>
    <?php
    if (isset($_POST['ara'])) {
      # code...
   

    while ($basvurucek=$basvurusor->fetch(PDO::FETCH_ASSOC)) {?>



      <tr>
        <?php 
        $saat7=$basvurucek['7-8'];
       $saat8=$basvurucek['8-9'];
       $saat9=$basvurucek['9-10'];
       $saat10=$basvurucek['10-11'];
       $saat11=$basvurucek['11-12'];
       $saat12=$basvurucek['12-1'];
       $saat1=$basvurucek['1-2']; ?>
        <td>07:00 - 08:00</td>
        <td><?php 
          if($saat7==1)
          {
            echo $basvurucek['rezervasyon_takim'];
          }
          else
          {
            echo 'BOŞ';
          }

         ?></td>
        <td><?php
       
          if($saat7==1)
          {
            echo '<input type="submit" value="Dolu" class="btn btn-danger">';
          }
          else
          {
            echo '<input type="submit" value="Boş" class="btn btn-success">&emsp;';
            echo '<input type="submit" name="btn7" value="Rezervasyon Yap" class="btn btn-success">';
          }

         ?></td>
      </tr>

      <tr>
        <td>08:00 - 09:00</td>
        <td><?php 
          if($saat8==1)
          {
            echo $basvurucek['rezervasyon_takim'];
          }
          else
          {
            echo 'BOŞ';
          }

         ?></td>
        <td><?php
       
          if($saat8==1)
          {
            echo '<input type="submit" value="Dolu" class="btn btn-danger">';
          }
          else
          {
            echo '<input type="submit" value="Boş" class="btn btn-success">&emsp;';
            echo '<input type="submit" name="btn8" value="Rezervasyon Yap" class="btn btn-success">';
          }

         ?></td>
      </tr>
      <tr>
        <td>09:00 - 10:00</td>
        <td><?php 
          if($saat9==1)
          {
            echo $basvurucek['rezervasyon_takim'];
          }
          else
          {
            echo 'BOŞ';
          }

         ?></td>
        <td><?php
       
          if($saat9==1)
          {
            echo '<input type="submit" value="Dolu" class="btn btn-danger">';
          }
          else
          {
            echo '<input type="submit" value="Boş" class="btn btn-success">&emsp;';
            echo '<input type="submit"name="btn9" value="Rezervasyon Yap" class="btn btn-success">';
          }

         ?></td>
      </tr>
      <tr>
        <td>10:00 - 11:00</td>
        <td><?php 
          if($saat10==1)
          {
            echo $basvurucek['rezervasyon_takim'];
          }
          else
          {
            echo 'BOŞ';
          }

         ?></td>
        <td><?php
       
          if($saat10==1)
          {
            echo '<input type="submit" value="Dolu" class="btn btn-danger">';
          }
          else
          {
            echo '<input type="submit" value="Boş" class="btn btn-success">&emsp;';
            echo '<input type="submit" name="btn10" value="Rezervasyon Yap" class="btn btn-success">';
          }

         ?></td>
      </tr>
      <tr>
        <td>11:00 - 12:00</td>
        <td><?php 
          if($saat11==1)
          {
            echo $basvurucek['rezervasyon_takim'];
          }
          else
          {
            echo 'BOŞ';
          }

         ?></td>
        <td><?php
       
          if($saat11==1)
          {
            echo '<input type="submit" value="Dolu" class="btn btn-danger">';
          }
          else
          {
            echo '<input type="submit" value="Boş" class="btn btn-success">&emsp;';
            echo '<input type="submit"name="btn11" value="Rezervasyon Yap" class="btn btn-success">';
          }

         ?></td>
      </tr>
      <tr>
        <td>12:00 - 01:00</td>
        <td><?php 
          if($saat12==1)
          {
            echo $basvurucek['rezervasyon_takim'];
          }
          else
          {
            echo 'BOŞ';
          }

         ?></td>
        <td><?php
       
          if($saat12==1)
          {
            echo '<input type="submit" value="Dolu" class="btn btn-danger">';
          }
          else
          {
            echo '<input type="submit" value="Boş" class="btn btn-success">&emsp;';
            echo '<input type="submit" name="btn12" value="Rezervasyon Yap" class="btn btn-success">';
          }

         ?></td>
         <tr>
        <td>01:00 - 02:00</td>
        <td><?php 
          if($saat1==1)
          {
            echo $basvurucek['rezervasyon_takim'];
          }
          else
          {
            echo 'BOŞ';
          }

         ?></td>
        <td><?php
       
          if($saat1==1)
          {
            echo '<input type="submit" value="Dolu" class="btn btn-danger">';
          }
          else
          {
            echo '<input type="submit" value="Boş" class="btn btn-success">&emsp;';
            echo '<input type="submit" name="btn1" value="Rezervasyon Yap" class="btn btn-success">';
          }

         ?></td>
      </tr>
      </tr>
    <?php } } ?>
</tbody>
</table>
</form>

<?php

  if (isset($_POST['btn7'])) 
  {
    $ayarkaydet=$db->exec("UPDATE `rezervasyonlar` SET `7-8` = '1',`rezervasyon_takim` = '".$_POST['adsoyad']."',`telefon` = '".$_POST['telefon']."' WHERE `rezervasyonlar`.`rezervasyon_tarih` = '".$_POST['tarih']."'");
  }
  if (isset($_POST['btn8'])) 
  {
    $ayarkaydet=$db->exec("UPDATE `rezervasyonlar` SET `8-9` = '1',`rezervasyon_takim` = '".$_POST['adsoyad']."',`telefon` = '".$_POST['telefon']."' WHERE `rezervasyonlar`.`rezervasyon_tarih` = '".$_POST['tarih']."'");
  }
  if (isset($_POST['btn9'])) 
  {
    $ayarkaydet=$db->exec("UPDATE `rezervasyonlar` SET `9-10` = '1',`rezervasyon_takim` = '".$_POST['adsoyad']."',`telefon` = '".$_POST['telefon']."' WHERE `rezervasyonlar`.`rezervasyon_tarih` = '".$_POST['tarih']."'");
  }
  if (isset($_POST['btn10'])) 
  {
    $ayarkaydet=$db->exec("UPDATE `rezervasyonlar` SET `10-11` = '1',`rezervasyon_takim` = '".$_POST['adsoyad']."',`telefon` = '".$_POST['telefon']."' WHERE `rezervasyonlar`.`rezervasyon_tarih` = '".$_POST['tarih']."'");
  }
  if (isset($_POST['btn11'])) 
  {
    $ayarkaydet=$db->exec("UPDATE `rezervasyonlar` SET `11-12` = '1',`rezervasyon_takim` = '".$_POST['adsoyad']."',`telefon` = '".$_POST['telefon']."' WHERE `rezervasyonlar`.`rezervasyon_tarih` = '".$_POST['tarih']."'");
  }
  if (isset($_POST['btn12'])) 
  {
    $ayarkaydet=$db->exec("UPDATE `rezervasyonlar` SET `12-1` = '1',`rezervasyon_takim` = '".$_POST['adsoyad']."',`telefon` = '".$_POST['telefon']."' WHERE `rezervasyonlar`.`rezervasyon_tarih` = '".$_POST['tarih']."'");
  }
   if (isset($_POST['btn1'])) 
  {
    $ayarkaydet=$db->exec("UPDATE `rezervasyonlar` SET `1-2` = '1',`rezervasyon_takim` = '".$_POST['adsoyad']."',`telefon` = '".$_POST['telefon']."' WHERE `rezervasyonlar`.`rezervasyon_tarih` = '".$_POST['tarih']."'");
  }
 ?>

</div>
</div>
</div>

<?php include 'footer.php'; ?>