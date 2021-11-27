
$(function () {
    $(".DateFechaOnly").datepicker({
        autoclose: true,
        format: "dd/mm/yyyy",
    });

    fnLoadCategoriaCliente();
    fnLoadPrecios();
    fnLoadTipoIdentificacion();
    fnLoadTipoContribuyente();
    fnLoadTipoSociedad();
    fnLoadOrigenCapital();
    fnLoadPais();
    fnLoadActividadEconomica();
    fnLoadRegimen();
    fnLoadNacionalidad();
    fnLoadSubUnidad();
    fnLoadAsesorComercial();

    $("#btnGuardarFormulario").on("click", function () {
        fnSaveFormularioCliente();
    });

    $("#cboTipoIdentificacionTributaria").on("change", function () {
        fnChangeIdentificacionIT();
    });

    $("#cboTipoSociedad").on("change", function () {
        fnChangeSociedadIT();
    });

    $("#cboActividadEconomica").on("change", function () {
        fnChangeEconomicaIT();
    });

    $("#cboNacionalidad").on("change", function () {
        fnChangeNacionalidadIT();
    });

});

function fnLoadCategoriaCliente() {
    Get("SisInternoSelect/GetCategoriaCliente").done(function (response) {
        console.log(response.data.Data);
        var Response = response.data.Data;
        /*if (Response != null) {
            var select = document.getElementById('cboCategoriaCliente');
            var options = '<option value="">Seleccionar Categoria Cliente</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Categoria_Cliente}">${item.Nombre_S_Categoria_Cliente}</option>`;
            }
            select.innerHTML = options;
        }*/
    });
}

function fnLoadPrecios() {
    Get("SisInternoSelect/GetPrecios").done(function (response) {
        console.log(response.data.Data);
        var Response = response.data.Data;
        /*if (Response != null) {
            var select = document.getElementById('cboPrecios');
            var options = '<option value="">Seleccionar Precios</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Lista_Precios}">${item.Nombre_S_Lista_Precios}</option>`;
            }
            select.innerHTML = options;
        }*/
    });
}

function fnLoadTipoIdentificacion() {
    Get("SisInternoSelect/GetTipoIdentificacion").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            //-----------Combo para Identificacion (seccion : Representate Legal)
            var select = document.getElementById('cboTipoIdenticacionLegal');
            var options = '<option value="">Seleccionar Tipo Identificación</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Tipo_Identificacion}">${item.Nombre_S_Tipo_Identificacion}</option>`;
            }
            select.innerHTML = options;
            //-----------Combo para Identificacion (seccion : Representate Legal)
            var select2 = document.getElementById('cboTipoIdentificacionTributaria');
            var options2 = '<option value="">Seleccionar Tipo Identificación</option>';
            for (let item of Response) {
                options2 += `<option value="${item.Id_S_Tipo_Identificacion}">${item.Nombre_S_Tipo_Identificacion}</option>`;
            }
            select2.innerHTML = options2;
        }
    });
}

function fnLoadTipoContribuyente() {
    Get("SisInternoSelect/GetTipoContribuyente").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboTipoContribuyente');
            var options = '<option value="">Seleccionar Tipo Contribuyente</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Tipo_Contribuyente}">${item.Nombre_S_Tipo_Contribuyente}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadTipoSociedad() {
    Get("SisInternoSelect/GetTipoSociedad").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboTipoSociedad');
            var options = '<option value="">Seleccionar Tipo Sociedad</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Tipo_Sociedad}">${item.Nombre_S_Tipo_Sociedad}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadOrigenCapital() {
    Get("SisInternoSelect/GetOrigenCapital").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboOrigenCapital');
            var options = '<option value="">Seleccionar Origen Capital</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Origen_Capital}">${item.Nombre_S_Origen_Capital}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadPais() {
    Get("SisInternoSelect/GetPais").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboPais');
            var options = '<option value="">Seleccionar País</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Pais}">${item.Nombre_S_Pais}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadActividadEconomica() {
    Get("SisInternoSelect/GetActividadEconomica").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboActividadEconomica');
            var options = '<option value="">Seleccionar Actividad Economica</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Actividad_Economica}">${item.Nombre_S_Actividad_Economica}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadRegimen() {
    Get("SisInternoSelect/GetRegimen").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboRegimen');
            var options = '<option value="">Seleccionar Regimen</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Regimen}">${item.Nombre_S_Regimen}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadNacionalidad() {
    Get("SisInternoSelect/GetNacionalidad").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboNacionalidad');
            var options = '<option value="">Seleccionar Nacionalidad</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Nacionalidad}">${item.Nombre_S_Nacionalidad}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadBiociencias() {
    Get("SisInternoSelect/GetBiociencias").done(function (response) {
        var Response = response.data.Data;
        /*if (Response != null) {
            var select = document.getElementById('cboBioCiencias');
            var options = '<option value="">Seleccionar BioCiencia</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Biocencia}">${item.Nombre_S_Biocencia}</option>`;
            }
            select.innerHTML = options;
        }*/
    });
}

