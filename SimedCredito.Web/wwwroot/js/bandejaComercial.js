let ArrayCodes = [];

$(function () {

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
            { data: "Estado" },
            { data: "Nombre_S_PAIS" },
            { data: "CiudadSedePrincipalDatosGenerales" },
            { data: "CelularDatosGenerales" }
        ],
        columnDefs: [{
            "targets": 0,
            "orderable": false,
            "data": "CodeClienteDatosGenerales",
            "render": function (data, type, full, meta) {
                return `<div style="text-align:center;">
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

    $("#btnNuevo").on("click", function () {
        fnViewForm();
    });

});

function fnLoadTrayUser() {
    var startDate = "";
    var endDate = "";
    startDate = $("#txtStartDate").val();
    endDate = $("#txtEndDate").val();

    Get("Bandeja/GetBandejaCliente?StartDate=" + startDate + "&EndDate=" + endDate + "&PerfilId=" + 3).done(function (response) {
        if (response.data.Data != null) {
            fnClearTable($('#tabDescTable').dataTable());
            if (response.data.Data.length > 0) {
                $('#tabDescTable').dataTable().fnAddData(response.data.Data);
            } else {
                fnAlertAdvertencia("No se Encontro Datos Disponibles");
            }
        }
    });
}

function fnViewRegister(CodeRegister) {
    location.href = '/Main/FormularioPerfilGerenteVentas/?code=' + CodeRegister;
}

function fnViewForm() {
    location.href = '/Main/FormularioCliente';
}
