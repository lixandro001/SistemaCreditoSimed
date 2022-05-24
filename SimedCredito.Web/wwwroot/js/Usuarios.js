$(function () {
    fnLoadTrayUser();
    $("#tabDescTable").DataTable({
        "paging": true,
        "lengthChange": false,
        "searching": true,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        
        columns: [
            { data: null },
            { data: "Login" },
            { data: "NombreCompleto" },
            { data: "DocumentoIdentidad" },
            { data: "Email" },
            { data: "nombrePerfil" }
             
        ],
        columnDefs: [{
            "targets": 0,
            "orderable": false,
            "data": "CodeClienteDatosGenerales",
            "render": function (data, type, full, meta) {
                 
                return `<div style="text-align:center;">
                           <a class="fa fa-pencil" href="#" onclick="event.preventDefault();fnViewEliminar('${data.UsuarioCodeGuid}')"><i class="fa fa-trash" aria-hidden="true"></i>
                           </a>
 
                           <a class="fa fa-pencil" href="#" onclick="event.preventDefault();fnEditRegister('${data.UsuarioCodeGuid}')"><i class="fa fa-edit" aria-hidden="true"></i>
                           </a>
                        </div>`;

                 
                //if (data.IdEstadoComercial == 4) {
                //    console.log(data.IdEstadoComercial);
                //    return `<div style="text-align:center;">
                //            <a class="fa fa-pencil" href="#" onclick="event.preventDefault();fnEditRegister('${data.CodeClienteDatosGenerales}')"><i class="fa fa-edit" aria-hidden="true"></i></a>
                //        </div>`;
                //}
                //else {
                //    return `<div style="text-align:center;">
                //            <a class="fa fa-pencil" href="#" onclick="event.preventDefault();fnViewRegister('${data.CodeClienteDatosGenerales}')"><i class="fa fa-eye" aria-hidden="true"></i></a>
                //        </div>`;
                //}

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

    $("#btnNuevoUsuario").on("click", function () {
        fnViewCreateUsuario();
    });
});


function fnLoadTrayUser() {
    Get("Usuarios/GetListadoUsuario").done(function (response) {
        $('body').loading('stop');
        if (response.data.Data != null) {
            fnClearTable($('#tabDescTable').dataTable());
            console.log(response.data.Data);
            if (response.data.Data.length > 0) {
                $('#tabDescTable').dataTable().fnAddData(response.data.Data);
            } else {
                fnAlertAdvertencia("No se Encontro Datos Disponibles");
            }
        }
    });
}


function fnViewEliminar(UsuarioCodeGuid) {
    console.log(UsuarioCodeGuid);
    var parametro = new Object();
    parametro.codeUsuario = UsuarioCodeGuid;
    Post("Usuarios/eliminarUsuarios", parametro).done(function (response) {
        $('body').loading('stop');
        console.log("-----------respuesta del guardado");
        console.log(response);
        console.log(response.data);

        if (response.data.code == 0) {
            fnAlertSuccess(response.data.message, function () {
                window.location = fnBaseUrlWeb("Usuarios/Index");
            });

        } else {
            fnAlertError(response.data.message);
        }
    });
}

function fnEditRegister(UsuarioCodeGuid) {
    location.href = '/Usuarios/NuevoUsuario/?codeUser=' + UsuarioCodeGuid;
}

function fnViewCreateUsuario() {
    location.href = '/Usuarios/NuevoUsuario';
}
