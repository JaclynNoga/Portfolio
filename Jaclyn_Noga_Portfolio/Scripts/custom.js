//smooth scroll for navigation
$("li a").click(function () {
    var navLinks = $(this).attr("href");
    $("body").animate({ scrollTop: $(navLinks).offset().top }, "slow");
    return false;
});