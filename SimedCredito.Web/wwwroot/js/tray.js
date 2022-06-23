﻿let ArrayCodes = [];

$(function () {
    fnLoadTrayUser();
    $("#tabTray").DataTable({
        "paging": true,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        columns: [
            { data: null },
            { data: "Nombre_RazonSocialDatosGenerales" },
            { data: "EstadoCredito" },
            { data: "EstadoVenta" },
            { data: "EstadoFinanza" },
            { data: "NombreCompleto" }
        ],
        columnDefs: [{
            "targets": 0,
            "orderable": false,
            "data": "CodeClienteDatosGenerales",
            "render": function (data, type, full, meta) {                
                return  `<div style="text-align:center;">
                            <a class="fa fa-pencil" href="#" onclick="event.preventDefault();fnViewRegister('${data.CodeClienteDatosGenerales}')"><i class="fa fa-eye" aria-hidden="true"></i></a>
                        </div>`;
            }
        }
        ]
    });

    $("#txtStartDate, #txtEndDate").datepicker({
        autoclose: true,
        format: "dd/mm/yyyy"
    });

    $("#btnConsultar").on("click", function () {
        fnLoadTrayUser();
    });

});
 
function fnLoadTrayUser() {
    var startDate = "";
    var endDate = "";
    startDate = $("#txtStartDate").val();
    endDate = $("#txtEndDate").val();
    var PerfilId = $("#perfil").val();
    Get("Bandeja/GetBandejaCliente?StartDate=" + startDate + "&EndDate=" + endDate + "&PerfilId=" + PerfilId).done(function (response) {
        $('body').loading('stop');

        if (response.code == 0) {
            fnClearTable($('#tabTray').dataTable());
            if (response.data.Data.length > 0) {
                $('#tabTray').dataTable().fnAddData(response.data.Data);
            } else {
                fnAlertAdvertencia("No se Encontro Datos Disponibles");
            }

         } else if (response.code == 3) {
            if (response.data == "SESSION_TIMEOUT") {
                fnAlertAdvertenciaSession(response.message, function () {
                    window.location = fnBaseUrlWeb("FormularioCliente/Exit");
                });
              }
        }
    });
}

function fnViewRegister(CodeRegister) {
    location.href = '/Main/FormularioPerfilAnalistaCredito/?code=' + CodeRegister;
}
