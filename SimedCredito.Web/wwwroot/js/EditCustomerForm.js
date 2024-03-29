﻿var code = "";
$(function () {
    var url = new URL(location.href);
    code = url.searchParams.get("code");

    console.log(code);

    $(".DateFechaOnly").datepicker({
        autoclose: true,
        format: "dd/mm/yyyy",
    });

    //fnLoadCategoriaCliente();
    //fnLoadPrecios();
    fnLoadTipoIdentificacion();
    fnLoadTipoContribuyente();
    fnLoadTipoSociedad();
    fnLoadOrigenCapital();
    fnLoadPais();
    fnLoadActividadEconomica();
    fnLoadRegimen();
    fnLoadNacionalidad();   
    fnLoadAsesorComercial();
    fnLoadUnidad();
    fnLoadTipoPago();
    LoadDataViewByCode(code);
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
    $("#btnGuardarFormulario").on("click", function () {
        fnSaveFormularioCliente();

    });
    $("#btnEnviar").on("click", function (e) {
        console.log("entro numero 1");
        fnEnviarFormularioCliente();
    });
    //********************************************************
    // PARA ADJUNTO 1
    $(".browse-btn1").on("click", function (a) {
        a.preventDefault();
        $("#real-input1").click();
    });
    // PARA ADJUNTO 2
    $(".browse-btn2").on("click", function (a) {
        a.preventDefault();
        $("#real-input2").click();
    });
    // PARA ADJUNTO 3
    $(".browse-btn3").on("click", function (a) {
        a.preventDefault();
        $("#real-input3").click();
    });
    // PARA ADJUNTO 4
    $(".browse-btn4").on("click", function (a) {
        a.preventDefault();
        $("#real-input4").click();
    });
    // PARA ADJUNTO 5
    $(".browse-btn5").on("click", function (a) {
        a.preventDefault();
        $("#real-input5").click();
    });
    // PARA ADJUNTO 6
    $(".browse-btn6").on("click", function (a) {
        a.preventDefault();
        $("#real-input6").click();
    });
    // PARA ADJUNTO 7
    $(".browse-btn7").on("click", function (a) {
        a.preventDefault();
        $("#real-input7").click();
    });
    // PARA ADJUNTO 8
    $(".browse-btn8").on("click", function (a) {
        a.preventDefault();
        $("#real-input8").click();
    });
    // PARA ADJUNTO 9
    $(".browse-btn9").on("click", function (a) {
        a.preventDefault();
        $("#real-input9").click();
    });
    // PARA ADJUNTO 10
    $(".browse-btn10").on("click", function (a) {
        a.preventDefault();
        $("#real-input10").click();
    });
    // PARA ADJUNTO 11
    $(".browse-btn11").on("click", function (a) {
        a.preventDefault();
        $("#real-input11").click();
    });
    // PARA ADJUNTO 12
    $(".browse-btn12").on("click", function (a) {
        a.preventDefault();
        $("#real-input12").click();
    });
    // PARA ADJUNTO 13
    $(".browse-btn13").on("click", function (a) {
        a.preventDefault();
        $("#real-input13").click();
    });
    //********************************************** BOTON PARA ADJUNTO********************************
    $("#real-input1").on("change", function () {
        const name = $("#real-input1").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info1").text(htmlName);
    });
    $("#real-input2").on("change", function () {
        const name = $("#real-input2").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info2").text(htmlName);
    });
    $("#real-input3").on("change", function () {
        const name = $("#real-input3").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info3").text(htmlName);
    });
    $("#real-input4").on("change", function () {
        const name = $("#real-input4").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info4").text(htmlName);
    });
    $("#real-input5").on("change", function () {
        const name = $("#real-input5").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info5").text(htmlName);
    });
    $("#real-input6").on("change", function () {
        const name = $("#real-input6").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info6").text(htmlName);
    });
    $("#real-input7").on("change", function () {
        const name = $("#real-input7").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info7").text(htmlName);
    });
    $("#real-input8").on("change", function () {
        const name = $("#real-input8").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info8").text(htmlName);
    });
    $("#real-input9").on("change", function () {
        const name = $("#real-input9").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info9").text(htmlName);
    });
    $("#real-input10").on("change", function () {
        const name = $("#real-input10").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info10").text(htmlName);
    });
    $("#real-input11").on("change", function () {
        const name = $("#real-input11").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info11").text(htmlName);
    });
    $("#real-input12").on("change", function () {
        const name = $("#real-input12").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info12").text(htmlName);
    });
    $("#real-input13").on("change", function () {
        const name = $("#real-input13").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info13").text(htmlName);
    });    
});


