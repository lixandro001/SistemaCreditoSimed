var code = "";
$(function (e) {

    var url = new URL(location.href);
    code = url.searchParams.get("codeUser");

    console.log("codigo de usuario de la url" + " " + code);

    ObtenereditarUsuario(code);

    $("#btnRefresh").on("click", function () {
        window.location = fnBaseUrlWeb("Usuarios/NuevoUsuario");
    });
     
    $("#btnGuardarFormulario").on("click", function () {
        fnvalidarformularioUsuario();

    });
     
    $("#cboNacionalidad").on("change", function () {
        fnChangeNacionalidadIT();
    });
  
});


function ObtenereditarUsuario(code) {
    Get("Usuarios/DataUsuario?CodeUsuario=" + code).done(function (response) {
        console.log(response.data.Data);
        if (response.data.Data != null) {
            SeteoDatosFormulario(response.data.Data);
        }
        else {
            fnAlertAdvertencia("No se Encontro Datos Disponibles");
        }
    });
}


function SeteoDatosFormulario(Datos) {
    $("#txtlogin").val(Datos.Login);
    $("#txtpassword").val(Datos.Password);
    $("#txtnombrecompleto").val(Datos.NombreCompleto);
    $("#txtdocumentoidentidad").val(Datos.DocumentoIdentidad);
    $("#txtemail").val(Datos.Email);
    $("#txtperfil").val(Datos.IdPerfil);

}

 
function fnvalidarformularioUsuario() {
    if (!fnValidFormularioUsuario()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Datos Generales.");
        return;
    }
    fnguardarusuario();
}
 

function fnguardarusuario() {
    console.log("entro fncion guardar");
    
    //Verificacion=  
    var txtlogin = $("#txtlogin").val();
    var txtpassword = $("#txtpassword").val();
    var txtnombrecompleto = $("#txtnombrecompleto").val();
    var txtdocumentoidentidad = $("#txtdocumentoidentidad").val();
    var txtemail = $("#txtemail").val();
    var txtperfil = $("#txtperfil").val();
  
    var parametro = new Object();

    parametro.login = txtlogin;
    parametro.password = txtpassword;
    parametro.nombrecompleto = txtnombrecompleto;
    parametro.documentoidentidad = txtdocumentoidentidad;
    parametro.email = txtemail;
    parametro.idperfil = txtperfil;
  
    Post("Usuarios/guardarUsuarios", parametro).done(function (response) {
        console.log("-----------respuesta del guardado");
        console.log(response);
        console.log(response.data);
        
        if (response.data.code == 0) {
            fnAlertSuccess(response.data.message, function () {
                window.location = fnBaseUrlWeb("Usuarios/NuevoUsuario");
            });
            
        } else {
            fnAlertError(response.data.message);
        }
    });

}


function fnValidFormularioUsuario() {
    var Rpta = true;

    if ($("#txtlogin").val() == '') {
        Rpta = false;
    }
    if ($("#txtpassword").val() == '') {
        Rpta = false;
    }
    if ($("#txtnombrecompleto").val() == '') {
        Rpta = false;
    }
    if ($("#txtdocumentoidentidad").val() == '') {
        Rpta = false;
    }
    if ($("#txtemail").val() == '') {
        Rpta = false;
    }
    if ($("#txttipoperfil").val() == 0) {
        Rpta = false;
    }
    return Rpta;
}
 