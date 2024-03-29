﻿var perfilixandro = '';

$(function () {
    console.log(perfilixandro);
  
    fnLoadTrayUser();
     
    $("#tabDescTable").DataTable({
        "paging": true,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        columns: [
            { data: null },
            { data: "Nombre_RazonSocialDatosGenerales" },
            { data: "EstadoComercial" },
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
                if (data.IdEstadoComercial == 4) {
                    console.log(data.IdEstadoComercial);
                    return `<div style="text-align:center;">
                            <a class="fa fa-pencil" href="#" onclick="event.preventDefault();fnEditRegister('${data.CodeClienteDatosGenerales}')"><i class="fa fa-edit" aria-hidden="true"></i></a>
                        </div>`;
                }
                else {
                    return `<div style="text-align:center;">
                            <a class="fa fa-pencil" href="#" onclick="event.preventDefault();fnViewRegister('${data.CodeClienteDatosGenerales}')"><i class="fa fa-eye" aria-hidden="true"></i></a>
                        </div>`;
                }
                
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

    $("#btnNuevo").on("click", function () {
        fnViewForm();
    });
     
});


function fnLoadTrayUser() {
    var startDate = "";
    var endDate = "";
    var PerfilId = "";
    startDate = $("#txtStartDate").val();
    endDate = $("#txtEndDate").val();
    PerfilId = perfilixandro;
    Get("Bandeja/GetBandejaCliente?StartDate=" + startDate + "&EndDate=" + endDate + "&PerfilId=" + PerfilId).done(function (response) {
        $('body').loading('stop');
        if (response.code == 0) {
            fnClearTable($('#tabDescTable').dataTable());
            console.log(response.data.Data);
            if (response.data.Data.length > 0) {
                $('#tabDescTable').dataTable().fnAddData(response.data.Data);
            }

            else {
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
    location.href = '/Main/FormularioPerfilComercial/?code=' + CodeRegister;
}

function fnEditRegister(CodeRegister) {
    location.href = '/Main/EditFormularioPerfilComercial/?code=' + CodeRegister;
}

function fnViewForm() {
    location.href = '/Main/FormularioCliente';
}
