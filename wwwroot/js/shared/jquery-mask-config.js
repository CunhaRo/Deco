$('.cpfCnpj').mask('000.000.000-00', {
    onKeyPress: function (cpfcnpj, e, field, options) {
        const masks = ['000.000.000-000', '00.000.000/0000-00'];
        const mask = (cpfcnpj.length > 14) ? masks[1] : masks[0];
        $('.cpfCnpj').mask(mask, options);
    }
});

$('.cpf').mask('000.000.000-00');
$('.cnpj').mask('00.000.000/0000-00');
$('.autorizacao-diaria').mask('00.00.000000');

jQuery("input.telefoneee")
    .mask("(99) 9999-9999?9")
    .focusout(function (event) {
        let target, phone, element;
        target = (event.currentTarget) ? event.currentTarget : event.srcElement;
        phone = target.value.replace(/\D/g, '');
        element = $(target);
        element.unmask();
        if (phone.length > 10) {
            element.mask("(99) 99999-999?9");
        } else {
            element.mask("(99) 9999-9999?9");
        }
    });

$('.processoSEI').mask('0000.000000/0000-00');
$('.campoDinheiro').mask('000.000.000.000.000,00', { reverse: true });
$('.telefone').mask('(00) 00000-0000');