function fnLoadSubUnidad() {
    Get("SisInternoSelect/GetSubUnidad").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboSubUnidad');
            var options = '<option value="">Seleccionar Sub Unidad</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Sub_Unidad}">${item.Nombre_S_Sub_Unidad}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadAsesorComercial() {
    Get("SisInternoSelect/GetAsesorComercial").done(function (response) {
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboAsesorComercial');
            var options = '<option value="">Seleccionar Asesor Comercial</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Asesor_Comercial}">${item.Nombre_S_Asesor_Comercial}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnChangeIdentificacionIT() {
    if ($("#cboTipoIdentificacionTributaria").val() != '4') {
        $("#txtCualIdentificacionIT").val('');
        $("#txtCualIdentificacionIT").prop('disabled', true);
    }
    else {
        $("#txtCualIdentificacionIT").prop('disabled', false);
    }
}

function fnChangeSociedadIT() {
    if ($("#cboTipoSociedad").val() != '5') {
        $("#txtCualSociedadIT").val('');
        $("#txtCualSociedadIT").prop('disabled', true);
    }
    else {
        $("#txtCualSociedadIT").prop('disabled', false);
    }
}

function fnChangeEconomicaIT() {
    if ($("#cboActividadEconomica").val() != '7') {
        $("#txtCualEconomicaIT").val('');
        $("#txtCualEconomicaIT").prop('disabled', true);
    }
    else {
        $("#txtCualEconomicaIT").prop('disabled', false);
    }
}

function fnChangeNacionalidadIT() {
    if ($("#cboNacionalidad").val() != '2') {
        $("#txtCualIRL").prop('disabled', true);
    }
    else {
        $("#txtCualIRL").prop('disabled', false);
    }
}

function fnSaveFormularioCliente() {
    //---- DATOS GENERALES (DG)
    /*if (!fnValidFormularioDG()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Datos Generales.");
        return;
    }*/
    //---- INFORMACION DE CONTACTOS (IDC)
    /*if (!fnValidFormularioIDC()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información De Contactos.");
        return;
    }*/
    //---- INFORMACION TRIBUTARIA (IT)
    /*if (!fnValidFormularioIT()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información Tributaria.");
        return;
    }*/
    //----- INFORMACION ACTIVIDAD ECONOMICA (IAE)
    /*if (!fnValidFormularioIAE()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información Actividad Económica.");
        return;
    }*/
    //----- INFORMACION REPRESENTANTE LEGAL(IRL)
    /*if (!fnValidFormularioIRL()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información Representación Legal.");
        return;
    }*/
    //----- PREGUNTAS PEP(PEP)
    /*if (!fnValidFormularioPEP()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Preguntas PEP.");
        return;
    }*/
    //----- INFORMACION DE SOCIOS O ACCIONISTAS(ISA)
    if (!fnValidFormularioISA()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información de Socios o Accionistas.");
        return;
    }
}

function fnValidFormularioDG() {
    var Rpta = true;
    if ($("#txtNombreRazonDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtDireccionDG").val() == '') {
        Rpta = false;
    }
    if ($("#cboPais").val() == '') {
        Rpta = false;
    }
    if ($("#txtCiudadPrincipalDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtTelefonoFijoDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtCelularDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtCorreoEnvioFacturaElectronicaDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtDireccionEntregaFacturaDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtCiudadFacturaDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtDireccionEntregaPedidoDG").val() == '') {
        Rpta = false;
    }
    if ($("#txtCiudadPedidoDG").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioIDC() {
    var Rpta = true;
    if ($("#txtNombreContactoAreaCobranzaIDC1").val() == '') {
        Rpta = false;
    }
    if ($("#txtTelefonoContactoAreaCobranzaIDC1").val() == '') {
        Rpta = false;
    }
    if ($("#txtCorreoContactoAreaCobranzaIDC1").val() == '') {
        Rpta = false;
    }
    if ($("#txtNombreContactoAreaFinancieraIDC2").val() == '') {
        Rpta = false;
    }
    if ($("#txtTelefonoContactoAreaFinancieraIDC2").val() == '') {
        Rpta = false;
    }
    if ($("#txtCorreoContactoAreaFinancieraIDC2").val() == '') {
        Rpta = false;
    }
    if ($("#txtNombreContactoAreaComercialIDC3").val() == '') {
        Rpta = false;
    }
    if ($("#txtTelefonoContactoAreaComercialIDC3").val() == '') {
        Rpta = false;
    }
    if ($("#txtCorreoContactoAreaComercialIDC3").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioIT() {
    var Rpta = true;
    if ($("#cboTipoIdentificacionTributaria").val() == '') {
        Rpta = false;
    }
    if ($("#txtCualIdentificacionIT").val() == '' && $("#cboTipoIdentificacionTributaria").val() == '4') {
        Rpta = false;
    }
    if ($("#txtNumIdentificacionIT").val() == '') {
        Rpta = false;
    }
    if ($("#cboTipoContribuyente").val() == '') {
        Rpta = false;
    }
    if ($("#cboTipoSociedad").val() == '') {
        Rpta = false;
    }
    if ($("#txtCualSociedadIT").val() == '' && $("#cboTipoSociedad").val() == '5') {
        Rpta = false;
    }
    if ($("#cboOrigenCapital").val() == '') {
        Rpta = false;
    }
    if ($("#cboActividadEconomica").val() == '') {
        Rpta = false;
    }
    if ($("#txtCualEconomicaIT").val() == '' && $("#cboActividadEconomica").val() == '7') {
        Rpta = false;
    }
    if ($("#txtFechaConstitucionIT").val() == '') {
        Rpta = false;
    }
    if ($("#cboRegimen").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioIAE() {
    var Rpta = true;
    if ($("#txtActividadPrincipalIAE").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioIRL() {
    var Rpta = true;
    if ($("#txtNombreRepresentanteLegalIRL").val() == '') {
        Rpta = false;
    }
    if ($("#cboTipoIdenticacionLegal").val() == '') {
        Rpta = false;
    }
    if ($("#txtNumeroIdentificacionIRL").val() == '') {
        Rpta = false;
    }
    if ($("#cboNacionalidad").val() == '') {
        Rpta = false;
    }
    /*
    if ($("#checkOtraIRL").val() == '') {
        Rpta = false;
    }
    if ($("#txtCualIRL").val() == '') {
        Rpta = false;
    }
     */
    if ($("#txtFechaExpedicionDocumentoIRL").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioPEP() {
    var Rpta = true;    
    if (!document.getElementById("checkSiGozaPEP").checked && !document.getElementById("checkNoGozaPEP").checked) {
        Rpta = false;
    }
    if (!document.getElementById("checkSiManejaPEP").checked && !document.getElementById("checkNoManejaPEP").checked) {
        Rpta = false;
    }
    if (!document.getElementById("checkSiOcupaPEP").checked && !document.getElementById("checkNoOcupaPEP").checked) {
        Rpta = false;
    }
    if (!document.getElementById("checkSiVinculo1PEP").checked && !document.getElementById("checkNoVinculo1PEP").checked) {
        Rpta = false;
    }
    if (!document.getElementById("checkSiVinculo2PEP").checked && !document.getElementById("checkNoVinculo2PEP").checked) {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioISA() {
    var Rpta = true;
    if (!document.getElementById("checkSiAccionistaISA").checked && !document.getElementById("checkNoAccionistaISA").checked) {
        Rpta = false;
    }
    if (document.getElementById("checkSiAccionistaISA").checked) {
        if ($("#txtNombreApellidoAccionista1ISA").val() == '' || $("#txtTipoIdAccionista1ISA").val() == '' || $("#txtNroDocumentoAccionista1ISA").val() == '' || $("#txtParticipacionAccionista1ISA").val() == '' || $("#txtNacionalidadAccionista1ISA").val() == '') {
            Rpta = true;
            fnAlertAdvertencia("Debe llenar los campos de Información de Socios o Accionistas, Minimo 2 filas.");
        }
        if ($("#txtNombreApellidoAccionista2ISA").val() == '' || $("#txtTipoIdAccionista2ISA").val() == '' || $("#txtNroDocumentoAccionista2ISA").val() == '' || $("#txtParticipacionAccionista2ISA").val() == '' || $("#txtNacionalidadAccionista2ISA").val() == '') {
            Rpta = true;
            fnAlertAdvertencia("Debe llenar los campos de Información de Socios o Accionistas, Minimo 2 filas.");
        }
    }
    return Rpta;
}

//--------PEP CHECKBOX TRUE O FALSE---------
//#region PEP CHECKBOC
$("#checkSiGozaPEP").on("change", function () {
    if (this.checked) {
        $("#checkNoGozaPEP").prop("checked", false);
    }
});

$("#checkNoGozaPEP").on("change", function () {
    if (this.checked) {
        $("#checkSiGozaPEP").prop("checked", false);
    }
});

$("#checkSiManejaPEP").on("change", function () {
    if (this.checked) {
        $("#checkNoManejaPEP").prop("checked", false);
    }
});

$("#checkNoManejaPEP").on("change", function () {
    if (this.checked) {
        $("#checkSiManejaPEP").prop("checked", false);
    }
});

$("#checkSiOcupaPEP").on("change", function () {
    if (this.checked) {
        $("#checkNoOcupaPEP").prop("checked", false);
    }
});

$("#checkNoOcupaPEP").on("change", function () {
    if (this.checked) {
        $("#checkSiOcupaPEP").prop("checked", false);
    }
});

$("#checkSiVinculo1PEP").on("change", function () {
    if (this.checked) {
        $("#checkNoVinculo1PEP").prop("checked", false);
    }
});

$("#checkNoVinculo1PEP").on("change", function () {
    if (this.checked) {
        $("#checkSiVinculo1PEP").prop("checked", false);
    }
});

$("#checkSiVinculo2PEP").on("change", function () {
    if (this.checked) {
        $("#checkNoVinculo2PEP").prop("checked", false);
    }
});

$("#checkNoVinculo2PEP").on("change", function () {
    if (this.checked) {
        $("#checkSiVinculo2PEP").prop("checked", false);
    }
});
//#endregion
///-------FIN PEP CHECKBOX TRUE O FALSE-------

//--------ISA CHECKBOX TRUE O FALSE---------
//#region ISA CHECKBOC
$("#checkSiAccionistaISA").on("change", function () {
    if (this.checked) {
        $("#checkNoAccionistaISA").prop("checked", false);
        fnInhabilitarImputTable();
    }
    else {
        $("#checkNoAccionistaISA").prop("checked", true);
        fnHabilitarImputTable();
    }
});

$("#checkNoAccionistaISA").on("change", function () {
    if (this.checked) {
        $("#checkSiAccionistaISA").prop("checked", false);
        fnHabilitarImputTable();
        fnLimpiarCamposTable();
    }
    else {
        $("#checkSiAccionistaISA").prop("checked", true);
        fnInhabilitarImputTable();
        fnLimpiarCamposTable();
    }
});

function fnHabilitarImputTable() {
    $("#txtNombreApellidoAccionista1ISA").prop("disabled", true);
    $("#txtNombreApellidoAccionista2ISA").prop("disabled", true);
    $("#txtNombreApellidoAccionista3ISA").prop("disabled", true);
    $("#txtNombreApellidoAccionista4ISA").prop("disabled", true);
    $("#txtTipoIdAccionista1ISA").prop("disabled", true);
    $("#txtTipoIdAccionista2ISA").prop("disabled", true);
    $("#txtTipoIdAccionista3ISA").prop("disabled", true);
    $("#txtTipoIdAccionista4ISA").prop("disabled", true);
    $("#txtNroDocumentoAccionista1ISA").prop("disabled", true);
    $("#txtNroDocumentoAccionista2ISA").prop("disabled", true);
    $("#txtNroDocumentoAccionista3ISA").prop("disabled", true);
    $("#txtNroDocumentoAccionista4ISA").prop("disabled", true);
    $("#txtParticipacionAccionista1ISA").prop("disabled", true);
    $("#txtParticipacionAccionista2ISA").prop("disabled", true);
    $("#txtParticipacionAccionista3ISA").prop("disabled", true);
    $("#txtParticipacionAccionista4ISA").prop("disabled", true);
    $("#txtNacionalidadAccionista1ISA").prop("disabled", true);
    $("#txtNacionalidadAccionista2ISA").prop("disabled", true);
    $("#txtNacionalidadAccionista3ISA").prop("disabled", true);
    $("#txtNacionalidadAccionista4ISA").prop("disabled", true);
}

function fnInhabilitarImputTable() {
    $("#txtNombreApellidoAccionista1ISA").prop("disabled", false);
    $("#txtNombreApellidoAccionista2ISA").prop("disabled", false);
    $("#txtNombreApellidoAccionista3ISA").prop("disabled", false);
    $("#txtNombreApellidoAccionista4ISA").prop("disabled", false);
    $("#txtTipoIdAccionista1ISA").prop("disabled", false);
    $("#txtTipoIdAccionista2ISA").prop("disabled", false);
    $("#txtTipoIdAccionista3ISA").prop("disabled", false);
    $("#txtTipoIdAccionista4ISA").prop("disabled", false);
    $("#txtNroDocumentoAccionista1ISA").prop("disabled", false);
    $("#txtNroDocumentoAccionista2ISA").prop("disabled", false);
    $("#txtNroDocumentoAccionista3ISA").prop("disabled", false);
    $("#txtNroDocumentoAccionista4ISA").prop("disabled", false);
    $("#txtParticipacionAccionista1ISA").prop("disabled", false);
    $("#txtParticipacionAccionista2ISA").prop("disabled", false);
    $("#txtParticipacionAccionista3ISA").prop("disabled", false);
    $("#txtParticipacionAccionista4ISA").prop("disabled", false);
    $("#txtNacionalidadAccionista1ISA").prop("disabled", false);
    $("#txtNacionalidadAccionista2ISA").prop("disabled", false);
    $("#txtNacionalidadAccionista3ISA").prop("disabled", false);
    $("#txtNacionalidadAccionista4ISA").prop("disabled", false);
}

function fnLimpiarCamposTable() {
    $("#txtNombreApellidoAccionista1ISA").val('');
    $("#txtNombreApellidoAccionista2ISA").val('');
    $("#txtNombreApellidoAccionista3ISA").val('');
    $("#txtNombreApellidoAccionista4ISA").val('');
    $("#txtTipoIdAccionista1ISA").val('');
    $("#txtTipoIdAccionista2ISA").val('');
    $("#txtTipoIdAccionista3ISA").val('');
    $("#txtTipoIdAccionista4ISA").val('');
    $("#txtNroDocumentoAccionista1ISA").val('');
    $("#txtNroDocumentoAccionista2ISA").val('');
    $("#txtNroDocumentoAccionista3ISA").val('');
    $("#txtNroDocumentoAccionista4ISA").val('');
    $("#txtParticipacionAccionista1ISA").val('');
    $("#txtParticipacionAccionista2ISA").val('');
    $("#txtParticipacionAccionista3ISA").val('');
    $("#txtParticipacionAccionista4ISA").val('');
    $("#txtNacionalidadAccionista1ISA").val('');
    $("#txtNacionalidadAccionista2ISA").val('');
    $("#txtNacionalidadAccionista3ISA").val('');
    $("#txtNacionalidadAccionista4ISA").val('');
}
//#endregion
///-------FIN ISA CHECKBOX TRUE O FALSE-------