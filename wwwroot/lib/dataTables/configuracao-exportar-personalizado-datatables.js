let configuracaoExportarPersonalizadoPadraoDatatables = {
    dom: 'Bfrtip',
    responsive: true,
    language: {
        url: 'https://cdn.datatables.net/plug-ins/1.10.25/i18n/Portuguese-Brasil.json'
    },
    buttons: [
        {
            text: 'CSV',
            action: function (e) {

                donwload(1, `Despesa`, e, '#filtroAvancado', 'Despesa');
            }
        },
        {
            text: 'EXCEL',
            action: function (e) {
                donwload(2, `Despesa`, e, '#filtroAvancado', 'Despesa')
            }
        },
    ]

}

