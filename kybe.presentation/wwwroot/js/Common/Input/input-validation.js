function CpfValidation(cpf) {
    cpf = cpf.replace(/\D/g, '');
    if (cpf.length !== 11 || /^(\d)\1+$/.test(cpf)) return false;

    let soma = 0, resto;

    for (let i = 1; i <= 9; i++) soma += parseInt(cpf[i - 1]) * (11 - i);
    resto = (soma * 10) % 11; if (resto === 10) resto = 0;
    if (resto !== parseInt(cpf[9])) return false;

    soma = 0;
    for (let i = 1; i <= 10; i++) soma += parseInt(cpf[i - 1]) * (12 - i);
    resto = (soma * 10) % 11; if (resto === 10) resto = 0;
    if (resto !== parseInt(cpf[10])) return false;

    return true;
}

$.validator.addMethod("cpfvalido", function (value, element) {
    return this.optional(element) || CpfValidation(value);
}, "CPF inválido");

$(function () {
    $("#mask-cpf").rules("add", { cpfvalido: true });
});