function LoadDataViewByCode(code) {
    Get("FormularioCliente/DataByCode?Code=" + code).done(function (response) {
        $('body').loading('stop');
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
    //-   DATOS GENERALES -//
    $("#txtNombreRazonDG").val(Datos.Nombre_RazonSocialDatosGenerales);
    $("#txtDireccionDG").val(Datos.DireccionDatosGenerales);
    $("#cboPais").val(Datos.IdPaisDatosGenerales);
    $("#txtCiudadPrincipalDG").val(Datos.CiudadSedePrincipalDatosGenerales);
    $("#txtTelefonoFijoDG").val(Datos.TelefonoFijoDatosGenerales);
    $("#txtCelularDG").val(Datos.CelularDatosGenerales);
    $("#txtCorreoEnvioFacturaElectronicaDG").val(Datos.CorreoEnvioFacturaElectronicaDatosGenerales);
    $("#txtDireccionEntregaFacturaDG").val(Datos.DireccionEntregaFacturaDatosGenerales);
    $("#txtCiudadFacturaDG").val(Datos.CiudadDireccionEntregaFacturaDatosGenerales);
    $("#txtDireccionEntregaPedidoDG").val(Datos.DireccionEntregaPedidoDatosGenerales);
    $("#txtCiudadPedidoDG").val(Datos.CiudadDireccionEntregaPedidoDatosGenerales);
    $("#txtDireccionEntregaSecundarioPedidoDG").val(Datos.DireccionSecundariaEntregaPedidoDatosGenerales);
    $("#txtCiudadSecundarioPedidoDG").val(Datos.CiudadDireccionSecundariaEntregaPedidoDatosGenerales);
    //-     INFORMACIÓN DE CONTACTOS    -//
    $("#txtNombreContactoAreaCobranzaIDC1").val(Datos.NombreContactoAreaCobranza);
    $("#txtTelefonoContactoAreaCobranzaIDC1").val(Datos.TelefonoContactoAreaCobranza);
    $("#txtCorreoContactoAreaCobranzaIDC1").val(Datos.CorreoElectronicoContactoAreaCobranza);
    $("#txtNombreContactoAreaFinancieraIDC2").val(Datos.NombreContactoAreaFinanciera);
    $("#txtTelefonoContactoAreaFinancieraIDC2").val(Datos.TelefonoContactoAreaFinanciera);
    $("#txtCorreoContactoAreaFinancieraIDC2").val(Datos.CorreoContactoAreaFinanciera);
    $("#txtNombreContactoAreaComercialIDC3").val(Datos.NombreContactoAreaComercial);
    $("#txtTelefonoContactoAreaComercialIDC3").val(Datos.TelefonoContactoAreaComercial);
    $("#txtCorreoContactoAreaComercialIDC3").val(Datos.CorreoContactoAreaComercial);
    //-     INFORMACIÓN TRIBUTARIA  -//
    $("#cboTipoIdentificacionTributaria").val(Datos.IdTipoIdentificacion);
    $("#txtCualIdentificacionIT").val(Datos.CualTipoIdentificacion);
    $("#txtNumIdentificacionIT").val(Datos.NumeroIdentificacion);
    $("#cboTipoContribuyente").val(Datos.IdTipoContribuyete);
    $("#cboTipoSociedad").val(Datos.IdTipoSociedad);
    $("#txtCualSociedadIT").val(Datos.CualTipoSociedad);
    $("#cboOrigenCapital").val(Datos.IdOrigenCapital);
    $("#cboActividadEconomica").val(Datos.IdActividadEconomica);
    $("#txtCualEconomicaIT").val(Datos.CualActividadEconomica);
    $("#txtSuperIntendenciaIT").val(Datos.TitularVigiladoPorAlgunaSuperIntendencia);
    $("#txtFechaConstitucionIT").val(Datos.CFechaConstitucion);
    $("#cboRegimen").val(Datos.IdRegimen);
    //-     INFORMACIÓN ACTIVIDAD ECONÓMICA  -//
    $("#txtActividadPrincipalIAE").val(Datos.ActidadPrincipal);
    $("#txtActividadSecundariaIAE").val(Datos.ActividadSecundaria);
    //--    INFORMACION DE REPRESENTACION LEGAL -//
    $("#txtNombreRepresentanteLegalIRL").val(Datos.NombreRepresentanteLegal);
    $("#cboTipoIdenticacionLegal").val(Datos.IdTipoIdentificacion_RL);
    $("#txtNumeroIdentificacionIRL").val(Datos.NumeroIdentificacion_RL);
    $("#cboNacionalidad").val(Datos.IdNacionalidad);
    $("#txtCualIRL").val(Datos.CualNacionalidad);
    $("#txtFechaExpedicionDocumentoIRL").val(Datos.CFechaExpedicionDocumento);
    $("#txtDireccionResidenciaIRL").val(Datos.DireccionResidencia);
    $("#txtCiudadIRL").val(Datos.Ciudad_RL);
    //--    PREGUNTAS PEP -//
    if (Datos.GozaReconocimientoPublico) { $("#checkSiGozaPEP").prop("checked", true); } else { $("#checkNoGozaPEP").prop("checked", true); }
    $("#txtEspecifiqueGozaPEP").val(Datos.EspecifiqueGozaReconocimientoPublico);
    if (Datos.ManejaRecursosPublicos) { $("#checkSiManejaPEP").prop("checked", true); } else { $("#checkNoManejaPEP").prop("checked", true); }
    $("#txtEspecifiqueManejaPEP").val(Datos.EspecifiqueManejaRecursosPublicos);
    if (Datos.OcupaCargosPublicos) { $("#checkSiOcupaPEP").prop("checked", true); } else { $("#checkNoOcupaPEP").prop("checked", true); }
    $("#txtEspecifiqueOcupaPEP").val(Datos.EspecifiqueOcupaCargosPublicos);
    if (Datos.ExisteVinculoEntreUstedPersonaPublicamenteExpuesta) { $("#checkSiVinculo1PEP").prop("checked", true); } else { $("#checkNoVinculo1PEP").prop("checked", true); }
    $("#txtEspecifiqueVinculo1PEP").val(Datos.EspecifiqueExisteVinculoEntreUstedPersonaPublicamenteExpuesta);
    if (Datos.ExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed) { $("#checkSiVinculo2PEP").prop("checked", true); } else { $("#checkNoVinculo2PEP").prop("checked", true); }
    $("#txtEspecifiqueVinculo2PEP").val(Datos.EspecifiqueExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed);
    $("#txtNombreApellidoPEP").val(Datos.CasoAfirmativoEspecifiquePersonaConVinculo);
    $("#txtCargoPEP").val(Datos.Cargo);
    //--INFORMACIÓN DE SOCIOS O ACCIONISTAS(UNICAMENTE APLICA PARA PERSONAS JURIDICAS)-- - pendiente-- 
    if (Datos.DetalleInformacionSocio[0].CompañiaCuentaAccionistas) { $("#checkSiAccionistaISA").prop("checked", true); } else { $("#checkNoAccionistaISA").prop("checked", true); }
    var IndiceAccionista = 1;
    for (var i = 0; i < Datos.DetalleInformacionSocio.length; i++) {
        var NombreApellido = "#txtNombreApellidoAccionista" + IndiceAccionista + "ISA";
        var TipoId = "#txtTipoIdAccionista" + IndiceAccionista + "ISA";
        var Documento = "#txtNroDocumentoAccionista" + IndiceAccionista + "ISA";
        var Participacion = "#txtParticipacionAccionista" + IndiceAccionista + "ISA";
        var Nacionalidad = "#txtNacionalidadAccionista" + IndiceAccionista + "ISA";
        $(NombreApellido).val(Datos.DetalleInformacionSocio[i].NombreApellidoAccionistas);
        $(TipoId).val(Datos.DetalleInformacionSocio[i].TipoId);
        $(Documento).val(Datos.DetalleInformacionSocio[i].NroDocumento);
        $(Participacion).val(Datos.DetalleInformacionSocio[i].Participacion);
        $(Nacionalidad).val(Datos.DetalleInformacionSocio[i].Nacionalidad);
        IndiceAccionista++;
    }
    /*for (var i = 0; i < Datos.DetalleInformacionSocio.length; i++) {

        $("#tblDocumentos > tbody").append('<tr>' +
            '<td style="text-align: center;"> ' + Datos.DetalleInformacionSocio[i].NombreApellidoAccionistas + ' </td>' +
            '<td style="text-align: center;font-size:12pt;"> ' + Datos.DetalleInformacionSocio[i].TipoId + '</td>' +
            '<td style="text-align: center;">' + Datos.DetalleInformacionSocio[i].NroDocumento + '</td>' +
            '<td style="text-align: center;font-size:12pt;">' + Datos.DetalleInformacionSocio[i].Participacion + '</td>' +
            '<td style="text-align: center;font-size:12pt;">' + Datos.DetalleInformacionSocio[i].Nacionalidad + '</td>'
            + '</tr>');
    }*/
    //--INFORMACIÓN FINANCIERA
    
    //--REFERENCIAS COMERCIALES
    var Indice = 1;
    for (var i = 0; i < Datos.DetalleReferenciaComercial.length; i++) {
        var Empresa = "#txtEmpresa" + Indice + "RC";
        var Ruc = "#txtRuc" + Indice + "RC";
        var Telefono = "#txtTelefono" + Indice + "RC";
        var Direccion = "#txtDireccion" + Indice + "RC";
        var Ciudad = "#txtCiudad" + Indice + "RC";
        $(Empresa).val(Datos.DetalleReferenciaComercial[i].Empresa);
        $(Ruc).val(Datos.DetalleReferenciaComercial[i].Ruc);
        $(Telefono).val(Datos.DetalleReferenciaComercial[i].Telefono);
        $(Direccion).val(Datos.DetalleReferenciaComercial[i].Direccion);
        $(Ciudad).val(Datos.DetalleReferenciaComercial[i].Ciudad);
        Indice++;
    }
    //--REFERENCIAS BANCARIAS
    $("#txtInstitucionRB").val(Datos.Institucion);
    $("#txtNroCuentaRB").val(Datos.NroCuenta);
    $("#txtTipoCuentaRB").val(Datos.TipoCuenta);
    $("#txtBeneficiarioRB").val(Datos.Beneficiario);
    $("#txtEmpresaRB").val(Datos.Empresa);
    $("#txtRucRB").val(Datos.Ruc);
    $("#txtTelefonoRB").val(Datos.Telefono);
    $("#txtDireccionRB").val(Datos.Direccion);
    //--CONTROL DE DOCUMENTOS EXIGIDOS PARA INGRESO DE CLIENTES
    $("#txtFile1CDE").html(Datos.CopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual);
    $("#txtFile1CDE").attr('href', Datos.RutaCopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual);
    $("#txtFile2CDE").html(Datos.CopiasFormularioPDTAnualRentaTerceraPersonaNatual);
    $("#txtFile2CDE").attr('href', Datos.RutaCopiasFormularioPDTAnualRentaTerceraPersonaNatual);
    $("#txtFile3CDE").html(Datos.CopiaFichaRucPersonaNatual);
    $("#txtFile3CDE").attr('href', Datos.RutaCopiaFichaRucPersonaNatual);
    $("#txtFile4CDE").html(Datos.CopiaDniPersonaNatual);
    $("#txtFile4CDE").attr('href', Datos.RutaCopiaDniPersonaNatual);
    $("#txtFile5CDE").html(Datos.CertificacoReferenciaComercialPersonaNatual);
    $("#txtFile5CDE").attr('href', Datos.RutaCertificacoReferenciaComercialPersonaNatual);
    $("#txtFile6CDE").html(Datos.CertificadoBancarioPersonaNatual);
    $("#txtFile6CDE").attr('href', Datos.RutaCertificadoBancarioPersonaNatual);
    $("#txtFile7CDE").html(Datos.SituacionFinancieraBalanceGeneralPerdidasJuridicas);
    $("#txtFile7CDE").attr('href', Datos.RutaSituacionFinancieraBalanceGeneralPerdidasJuridicas);
    $("#txtFile8CDE").html(Datos.CopiaFormularioPDTAnualRentaTerceraJuridicas);
    $("#txtFile8CDE").attr('href', Datos.RutaCopiaFormularioPDTAnualRentaTerceraJuridicas);
    $("#txtFile9CDE").html(Datos.CopiaFichaRucJuridicas);
    $("#txtFile9CDE").attr('href', Datos.RutaCopiaFichaRucJuridicas);
    $("#txtFile10CDE").html(Datos.CopiaDNIRepresentanteLegalJuridicas);
    $("#txtFile10CDE").attr('href', Datos.RutaCopiaDNIRepresentanteLegalJuridicas);
    $("#txtFile11CDE").html(Datos.VigenciaPoderRepresentanteLegalJuridicas);
    $("#txtFile11CDE").attr('href', Datos.RutaVigenciaPoderRepresentanteLegalJuridicas);
    $("#txtFile12CDE").html(Datos.CertificadoReferenciaComercialJuridicas);
    $("#txtFile12CDE").attr('href', Datos.RutaCertificadoReferenciaComercialJuridicas);
    $("#txtFile13CDE").html(Datos.CertificadoBancarioJuridicas);
    $("#txtFile13CDE").attr('href', Datos.RutaCertificadoBancarioJuridicas);
    //--CLASIFICACIÓN PARA USO COMERCIAL
    $("#cboUnidad").val(Datos.Unidad);
    $("#cboSubUnidad").val(Datos.SubUnidad);
    $("#cboAsesorComercial").val(Datos.AsesorComercial);
    $("#txtDescripcion").val(Datos.Descripcion);
    //--TÉRMINOS DE PAGO
    $("#cboTipoPago").val(Datos.IdTerminoPago);
    $("#cuposolicitado").val(Datos.cupoSolicitado);
    //--VERIFICACION PARA USO EXTERNO
    $("#txtAsesorComercialVUI").val(Datos.ResponsableContratacion);
    $("#txtFirmaVUI").val(Datos.Firma);
}

function fnLoadTipoIdentificacion() {
    Get("SisInternoSelect/GetTipoIdentificacion").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            //-----------Combo para Identificacion (seccion : Representate Legal)
            var select = document.getElementById('cboTipoIdenticacionLegal');
            var options = '<option value="0">Seleccionar Tipo Identificación</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Tipo_Identificacion}">${item.Nombre_S_Tipo_Identificacion}</option>`;
            }
            select.innerHTML = options;
            //-----------Combo para Identificacion (seccion : Representate Legal)
            var select2 = document.getElementById('cboTipoIdentificacionTributaria');
            var options2 = '<option value="0">Seleccionar Tipo Identificación</option>';
            for (let item of Response) {
                options2 += `<option value="${item.Id_S_Tipo_Identificacion}">${item.Nombre_S_Tipo_Identificacion}</option>`;
            }
            select2.innerHTML = options2;
        }
    });
}

