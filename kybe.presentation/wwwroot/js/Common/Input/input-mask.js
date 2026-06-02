$(function () {

    $(".mask-cpf").inputmask({
        mask: "999.999.999-99",
        showMaskOnFocus: true,
        showMaskOnHover: false
    });

    $(".mask-phone").inputmask({
        mask: "(99) 99999-9999",
        showMaskOnFocus: true,   
        showMaskOnHover: false   
    });

});

