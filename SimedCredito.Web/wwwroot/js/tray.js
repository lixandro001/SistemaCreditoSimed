let ArrayCodes = [];

$(function () {

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
            { data: "DireccionDatosGenerales" },
            { data: "Nombre_S_PAIS" },
            { data: "CiudadSedePrincipalDatosGenerales" },
            { data: "CelularDatosGenerales" }
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
    //SIEMPRE EL ANALISTA DE CREDITO VA A VER EL GUARDADO DEL ASESOR COMERCIAL 
    Get("Bandeja/GetBandejaCliente?StartDate=" + startDate + "&EndDate=" + endDate + "&PerfilId=" + 2).done(function (response) {
        if (response.data.Data != null) {
            fnClearTable($('#tabTray').dataTable());
            if (response.data.Data.length > 0) {
                $('#tabTray').dataTable().fnAddData(response.data.Data);
            } else {
                fnAlertAdvertencia("No se Encontro Datos Disponibles");
            }
        }
    });
}

function fnViewRegister(CodeRegister) {
    location.href = '/Main/FormularioPerfilAnalistaCredito/?code=' + CodeRegister;
}