function fnLoadTipoContribuyente() {
    Get("SisInternoSelect/GetTipoContribuyente").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboTipoContribuyente');
            var options = '<option value="0">Seleccionar Tipo Contribuyente</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Tipo_Contribuyente}">${item.Nombre_S_Tipo_Contribuyente}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadTipoSociedad() {
    Get("SisInternoSelect/GetTipoSociedad").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboTipoSociedad');
            var options = '<option value="0">Seleccionar Tipo Sociedad</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Tipo_Sociedad}">${item.Nombre_S_Tipo_Sociedad}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadOrigenCapital() {
    Get("SisInternoSelect/GetOrigenCapital").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboOrigenCapital');
            var options = '<option value="0">Seleccionar Origen Capital</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Origen_Capital}">${item.Nombre_S_Origen_Capital}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

  
function fnLoadPais() {
    Get("SisInternoSelect/GetPais").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;

        //if (Response != null) {
        //    console.log(response.code);

        if (response.code == 0) {
            var select = document.getElementById('cboPais');
            var options = '<option value="">Seleccionar País</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Pais}">${item.Nombre_S_Pais}</option>`;
            }
            select.innerHTML = options;
        } else if (response.code == 3) {
            if (response.data == "SESSION_TIMEOUT") {
                fnAlertAdvertenciaSession(response.message, function () {
                    window.location = fnBaseUrlWeb("FormularioCliente/Exit");
                });
            }
        }


        //}
    });
}

