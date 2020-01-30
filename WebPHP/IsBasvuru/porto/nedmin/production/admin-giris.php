<?php
ob_start();
session_start();
include '../netting/baglan.php';
?>
<!DOCTYPE html>
<html lang="en">
<head>
  <?php
  if (isset($_SESSION['adminadi']))
  {
   header("Location:index.php");
  }

 ?>
 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
 <!-- Meta, title, CSS, favicons, etc. -->
 <meta charset="utf-8">
 <meta http-equiv="X-UA-Compatible" content="IE=edge">
 <meta name="viewport" content="width=device-width, initial-scale=1">

 <title>Admin Panele | Hoş Geldiniz. </title>

 <!-- Bootstrap -->
 <link href="../vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
 <!-- Font Awesome -->
 <link href="../vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
 <!-- NProgress -->
 <link href="../vendors/nprogress/nprogress.css" rel="stylesheet">
 <!-- Animate.css -->
 <link href="../vendors/animate.css/animate.min.css" rel="stylesheet">

 <!-- Custom Theme Style -->
 <link href="../build/css/custom.min.css" rel="stylesheet">
</head>

<body class="login">

  <div class="login_wrapper">

    <section class="login_content">
      <form action="" method="post">
        <h1>Admin Girişi</h1>
        <div>
          <input type="text" class="form-control" placeholder="Kullanıcı Adı" required="" name="kadi" />
        </div>
        <div>
          <input type="password" class="form-control" placeholder="Şifre" required="" name="sifre" />
        </div>
        <div style="margin-left: 100px;">
          <input type="submit" class="btn btn-primary text-center" value="Giriş Yap" name="giris" />
        </div>
        <br>

        <div><br>
          <br><h1><i class="fa fa-cogs"></i>  -   İş Makineniz Admin Paneli Girişi</h1>
          <p>©2018 All Rights Reserved. B&B Developers.<br> Privacy and Terms</p>
        </div>

      </form>
    </section>
  </div>
</div>

<?php if (isset($_POST['giris'])){
  $kullaniciAdi = @$_POST['kadi'];
  $sifre  = md5(@$_POST['sifre']);
  if (empty($kullaniciAdi) || empty($sifre)) {   


  }
  else{

    $uyegiris = $db->prepare("SELECT * FROM adminler WHERE kadi=? AND sifre=? ");
    $uyegiris->execute(array($kullaniciAdi,$sifre));
    $say=$uyegiris->rowCount();

    if($say==1){


      $uyegiriscek=$uyegiris->fetch(PDO::FETCH_ASSOC);
      $adminIdsi = $uyegiriscek['ID'];
      $adminAdi = $uyegiriscek['admin_adi'];

      $_SESSION["adminid"] = $adminIdsi;
      $_SESSION['adminadi'] = $adminAdi;

      header("Location:index.php");
  //  echo "yönlendiriliyor..";


    }

    else{

      echo '<div class="alert alert-danger" role="alert" style="text-align:center;">
     <span><i class="fa fa-user-times fa-2x"></i></span>
     Kullanıcı Adı Veya Şifre Yanlış. !
     </div>';
     

   }
 }
} ?>

</body>
</html>
