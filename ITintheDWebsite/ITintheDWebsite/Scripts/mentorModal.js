$(function () {
    var contact = $('.mentor'),
        popup = $('.contactInfo'),
        mask = $('.mask'),
        close = $('.contactInfo span');

    contact.click(function (event) {
        //$('<div class="mask" />').prependTo('body');
        //mask.css({ 'width': $('html').outerWidth(), 'height': $('html').height() });
        centerPopUp(popup, mask);
        popup.slideDown(200);

        var picPath = $(this).attr("src");
        $("#mentorPic").attr("src", picPath);

        var name = $(this).data("mentor-name");
        url = "/Mentor/GetMentorInfo?name=" + name;
        document.getElementById("mentorName").innerHTML = name;

        $.post(url, function (data) {
            document.getElementById("mentorInfo").innerHTML = data;
        });
    
    });

    close.click(function () {
        popup.slideUp(200);
        $('.mask').remove();
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