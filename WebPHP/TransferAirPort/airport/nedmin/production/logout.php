<?php
ob_start();
ob_clean();
session_start();
unset($_SESSION['adminadi']);

header("Location: admin-giris.php");
                                                  ?>