function fnLoadActividadEconomica() {
    Get("SisInternoSelect/GetActividadEconomica").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboActividadEconomica');
            var options = '<option value="0">Seleccionar Actividad Economica</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Actividad_Economica}">${item.Nombre_S_Actividad_Economica}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadRegimen() {
    Get("SisInternoSelect/GetRegimen").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboRegimen');
            var options = '<option value="0">Seleccionar Regimen</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Regimen}">${item.Nombre_S_Regimen}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadNacionalidad() {
    Get("SisInternoSelect/GetNacionalidad").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboNacionalidad');
            var options = '<option value="0">Seleccionar Nacionalidad</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Nacionalidad}">${item.Nombre_S_Nacionalidad}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadBiociencias() {
    Get("SisInternoSelect/GetBiociencias").done(function (response) {
        $('body').loading('stop');
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

 

function fnLoadAsesorComercial() {
    Get("SisInternoSelect/GetAsesorComercial").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboAsesorComercial');
            var options = '<option value="0">Seleccionar Asesor Comercial</option>';
            for (let item of Response) {
                options += `<option value="${item.Id_S_Asesor_Comercial}">${item.Nombre_S_Asesor_Comercial}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadUnidad() {
    Get("SisInternoSelect/GetUnidad").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboUnidad');
            var options = '<option value="0">Seleccionar Unidad</option>';
            for (let item of Response) {
                options += `<option value="${item.IdUnidad}">${item.DescripcionUnidad}</option>`;
            }
            select.innerHTML = options;
        }
    });
}

function fnLoadTipoPago() {
    Get("SisInternoSelect/GetTipoPago").done(function (response) {
        $('body').loading('stop');
        var Response = response.data.Data;
        if (Response != null) {
            var select = document.getElementById('cboTipoPago');
            var options = '<option value="0">Seleccionar Tipo Pago</option>';
            for (let item of Response) {
                options += `<option value="${item.IdTipoPago}">${item.Descripcion}</option>`;
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
    if (!fnValidFormularioDG()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Datos Generales.");
        return;
    }
    //---- INFORMACION DE CONTACTOS (IDC)
    if (!fnValidFormularioIDC()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información De Contactos.");
        return;
    }
    //---- INFORMACION TRIBUTARIA (IT)
    if (!fnValidFormularioIT()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información Tributaria.");
        return;
    }
    //----- INFORMACION ACTIVIDAD ECONOMICA (IAE)
    if (!fnValidFormularioIAE()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información Actividad Económica.");
        return;
    }
    //----- INFORMACION REPRESENTANTE LEGAL(IRL)
    if (!fnValidFormularioIRL()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información Representación Legal.");
        return;
    }
    //----- PREGUNTAS PEP(PEP)
    if (!fnValidFormularioPEP()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Preguntas PEP.");
        return;
    }
    //----- INFORMACION DE SOCIOS O ACCIONISTAS(ISA)
    if (!fnValidFormularioISA()) {
        fnAlertAdvertencia("Debe llenar los campos de Información de Socios o Accionistas, Minimo 2 filas y los datos obligatorios(*).");
        return;
    }
    //------- INFORMACION FINANCIERA (IF)
    if (!fnValidFormularioIF()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Información Financiera.");
        return;
    }
    //------  REFERENCIAS COMERCIALES (RC)
    if (!fnValidFormularioRC()) {
        fnAlertAdvertencia("Debe llenar los campos de Referencias Comerciales.");
        return;
    }
    //------  REFERENCIAS BANCARIAS (RB)
    if (!fnValidFormularioRB()) {
        fnAlertAdvertencia("Debe llenar los campos de Referencias Bancarias, minimo la primera fila.");
        return;
    }
    //------  CONTROL DE DOCUMENTOS EXIGIDOS PARA INGRESO DE CLIENTES (CDE)
    if (!fnValidFormularioCDE()) {
        //fnAlertAdvertencia("Debe subir archivo de los datos obligatorios (*) en Control de Documentos Exigidos para Ingreso de Clientes.");
        fnAlertAdvertencia("Debe subir archivo de los datos obligatorios (*) Ya sea Personas Naturales o Persona Juridicas.");
        return;
    }
    //------    CLASIFICACION PARA USO COMERCIAL (CUC)
    if (!fnValidFormularioCUC()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Clasificación para uso Comercial.");
        return;
    }
    //------    TERMINOS DE PAGO (TP)
    if (!fnValidFormularioTP()) {
        fnAlertAdvertencia("Debe llenar los datos de Términos de Pago.");
        return;
    }
    //----- VERIFICACION PARA USO INTERNO (VUI)
    if (!fnValidFormularioVUI()) {
        fnAlertAdvertencia("Debe llenar los datos obligatorios (*) de Verificación para uso Interno.");
        return;
    }

    fnGuardarFormularioCliente();

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
            Rpta = false;
        }
        if ($("#txtNombreApellidoAccionista2ISA").val() == '' || $("#txtTipoIdAccionista2ISA").val() == '' || $("#txtNroDocumentoAccionista2ISA").val() == '' || $("#txtParticipacionAccionista2ISA").val() == '' || $("#txtNacionalidadAccionista2ISA").val() == '') {
            Rpta = false;
        }
    }
    return Rpta;
}

function fnValidFormularioIF() {
    var Rpta = true;
    
    return Rpta;
}

function fnValidFormularioRC() {
    Rpta = true;
    if ($("#txtEmpresa1RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtRuc1RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtTelefono1RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtDireccion1RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtCiudad1RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtEmpresa2RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtRuc2RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtTelefono2RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtDireccion2RC").val() == '') {
        Rpta = false;
    }
    if ($("#txtCiudad2RC").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioRB() {
    var Rpta = true;
    if ($("#txtInstitucionRB").val() == '') {
        Rpta = false;
    }
    if ($("#txtNroCuentaRB").val() == '') {
        Rpta = false;
    }
    if ($("#txtTipoCuentaRB").val() == '') {
        Rpta = false;
    }
    if ($("#txtBeneficiarioRB").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioCDE() {
    var Rpta = true;
    if ($("#real-input1").val() == '' || $("#real-input3").val() == '' || $("#real-input4").val() == '') {
        if ($("#real-input7").val() == '' || $("#real-input8").val() == '' || $("#real-input9").val() == '' || $("#real-input10").val() == '') {
            Rpta = false;
        }
    }
    return Rpta;
}

function fnValidFormularioCUC() {
    var Rpta = true;
    if ($("#cboUnidad").val() == '') {
        Rpta = false;
    }
    if ($("#cboSubUnidad").val() == '') {
        Rpta = false;
    }
    if ($("#cboAsesorComercial").val() == '') {
        Rpta = false;
    }
    if ($("#txtDescripcion").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioTP() {
    var Rpta = true;
    if ($("#cboTipoPago").val() == '') {
        Rpta = false;
    }
    if ($("#cuposolicitado").val() == '') {
        Rpta = false;
    }
    return Rpta;
}

function fnValidFormularioVUI() {
    var Rpta = true;
    if ($("#txtAsesorComercialVUI").val() == '') {
        Rpta = false;
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
//--------ISA CHECKBOX TRUE O FALSE---------

//#region IF CHECKBOC
$("#checkSolesIF").on("change", function () {
    fnLimpiarCamposIF();
    if (this.checked) {
        $("#checkDolaresIF").prop("checked", false);
        fnPlaceholderSolesIf();
    }
    else {
        $("#checkDolaresIF").prop("checked", true);
        fnPlaceholderDolaresIf();
    }
});

$("#checkDolaresIF").on("change", function () {
    fnLimpiarCamposIF();
     
});

function fnLimpiarCamposIF() {
     
}

function fnPlaceholderSolesIf() {
  
}

function fnPlaceholderDolaresIf() {
    
}

//#endregion
///-------FIN ISA CHECKBOX TRUE O FALSE-------


function fnGuardarFormularioCliente() {
    console.log(code);
    console.log("entro fncion guardar");
    //DG()
    var NombreRazonSocialDG = $("#txtNombreRazonDG").val();
    var DireccionDG = $("#txtDireccionDG").val();
    var PaisId = $("#cboPais").val();
    var CiudadPrinciaplDDG = $("#txtCiudadPrincipalDG").val();
    var TelefonoFijoDG = $("#txtTelefonoFijoDG").val();
    var CelularDG = $("#txtCelularDG").val();

    var CorreoElecontronicoDG = $("#txtCorreoEnvioFacturaElectronicaDG").val();
    var DireccionFacturaDG = $("#txtDireccionEntregaFacturaDG").val();
    var CiudadFacturaDG = $("#txtCiudadFacturaDG").val();
    var DireccionPedidoDG = $("#txtDireccionEntregaPedidoDG").val();
    var CiudadPedidoDG = $("#txtCiudadPedidoDG").val();
    var DireccionPedidoSecundarioDG = $("#txtDireccionEntregaSecundarioPedidoDG").val();
    var CiudadPedidoSecundarioDG = $("#txtCiudadSecundarioPedidoDG").val();
    //IC()
    var NombreContactoAreaCobranza = $("#txtNombreContactoAreaCobranzaIDC1").val();
    var TelefonoContactoAreaCobranza = $("#txtTelefonoContactoAreaCobranzaIDC1").val();
    var CorreoContactoAreaCobranza = $("#txtCorreoContactoAreaCobranzaIDC1").val();
    var NombreContactoAreaFinanciera = $("#txtNombreContactoAreaFinancieraIDC2").val();
    var TelefonoContactoAreaFinanciera = $("#txtTelefonoContactoAreaFinancieraIDC2").val();
    var CorreoContactoAreaFinanciera = $("#txtCorreoContactoAreaFinancieraIDC2").val();
    var NombreContactoAreaComercial = $("#txtNombreContactoAreaComercialIDC3").val();
    var TelefonoContactoAreaComercial = $("#txtTelefonoContactoAreaComercialIDC3").val();
    var CorreoContactoAreaComercial = $("#txtCorreoContactoAreaComercialIDC3").val();
    //IT()
    var TipoIdentificacionIdIT = $("#cboTipoIdentificacionTributaria").val();
    var CualIdentificacionIT = $("#txtCualIdentificacionIT").val();
    var NumeroIdentificacionIT = $("#txtNumIdentificacionIT").val();
    var cboTipoContribuyente = $("#cboTipoContribuyente").val();
    var cboTipoSociedad = $("#cboTipoSociedad").val();
    var txtCualSociedadIT = $("#txtCualSociedadIT").val();
    var cboOrigenCapital = $("#cboOrigenCapital").val();
    var cboActividadEconomica = $("#cboActividadEconomica").val();
    var txtCualEconomicaIT = $("#txtCualEconomicaIT").val();
    var txtSuperIntendenciaIT = $("#txtSuperIntendenciaIT").val();
    var txtFechaConstitucionIT = $("#txtFechaConstitucionIT").val();
    var cboRegimen = $("#cboRegimen").val();
    //INFORMACION AE()
    var txtActividadPrincipalIAE = $("#txtActividadPrincipalIAE").val();
    var txtActividadSecundariaIAE = $("#txtActividadSecundariaIAE").val();
    //informacion representante legal()
    var txtNombreRepresentanteLegalIRL = $("#txtNombreRepresentanteLegalIRL").val();
    var cboTipoIdenticacionLegal = $("#cboTipoIdenticacionLegal").val();
    var txtNumeroIdentificacionIRL = $("#txtNumeroIdentificacionIRL").val();
    var cboNacionalidad = $("#cboNacionalidad").val();
    var txtCualIRL = $("#txtCualIRL").val();
    var txtFechaExpedicionDocumentoIRL = $("#txtFechaExpedicionDocumentoIRL").val();
    var txtDireccionResidenciaIRL = $("#txtDireccionResidenciaIRL").val();
    var txtCiudadIRL = $("#txtCiudadIRL").val();
    //preguntas pep (persona publicamente expuesta)
    var checkGozaPEP = false;
    if (document.getElementById("checkSiGozaPEP").checked) { checkGozaPEP = true }
    var txtEspecifiqueGozaPEP = $("#txtEspecifiqueGozaPEP").val();
    var checkManejaPEP = false;
    if (document.getElementById("checkSiManejaPEP").checked) { checkManejaPEP = true }
    var txtEspecifiqueManejaPEP = $("#txtEspecifiqueManejaPEP").val();
    var checkOcupaPEP = false;
    if (document.getElementById("checkSiOcupaPEP").checked) { checkOcupaPEP = true }
    var txtEspecifiqueOcupaPEP = $("#txtEspecifiqueOcupaPEP").val();
    var checkVinculo1PEP = false;
    if (document.getElementById("checkSiVinculo1PEP").checked) { checkVinculo1PEP = true }
    var txtEspecifiqueVinculo1PEP = $("#txtEspecifiqueVinculo1PEP").val();
    var checkVinculo2PEP = false
    if (document.getElementById("checkSiVinculo2PEP").checked) { checkVinculo2PEP = true }
    var txtEspecifiqueVinculo2PEP = $("#txtEspecifiqueVinculo2PEP").val();
    var txtNombreApellidoPEP = $("#txtNombreApellidoPEP").val();
    var txtCargoPEP = $("#txtCargoPEP").val();
    //informacion socios o accionistas
    var checkAccionistaISA = false;
    if (document.getElementById("checkSiAccionistaISA").checked) { checkAccionistaISA = true }
    var txtNombreApellidoAccionista1ISA = $("#txtNombreApellidoAccionista1ISA").val();
    var txtTipoIdAccionista1ISA = $("#txtTipoIdAccionista1ISA").val();
    var txtNroDocumentoAccionista1ISA = $("#txtNroDocumentoAccionista1ISA").val();
    var txtParticipacionAccionista1ISA = $("#txtParticipacionAccionista1ISA").val();
    var txtNacionalidadAccionista1ISA = $("#txtNacionalidadAccionista1ISA").val();
    var txtNombreApellidoAccionista2ISA = $("#txtNombreApellidoAccionista2ISA").val();
    var txtTipoIdAccionista2ISA = $("#txtTipoIdAccionista2ISA").val();
    var txtNroDocumentoAccionista2ISA = $("#txtNroDocumentoAccionista2ISA").val();
    var txtParticipacionAccionista2ISA = $("#txtParticipacionAccionista2ISA").val();
    var txtNacionalidadAccionista2ISA = $("#txtNacionalidadAccionista2ISA").val();
    var txtNombreApellidoAccionista3ISA = $("#txtNombreApellidoAccionista3ISA").val();
    var txtTipoIdAccionista3ISA = $("#txtTipoIdAccionista3ISA").val();
    var txtNroDocumentoAccionista3ISA = $("#txtNroDocumentoAccionista3ISA").val();
    var txtParticipacionAccionista3ISA = $("#txtParticipacionAccionista3ISA").val();
    var txtNacionalidadAccionista3ISA = $("#txtNacionalidadAccionista3ISA").val();
    var txtNombreApellidoAccionista4ISA = $("#txtNombreApellidoAccionista4ISA").val();
    var txtTipoIdAccionista4ISA = $("#txtTipoIdAccionista4ISA").val();
    var txtNroDocumentoAccionista4ISA = $("#txtNroDocumentoAccionista4ISA").val();
    var txtParticipacionAccionista4ISA = $("#txtParticipacionAccionista4ISA").val();
    var txtNacionalidadAccionista4ISA = $("#txtNacionalidadAccionista4ISA").val();
    //INFORMACIÓN FINANCIERA
     
    //Referencias Comerciales
    var txtEmpresa1RC = $("#txtEmpresa1RC").val();
    var txtRuc1RC = $("#txtRuc1RC").val();
    var txtTelefono1RC = $("#txtTelefono1RC").val();
    var txtDireccion1RC = $("#txtDireccion1RC").val();
    var txtCiudad1RC = $("#txtCiudad1RC").val();
    var txtEmpresa2RC = $("#txtEmpresa2RC").val();
    var txtRuc2RC = $("#txtRuc2RC").val();
    var txtTelefono2RC = $("#txtTelefono2RC").val();
    var txtDireccion2RC = $("#txtDireccion2RC").val();
    var txtCiudad2RC = $("#txtCiudad2RC").val();
    //Referencias BANCARIAS
    var txtInstitucionRB = $("#txtInstitucionRB").val();
    var txtNroCuentaRB = $("#txtNroCuentaRB").val();
    var txtTipoCuentaRB = $("#txtTipoCuentaRB").val();
    var txtBeneficiarioRB = $("#txtBeneficiarioRB").val();
    var txtEmpresaRB = $("#txtEmpresaRB").val();
    var txtRucRB = $("#txtRucRB").val();
    var txtTelefonoRB = $("#txtTelefonoRB").val();
    var txtDireccionRB = $("#txtDireccionRB").val();
    //Clasificación para uso Comercial CUC
    var cboUnidad = $("#cboUnidad").val();
    var cboSubUnidad = $("#cboSubUnidad").val();
    var cboAsesorComercial = $("#cboAsesorComercial").val();
    var txtDescripcion = $("#txtDescripcion").val();
    //Terminos de pago  
    var cboTipoPago = $("#cboTipoPago").val();
    var cuposolicitado = $("#cuposolicitado").val();
    //Verificacion=  
    var txtAsesorComercialVUI = $("#txtAsesorComercialVUI").val();
    // Control de Documentos 
    var file1 = $("#real-input1")[0].files;
    console.log(file1);
    var file2 = $("#real-input2")[0].files;
    console.log(file2);
    var file3 = $("#real-input3")[0].files;
    console.log(file3);
    var file4 = $("#real-input4")[0].files;
    console.log(file4);
    var file5 = $("#real-input5")[0].files;
    console.log(file5);
    var file6 = $("#real-input6")[0].files;
    console.log(file6);
    var file7 = $("#real-input7")[0].files;
    console.log(file7);
    var file8 = $("#real-input8")[0].files;
    console.log(file8);
    var file9 = $("#real-input9")[0].files;
    console.log(file9);
    var file10 = $("#real-input10")[0].files;
    console.log(file10);
    var file11 = $("#real-input11")[0].files;
    console.log(file11);
    var file12 = $("#real-input12")[0].files;
    console.log(file12);
    var file13 = $("#real-input13")[0].files;
    console.log(file13);

    var fdata = new FormData();

    fdata.append("FormFile1", file1[0]);
    fdata.append("FormFile2", file2[0]);
    fdata.append("FormFile3", file3[0]);
    fdata.append("FormFile4", file4[0]);
    fdata.append("FormFile5", file5[0]);
    fdata.append("FormFile6", file6[0]);
    fdata.append("FormFile7", file7[0]);
    fdata.append("FormFile8", file8[0]);
    fdata.append("FormFile9", file9[0]);
    fdata.append("FormFile10", file10[0]);
    fdata.append("FormFile11", file11[0]);
    fdata.append("FormFile12", file12[0]);
    fdata.append("FormFile13", file13[0]);
    //perfil

    fdata.append("IdPerfil", $("#perfil").val());

    //DG()
    fdata.append("NombreRazonSocialDG", NombreRazonSocialDG);
    fdata.append("DireccionDG", DireccionDG);
    fdata.append("PaisId", PaisId);
    fdata.append("CiudadPrinciaplDDG", CiudadPrinciaplDDG);
    fdata.append("TelefonoFijoDG", TelefonoFijoDG);
    fdata.append("CelularDG", CelularDG);
    fdata.append("CorreoElecontronicoDG", CorreoElecontronicoDG);
    fdata.append("DireccionFacturaDG", DireccionFacturaDG);
    fdata.append("CiudadFacturaDG", CiudadFacturaDG);
    fdata.append("DireccionPedidoDG", DireccionPedidoDG);
    fdata.append("CiudadPedidoDG", CiudadPedidoDG);
    fdata.append("DireccionPedidoSecundarioDG", DireccionPedidoSecundarioDG);
    fdata.append("CiudadPedidoSecundarioDG", CiudadPedidoSecundarioDG);
    //IC()
    fdata.append("NombreContactoAreaCobranza", NombreContactoAreaCobranza);
    fdata.append("TelefonoContactoAreaCobranza", TelefonoContactoAreaCobranza);
    fdata.append("CorreoContactoAreaCobranza", CorreoContactoAreaCobranza);
    fdata.append("NombreContactoAreaFinanciera", NombreContactoAreaFinanciera);
    fdata.append("TelefonoContactoAreaFinanciera", TelefonoContactoAreaFinanciera);
    fdata.append("CorreoContactoAreaFinanciera", CorreoContactoAreaFinanciera);
    fdata.append("NombreContactoAreaComercial", NombreContactoAreaComercial);
    fdata.append("TelefonoContactoAreaComercial", TelefonoContactoAreaComercial);
    fdata.append("CorreoContactoAreaComercial", CorreoContactoAreaComercial);
    //IT()
    fdata.append("TipoIdentificacionIdIT", TipoIdentificacionIdIT);
    fdata.append("CualIdentificacionIT", CualIdentificacionIT);
    fdata.append("NumeroIdentificacionIT", NumeroIdentificacionIT);
    fdata.append("cboTipoContribuyente", cboTipoContribuyente);
    fdata.append("cboTipoSociedad", cboTipoSociedad);
    fdata.append("txtCualSociedadIT", txtCualSociedadIT);
    fdata.append("cboOrigenCapital", cboOrigenCapital);
    fdata.append("cboActividadEconomica", cboActividadEconomica);
    fdata.append("txtCualEconomicaIT", txtCualEconomicaIT);
    fdata.append("txtSuperIntendenciaIT", txtSuperIntendenciaIT);
    fdata.append("txtFechaConstitucionIT", txtFechaConstitucionIT);
    fdata.append("cboRegimen", cboRegimen);
    //INFORMACION AE()
    fdata.append("txtActividadPrincipalIAE", txtActividadPrincipalIAE);
    fdata.append("txtActividadSecundariaIAE", txtActividadSecundariaIAE);
    //informacion representante legal()
    fdata.append("txtNombreRepresentanteLegalIRL", txtNombreRepresentanteLegalIRL);
    fdata.append("cboTipoIdenticacionLegal", cboTipoIdenticacionLegal);
    fdata.append("txtNumeroIdentificacionIRL", txtNumeroIdentificacionIRL);
    fdata.append("cboNacionalidad", cboNacionalidad);
    fdata.append("txtCualIRL", txtCualIRL);
    fdata.append("txtFechaExpedicionDocumentoIRL", txtFechaExpedicionDocumentoIRL);
    fdata.append("txtDireccionResidenciaIRL", txtDireccionResidenciaIRL);
    fdata.append("txtCiudadIRL", txtCiudadIRL);
    //preguntas pep (persona publicamente expuesta)
    fdata.append("checkGozaPEP", checkGozaPEP);
    fdata.append("txtEspecifiqueGozaPEP", txtEspecifiqueGozaPEP);
    fdata.append("checkManejaPEP", checkManejaPEP);
    fdata.append("txtEspecifiqueManejaPEP", txtEspecifiqueManejaPEP);
    fdata.append("checkOcupaPEP", checkOcupaPEP);
    fdata.append("txtEspecifiqueOcupaPEP", txtEspecifiqueOcupaPEP);
    fdata.append("checkVinculo1PEP", checkVinculo1PEP);
    fdata.append("txtEspecifiqueVinculo1PEP", txtEspecifiqueVinculo1PEP);
    fdata.append("checkVinculo2PEP", checkVinculo2PEP);
    fdata.append("txtEspecifiqueVinculo2PEP", txtEspecifiqueVinculo2PEP);
    fdata.append("txtNombreApellidoPEP", txtNombreApellidoPEP);
    fdata.append("txtCargoPEP", txtCargoPEP);
    //informacion socios o accionistas
    fdata.append("checkAccionistaISA", checkAccionistaISA);
    fdata.append("txtNombreApellidoAccionista1ISA", txtNombreApellidoAccionista1ISA);
    fdata.append("txtTipoIdAccionista1ISA", txtTipoIdAccionista1ISA);
    fdata.append("txtNroDocumentoAccionista1ISA", txtNroDocumentoAccionista1ISA);
    fdata.append("txtParticipacionAccionista1ISA", txtParticipacionAccionista1ISA);
    fdata.append("txtNacionalidadAccionista1ISA", txtNacionalidadAccionista1ISA);
    fdata.append("txtNombreApellidoAccionista2ISA", txtNombreApellidoAccionista2ISA);
    fdata.append("txtTipoIdAccionista2ISA", txtTipoIdAccionista2ISA);
    fdata.append("txtNroDocumentoAccionista2ISA", txtNroDocumentoAccionista2ISA);
    fdata.append("txtParticipacionAccionista2ISA", txtParticipacionAccionista2ISA);
    fdata.append("txtNacionalidadAccionista2ISA", txtNacionalidadAccionista2ISA);
    fdata.append("txtNombreApellidoAccionista3ISA", txtNombreApellidoAccionista3ISA);
    fdata.append("txtTipoIdAccionista3ISA", txtTipoIdAccionista3ISA);
    fdata.append("txtNroDocumentoAccionista3ISA", txtNroDocumentoAccionista3ISA);
    fdata.append("txtParticipacionAccionista3ISA", txtParticipacionAccionista3ISA);
    fdata.append("txtNacionalidadAccionista3ISA", txtNacionalidadAccionista3ISA);
    fdata.append("txtNombreApellidoAccionista4ISA", txtNombreApellidoAccionista4ISA);
    fdata.append("txtTipoIdAccionista4ISA", txtTipoIdAccionista4ISA);
    fdata.append("txtNroDocumentoAccionista4ISA", txtNroDocumentoAccionista4ISA);
    fdata.append("txtParticipacionAccionista4ISA", txtParticipacionAccionista4ISA);
    fdata.append("txtNacionalidadAccionista4ISA", txtNacionalidadAccionista4ISA);
    //INFORMACIÓN FINANCIERA
    
    //Referencias Comerciales
    fdata.append("txtEmpresa1RC", txtEmpresa1RC);
    fdata.append("txtRuc1RC", txtRuc1RC);
    fdata.append("txtTelefono1RC", txtTelefono1RC);
    fdata.append("txtDireccion1RC", txtDireccion1RC);
    fdata.append("txtCiudad1RC", txtCiudad1RC);
    fdata.append("txtEmpresa2RC", txtEmpresa2RC);
    fdata.append("txtRuc2RC", txtRuc2RC);
    fdata.append("txtTelefono2RC", txtTelefono2RC);
    fdata.append("txtDireccion2RC", txtDireccion2RC);
    fdata.append("txtCiudad2RC", txtCiudad2RC);
    //Referencias BANCARIAS
    fdata.append("txtInstitucionRB", txtInstitucionRB);
    fdata.append("txtNroCuentaRB", txtNroCuentaRB);
    fdata.append("txtTipoCuentaRB", txtTipoCuentaRB);
    fdata.append("txtBeneficiarioRB", txtBeneficiarioRB);
    fdata.append("txtEmpresaRB", txtEmpresaRB);
    fdata.append("txtRucRB", txtRucRB);
    fdata.append("txtTelefonoRB", txtTelefonoRB);
    fdata.append("txtDireccionRB", txtDireccionRB);
    //Clasificación para uso Comercial
    fdata.append("cboUnidad", cboUnidad);
    fdata.append("cboSubUnidad", cboSubUnidad);
    fdata.append("cboAsesorComercial", cboAsesorComercial);
    fdata.append("txtDescripcion", txtDescripcion);
    //Terminos de pago  
    fdata.append("cboTipoPago", cboTipoPago);
    fdata.append("cuposolicitado", cuposolicitado);
    //Verificacion=  
    fdata.append("txtAsesorComercialVUI", txtAsesorComercialVUI);
    fdata.append("CodeCliente", code);

    if (validateExtension(file1) && validateExtension(file2) && validateExtension(file3) && validateExtension(file4) &&
        validateExtension(file5) && validateExtension(file6) && validateExtension(file7) && validateExtension(file8) &&
        validateExtension(file9) && validateExtension(file10) && validateExtension(file11) && validateExtension(file12) &&
        validateExtension(file13)) {
        var parametros = new Object();
        parametros.data = fdata;
        PostUpload("FormularioCliente/GuardarFormularioCliente", fdata).done(function (response) {
            $('body').loading('stop');
            if (response.code == 0) {
                fnAlertSuccess(response.message, function () {
                    window.location = fnBaseUrlWeb("Main/BandejaComercial");
                });
                console.log(response.data);
            } else if (response.code == 3) {
                if (response.data == "SESSION_TIMEOUT") {
                    fnAlertAdvertenciaSession(response.message, function () {
                        window.location = fnBaseUrlWeb("FormularioCliente/Exit");
                    });
                }
            } else {
                fnAlertError(response.message);
            }
        });
    }
    else {
        fnAlertAdvertencia("No Ingreso Un Formato JPG O PNG O PDF");
    }

}

function validateExtension(file) {
    console.log(file);

    if (file != null
        && file.length > 0) {

        var extension = "";
        var extxml = file[0].type;
        var extxml2 = extxml.split("/");
        console.log(extxml);
        var extensionpdf = "";
        var extpdf = file[0].type;
        var extpdf2 = extpdf.split("/");

        if (extxml2.length >= 1 && extpdf2.length > 1) {
            extension = extxml2[1];
            extensionpdf = extpdf2[1];
            console.log(extension);

            if (extension.toUpperCase() == "JPG" || extension.toUpperCase() == "JPEG" || extension.toUpperCase() == "PNG" ||
                extensionpdf.toUpperCase() == "PDF" || extensionpdf.toUpperCase() == "pdf") {

                return true;
            }
            else {
                return false;
            }
        }
        else {
            return false;
        }
    }
    else {
        return true;
    }
}

function fnEnviarFormularioCliente() {
    console.log("entro fncion guardar");
    //DG()
    var NombreRazonSocialDG = $("#txtNombreRazonDG").val();
    var DireccionDG = $("#txtDireccionDG").val();
    var PaisId = $("#cboPais").val();
    var CiudadPrinciaplDDG = $("#txtCiudadPrincipalDG").val();
    var TelefonoFijoDG = $("#txtTelefonoFijoDG").val();
    var CelularDG = $("#txtCelularDG").val();
    var CorreoElecontronicoDG = $("#txtCorreoEnvioFacturaElectronicaDG").val();
    var DireccionFacturaDG = $("#txtDireccionEntregaFacturaDG").val();
    var CiudadFacturaDG = $("#txtCiudadFacturaDG").val();
    var DireccionPedidoDG = $("#txtDireccionEntregaPedidoDG").val();
    var CiudadPedidoDG = $("#txtCiudadPedidoDG").val();
    var DireccionPedidoSecundarioDG = $("#txtDireccionEntregaSecundarioPedidoDG").val();
    var CiudadPedidoSecundarioDG = $("#txtCiudadSecundarioPedidoDG").val();
    //IC()
    var NombreContactoAreaCobranza = $("#txtNombreContactoAreaCobranzaIDC1").val();
    var TelefonoContactoAreaCobranza = $("#txtTelefonoContactoAreaCobranzaIDC1").val();
    var CorreoContactoAreaCobranza = $("#txtCorreoContactoAreaCobranzaIDC1").val();
    var NombreContactoAreaFinanciera = $("#txtNombreContactoAreaFinancieraIDC2").val();
    var TelefonoContactoAreaFinanciera = $("#txtTelefonoContactoAreaFinancieraIDC2").val();
    var CorreoContactoAreaFinanciera = $("#txtCorreoContactoAreaFinancieraIDC2").val();
    var NombreContactoAreaComercial = $("#txtNombreContactoAreaComercialIDC3").val();
    var TelefonoContactoAreaComercial = $("#txtTelefonoContactoAreaComercialIDC3").val();
    var CorreoContactoAreaComercial = $("#txtCorreoContactoAreaComercialIDC3").val();
    //IT()
    var TipoIdentificacionIdIT = $("#cboTipoIdentificacionTributaria").val();
    var CualIdentificacionIT = $("#txtCualIdentificacionIT").val();
    var NumeroIdentificacionIT = $("#txtNumIdentificacionIT").val();
    var cboTipoContribuyente = $("#cboTipoContribuyente").val();
    var cboTipoSociedad = $("#cboTipoSociedad").val();
    var txtCualSociedadIT = $("#txtCualSociedadIT").val();
    var cboOrigenCapital = $("#cboOrigenCapital").val();
    var cboActividadEconomica = $("#cboActividadEconomica").val();
    var txtCualEconomicaIT = $("#txtCualEconomicaIT").val();
    var txtSuperIntendenciaIT = $("#txtSuperIntendenciaIT").val();
    var txtFechaConstitucionIT = $("#txtFechaConstitucionIT").val();
    var cboRegimen = $("#cboRegimen").val();
    //INFORMACION AE()
    var txtActividadPrincipalIAE = $("#txtActividadPrincipalIAE").val();
    var txtActividadSecundariaIAE = $("#txtActividadSecundariaIAE").val();
    //informacion representante legal()
    var txtNombreRepresentanteLegalIRL = $("#txtNombreRepresentanteLegalIRL").val();
    var cboTipoIdenticacionLegal = $("#cboTipoIdenticacionLegal").val();
    var txtNumeroIdentificacionIRL = $("#txtNumeroIdentificacionIRL").val();
    var cboNacionalidad = $("#cboNacionalidad").val();
    var txtCualIRL = $("#txtCualIRL").val();
    var txtFechaExpedicionDocumentoIRL = $("#txtFechaExpedicionDocumentoIRL").val();
    var txtDireccionResidenciaIRL = $("#txtDireccionResidenciaIRL").val();
    var txtCiudadIRL = $("#txtCiudadIRL").val();
    //preguntas pep (persona publicamente expuesta)
    var checkGozaPEP = false;
    if (document.getElementById("checkSiGozaPEP").checked) { checkGozaPEP = true }
    var txtEspecifiqueGozaPEP = $("#txtEspecifiqueGozaPEP").val();
    var checkManejaPEP = false;
    if (document.getElementById("checkSiManejaPEP").checked) { checkManejaPEP = true }
    var txtEspecifiqueManejaPEP = $("#txtEspecifiqueManejaPEP").val();
    var checkOcupaPEP = false;
    if (document.getElementById("checkSiOcupaPEP").checked) { checkOcupaPEP = true }
    var txtEspecifiqueOcupaPEP = $("#txtEspecifiqueOcupaPEP").val();
    var checkVinculo1PEP = false;
    if (document.getElementById("checkSiVinculo1PEP").checked) { checkVinculo1PEP = true }
    var txtEspecifiqueVinculo1PEP = $("#txtEspecifiqueVinculo1PEP").val();
    var checkVinculo2PEP = false
    if (document.getElementById("checkSiVinculo2PEP").checked) { checkVinculo2PEP = true }
    var txtEspecifiqueVinculo2PEP = $("#txtEspecifiqueVinculo2PEP").val();
    var txtNombreApellidoPEP = $("#txtNombreApellidoPEP").val();
    var txtCargoPEP = $("#txtCargoPEP").val();
    //informacion socios o accionistas
    var checkAccionistaISA = false;
    if (document.getElementById("checkSiAccionistaISA").checked) { checkAccionistaISA = true }
    var txtNombreApellidoAccionista1ISA = $("#txtNombreApellidoAccionista1ISA").val();
    var txtTipoIdAccionista1ISA = $("#txtTipoIdAccionista1ISA").val();
    var txtNroDocumentoAccionista1ISA = $("#txtNroDocumentoAccionista1ISA").val();
    var txtParticipacionAccionista1ISA = $("#txtParticipacionAccionista1ISA").val();
    var txtNacionalidadAccionista1ISA = $("#txtNacionalidadAccionista1ISA").val();
    var txtNombreApellidoAccionista2ISA = $("#txtNombreApellidoAccionista2ISA").val();
    var txtTipoIdAccionista2ISA = $("#txtTipoIdAccionista2ISA").val();
    var txtNroDocumentoAccionista2ISA = $("#txtNroDocumentoAccionista2ISA").val();
    var txtParticipacionAccionista2ISA = $("#txtParticipacionAccionista2ISA").val();
    var txtNacionalidadAccionista2ISA = $("#txtNacionalidadAccionista2ISA").val();
    var txtNombreApellidoAccionista3ISA = $("#txtNombreApellidoAccionista3ISA").val();
    var txtTipoIdAccionista3ISA = $("#txtTipoIdAccionista3ISA").val();
    var txtNroDocumentoAccionista3ISA = $("#txtNroDocumentoAccionista3ISA").val();
    var txtParticipacionAccionista3ISA = $("#txtParticipacionAccionista3ISA").val();
    var txtNacionalidadAccionista3ISA = $("#txtNacionalidadAccionista3ISA").val();
    var txtNombreApellidoAccionista4ISA = $("#txtNombreApellidoAccionista4ISA").val();
    var txtTipoIdAccionista4ISA = $("#txtTipoIdAccionista4ISA").val();
    var txtNroDocumentoAccionista4ISA = $("#txtNroDocumentoAccionista4ISA").val();
    var txtParticipacionAccionista4ISA = $("#txtParticipacionAccionista4ISA").val();
    var txtNacionalidadAccionista4ISA = $("#txtNacionalidadAccionista4ISA").val();
    //INFORMACIÓN FINANCIERA
   
    //Referencias Comerciales
    var txtEmpresa1RC = $("#txtEmpresa1RC").val();
    var txtRuc1RC = $("#txtRuc1RC").val();
    var txtTelefono1RC = $("#txtTelefono1RC").val();
    var txtDireccion1RC = $("#txtDireccion1RC").val();
    var txtCiudad1RC = $("#txtCiudad1RC").val();
    var txtEmpresa2RC = $("#txtEmpresa2RC").val();
    var txtRuc2RC = $("#txtRuc2RC").val();
    var txtTelefono2RC = $("#txtTelefono2RC").val();
    var txtDireccion2RC = $("#txtDireccion2RC").val();
    var txtCiudad2RC = $("#txtCiudad2RC").val();
    //Referencias BANCARIAS
    var txtInstitucionRB = $("#txtInstitucionRB").val();
    var txtNroCuentaRB = $("#txtNroCuentaRB").val();
    var txtTipoCuentaRB = $("#txtTipoCuentaRB").val();
    var txtBeneficiarioRB = $("#txtBeneficiarioRB").val();
    var txtEmpresaRB = $("#txtEmpresaRB").val();
    var txtRucRB = $("#txtRucRB").val();
    var txtTelefonoRB = $("#txtTelefonoRB").val();
    var txtDireccionRB = $("#txtDireccionRB").val();
    //Clasificación para uso Comercial CUC
    var cboUnidad = $("#cboUnidad").val();
    var cboSubUnidad = $("#cboSubUnidad").val();
    var cboAsesorComercial = $("#cboAsesorComercial").val();
    var txtDescripcion = $("#txtDescripcion").val();
    //Terminos de pago  
    var cboTipoPago = $("#cboTipoPago").val();
    var cuposolicitado = $("#cuposolicitado").val();
    //Verificacion=  
    var txtAsesorComercialVUI = $("#txtAsesorComercialVUI").val();
    // Control de Documentos 
    var file1 = $("#real-input1")[0].files;
    console.log(file1);
    var file2 = $("#real-input2")[0].files;
    console.log(file2);
    var file3 = $("#real-input3")[0].files;
    console.log(file3);
    var file4 = $("#real-input4")[0].files;
    console.log(file4);
    var file5 = $("#real-input5")[0].files;
    console.log(file5);
    var file6 = $("#real-input6")[0].files;
    console.log(file6);
    var file7 = $("#real-input7")[0].files;
    console.log(file7);
    var file8 = $("#real-input8")[0].files;
    console.log(file8);
    var file9 = $("#real-input9")[0].files;
    console.log(file9);
    var file10 = $("#real-input10")[0].files;
    console.log(file10);
    var file11 = $("#real-input11")[0].files;
    console.log(file11);
    var file12 = $("#real-input12")[0].files;
    console.log(file12);
    var file13 = $("#real-input13")[0].files;
    console.log(file13);
    var fdata = new FormData();
    fdata.append("FormFile1", file1[0]);
    fdata.append("FormFile2", file2[0]);
    fdata.append("FormFile3", file3[0]);
    fdata.append("FormFile4", file4[0]);
    fdata.append("FormFile5", file5[0]);
    fdata.append("FormFile6", file6[0]);
    fdata.append("FormFile7", file7[0]);
    fdata.append("FormFile8", file8[0]);
    fdata.append("FormFile9", file9[0]);
    fdata.append("FormFile10", file10[0]);
    fdata.append("FormFile11", file11[0]);
    fdata.append("FormFile12", file12[0]);
    fdata.append("FormFile13", file13[0]);
    //perfil
    fdata.append("IdPerfil", $("#perfil").val());
    //DG()
    fdata.append("NombreRazonSocialDG", NombreRazonSocialDG);
    fdata.append("DireccionDG", DireccionDG);
    fdata.append("PaisId", PaisId);
    fdata.append("CiudadPrinciaplDDG", CiudadPrinciaplDDG);
    fdata.append("TelefonoFijoDG", TelefonoFijoDG);
    fdata.append("CelularDG", CelularDG);
    fdata.append("CorreoElecontronicoDG", CorreoElecontronicoDG);
    fdata.append("DireccionFacturaDG", DireccionFacturaDG);
    fdata.append("CiudadFacturaDG", CiudadFacturaDG);
    fdata.append("DireccionPedidoDG", DireccionPedidoDG);
    fdata.append("CiudadPedidoDG", CiudadPedidoDG);
    fdata.append("DireccionPedidoSecundarioDG", DireccionPedidoSecundarioDG);
    fdata.append("CiudadPedidoSecundarioDG", CiudadPedidoSecundarioDG);
    //IC()
    fdata.append("NombreContactoAreaCobranza", NombreContactoAreaCobranza);
    fdata.append("TelefonoContactoAreaCobranza", TelefonoContactoAreaCobranza);
    fdata.append("CorreoContactoAreaCobranza", CorreoContactoAreaCobranza);
    fdata.append("NombreContactoAreaFinanciera", NombreContactoAreaFinanciera);
    fdata.append("TelefonoContactoAreaFinanciera", TelefonoContactoAreaFinanciera);
    fdata.append("CorreoContactoAreaFinanciera", CorreoContactoAreaFinanciera);
    fdata.append("NombreContactoAreaComercial", NombreContactoAreaComercial);
    fdata.append("TelefonoContactoAreaComercial", TelefonoContactoAreaComercial);
    fdata.append("CorreoContactoAreaComercial", CorreoContactoAreaComercial);
    //IT()
    fdata.append("TipoIdentificacionIdIT", TipoIdentificacionIdIT);
    fdata.append("CualIdentificacionIT", CualIdentificacionIT);
    fdata.append("NumeroIdentificacionIT", NumeroIdentificacionIT);
    fdata.append("cboTipoContribuyente", cboTipoContribuyente);
    fdata.append("cboTipoSociedad", cboTipoSociedad);
    fdata.append("txtCualSociedadIT", txtCualSociedadIT);
    fdata.append("cboOrigenCapital", cboOrigenCapital);
    fdata.append("cboActividadEconomica", cboActividadEconomica);
    fdata.append("txtCualEconomicaIT", txtCualEconomicaIT);
    fdata.append("txtSuperIntendenciaIT", txtSuperIntendenciaIT);
    fdata.append("txtFechaConstitucionIT", txtFechaConstitucionIT);
    fdata.append("cboRegimen", cboRegimen);
    //INFORMACION AE()
    fdata.append("txtActividadPrincipalIAE", txtActividadPrincipalIAE);
    fdata.append("txtActividadSecundariaIAE", txtActividadSecundariaIAE);
    //informacion representante legal()
    fdata.append("txtNombreRepresentanteLegalIRL", txtNombreRepresentanteLegalIRL);
    fdata.append("cboTipoIdenticacionLegal", cboTipoIdenticacionLegal);
    fdata.append("txtNumeroIdentificacionIRL", txtNumeroIdentificacionIRL);
    fdata.append("cboNacionalidad", cboNacionalidad);
    fdata.append("txtCualIRL", txtCualIRL);
    fdata.append("txtFechaExpedicionDocumentoIRL", txtFechaExpedicionDocumentoIRL);
    fdata.append("txtDireccionResidenciaIRL", txtDireccionResidenciaIRL);
    fdata.append("txtCiudadIRL", txtCiudadIRL);
    //preguntas pep (persona publicamente expuesta)
    fdata.append("checkGozaPEP", checkGozaPEP);
    fdata.append("txtEspecifiqueGozaPEP", txtEspecifiqueGozaPEP);
    fdata.append("checkManejaPEP", checkManejaPEP);
    fdata.append("txtEspecifiqueManejaPEP", txtEspecifiqueManejaPEP);
    fdata.append("checkOcupaPEP", checkOcupaPEP);
    fdata.append("txtEspecifiqueOcupaPEP", txtEspecifiqueOcupaPEP);
    fdata.append("checkVinculo1PEP", checkVinculo1PEP);
    fdata.append("txtEspecifiqueVinculo1PEP", txtEspecifiqueVinculo1PEP);
    fdata.append("checkVinculo2PEP", checkVinculo2PEP);
    fdata.append("txtEspecifiqueVinculo2PEP", txtEspecifiqueVinculo2PEP);
    fdata.append("txtNombreApellidoPEP", txtNombreApellidoPEP);
    fdata.append("txtCargoPEP", txtCargoPEP);
    //informacion socios o accionistas
    fdata.append("checkAccionistaISA", checkAccionistaISA);
    fdata.append("txtNombreApellidoAccionista1ISA", txtNombreApellidoAccionista1ISA);
    fdata.append("txtTipoIdAccionista1ISA", txtTipoIdAccionista1ISA);
    fdata.append("txtNroDocumentoAccionista1ISA", txtNroDocumentoAccionista1ISA);
    fdata.append("txtParticipacionAccionista1ISA", txtParticipacionAccionista1ISA);
    fdata.append("txtNacionalidadAccionista1ISA", txtNacionalidadAccionista1ISA);
    fdata.append("txtNombreApellidoAccionista2ISA", txtNombreApellidoAccionista2ISA);
    fdata.append("txtTipoIdAccionista2ISA", txtTipoIdAccionista2ISA);
    fdata.append("txtNroDocumentoAccionista2ISA", txtNroDocumentoAccionista2ISA);
    fdata.append("txtParticipacionAccionista2ISA", txtParticipacionAccionista2ISA);
    fdata.append("txtNacionalidadAccionista2ISA", txtNacionalidadAccionista2ISA);
    fdata.append("txtNombreApellidoAccionista3ISA", txtNombreApellidoAccionista3ISA);
    fdata.append("txtTipoIdAccionista3ISA", txtTipoIdAccionista3ISA);
    fdata.append("txtNroDocumentoAccionista3ISA", txtNroDocumentoAccionista3ISA);
    fdata.append("txtParticipacionAccionista3ISA", txtParticipacionAccionista3ISA);
    fdata.append("txtNacionalidadAccionista3ISA", txtNacionalidadAccionista3ISA);
    fdata.append("txtNombreApellidoAccionista4ISA", txtNombreApellidoAccionista4ISA);
    fdata.append("txtTipoIdAccionista4ISA", txtTipoIdAccionista4ISA);
    fdata.append("txtNroDocumentoAccionista4ISA", txtNroDocumentoAccionista4ISA);
    fdata.append("txtParticipacionAccionista4ISA", txtParticipacionAccionista4ISA);
    fdata.append("txtNacionalidadAccionista4ISA", txtNacionalidadAccionista4ISA);
    //INFORMACIÓN FINANCIERA
     
    //Referencias Comerciales
    fdata.append("txtEmpresa1RC", txtEmpresa1RC);
    fdata.append("txtRuc1RC", txtRuc1RC);
    fdata.append("txtTelefono1RC", txtTelefono1RC);
    fdata.append("txtDireccion1RC", txtDireccion1RC);
    fdata.append("txtCiudad1RC", txtCiudad1RC);
    fdata.append("txtEmpresa2RC", txtEmpresa2RC);
    fdata.append("txtRuc2RC", txtRuc2RC);
    fdata.append("txtTelefono2RC", txtTelefono2RC);
    fdata.append("txtDireccion2RC", txtDireccion2RC);
    fdata.append("txtCiudad2RC", txtCiudad2RC);
    //Referencias BANCARIAS
    fdata.append("txtInstitucionRB", txtInstitucionRB);
    fdata.append("txtNroCuentaRB", txtNroCuentaRB);
    fdata.append("txtTipoCuentaRB", txtTipoCuentaRB);
    fdata.append("txtBeneficiarioRB", txtBeneficiarioRB);
    fdata.append("txtEmpresaRB", txtEmpresaRB);
    fdata.append("txtRucRB", txtRucRB);
    fdata.append("txtTelefonoRB", txtTelefonoRB);
    fdata.append("txtDireccionRB", txtDireccionRB);
    //Clasificación para uso Comercial
    fdata.append("cboUnidad", cboUnidad);
    fdata.append("cboSubUnidad", cboSubUnidad);
    fdata.append("cboAsesorComercial", cboAsesorComercial);
    fdata.append("txtDescripcion", txtDescripcion);
    //Terminos de pago  
    fdata.append("cboTipoPago", cboTipoPago);
    fdata.append("cuposolicitado", cuposolicitado);
    //Verificacion=  
    fdata.append("txtAsesorComercialVUI", txtAsesorComercialVUI);
    fdata.append("CodeCliente", code);

    if (validateExtension(file1) && validateExtension(file2) && validateExtension(file3) && validateExtension(file4) &&
        validateExtension(file5) && validateExtension(file6) && validateExtension(file7) && validateExtension(file8) &&
        validateExtension(file9) && validateExtension(file10) && validateExtension(file11) && validateExtension(file12) &&
        validateExtension(file13)) {
        var parametros = new Object();
        parametros.data = fdata;
        PostUpload("FormularioCliente/EnviarFormularioCliente", fdata).done(function (response) {
            $('body').loading('stop');
            if (response.code == 0) {

                fnAlertSuccess(response.message, function () {
                    window.location = fnBaseUrlWeb("Main/BandejaComercial");
                });

                console.log(response.data);

            } else {
                fnAlertError(response.message);
            }
        });
    }
    else {
        fnAlertAdvertencia("No Ingreso Un Formato JPG O PNG O PDF");
    }

}