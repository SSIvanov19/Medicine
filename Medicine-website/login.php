<?php
$error = '';

include_once './includes/login.inc.php';

include_once 'header.php';
?>
<head>
    <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">
    <link rel="stylesheet" href="css/login.css">
</head>
<section class="sign-in">
    <div class="container">
        <div class="signin-content">
            <div class="signin-image">
                <figure><img src="img/login-image.jpg" alt="sing up image"></figure>
                <a href="#" class="signup-image-link">Създаване на акаунт</a>
            </div>
            <div class="signup-form">
                <h2 class="form-title">Влизане</h2>
                <form method="POST" class="register-form" id="login-form" action="includes/login.inc.php">
                    <div class="form-group">
                        <label for="your_name"><i class="zmdi zmdi-account material-icons-name"></i></label>
                        <input type="text" name="email" placeholder="Имейл">
                    </div>
                    <div class="form-group">
                        <label for="your_pass"><i class="zmdi zmdi-lock"></i></label>
                        <input type="password" name="password" placeholder="Парола">
                    </div>
                    <div class="form-group form-button">
                        <input type="submit" name="signin" id="signin" class="form-submit" value="Влизане"/>
                    </div>
                </form>
            </div>
    <?php
    if ($error) {
        switch ($error) {
            case 'wronglogin':
    ?>
    <p class="error">Неправилна информация за вход!</p>
    <?php
                break;
        }
    }
    ?>
</section>
<?php include_once 'footer.php'; ?>
