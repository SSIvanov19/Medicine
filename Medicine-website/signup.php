<?php
    include_once 'header.php'
?>
    <head>
        <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">
        <link rel="stylesheet" href="css/login.css">
    </head>

    <section class="signup">
        <div class="container">
            <div class="signup-content">
                <div class="signup-form">
                    <h2>Регистрация</h2>
                    <form method="POST" class="register-form" id="register-form" action="includes/signup.inc.php">
                        <div class="form-group">
                            <label for="name"><i class="zmdi zmdi-account material-icons-name"></i></label>
                            <input type="text" name="name" id="name" placeholder="Пълно име...">
                        </div>
                        <div class="form-group">
                            <label for="email"><i class="zmdi zmdi-email"></i></label>
                            <input type="text" name="email" id="email" placeholder="Имейл...">
                        </div>
                        <div class="form-group">
                            <label for="pass"><i class="zmdi zmdi-lock"></i></label>
                            <input type="password" name="pwd" id="pwd" placeholder="Парола...">
                        </div>
                        <div class="form-group">
                            <label for="re-pass"><i class="zmdi zmdi-lock-outline"></i></label>
                            <input type="password" name="pwdrepeat" id="name" placeholder="Повтори паролата...">
                        </div>
                        <div class="form-group form-button">
                            <input type="submit" name="signup" id="signup" class="form-submit" value="Регистрирай се" />
                        </div>
                    </form>
                </div>
                <div class="signup-image">
                    <figure><img src="img/signup-image.jpg" alt="sing up image"></figure>
                    <a href="login.php" class="signup-image-link">Вече съм член</a>
                </div>
            </div>
        </div>
        <?php
        if (isset($_GET["error"])) {
            if ($_GET["error"] == "emptyinput") {
                echo "<p>Попълнете всички полета!</p>";
            }
            else if ($_GET["error"] == "invaliduid") {
                echo "<p>Изберете правилно потребителско име!</p>";
            }
            else if ($_GET["error"] == "invalidemail") {
                echo "<p>Изберете подходящ имейл!</p>";
            }
            else if ($_GET["error"] == "passwordsdontmatch") {
                echo "<p>Паролите не съвпадат!</p>";
            }
            else if ($_GET["error"] == "stmtfailed") {
                echo "<p>Нещо се обърка, опитайте отново!</p>";
            }
            else if ($_GET["error"] == "usernametaken") {
                echo "<p>Потребителско име вече е заето!</p>";
            }
            else if ($_GET["error"] == "none") {
                echo "<p>Регистрахте се!</p>";
            }

        }
        ?>
    </section>

<script src="vendor/jquery/jquery.min.js"></script>
<?php
    include_once 'footer.php'
?>
