$(function () {
    var url = new URL(location.href);
    var code = url.searchParams.get("code");
    LoadDataViewByCode(code);
});

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
    for (var i = 0; i < Datos.DetalleInformacionSocio.length; i++) {

        $("#tblDocumentos > tbody").append('<tr>' +
            '<td style="text-align: center;"></td>' +
            '<td style="text-align: center;font-size:12pt;"> ' + Datos.DetalleInformacionSocio[i].IdClienteDatosGenerales + '" /></td>' +
            '<td style="text-align: center;"></td>' + 
            '<td style="text-align: center;font-size:12pt;">' + Datos.DetalleInformacionSocio[i].NombreApellidoAccionistas + '</td>'
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

}