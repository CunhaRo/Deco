toastr.options.progressBar = true;
toastr.options.timeOut = 10000;
toastr.options.closeButton = true;
toastr.options.preventDuplicates = true;
toastr.options.positionClass = "toast-top-full-width"
toastr.options.positionClass = "toast-bottom-left"

function Notificar(type, mensagem) {
    toastr[type](mensagem);
}