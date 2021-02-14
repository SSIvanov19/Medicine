<?php

function emptyInputSignup($name, $email, $username, $pwd, $pwdRepeat) {
    $result = false;
    if (empty($name) || empty($email) || empty($username) || empty($pwd) || empty($pwdRepeat)) {
        $result = true;
    }
    return $result;
}

function invalidUid($username) {
    $result = false;
    if (!preg_match("/^[a-zA-Z0-9]*$/", $username)) {
        $result = true;
    }
    return $result;
}

function invalidEmail($email) {
    $result = false;
    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $result = true;
    }
    return $result;
}

function pwdMatch($pwd, $pwdRepeat) {
    $result = false;
    if ($pwd !== $pwdRepeat) {
        $result = true;
    }
    return $result;
}

function uidExists($conn, $email) {
    $sql = "SELECT * FROM users WHERE OR email = ?;";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $sql)) {
        return false;
    }
    mysqli_stmt_bind_param($stmt, "s", $email);
    mysqli_stmt_execute($stmt);
    $result = mysqli_fetch_assoc(mysqli_stmt_get_result($stmt));
    mysqli_stmt_close($stmt);
    return $result;
}

function createUser($conn, $name, $email, $username, $password) {
    global $error;
    $sql = "INSERT INTO users (name, email, id, password) VALUES (?, ?, ?, ?);";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $sql)) {
        header("location: ../signup.php?error=stmtfailed");
        exit();
    }

    $hashedPassword = password_hash($password, PASSWORD_DEFAULT);

    mysqli_stmt_bind_param($stmt, "ssss", $name, $email, $username, $hashedPassword);
    if (mysqli_stmt_execute($stmt)) {
        $error = 'unableToCreateUser';
    }
    mysqli_stmt_close($stmt);
}

function emptyInputLogin($username, $password) {
    $result = false;
    if (empty($username) || empty($password)) {
        $result = true;
    }
    return $result;
}

function loginUser($conn, $email, $password): bool {
    global $error;

    $passwordHashed = password_hash($password, PASSWORD_DEFAULT);
    $sql = "SELECT * FROM users WHERE email = ? AND password = ?;";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $sql)) {
        $error = 'sqlerror';
        return false;
    }
    mysqli_stmt_bind_param($stmt, "ss", $email, $passwordHashed);
    mysqli_stmt_execute($stmt);
    $user = mysqli_fetch_assoc(mysqli_stmt_get_result($stmt));
    mysqli_stmt_close($stmt);

    if ($user === false) {
        $error = 'wronglogin';
        return false;
    }

    session_start();
    $_SESSIONS["userId"] = $user['id'];
    header("location: ./index.php");
    return true;
}