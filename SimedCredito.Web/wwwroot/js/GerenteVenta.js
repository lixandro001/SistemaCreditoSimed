﻿var code = "";
$(function () {
    var url = new URL(location.href);
    code = url.searchParams.get("code");
    LoadDataViewByCode(code);

    $("#btnAprobar").on("click", function () {
        fnAprobarFormulario();
    });

    $("#btnReiniciar").on("click", function () {
        fnReiniciar();
    });

    $("#btnRechazar").on("click", function () {
        $("#rechazopoppup").val("");
        $("#modalRechazo").modal("show");
    });

    $("#SendEnvioRechazo").on("click", function () {
        if ($("#rechazopoppup").val() == "") {
            fnAlertAdvertencia("Escriba el motivo del rechazó.");
            return;
        }
        fnRechazarFormulario();
    });

    $("#btnVerRechazo").on("click", function () {
        $("#VerMotivoRechazo").modal("show");
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
    $("#idrutahide").val(Datos.idEvaluacionDocumento);
    $("#txtNombreRazonDG").val(Datos.Nombre_RazonSocialDatosGenerales);
    $("#txtDireccionDG").val(Datos.DireccionDatosGenerales);
    $("#cboPais").val(Datos.Nombre_S_PAIS);
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
    $("#cboTipoIdentificacionTributaria").val(Datos.Nombre_S_TIPO_IDENTIFICACION);
    $("#txtCualIdentificacionIT").val(Datos.CualTipoIdentificacion);
    $("#txtNumIdentificacionIT").val(Datos.NumeroIdentificacion);
    $("#cboTipoContribuyente").val(Datos.Nombre_S_TIPO_CONTRIBUYENTE);
    $("#cboTipoSociedad").val(Datos.Nombre_S_TIPO_SOCIEDAD);
    $("#txtCualSociedadIT").val(Datos.CualTipoSociedad);
    $("#cboOrigenCapital").val(Datos.Nombre_S_ORIGEN_CAPITAL);
    $("#cboActividadEconomica").val(Datos.Nombre_S_ACTIVIDAD_ECONOMICA);
    $("#txtCualEconomicaIT").val(Datos.CualActividadEconomica);
    $("#txtSuperIntendenciaIT").val(Datos.TitularVigiladoPorAlgunaSuperIntendencia);
    $("#txtFechaConstitucionIT").val(Datos.CFechaConstitucion);
    $("#cboRegimen").val(Datos.Nombre_S_REGIMEN);
    //-     INFORMACIÓN ACTIVIDAD ECONÓMICA  -//
    $("#txtActividadPrincipalIAE").val(Datos.ActidadPrincipal);
    $("#txtActividadSecundariaIAE").val(Datos.ActividadSecundaria);
    //--    INFORMACION DE REPRESENTACION LEGAL -//
    $("#txtNombreRepresentanteLegalIRL").val(Datos.NombreRepresentanteLegal);
    $("#cboTipoIdenticacionLegal").val(Datos.Nombre_S_TIPO_IDENTIFICACION_RL);
    $("#txtNumeroIdentificacionIRL").val(Datos.NumeroIdentificacion_RL);
    $("#cboNacionalidad").val(Datos.Nombre_S_NACIONALIDAD);
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
    for (var i = 0; i < Datos.DetalleInformacionSocio.length; i++) {

        $("#tblDocumentos > tbody").append('<tr>' +
            '<td style="text-align: center;"> ' + Datos.DetalleInformacionSocio[i].NombreApellidoAccionistas + ' </td>' +
            '<td style="text-align: center;font-size:12pt;"> ' + Datos.DetalleInformacionSocio[i].TipoId + '</td>' +
            '<td style="text-align: center;">' + Datos.DetalleInformacionSocio[i].NroDocumento + '</td>' +
            '<td style="text-align: center;font-size:12pt;">' + Datos.DetalleInformacionSocio[i].Participacion + '</td>' +
            '<td style="text-align: center;font-size:12pt;">' + Datos.DetalleInformacionSocio[i].Nacionalidad + '</td>'
            + '</tr>');
    }
    //--INFORMACIÓN FINANCIERA
    $("#FechaCorte").val(Datos.CFechaCorte);
    if (Datos.InformacionDebeSoles) { $("#checkSolesIF").prop("checked", true); }
    if (Datos.InformacionDebeDolares) { $("#checkDolaresIF").prop("checked", true); }
    $("#txtActivosIF").val(Datos.Activos);
    $("#txtPasivosIF").val(Datos.Pasivos);
    $("#txtPatrimonioIF").val(Datos.Patrimonio);
    $("#txtIngresosMensualesIF").val(Datos.IngresoMensual);
    $("#txtEgresosMensualesIF").val(Datos.EgresoMensual);
    $("#txtOtrosIngresosIF").val(Datos.OtrosIngresos);
    $("#txtConceptoOtrosIngresosIF").val(Datos.ConceptoOtrosIngresos);
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
    $("#txtFile1CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual

    });
    $("#txtFile2CDE").html(Datos.CopiasFormularioPDTAnualRentaTerceraPersonaNatual);
    $("#txtFile2CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CopiasFormularioPDTAnualRentaTerceraPersonaNatual

    });

    $("#txtFile3CDE").html(Datos.CopiaFichaRucPersonaNatual);
    $("#txtFile3CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CopiaFichaRucPersonaNatual

    });

    $("#txtFile4CDE").html(Datos.CopiaDniPersonaNatual);
    $("#txtFile4CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CopiaDniPersonaNatual

    });

    $("#txtFile5CDE").html(Datos.CertificacoReferenciaComercialPersonaNatual);
    $("#txtFile5CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CertificacoReferenciaComercialPersonaNatual

    });

    $("#txtFile6CDE").html(Datos.CertificadoBancarioPersonaNatual);
    $("#txtFile6CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CertificadoBancarioPersonaNatual

    });

    $("#txtFile7CDE").html(Datos.SituacionFinancieraBalanceGeneralPerdidasJuridicas);
    $("#txtFile7CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.SituacionFinancieraBalanceGeneralPerdidasJuridicas

    });

    $("#txtFile8CDE").html(Datos.CopiaFormularioPDTAnualRentaTerceraJuridicas);
    $("#txtFile8CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CopiaFormularioPDTAnualRentaTerceraJuridicas

    });

    $("#txtFile9CDE").html(Datos.CopiaFichaRucJuridicas);
    $("#txtFile9CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CopiaFichaRucJuridicas

    });

    $("#txtFile10CDE").html(Datos.CopiaDNIRepresentanteLegalJuridicas);
    $("#txtFile10CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CopiaDNIRepresentanteLegalJuridicas

    });

    $("#txtFile11CDE").html(Datos.VigenciaPoderRepresentanteLegalJuridicas);
    $("#txtFile11CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.VigenciaPoderRepresentanteLegalJuridicas

    });

    $("#txtFile12CDE").html(Datos.CertificadoReferenciaComercialJuridicas);
    $("#txtFile12CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CertificadoReferenciaComercialJuridicas

    });

    $("#txtFile13CDE").html(Datos.CertificadoBancarioJuridicas);
    $("#txtFile13CDE").attr({
        target: '_blank',
        href: urlglobal + Datos.CertificadoBancarioJuridicas

    });
    //--CLASIFICACIÓN PARA USO COMERCIAL
    $("#cboUnidad").val(Datos.DescripcionUnidad);
    $("#cboSubUnidad").val(Datos.Nombre_S_SUB_UNIDAD);
    $("#cboAsesorComercial").val(Datos.Nombre_S_ASESOR_COMERCIAL);
    $("#txtDescripcion").val(Datos.Descripcion);
    //--TÉRMINOS DE PAGO
    $("#cboTipoPago").val(Datos.DescripcionPAGO);
    $("#cuposolicitado").val(Datos.cupoSolicitado);
    //--VERIFICACION PARA USO EXTERNO
    $("#txtAsesorComercialVUI").val(Datos.ResponsableContratacion);
    //$("#txtFirmaVUI").val(Datos.Firma);
    $("#txtFirmaVUI").val(Datos.ResponsableContratacion);

    if (Datos.EstadoVenta == 2 || Datos.EstadoVenta == 3) {
        $("#btnRechazar").hide();
        $("#btnAprobar").hide();
    }
    if (Datos.EstadoVenta == 3 || Datos.EstadoFinanza == 3) {
        $("#verrechazopoppup").val(Datos.MotivoRechazo);
        $("#btnVerRechazo").show();
    }
    var rutaseven = $("#idrutahide").val();
    console.log("----" + rutaseven);

    var nuevoNombre1
    var nuevoNombre2
    var Indice2 = 1;
    for (var i = 0; i < Datos.DetalleEvaluacion.length; i++) {

        var array = Datos.DetalleEvaluacion;
        var nombre1 = array[0];
        var nombre2 = array[1];

        console.log(nombre1);
        console.log(nombre2);

        if (nombre1 == null) {
            nuevoNombre1 = "";
            nuevoNombre2 = nombre2.NombreDocumento;
            Indice2++;
            $("#idAdjuntardocument2").hide();
            $("#txtevaluacion2").html(Datos.DetalleEvaluacion[1].NombreOriginal);
            $("#txtevaluacion2").attr({
                target: '_blank',
                href: urlglobal + nuevoNombre2
            });
        }
        else if (nombre2 == null) {
            nuevoNombre2 = "";
            nuevoNombre1 = nombre1.NombreDocumento;
            Indice2++;

            $("#idAdjuntardocument").hide();
            $("#txtevaluacion").html(Datos.DetalleEvaluacion[0].NombreOriginal);
            $("#txtevaluacion").attr({
                target: '_blank',
                href: urlglobal + nuevoNombre1
            });
        }
        else {
            nuevoNombre1 = nombre1.NombreDocumento;
            nuevoNombre2 = nombre2.NombreDocumento;
            Indice2++;

            $("#idAdjuntardocument").hide();
            $("#txtevaluacion").html(Datos.DetalleEvaluacion[0].NombreOriginal);
            $("#txtevaluacion").attr({
                target: '_blank',
                href: urlglobal + nuevoNombre1
            });
            $("#idAdjuntardocument2").hide();
            $("#txtevaluacion2").html(Datos.DetalleEvaluacion[1].NombreOriginal);
            $("#txtevaluacion2").attr({
                target: '_blank',
                href: urlglobal + nuevoNombre2
            });

        }

    }


}

