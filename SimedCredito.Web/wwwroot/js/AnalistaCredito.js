var code = "";
 
$(function () {
    var url = new URL(location.href);
    code = url.searchParams.get("code");
    LoadDataViewByCode(code);

  

    $("#GuardarEvaluacion").on("click", function () {   
        var realinput1evaluacion = $("#real-input1evaluacion")[0].files;
        console.log(realinput1evaluacion);
        console.log(realinput1evaluacion.length);
        if (realinput1evaluacion.length == 0) {  
            fnAlertAdvertencia("Falta Adjubtar Documento De Evaluacion");  
        } else {
            GuardarEvaluacionDocumento();
        }
    });

    $("#btnAprobar").on("click", function () {
        fnAprobarFormulario();
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


    // PARA ADJUNTO DE EVALUACION
    $(".browse-btn1evaluacion").on("click", function (a) {
        a.preventDefault();
        $("#real-input1evaluacion").click();
    });

    $("#real-input1evaluacion").on("change", function () {
        const name = $("#real-input1evaluacion").val().split(/\\|\//).pop();
        console.log(name);
        var htmlName = name.length > 80 ? name.substr(name.length - 80) : name;
        $(".file-info1evaluacion").text(htmlName);
    });


});


function GuardarEvaluacionDocumento() {

    var idclientedatosgenerales = $("#IdClienteDatosGenerales").val();
    var perfil = $("#perfil").val();
    var txtRucRB = $("#txtRucRB").val();

    var file1 = $("#real-input1evaluacion")[0].files;
    console.log(file1);
    var fdata = new FormData();

    fdata.append("FormFile1evaluacion", file1[0]);
    fdata.append("idclientedatosgenerales", idclientedatosgenerales);
    fdata.append("perfil", perfil);
    fdata.append("txtRucRB", txtRucRB);

    if ( validateExtension(file1) ) {
        var parametros = new Object();
        parametros.data = fdata;
        PostUpload("FormularioCliente/InsertarEvaluacionDocumento", fdata).done(function (response) {
            if (response.code == 0) {
                fnAlertSuccess(response.message, function () {
                    window.location = fnBaseUrlWeb("Main/Cliente");
                });
                console.log(response.data);
            }
            else if (response.code == 1) {
                fnAlertAdvertencia(response.message);
            }
            else {
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

function LoadDataViewByCode(code) {
    Get("FormularioCliente/DataByCode?Code=" + code).done(function (response) {
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
    $("#IdClienteDatosGenerales").val(Datos.IdClienteDatosGenerales);
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
    if (Datos.DetalleInformacionSocio[0].CompañiaCuentaAccionistas) { $("#checkSiAccionistaISA").prop("checked", true); } else { $("#checkNoAccionistaISA").prop("checked", true);}
    for (var i = 0; i < Datos.DetalleInformacionSocio.length; i++) {

        $("#tblDocumentos > tbody").append('<tr>' +
            '<td style="text-align: center;"> ' + Datos.DetalleInformacionSocio[i].NombreApellidoAccionistas +' </td>' +
            '<td style="text-align: center;font-size:12pt;"> ' + Datos.DetalleInformacionSocio[i].TipoId + '</td>' +
            '<td style="text-align: center;">' + Datos.DetalleInformacionSocio[i].NroDocumento+'</td>' +
            '<td style="text-align: center;font-size:12pt;">' + Datos.DetalleInformacionSocio[i].Participacion + '</td>' +
            '<td style="text-align: center;font-size:12pt;">' + Datos.DetalleInformacionSocio[i].Nacionalidad + '</td>'
            +'</tr>');
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

    if (Datos.EstadoCredito == 2 || Datos.EstadoCredito == 3) {
        $("#btnRechazar").hide();
        $("#btnAprobar").hide();
    }
    if (Datos.EstadoCredito == 3 || Datos.EstadoVenta == 3 || Datos.EstadoFinanza == 3) {
        $("#verrechazopoppup").val(Datos.MotivoRechazo);
        $("#btnVerRechazo").show();
    }

     
    var rutaseven = $("#idrutahide").val();
    console.log("----" + rutaseven);
    if (rutaseven == 1) {
         
        $("#idAdjuntardocument").hide();    
        $("#txtevaluacion").html(Datos.NombreOriginal);
        $("#txtevaluacion").attr({
            target: '_blank',
            href: urlglobal + Datos.NombreOriginal
        });

    } else if (rutaseven == 0) {
        $("#idAdjuntardocument").show();
    }

}

function fnAprobarFormulario() {
    var parametros = new Object();
    var PerfilId = $("#perfil").val();
    parametros.IdPerfil = PerfilId;
    parametros.Code = code;

    Post("FormularioCliente/AprobarFormularioCliente", parametros).done(function (response) {
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
        location.href = '/Main/Cliente';
    });
}