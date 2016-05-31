//smooth scroll for navigation
$("li a").click(function () {
    var navLinks = $(this).attr("href");
    $("body").animate({ scrollTop: $(navLinks).offset().top }, "slow");
    return false;
});


// ===== Scroll to Top ==== 
$(window).scroll(function () {
    if ($(this).scrollTop() >= 550) {        // If page is scrolled more than 550px
        $('#return-to-top').fadeIn(200);    // Fade in the arrow
    } else {
        $('#return-to-top').fadeOut(200);   // Else fade out the arrow
    }
});
$('#return-to-top').click(function () {      // When arrow is clicked
    $('body,html').animate({
        scrollTop: 0                       // Scroll to top of body
    }, 500);
});