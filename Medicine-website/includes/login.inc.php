<?php

if (isset($_POST["submit"])) {

    $username = $_POST["email"];
    $pwd = $_POST["password"];

    require_once 'dbh.inc.php';
    require_once 'functions.inc.php';

    if (loginUser($conn, $username, $pwd)) {
        exit();
    }
}