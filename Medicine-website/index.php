<?php
    include_once 'header.php'
?>

<section id="hero" class="hero d-flex align-items-center">
    <?php
    if (isset($_SESSION["useruid"])) {
        echo "<p>Здравей " . $_SESSION["useruid"] . "</p>";

    }
    ?>
    <div class="container">
        <div class="row">
            <div class="col-lg-6 d-flex flex-column justify-content-center">
                <h1 data-aos="fade-up" class="aos-init aos-animate">Информационен уебсайт за проекта "Лекарствомат"</h1>
                <h2 data-aos="fade-up" data-aos-delay="400" class="aos-init aos-animate">От тук може да получите вашата онлайн рецепта, чрез влизане в нашата платформа</h2>
                <div data-aos="fade-up" data-aos-delay="600" class="aos-init aos-animate">
                    <div class="text-center text-lg-start">
                        <a href="#about" class="btn-get-started scrollto d-inline-flex align-items-center justify-content-center align-self-center">
                            <span>Искам да науча още</span>
                            <i class="bi bi-arrow-right"></i>
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-lg-6 hero-img aos-init aos-animate" data-aos="zoom-out" data-aos-delay="200">
                <div class="sketchfab-embed-wrapper">
                    <iframe title="A 3D model" width="840" height="680" src="https://sketchfab.com/models/b86a58f41a1a4d6c81b3388fd9ebd16c/embed?autostart=0&amp;ui_controls=1&amp;ui_infos=1&amp;ui_inspector=1&amp;ui_stop=1&amp;ui_watermark=1&amp;ui_watermark_link=1" frameborder="0" allow="autoplay; fullscreen; vr" mozallowfullscreen="true" webkitallowfullscreen="true"></iframe>
                </div>
            </div>
        </div>
    </div>

</section>

<?php
    include_once 'footer.php'
?>
