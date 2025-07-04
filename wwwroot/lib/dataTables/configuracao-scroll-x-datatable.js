﻿let configuracaoScrollXDatatables = {
    dom: 'Bfrtip',
    responsive: false,
    scrollX: true,
    language: {
        url: 'https://cdn.datatables.net/plug-ins/1.10.25/i18n/Portuguese-Brasil.json'
    },
    buttons: [
        {
            extend: 'pdfHtml5',
            text: 'PDF',
            orientation: 'landscape',
            pageSize: 'A4',
            exportOptions: {
                modifier: {
                    search: 'none'
                }
            }
        },
        {
            extend: 'excelHtml5',
            text: 'EXCEL',
            exportOptions: {
                modifier: {
                    search: 'none'
                }
            }
        },
        {
            extend: 'csvHtml5',
            text: 'CSV',
            charset: "utf-8",
            exportOptions: {
                modifier: {
                    search: 'none'
                }
            }
        }
    ]
}