function fnAprobarFormulario() {
    var PerfilId = $("#perfil").val();
    var parametros = new Object();
    parametros.IdPerfil = PerfilId;
    parametros.Code = code;

    Post("FormularioCliente/AprobarFormularioCliente", parametros).done(function (response) {
        $('body').loading('stop');
        if (response.code == 0) {
            fnConfirm(response.message);
        }
    });
}

function fnRechazarFormulario() {
    var MensajeRechazo = $("#rechazopoppup").val();
    var PerfilId = $("#perfil").val();
    var parametros = new Object();
    parametros.IdPerfil = PerfilId;
    parametros.Code = code;
    parametros.MensajeRechazado = MensajeRechazo;

    Post("FormularioCliente/RechazarFormularioCliente", parametros).done(function (response) {
        $('body').loading('stop');
        if (response.code == 0) {
            fnConfirm(response.message);
        }
    });
}


function fnReiniciar() {
    var PerfilId = $("#perfil").val();
    var parametros = new Object();
    parametros.IdPerfil = PerfilId;
    parametros.Code = code;
    Post("FormularioCliente/ReiniciarFormulario", parametros).done(function (response) {
        $('body').loading('stop');
        if (response.code == 0) {
            fnConfirm(response.message);
        }
    });
}

function fnConfirm(message) {
    swal({
        title: "¡Exito!",
        html: false,
        text: message || "Acción ejecutada con exito.",
        type: "success",
        showCancelButton: false,
        confirmButtonColor: "#007bff",
        confirmButtonText: "Aceptar",
        closeOnConfirm: true
    }, function () {
        location.href = '/Main/BandejaGerenteVenta';
    });
}