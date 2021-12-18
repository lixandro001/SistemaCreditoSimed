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
                            <a class="fa fa-pencil" href="#" onclick="event.preventDefault();gestion.certificado('${data.CodeClienteDatosGenerales}')"><i class="fa fa-eye" aria-hidden="true"></i></a>
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

    Get("Bandeja/GetBandejaCliente?StartDate=" + startDate + "&EndDate=" + endDate + "&PerfilId=" + 1).done(function (response) {

        console.log(response);
        if (response.data.Data != null) {
            //fnClearTable($('#tabTray').dataTable());
            if (response.data.Data.length > 0) {
                $('#tabTray').dataTable().fnAddData(response.data.Data);
            } else {
                fnAlertAdvertencia("No se Encontro Datos Disponibles");
            }
        }
    });

}
