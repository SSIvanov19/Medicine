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
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">
    <link href="assets/vendor/aos/aos.css" rel="stylesheet">
    <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
    <link href="assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
    <link href="assets/vendor/glightbox/css/glightbox.min.css" rel="stylesheet">
    <link href="assets/vendor/swiper/swiper-bundle.min.css" rel="stylesheet">
    <link href="assets/css/style.css" rel="stylesheet">
    <script src="js/ie-emulation-modes-warning.js"></script>
</head>
<body>


<navbar class="navbar navbar-expand-md fixed-top navbar-light font-weight-bold">
    <div class="container-fluid">
        <a class="navbar-brand" href="index.php">
            <img class="logo horizontal-logo" src="img/logo.png" alt="logo">
            Лекарствомат
        </a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item">
                    <a class="nav-link" href="index.php">Начало</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="project.php">За Проекта</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown3" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Как работи
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdown3">
                        <a class="dropdown-item" href="recipes.php">Рецептата</a>
                        <div class="dropdown-divider"></div>
                        <a class="dropdown-item" href="mashines.php">Машината</a>
                    </div>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="login.php">Вход</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="signup.php">Регистрация</a>
                </li>
            </ul>
        </div>
    </div>
</navbar>
