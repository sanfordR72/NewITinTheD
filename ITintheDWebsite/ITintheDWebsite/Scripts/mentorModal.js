$(function () {
    var contact = $('.mentor'),
        popup = $('.contactInfo'),
        mask = $('.mask'),
        close = $('.contactInfo span');

    contact.click(function (event) {

        mask.css({ 'width': $('html').outerWidth(), 'height': $(window).height() });
        centerPopUp(popup, mask);
        mask.fadeIn(200);
        popup.slideDown(200);

        var picPath = $(this).attr("src");
        $("#mentorPic").attr("src", picPath);

        var name = $(this).data("mentor-name");
        url = "/Mentor/GetMentorInfo?name=" + name;
        $("#mentorName").html(name);

        $.post(url, function (data) {
        $("#mentorInfo").html(data);
        });
    
    });

    close.add(mask).click(function () {
        popup.slideUp(200);
        $('.mask').fadeOut(200);
    });

    function centerPopUp(pop, m) {
        var winH = $(window).height(),
            winW = $(window).outerWidth(),
            popH = $(pop).height(),
            popW = $(pop).width();

        //Set the popup window to center
        if (screen.height > 640) {
            $(pop).css('top', Math.max((winH - popH), 0) / 2);
            $(pop).css('left', Math.max((winW - popW), 0) / 2);
        } else {
            return false;
        }

        //Stretch FilterMask to Full Size
        $(m).width(winW + 20);
        $(m).height(winH);
    }

    $(window).resize(centerPopUp(popup, mask));

});