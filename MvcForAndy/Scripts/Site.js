$(document).ready(function () {
    if ($("#Email").val() == '') {
        $("#Email").css('color', '#999')
                   .val('email@address.com');
    }

    $("#Email").focusin(function () {
        if ($(this).val() == 'email@address.com') {
            $("#Email").val('');
        }
        $("#Email").css('color', '#333');
    });

    $("#Email").focusout(function () {
        if ($(this).val() == '') {
            $("#Email").css('color', '#999')
                       .val('email@address.com');
        }
    });
});