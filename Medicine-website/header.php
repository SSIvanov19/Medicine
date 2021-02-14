<?php
    session_start();
?>

<!DOCTYPE html>
<html lang=en>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="Website for NOIT">
    <meta name="keywords" content="HTML, CSS, JS, PHP, SQL">
    <meta name="author" content="Stas Uzunov and Stoyan Ivanov">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0"/>
    <meta name="theme-color" content="#ffffff">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Home | Medicine</title>
    <link rel="stylesheet" href="css/style.css">
    <link href="css/bootstrap.min.3.4.1.css" rel="stylesheet">
    <link href="css/ie10-viewport-bug-workaround.css" rel="stylesheet">
    <link href="css/navbar.css" rel="stylesheet">
    <script src="js/ie-emulation-modes-warning.js"></script>
</head>
<body>

<header>
    <div class="container">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar"
                            aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Лекарствомат</a>
                </div>
                <div id="navbar" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li ><a href="#">Начало</a></li>
                        <li ><a href="#">За Проекта</a></li>
                        <li ><a href="#">Как работи</a></li>
                        <li><a href="#">Контакти</a></li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <?php
                            if (isset($_SESSION["useruid"])) {
                                echo "<li><a href='profile.php'>Профилна страница</a></li>";
                                echo "<li><a href='includes/logout.inc.php'>Излизане</a></li>";
                            } else {
                                echo "<li><a href='login.php'>Вход</a></li>";
                                echo "<li><a href='signup.php'>Регистрация</a></li>";
                            }
                        ?>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
</header>