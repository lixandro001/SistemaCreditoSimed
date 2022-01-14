using Simed.Entity.Request;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Simed.Data
{
   public class FormularioClienteDA
    {
        private string ConStr;
        public FormularioClienteDA(string ConStr)
        {
            this.ConStr = ConStr;
        }
        public void Disponse()
        {
            GC.SuppressFinalize(this);
        }

        public int GuardarFormulario(EnviarFromulatioRequestCliente datos)
        {
            using (var Ado = new SQLServer(ConStr))
                try
                {
                    string strsql = "usp_GuardarFormularioCliente";
                    var parametros = new SqlParameter[]
                    {
                       new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, Direction= ParameterDirection.Output},
                       new SqlParameter { ParameterName = "@mensaje", SqlDbType = SqlDbType.Int, Direction= ParameterDirection.Output},
                       new SqlParameter { ParameterName = "@Nombre_RazonSocialDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.NombreRazonSocialDG },
                       new SqlParameter { ParameterName = "@DireccionDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue= datos.DireccionDG },
                       new SqlParameter { ParameterName = "@IdPaisDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue= datos.PaisId },
                       new SqlParameter { ParameterName = "@CiudadSedePrincipalDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.CiudadPrinciaplDDG },
                       new SqlParameter { ParameterName = "@TelefonoFijoDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.TelefonoFijoDG },
                       new SqlParameter { ParameterName = "@CelularDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.CelularDG },  
                       new SqlParameter { ParameterName = "@CorreoEnvioFacturaElectronicaDatosGenerales", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.CorreoElecontronicoDG },
                       new SqlParameter { ParameterName = "@DireccionEntregaFacturaDatosGenerales", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.DireccionFacturaDG },
                       new SqlParameter { ParameterName = "@CiudadDireccionEntregaFacturaDatosGenerales", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.CiudadFacturaDG },
                       new SqlParameter { ParameterName = "@DireccionEntregaPedidoDatosGenerales", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.DireccionPedidoDG },
                       new SqlParameter { ParameterName = "@CiudadDireccionEntregaPedidoDatosGenerales", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.CiudadPedidoDG },
                       new SqlParameter { ParameterName = "@DireccionSecundariaEntregaPedidoDatosGenerales", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.DireccionPedidoSecundarioDG },
                       new SqlParameter { ParameterName = "@CiudadDireccionSecundariaEntregaPedidoDatosGenerales", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.CiudadPedidoSecundarioDG },
                       new SqlParameter { ParameterName = "@IdUsuario", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.IdUsuario},
                       new SqlParameter { ParameterName = "@IdPerfil", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.IdPerfil},                
                       new SqlParameter { ParameterName = "@code", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.code},
                       new SqlParameter { ParameterName = "@BtnEnvio", SqlDbType = SqlDbType.Int, SqlValue = datos.btnEnvio},
                    };
                    Ado.ExecNonQueryProc(strsql, parametros);
                    var valor = parametros[0].Value;
                    var idcliente = Convert.ToInt32(parametros[0].Value.ToString());
                    var mensaje = Convert.ToInt32(parametros[1].Value.ToString());

                    if (idcliente != 0) 
                    {
                        string strsql2 = "usp_GuardarInformacionContacto";
                        var parametros2 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@NombreContactoAreaCobranza", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.NombreContactoAreaCobranza},
                        new SqlParameter { ParameterName = "@TelefonoContactoAreaCobranza", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.TelefonoContactoAreaCobranza},
                        new SqlParameter { ParameterName = "@CorreoElectronicoContactoAreaCobranza", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.CorreoContactoAreaCobranza},
                        new SqlParameter { ParameterName = "@NombreContactoAreaFinanciera", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.NombreContactoAreaFinanciera},
                        new SqlParameter { ParameterName = "@TelefonoContactoAreaFinanciera", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.TelefonoContactoAreaFinanciera},
                        new SqlParameter { ParameterName = "@CorreoContactoAreaFinanciera", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.CorreoContactoAreaFinanciera},
                        new SqlParameter { ParameterName = "@NombreContactoAreaComercial", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.NombreContactoAreaComercial},
                        new SqlParameter { ParameterName = "@TelefonoContactoAreaComercial", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.TelefonoContactoAreaComercial},
                        new SqlParameter { ParameterName = "@CorreoContactoAreaComercial", SqlDbType = SqlDbType.VarChar,Size=200, SqlValue = datos.CorreoContactoAreaComercial},
                        };
                        Ado.ExecNonQueryProc(strsql2, parametros2);

                        string strsql3 = "usp_GuardarInformacionTributaria";
                        var parametros3 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@IdTipoIdentificacion", SqlDbType = SqlDbType.Int, SqlValue = datos.TipoIdentificacionIdIT},
                        new SqlParameter { ParameterName = "@CualTipoIdentificacion", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.CualIdentificacionIT},
                        new SqlParameter { ParameterName = "@NumeroIdentificacion", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.NumeroIdentificacionIT},
                        new SqlParameter { ParameterName = "@IdTipoContribuyete", SqlDbType = SqlDbType.Int, SqlValue = datos.cboTipoContribuyente},
                        new SqlParameter { ParameterName = "@IdTipoSociedad", SqlDbType = SqlDbType.Int, SqlValue = datos.cboTipoSociedad},
                        new SqlParameter { ParameterName = "@CualTipoSociedad", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtCualSociedadIT},
                        new SqlParameter { ParameterName = "@IdOrigenCapital", SqlDbType = SqlDbType.Int, SqlValue = datos.cboOrigenCapital},
                        new SqlParameter { ParameterName = "@IdActividadEconomica", SqlDbType = SqlDbType.Int, SqlValue = datos.cboActividadEconomica},
                        new SqlParameter { ParameterName = "@CualActividadEconomica", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtCualEconomicaIT},
                        new SqlParameter { ParameterName = "@TitularVigiladoPorAlgunaSuperIntendencia", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtSuperIntendenciaIT},
                        new SqlParameter { ParameterName = "@FechaConstitucion", SqlDbType = SqlDbType.DateTime, SqlValue = datos.txtFechaConstitucionIT},
                        new SqlParameter { ParameterName = "@IdRegimen", SqlDbType = SqlDbType.Int, SqlValue = datos.cboRegimen},
                        };
                        Ado.ExecNonQueryProc(strsql3, parametros3);

                        string strsql4 = "USP_GuardarInformacionActividadEconomica";
                        var parametros4 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@ActidadPrincipal", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtActividadPrincipalIAE},
                        new SqlParameter { ParameterName = "@ActividadSecundaria", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtActividadSecundariaIAE},
                        };
                        Ado.ExecNonQueryProc(strsql4, parametros4);

                        string strsql5 = "usp_GuardarInformacionRepresentacionLegalPersonasJuridicas";
                        var parametros5 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@NombreRepresentanteLegal", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtNombreRepresentanteLegalIRL},
                        new SqlParameter { ParameterName = "@IdTipoIdentificacion", SqlDbType = SqlDbType.Int, SqlValue = datos.cboTipoIdenticacionLegal},
                        new SqlParameter { ParameterName = "@NumeroIdentificacion", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtNumeroIdentificacionIRL},
                        new SqlParameter { ParameterName = "@IdNacionalidad", SqlDbType = SqlDbType.Int, SqlValue = datos.cboNacionalidad},
                        new SqlParameter { ParameterName = "@CualNacionalidad", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtCualIRL},
                        new SqlParameter { ParameterName = "@FechaExpedicionDocumento", SqlDbType = SqlDbType.DateTime, SqlValue = datos.txtFechaExpedicionDocumentoIRL},
                        new SqlParameter { ParameterName = "@DireccionResidencia", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtDireccionResidenciaIRL},
                        new SqlParameter { ParameterName = "@Ciudad", SqlDbType = SqlDbType.VarChar,Size=100, SqlValue = datos.txtCiudadIRL},
                        };
                        Ado.ExecNonQueryProc(strsql5, parametros5);

                        string strsql6 = "usp_GuardarPreguntasPepPersonasPublicamenteExpuestas";
                        var parametros6 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@GozaReconocimientoPublico", SqlDbType = SqlDbType.Bit, SqlValue = datos.checkGozaPEP},
                        new SqlParameter { ParameterName = "@EspecifiqueGozaReconocimientoPublico", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtEspecifiqueGozaPEP},
                        new SqlParameter { ParameterName = "@ManejaRecursosPublicos", SqlDbType = SqlDbType.Bit, SqlValue = datos.checkManejaPEP},
                        new SqlParameter { ParameterName = "@EspecifiqueManejaRecursosPublicos", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtEspecifiqueManejaPEP},
                        new SqlParameter { ParameterName = "@OcupaCargosPublicos", SqlDbType = SqlDbType.Bit, SqlValue = datos.checkOcupaPEP},
                        new SqlParameter { ParameterName = "@EspecifiqueOcupaCargosPublicos", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtEspecifiqueOcupaPEP},
                        new SqlParameter { ParameterName = "@ExisteVinculoEntreUstedPersonaPublicamenteExpuesta", SqlDbType = SqlDbType.Bit, SqlValue = datos.checkVinculo1PEP},
                        new SqlParameter { ParameterName = "@EspecifiqueExisteVinculoEntreUstedPersonaPublicamenteExpuesta", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtEspecifiqueVinculo1PEP},
                        new SqlParameter { ParameterName = "@ExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed", SqlDbType = SqlDbType.Bit, SqlValue = datos.checkVinculo2PEP},
                        new SqlParameter { ParameterName = "@EspecifiqueExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtEspecifiqueVinculo2PEP},
                        new SqlParameter { ParameterName = "@CasoAfirmativoEspecifiquePersonaConVinculo", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = datos.txtNombreApellidoPEP},
                        new SqlParameter { ParameterName = "@Cargo", SqlDbType = SqlDbType.VarChar,Size=450, SqlValue = datos.txtCargoPEP},
                        };
                        Ado.ExecNonQueryProc(strsql6, parametros6);

                        string strsqlDelete1 = "LimpiarInformacionSociosAccionistasUnicamentePersonasJuridicasById";

                        var parametrosDelete1 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        };
                        Ado.ExecNonQueryProc(strsqlDelete1, parametrosDelete1);

                        string strsql7 = "usp_GuardarInformacionSociosAccionistasUnicamentePersonasJuridicas";
                        foreach (var item in datos.DetalleUnicamentePersonaJuridicas)
                        {
                            var parametros7 = new SqlParameter[]
                            {
                            new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                            new SqlParameter { ParameterName = "@CompañiaCuentaAccionistas", SqlDbType = SqlDbType.Bit, SqlValue = item.CompañiaCuentaAccionistas},
                            new SqlParameter { ParameterName = "@NombreApellidoAccionistas", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = item.NombreApellidoAccionistas},
                            new SqlParameter { ParameterName = "@TipoId", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = item.TipoId},
                            new SqlParameter { ParameterName = "@NroDocumento", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = item.NroDocumento},
                            new SqlParameter { ParameterName = "@Participacion", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = item.Participacion},
                            new SqlParameter { ParameterName = "@Nacionalidad", SqlDbType = SqlDbType.VarChar,Size=500, SqlValue = item.Nacionalidad},
                            };
                            Ado.ExecNonQueryProc(strsql7, parametros7);
                        }

                        string strsql8 = "usp_GuardarInformacionFinanciera";
                        var parametros8 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@FechaCorte", SqlDbType = SqlDbType.DateTime, SqlValue = datos.FechaCorte},
                        new SqlParameter { ParameterName = "@InformacionDebeSoles", SqlDbType = SqlDbType.Bit, SqlValue = datos.checkSolesIF},
                        new SqlParameter { ParameterName = "@InformacionDebeDolares", SqlDbType = SqlDbType.Bit, SqlValue = datos.checkDolaresIF},
                        new SqlParameter { ParameterName = "@Activos", SqlDbType = SqlDbType.Decimal, SqlValue = datos.txtActivosIF},
                        new SqlParameter { ParameterName = "@Pasivos", SqlDbType = SqlDbType.Decimal, SqlValue = datos.txtPasivosIF},
                        new SqlParameter { ParameterName = "@Patrimonio", SqlDbType = SqlDbType.Decimal, SqlValue = datos.txtPatrimonioIF},
                        new SqlParameter { ParameterName = "@IngresoMensual", SqlDbType = SqlDbType.Decimal, SqlValue = datos.txtIngresosMensualesIF},
                        new SqlParameter { ParameterName = "@EgresoMensual", SqlDbType = SqlDbType.Decimal, SqlValue = datos.txtEgresosMensualesIF},
                        new SqlParameter { ParameterName = "@OtrosIngresos", SqlDbType = SqlDbType.Decimal, SqlValue = datos.txtOtrosIngresosIF},
                        new SqlParameter { ParameterName = "@ConceptoOtrosIngresos", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtConceptoOtrosIngresosIF},
                        };
                        Ado.ExecNonQueryProc(strsql8, parametros8);

                        string strsqlDelete2 = "LimpiarReferenciasComercialesById";

                        var parametrosDelete2 = new SqlParameter[]
                        {
                            new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        };
                        Ado.ExecNonQueryProc(strsqlDelete2, parametrosDelete2);

                        string strsql9 = "usp_GuardarReferenciasComerciales";
                        foreach (var item in datos.DetalleReferenciasComerciales)
                        {
                            var parametros9 = new SqlParameter[]
                            {
                            new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                            new SqlParameter { ParameterName = "@Empresa", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = item.Empresa},
                            new SqlParameter { ParameterName = "@Ruc", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = item.Ruc},
                            new SqlParameter { ParameterName = "@Telefono", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = item.Telefono},
                            new SqlParameter { ParameterName = "@Direccion", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = item.Direccion},
                            new SqlParameter { ParameterName = "@Ciudad", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = item.Ciudad}
                            };
                            Ado.ExecNonQueryProc(strsql9, parametros9);
                        }


                        string strsql10 = "usp_GuardarReferenciaBancarias";
                        var parametros10 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@Institucion", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtInstitucionRB},
                        new SqlParameter { ParameterName = "@NroCuenta", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtNroCuentaRB},
                        new SqlParameter { ParameterName = "@TipoCuenta", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtTipoCuentaRB},
                        new SqlParameter { ParameterName = "@Beneficiario", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtBeneficiarioRB},
                        new SqlParameter { ParameterName = "@Empresa", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtEmpresaRB},
                        new SqlParameter { ParameterName = "@Ruc", SqlDbType = SqlDbType.VarChar, Size = 11, SqlValue = datos.txtRucRB},
                        new SqlParameter { ParameterName = "@Telefono", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtTelefonoRB},
                        new SqlParameter { ParameterName = "@Direccion", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.txtDireccionRB},
                        };
                        Ado.ExecNonQueryProc(strsql10, parametros10);

                        string strsql11 = "usp_GuardarControlDocumentosExigidosIngresoClientes";
                        var parametros11 = new SqlParameter[]
                        {
                                 new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                                 new SqlParameter { ParameterName = "@CopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename1},
                                 new SqlParameter { ParameterName = "@GuidCopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesCopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual", SqlDbType = SqlDbType.BigInt, SqlValue =0 },
                                 new SqlParameter { ParameterName = "@RutaCopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta1},
                                 new SqlParameter { ParameterName = "@CopiasFormularioPDTAnualRentaTerceraPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename2},
                                 new SqlParameter { ParameterName = "@GuidCopiasFormularioPDTAnualRentaTerceraPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesCopiasFormularioPDTAnualRentaTerceraPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                 new SqlParameter { ParameterName = "@RutaCopiasFormularioPDTAnualRentaTerceraPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta2},
                                 new SqlParameter { ParameterName = "@CopiaFichaRucPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename3},
                                 new SqlParameter { ParameterName = "@GuidCopiaFichaRucPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesCopiaFichaRucPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                 new SqlParameter { ParameterName = "@RutaCopiaFichaRucPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue =  datos.ruta3},
                                 new SqlParameter { ParameterName = "@CopiaDniPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename4},
                                 new SqlParameter { ParameterName = "@GuidCopiaDniPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesCopiaDniPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                 new SqlParameter { ParameterName = "@RutaCopiaDniPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta4},
                                 new SqlParameter { ParameterName = "@CertificacoReferenciaComercialPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename5},
                                 new SqlParameter { ParameterName = "@GuidCertificacoReferenciaComercialPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesCertificacoReferenciaComercialPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                 new SqlParameter { ParameterName = "@RutaCertificacoReferenciaComercialPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta5},
                                 new SqlParameter { ParameterName = "@CertificadoBancarioPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename6},
                                 new SqlParameter { ParameterName = "@GuidCertificadoBancarioPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesCertificadoBancarioPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                 new SqlParameter { ParameterName = "@RutaCertificadoBancarioPersonaNatual", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue =datos.ruta6},
                                 new SqlParameter { ParameterName = "@SituacionFinancieraBalanceGeneralPerdidasJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename7},
                                 new SqlParameter { ParameterName = "@GuidSituacionFinancieraBalanceGeneralPerdidasJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesSituacionFinancieraBalanceGeneralPerdidasJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                 new SqlParameter { ParameterName = "@RutaSituacionFinancieraBalanceGeneralPerdidasJuridicas", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta7},
                                 new SqlParameter { ParameterName = "@CopiaFormularioPDTAnualRentaTerceraJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename8},
                                 new SqlParameter { ParameterName = "@GuidCopiaFormularioPDTAnualRentaTerceraJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = Convert.ToString(Guid.NewGuid())},
                                 new SqlParameter { ParameterName = "@BytesCopiaFormularioPDTAnualRentaTerceraJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                   new SqlParameter { ParameterName = "@RutaCopiaFormularioPDTAnualRentaTerceraJuridicas", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta8},
                                   new SqlParameter { ParameterName = "@CopiaFichaRucJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename9},
                                   new SqlParameter { ParameterName = "@GuidCopiaFichaRucJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =Convert.ToString(Guid.NewGuid())},
                                   new SqlParameter { ParameterName = "@BytesCopiaFichaRucJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =  0},
                                   new SqlParameter { ParameterName = "@RutaCopiaFichaRucJuridicas", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta9},
                                   new SqlParameter { ParameterName = "@CopiaDNIRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename10},
                                   new SqlParameter { ParameterName = "@GuidCopiaDNIRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =  Convert.ToString(Guid.NewGuid())},
                                   new SqlParameter { ParameterName = "@BytesCopiaDNIRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                   new SqlParameter { ParameterName = "@RutaCopiaDNIRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta10},
                                   new SqlParameter { ParameterName = "@VigenciaPoderRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename11},
                                   new SqlParameter { ParameterName = "@GuidVigenciaPoderRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = Convert.ToString(Guid.NewGuid())},
                                   new SqlParameter { ParameterName = "@BytesVigenciaPoderRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue =0},
                                   new SqlParameter { ParameterName = "@RutaVigenciaPoderRepresentanteLegalJuridicas", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta11},
                                   new SqlParameter { ParameterName = "@CertificadoReferenciaComercialJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename12},
                                   new SqlParameter { ParameterName = "@GuidCertificadoReferenciaComercialJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = Convert.ToString(Guid.NewGuid())},
                                   new SqlParameter { ParameterName = "@BytesCertificadoReferenciaComercialJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                   new SqlParameter { ParameterName = "@RutaCertificadoReferenciaComercialJuridicas", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta12},
                                   new SqlParameter { ParameterName = "@CertificadoBancarioJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.Filename13},
                                   new SqlParameter { ParameterName = "@GuidCertificadoBancarioJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = Convert.ToString(Guid.NewGuid())},
                                   new SqlParameter { ParameterName = "@BytesCertificadoBancarioJuridicas", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = 0},
                                   new SqlParameter { ParameterName = "@RutaCertificadoBancarioJuridicas", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.ruta13},

                        };
                        Ado.ExecNonQueryProc(strsql11, parametros11);

                        string strsql12 = "usp_GuardarClasificacionUsoComercial";
                        var parametros12 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@Unidad", SqlDbType = SqlDbType.Int, SqlValue = datos.cboUnidad},
                        new SqlParameter { ParameterName = "@SubUnidad", SqlDbType = SqlDbType.Int, SqlValue = datos.cboSubUnidad},
                        new SqlParameter { ParameterName = "@AsesorComercial", SqlDbType = SqlDbType.Int, SqlValue = datos.cboAsesorComercial},
                        new SqlParameter { ParameterName = "@Descripcion", SqlDbType = SqlDbType.VarChar, Size = 1000, SqlValue = datos.txtDescripcion},

                        };
                        Ado.ExecNonQueryProc(strsql12, parametros12);

                        string strsql13 = "usp_GuardarTerminoPago";
                        var parametros13 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@tipoPago", SqlDbType = SqlDbType.Int, SqlValue = datos.cboTipoPago},
                        new SqlParameter { ParameterName = "@cupoSolicitado", SqlDbType = SqlDbType.VarChar,Size=1000, SqlValue = datos.cuposolicitado},

                        };
                        Ado.ExecNonQueryProc(strsql13, parametros13);

                        string strsql14 = "usp_GuardarVerificacionUsoInterno";
                        var parametros14 = new SqlParameter[]
                        {
                        new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = idcliente},
                        new SqlParameter { ParameterName = "@ResponsableContratacion", SqlDbType = SqlDbType.VarChar,Size=1000, SqlValue = datos.txtAsesorComercialVUI},
                        new SqlParameter { ParameterName = "@Firma", SqlDbType = SqlDbType.VarChar,Size=1000, SqlValue = ""},

                        };
                        Ado.ExecNonQueryProc(strsql14, parametros14);
 
                    }
                   
                    return mensaje;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        public DataByCodeResponse DataByCode(string Code)
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    DataByCodeResponse Entity = null;
                    var Parameters = new SqlParameter[]
                    {
                        new SqlParameter{ ParameterName = "@Code", SqlDbType = SqlDbType.VarChar,Size=1000,SqlValue=Code},
                    };
                    var Dr = Ado.ExecDataReaderProc("usp_GetDatosRegistroByCode", Parameters);
                    {
                        if (!Dr.HasRows) { return Entity; }

                        while (Dr.Read())
                        {
                            Entity = new DataByCodeResponse();
                            //--Datos Generales
                            if (Dr["Nombre_RazonSocialDatosGenerales"] != DBNull.Value) { Entity.Nombre_RazonSocialDatosGenerales = (string)Dr["Nombre_RazonSocialDatosGenerales"]; }
                            if (Dr["DireccionDatosGenerales"] != DBNull.Value) { Entity.DireccionDatosGenerales = (string)Dr["DireccionDatosGenerales"]; }
                            if (Dr["IdPaisDatosGenerales"] != DBNull.Value) { Entity.IdPaisDatosGenerales = (int)Dr["IdPaisDatosGenerales"]; }
                            if (Dr["Nombre_S_PAIS"] != DBNull.Value) { Entity.Nombre_S_PAIS = (string)Dr["Nombre_S_PAIS"]; }
                            if (Dr["CiudadSedePrincipalDatosGenerales"] != DBNull.Value) { Entity.CiudadSedePrincipalDatosGenerales = (string)Dr["CiudadSedePrincipalDatosGenerales"]; }
                            if (Dr["TelefonoFijoDatosGenerales"] != DBNull.Value) { Entity.TelefonoFijoDatosGenerales = (string)Dr["TelefonoFijoDatosGenerales"]; }
                            if (Dr["CelularDatosGenerales"] != DBNull.Value) { Entity.CelularDatosGenerales = (string)Dr["CelularDatosGenerales"]; }
                            if (Dr["CorreoEnvioFacturaElectronicaDatosGenerales"] != DBNull.Value) { Entity.CorreoEnvioFacturaElectronicaDatosGenerales = (string)Dr["CorreoEnvioFacturaElectronicaDatosGenerales"]; }
                            if (Dr["DireccionEntregaFacturaDatosGenerales"] != DBNull.Value) { Entity.DireccionEntregaFacturaDatosGenerales = (string)Dr["DireccionEntregaFacturaDatosGenerales"]; }
                            if (Dr["CiudadDireccionEntregaFacturaDatosGenerales"] != DBNull.Value) { Entity.CiudadDireccionEntregaFacturaDatosGenerales = (string)Dr["CiudadDireccionEntregaFacturaDatosGenerales"]; }
                            if (Dr["DireccionEntregaPedidoDatosGenerales"] != DBNull.Value) { Entity.DireccionEntregaPedidoDatosGenerales = (string)Dr["DireccionEntregaPedidoDatosGenerales"]; }
                            if (Dr["CiudadDireccionEntregaPedidoDatosGenerales"] != DBNull.Value) { Entity.CiudadDireccionEntregaPedidoDatosGenerales = (string)Dr["CiudadDireccionEntregaPedidoDatosGenerales"]; }
                            if (Dr["DireccionSecundariaEntregaPedidoDatosGenerales"] != DBNull.Value) { Entity.DireccionSecundariaEntregaPedidoDatosGenerales = (string)Dr["DireccionSecundariaEntregaPedidoDatosGenerales"]; }
                            if (Dr["CiudadDireccionSecundariaEntregaPedidoDatosGenerales"] != DBNull.Value) { Entity.CiudadDireccionSecundariaEntregaPedidoDatosGenerales = (string)Dr["CiudadDireccionSecundariaEntregaPedidoDatosGenerales"]; }
                            if (Dr["EstadoComercial"] != DBNull.Value) { Entity.EstadoComercial = Convert.ToInt32(Dr["EstadoComercial"]); }
                            if (Dr["EstadoCredito"] != DBNull.Value) { Entity.EstadoCredito = Convert.ToInt32(Dr["EstadoCredito"]); }
                            if (Dr["EstadoVenta"] != DBNull.Value) { Entity.EstadoVenta = Convert.ToInt32(Dr["EstadoVenta"]); }
                            if (Dr["EstadoFinanza"] != DBNull.Value) { Entity.EstadoFinanza = Convert.ToInt32(Dr["EstadoFinanza"]); }
                            if (Dr["MotivoRechazo"] != DBNull.Value) { Entity.MotivoRechazo = (string)Dr["MotivoRechazo"]; }                            
                            //----INFORMACIÓN DE CONTACTOS
                            if (Dr["NombreContactoAreaCobranza"] != DBNull.Value) { Entity.NombreContactoAreaCobranza = (string)Dr["NombreContactoAreaCobranza"]; }
                            if (Dr["TelefonoContactoAreaCobranza"] != DBNull.Value) { Entity.TelefonoContactoAreaCobranza = (string)Dr["TelefonoContactoAreaCobranza"]; }
                            if (Dr["CorreoElectronicoContactoAreaCobranza"] != DBNull.Value) { Entity.CorreoElectronicoContactoAreaCobranza = (string)Dr["CorreoElectronicoContactoAreaCobranza"]; }
                            if (Dr["NombreContactoAreaFinanciera"] != DBNull.Value) { Entity.NombreContactoAreaFinanciera = (string)Dr["NombreContactoAreaFinanciera"]; }
                            if (Dr["TelefonoContactoAreaFinanciera"] != DBNull.Value) { Entity.TelefonoContactoAreaFinanciera = (string)Dr["TelefonoContactoAreaFinanciera"]; }
                            if (Dr["CorreoContactoAreaFinanciera"] != DBNull.Value) { Entity.CorreoContactoAreaFinanciera = (string)Dr["CorreoContactoAreaFinanciera"]; }
                            if (Dr["NombreContactoAreaComercial"] != DBNull.Value) { Entity.NombreContactoAreaComercial = (string)Dr["NombreContactoAreaComercial"]; }
                            if (Dr["TelefonoContactoAreaComercial"] != DBNull.Value) { Entity.TelefonoContactoAreaComercial = (string)Dr["TelefonoContactoAreaComercial"]; }
                            if (Dr["CorreoContactoAreaComercial"] != DBNull.Value) { Entity.CorreoContactoAreaComercial = (string)Dr["CorreoContactoAreaComercial"]; }
                            //--INFORMACIÓN TRIBUTARIA
                            if (Dr["IdTipoIdentificacion"] != DBNull.Value) { Entity.IdTipoIdentificacion = (int)Dr["IdTipoIdentificacion"]; }
                            if (Dr["IdTipoContribuyete"] != DBNull.Value) { Entity.IdTipoContribuyete = (int)Dr["IdTipoContribuyete"]; }
                            if (Dr["IdTipoSociedad"] != DBNull.Value) { Entity.IdTipoSociedad = (int)Dr["IdTipoSociedad"]; }
                            if (Dr["IdActividadEconomica"] != DBNull.Value) { Entity.IdActividadEconomica = (int)Dr["IdActividadEconomica"]; }
                            if (Dr["IdRegimen"] != DBNull.Value) { Entity.IdRegimen = (int)Dr["IdRegimen"]; }
                            if (Dr["IdOrigenCapital"] != DBNull.Value) { Entity.IdOrigenCapital = (int)Dr["IdOrigenCapital"]; }
                            if (Dr["Nombre_S_TIPO_IDENTIFICACION"] != DBNull.Value) { Entity.Nombre_S_TIPO_IDENTIFICACION = (string)Dr["Nombre_S_TIPO_IDENTIFICACION"]; }
                            if (Dr["CualTipoIdentificacion"] != DBNull.Value) { Entity.CualTipoIdentificacion = (string)Dr["CualTipoIdentificacion"]; }
                            if (Dr["NumeroIdentificacion"] != DBNull.Value) { Entity.NumeroIdentificacion = (string)Dr["NumeroIdentificacion"]; }
                            if (Dr["Nombre_S_TIPO_CONTRIBUYENTE"] != DBNull.Value) { Entity.Nombre_S_TIPO_CONTRIBUYENTE = (string)Dr["Nombre_S_TIPO_CONTRIBUYENTE"]; }
                            if (Dr["Nombre_S_TIPO_SOCIEDAD"] != DBNull.Value) { Entity.Nombre_S_TIPO_SOCIEDAD = (string)Dr["Nombre_S_TIPO_SOCIEDAD"]; }
                            if (Dr["CualTipoSociedad"] != DBNull.Value) { Entity.CualTipoSociedad = (string)Dr["CualTipoSociedad"]; }
                            if (Dr["Nombre_S_ORIGEN_CAPITAL"] != DBNull.Value) { Entity.Nombre_S_ORIGEN_CAPITAL = (string)Dr["Nombre_S_ORIGEN_CAPITAL"]; }
                            if (Dr["Nombre_S_ACTIVIDAD_ECONOMICA"] != DBNull.Value) { Entity.Nombre_S_ACTIVIDAD_ECONOMICA = (string)Dr["Nombre_S_ACTIVIDAD_ECONOMICA"]; }
                            if (Dr["CualActividadEconomica"] != DBNull.Value) { Entity.CualActividadEconomica = (string)Dr["CualActividadEconomica"]; }
                            if (Dr["TitularVigiladoPorAlgunaSuperIntendencia"] != DBNull.Value) { Entity.TitularVigiladoPorAlgunaSuperIntendencia = (string)Dr["TitularVigiladoPorAlgunaSuperIntendencia"]; }
                            if (Dr["FechaConstitucion"] != DBNull.Value) { Entity.FechaConstitucion = (DateTime)Dr["FechaConstitucion"]; }
                            if (Dr["Nombre_S_REGIMEN"] != DBNull.Value) { Entity.Nombre_S_REGIMEN = (string)Dr["Nombre_S_REGIMEN"]; }
                            //--INFORMACIÓN ACTIVIDAD ECONÓMICA
                            if (Dr["ActidadPrincipal"] != DBNull.Value) { Entity.ActidadPrincipal = (string)Dr["ActidadPrincipal"]; }
                            if (Dr["ActividadSecundaria"] != DBNull.Value) { Entity.ActividadSecundaria = (string)Dr["ActividadSecundaria"]; }
                            //--INFORMACION DE REPRESENTACION LEGAL
                            if (Dr["IdTipoIdentificacion_RL"] != DBNull.Value) { Entity.IdTipoIdentificacion_RL = Convert.ToInt32(Dr["IdTipoIdentificacion_RL"]); }
                            if (Dr["IdNacionalidad"] != DBNull.Value) { Entity.IdNacionalidad = (int)Dr["IdNacionalidad"]; }
                            if (Dr["NombreRepresentanteLegal"] != DBNull.Value) { Entity.NombreRepresentanteLegal = (string)Dr["NombreRepresentanteLegal"]; }
                            if (Dr["Nombre_S_TIPO_IDENTIFICACION_RL"] != DBNull.Value) { Entity.Nombre_S_TIPO_IDENTIFICACION_RL = (string)Dr["Nombre_S_TIPO_IDENTIFICACION_RL"]; }
                            if (Dr["NumeroIdentificacion_RL"] != DBNull.Value) { Entity.NumeroIdentificacion_RL = (string)Dr["NumeroIdentificacion_RL"]; }
                            if (Dr["Nombre_S_NACIONALIDAD"] != DBNull.Value) { Entity.Nombre_S_NACIONALIDAD = (string)Dr["Nombre_S_NACIONALIDAD"]; }
                            if (Dr["CualNacionalidad"] != DBNull.Value) { Entity.CualNacionalidad = (string)Dr["CualNacionalidad"]; }
                            if (Dr["FechaExpedicionDocumento"] != DBNull.Value) { Entity.FechaExpedicionDocumento = (DateTime)Dr["FechaExpedicionDocumento"]; }
                            if (Dr["DireccionResidencia"] != DBNull.Value) { Entity.DireccionResidencia = (string)Dr["DireccionResidencia"]; }
                            if (Dr["Ciudad_RL"] != DBNull.Value) { Entity.Ciudad_RL = (string)Dr["Ciudad_RL"]; }
                            //--PREGUNTAS PEP
                            if (Dr["GozaReconocimientoPublico"] != DBNull.Value) { Entity.GozaReconocimientoPublico = (bool)Dr["GozaReconocimientoPublico"]; }
                            if (Dr["EspecifiqueGozaReconocimientoPublico"] != DBNull.Value) { Entity.EspecifiqueGozaReconocimientoPublico = (string)Dr["EspecifiqueGozaReconocimientoPublico"]; }
                            if (Dr["ManejaRecursosPublicos"] != DBNull.Value) { Entity.ManejaRecursosPublicos = (bool)Dr["ManejaRecursosPublicos"]; }
                            if (Dr["EspecifiqueManejaRecursosPublicos"] != DBNull.Value) { Entity.EspecifiqueManejaRecursosPublicos = (string)Dr["EspecifiqueManejaRecursosPublicos"]; }
                            if (Dr["OcupaCargosPublicos"] != DBNull.Value) { Entity.OcupaCargosPublicos = (bool)Dr["OcupaCargosPublicos"]; }
                            if (Dr["EspecifiqueOcupaCargosPublicos"] != DBNull.Value) { Entity.EspecifiqueOcupaCargosPublicos = (string)Dr["EspecifiqueOcupaCargosPublicos"]; }
                            if (Dr["ExisteVinculoEntreUstedPersonaPublicamenteExpuesta"] != DBNull.Value) { Entity.ExisteVinculoEntreUstedPersonaPublicamenteExpuesta = (bool)Dr["ExisteVinculoEntreUstedPersonaPublicamenteExpuesta"]; }
                            if (Dr["EspecifiqueExisteVinculoEntreUstedPersonaPublicamenteExpuesta"] != DBNull.Value) { Entity.EspecifiqueExisteVinculoEntreUstedPersonaPublicamenteExpuesta = (string)Dr["EspecifiqueExisteVinculoEntreUstedPersonaPublicamenteExpuesta"]; }
                            if (Dr["ExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed"] != DBNull.Value) { Entity.ExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed = (bool)Dr["ExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed"]; }
                            if (Dr["EspecifiqueExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed"] != DBNull.Value) { Entity.EspecifiqueExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed = (string)Dr["EspecifiqueExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed"]; }
                            if (Dr["CasoAfirmativoEspecifiquePersonaConVinculo"] != DBNull.Value) { Entity.CasoAfirmativoEspecifiquePersonaConVinculo = (string)Dr["CasoAfirmativoEspecifiquePersonaConVinculo"]; }
                            if (Dr["Cargo"] != DBNull.Value) { Entity.Cargo = (string)Dr["Cargo"]; }
                            //--INFORMACIÓN DE SOCIOS O ACCIONISTAS (UNICAMENTE APLICA PARA PERSONAS JURIDICAS) --- pendiente ---ARRAYLIST G
                            //--INFORMACIÓN FINANCIERA
                            if (Dr["FechaCorte"] != DBNull.Value) { Entity.FechaCorte = (DateTime)Dr["FechaCorte"]; }
                            if (Dr["InformacionDebeSoles"] != DBNull.Value) { Entity.InformacionDebeSoles = (bool)Dr["InformacionDebeSoles"]; }
                            if (Dr["InformacionDebeDolares"] != DBNull.Value) { Entity.InformacionDebeDolares = (bool)Dr["InformacionDebeDolares"]; }
                            if (Dr["Activos"] != DBNull.Value) { Entity.Activos = (decimal)Dr["Activos"]; }
                            if (Dr["Pasivos"] != DBNull.Value) { Entity.Pasivos = (decimal)Dr["Pasivos"]; }
                            if (Dr["Patrimonio"] != DBNull.Value) { Entity.Patrimonio = (decimal)Dr["Patrimonio"]; }
                            if (Dr["IngresoMensual"] != DBNull.Value) { Entity.IngresoMensual = (decimal)Dr["IngresoMensual"]; }
                            if (Dr["EgresoMensual"] != DBNull.Value) { Entity.EgresoMensual = (decimal)Dr["EgresoMensual"]; }
                            if (Dr["OtrosIngresos"] != DBNull.Value) { Entity.OtrosIngresos = (decimal)Dr["OtrosIngresos"]; }
                            if (Dr["ConceptoOtrosIngresos"] != DBNull.Value) { Entity.ConceptoOtrosIngresos = (string)Dr["ConceptoOtrosIngresos"]; }
                            //REFERENCIA COMERCIAL ---PENDIENTE --ARRAYLST
                            //REFERENCIA BANCARIA
                            if (Dr["Institucion"] != DBNull.Value) { Entity.Institucion = (string)Dr["Institucion"]; }
                            if (Dr["NroCuenta"] != DBNull.Value) { Entity.NroCuenta = (string)Dr["NroCuenta"]; }
                            if (Dr["TipoCuenta"] != DBNull.Value) { Entity.TipoCuenta = (string)Dr["TipoCuenta"]; }
                            if (Dr["Beneficiario"] != DBNull.Value) { Entity.Beneficiario = (string)Dr["Beneficiario"]; }
                            if (Dr["Empresa"] != DBNull.Value) { Entity.Empresa = (string)Dr["Empresa"]; }
                            if (Dr["Ruc"] != DBNull.Value) { Entity.Ruc = (string)Dr["Ruc"]; }
                            if (Dr["Telefono"] != DBNull.Value) { Entity.Telefono = (string)Dr["Telefono"]; }
                            if (Dr["Direccion"] != DBNull.Value) { Entity.Direccion = (string)Dr["Direccion"]; }
                            //CONTROL DOCUMENTOS EXIGIDOS
                            if (Dr["CopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual"] != DBNull.Value) { Entity.CopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual = (string)Dr["CopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual"]; }
                            if (Dr["RutaCopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual"] != DBNull.Value) { Entity.RutaCopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual = (string)Dr["RutaCopiasTresUltimasDeclaracionesPDTIGV621PersonaNatual"]; }
                            if (Dr["CopiasFormularioPDTAnualRentaTerceraPersonaNatual"] != DBNull.Value) { Entity.CopiasFormularioPDTAnualRentaTerceraPersonaNatual = (string)Dr["CopiasFormularioPDTAnualRentaTerceraPersonaNatual"]; }
                            if (Dr["RutaCopiasFormularioPDTAnualRentaTerceraPersonaNatual"] != DBNull.Value) { Entity.RutaCopiasFormularioPDTAnualRentaTerceraPersonaNatual = (string)Dr["RutaCopiasFormularioPDTAnualRentaTerceraPersonaNatual"]; }
                            if (Dr["CopiaFichaRucPersonaNatual"] != DBNull.Value) { Entity.CopiaFichaRucPersonaNatual = (string)Dr["CopiaFichaRucPersonaNatual"]; }
                            if (Dr["RutaCopiaFichaRucPersonaNatual"] != DBNull.Value) { Entity.RutaCopiaFichaRucPersonaNatual = (string)Dr["RutaCopiaFichaRucPersonaNatual"]; }
                            if (Dr["CopiaDniPersonaNatual"] != DBNull.Value) { Entity.CopiaDniPersonaNatual = (string)Dr["CopiaDniPersonaNatual"]; }
                            if (Dr["RutaCopiaDniPersonaNatual"] != DBNull.Value) { Entity.RutaCopiaDniPersonaNatual = (string)Dr["RutaCopiaDniPersonaNatual"]; }
                            if (Dr["CertificacoReferenciaComercialPersonaNatual"] != DBNull.Value) { Entity.CertificacoReferenciaComercialPersonaNatual = (string)Dr["CertificacoReferenciaComercialPersonaNatual"]; }
                            if (Dr["RutaCertificacoReferenciaComercialPersonaNatual"] != DBNull.Value) { Entity.RutaCertificacoReferenciaComercialPersonaNatual = (string)Dr["RutaCertificacoReferenciaComercialPersonaNatual"]; }
                            if (Dr["CertificadoBancarioPersonaNatual"] != DBNull.Value) { Entity.CertificadoBancarioPersonaNatual = (string)Dr["CertificadoBancarioPersonaNatual"]; }
                            if (Dr["RutaCertificadoBancarioPersonaNatual"] != DBNull.Value) { Entity.RutaCertificadoBancarioPersonaNatual = (string)Dr["RutaCertificadoBancarioPersonaNatual"]; }
                            if (Dr["SituacionFinancieraBalanceGeneralPerdidasJuridicas"] != DBNull.Value) { Entity.SituacionFinancieraBalanceGeneralPerdidasJuridicas = (string)Dr["SituacionFinancieraBalanceGeneralPerdidasJuridicas"]; }
                            if (Dr["RutaSituacionFinancieraBalanceGeneralPerdidasJuridicas"] != DBNull.Value) { Entity.RutaSituacionFinancieraBalanceGeneralPerdidasJuridicas = (string)Dr["RutaSituacionFinancieraBalanceGeneralPerdidasJuridicas"]; }
                            if (Dr["CopiaFormularioPDTAnualRentaTerceraJuridicas"] != DBNull.Value) { Entity.CopiaFormularioPDTAnualRentaTerceraJuridicas = (string)Dr["CopiaFormularioPDTAnualRentaTerceraJuridicas"]; }
                            if (Dr["RutaCopiaFormularioPDTAnualRentaTerceraJuridicas"] != DBNull.Value) { Entity.RutaCopiaFormularioPDTAnualRentaTerceraJuridicas = (string)Dr["RutaCopiaFormularioPDTAnualRentaTerceraJuridicas"]; }
                            if (Dr["CopiaFichaRucJuridicas"] != DBNull.Value) { Entity.CopiaFichaRucJuridicas = (string)Dr["CopiaFichaRucJuridicas"]; }
                            if (Dr["RutaCopiaFichaRucJuridicas"] != DBNull.Value) { Entity.RutaCopiaFichaRucJuridicas = (string)Dr["RutaCopiaFichaRucJuridicas"]; }
                            if (Dr["CopiaDNIRepresentanteLegalJuridicas"] != DBNull.Value) { Entity.CopiaDNIRepresentanteLegalJuridicas = (string)Dr["CopiaDNIRepresentanteLegalJuridicas"]; }
                            if (Dr["RutaCopiaDNIRepresentanteLegalJuridicas"] != DBNull.Value) { Entity.RutaCopiaDNIRepresentanteLegalJuridicas = (string)Dr["RutaCopiaDNIRepresentanteLegalJuridicas"]; }
                            if (Dr["VigenciaPoderRepresentanteLegalJuridicas"] != DBNull.Value) { Entity.VigenciaPoderRepresentanteLegalJuridicas = (string)Dr["VigenciaPoderRepresentanteLegalJuridicas"]; }
                            if (Dr["RutaVigenciaPoderRepresentanteLegalJuridicas"] != DBNull.Value) { Entity.RutaVigenciaPoderRepresentanteLegalJuridicas = (string)Dr["RutaVigenciaPoderRepresentanteLegalJuridicas"]; }
                            if (Dr["CertificadoReferenciaComercialJuridicas"] != DBNull.Value) { Entity.CertificadoReferenciaComercialJuridicas = (string)Dr["CertificadoReferenciaComercialJuridicas"]; }
                            if (Dr["RutaCertificadoReferenciaComercialJuridicas"] != DBNull.Value) { Entity.RutaCertificadoReferenciaComercialJuridicas = (string)Dr["RutaCertificadoReferenciaComercialJuridicas"]; }
                            if (Dr["CertificadoBancarioJuridicas"] != DBNull.Value) { Entity.CertificadoBancarioJuridicas = (string)Dr["CertificadoBancarioJuridicas"]; }
                            if (Dr["RutaCertificadoBancarioJuridicas"] != DBNull.Value) { Entity.RutaCertificadoBancarioJuridicas = (string)Dr["RutaCertificadoBancarioJuridicas"]; }
                            //CLASIFICACION PARA USO COMERCIAL
                            if (Dr["Unidad"] != DBNull.Value) { Entity.Unidad = (int)Dr["Unidad"]; }
                            if (Dr["SubUnidad"] != DBNull.Value) { Entity.SubUnidad = (int)Dr["SubUnidad"]; }
                            if (Dr["AsesorComercial"] != DBNull.Value) { Entity.AsesorComercial = (int)Dr["AsesorComercial"]; }
                            if (Dr["DescripcionUnidad"] != DBNull.Value) { Entity.DescripcionUnidad = (string)Dr["DescripcionUnidad"]; }
                            if (Dr["Nombre_S_SUB_UNIDAD"] != DBNull.Value) { Entity.Nombre_S_SUB_UNIDAD = (string)Dr["Nombre_S_SUB_UNIDAD"]; }
                            if (Dr["Nombre_S_ASESOR_COMERCIAL"] != DBNull.Value) { Entity.Nombre_S_ASESOR_COMERCIAL = (string)Dr["Nombre_S_ASESOR_COMERCIAL"]; }
                            if (Dr["Descripcion"] != DBNull.Value) { Entity.Descripcion = (string)Dr["Descripcion"]; }
                            //TERMINO DE PAGO
                            if (Dr["tipoPago"] != DBNull.Value) { Entity.IdTerminoPago = (int)Dr["tipoPago"]; }
                            if (Dr["DescripcionPago"] != DBNull.Value) { Entity.DescripcionPAGO = (string)Dr["DescripcionPago"]; }
                            if (Dr["cupoSolicitado"] != DBNull.Value) { Entity.cupoSolicitado = (string)Dr["cupoSolicitado"]; }
                            //VERIFICACION PARA USO EXTERNO
                            if (Dr["ResponsableContratacion"] != DBNull.Value) { Entity.ResponsableContratacion = (string)Dr["ResponsableContratacion"]; }
                            if (Dr["Firma"] != DBNull.Value) { Entity.Firma = (string)Dr["Firma"]; }
 
                            break;
                        }

                        Dr.Close();

                        var ParametersDetalle = new SqlParameter[]
                        {
                        new SqlParameter{ ParameterName = "@Code", SqlDbType = SqlDbType.VarChar,SqlValue=Code},
                        };
                        var DrMain = Ado.ExecDataReaderProc("usp_GetDatosDetalleInformacionSocios", ParametersDetalle);

                        List<listadoDetalleInformacionSocios> DetalleInformacionSocio = new List<listadoDetalleInformacionSocios>();

                        while (DrMain.Read())
                        {
                            listadoDetalleInformacionSocios EntityInformacionSocio = new listadoDetalleInformacionSocios();

                            if (DrMain["IdClienteDatosGenerales"] != DBNull.Value)
                                EntityInformacionSocio.IdClienteDatosGenerales = (int)DrMain["IdClienteDatosGenerales"];
                            if (DrMain["CompañiaCuentaAccionistas"] != DBNull.Value)
                                EntityInformacionSocio.CompañiaCuentaAccionistas = (bool)DrMain["CompañiaCuentaAccionistas"];
                            if (DrMain["NombreApellidoAccionistas"] != DBNull.Value)
                                EntityInformacionSocio.NombreApellidoAccionistas = (string)DrMain["NombreApellidoAccionistas"];
                            if (DrMain["TipoId"] != DBNull.Value)
                                EntityInformacionSocio.TipoId = (string)DrMain["TipoId"];
                            if (DrMain["NroDocumento"] != DBNull.Value)
                                EntityInformacionSocio.NroDocumento = (string)DrMain["NroDocumento"];
                            if (DrMain["Participacion"] != DBNull.Value)
                                EntityInformacionSocio.Participacion = (string)DrMain["Participacion"];
                            if (DrMain["Nacionalidad"] != DBNull.Value)
                                EntityInformacionSocio.Nacionalidad = (string)DrMain["Nacionalidad"];

                            DetalleInformacionSocio.Add(EntityInformacionSocio);
                        }

                        DrMain.Close();

                        var ParametersDetalle2 = new SqlParameter[]
                        {
                        new SqlParameter{ ParameterName = "@Code", SqlDbType = SqlDbType.VarChar,SqlValue=Code},
                        };
                        var DrMain2 = Ado.ExecDataReaderProc("usp_GetDatosDetalleReferenciaComercial", ParametersDetalle2);

                        List<listadoDetalleReferenciaComercial> DetalleReferenciaComercial = new List<listadoDetalleReferenciaComercial>();

                        while (DrMain2.Read())
                        {
                            listadoDetalleReferenciaComercial EntityReferenciaComercial = new listadoDetalleReferenciaComercial();

                            if (DrMain2["IdClienteDatosGenerales"] != DBNull.Value)
                                EntityReferenciaComercial.IdClienteDatosGenerales = (int)DrMain2["IdClienteDatosGenerales"];
                            if (DrMain2["Empresa"] != DBNull.Value)
                                EntityReferenciaComercial.Empresa = (string)DrMain2["Empresa"];
                            if (DrMain2["Ruc"] != DBNull.Value)
                                EntityReferenciaComercial.Ruc = (string)DrMain2["Ruc"];
                            if (DrMain2["Telefono"] != DBNull.Value)
                                EntityReferenciaComercial.Telefono = (string)DrMain2["Telefono"];
                            if (DrMain2["Direccion"] != DBNull.Value)
                                EntityReferenciaComercial.Direccion = (string)DrMain2["Direccion"];
                            if (DrMain2["Ciudad"] != DBNull.Value)
                                EntityReferenciaComercial.Ciudad = (string)DrMain2["Ciudad"];
                              
                            DetalleReferenciaComercial.Add(EntityReferenciaComercial);
                        }

                        DrMain2.Close();
 
                        Entity.DetalleReferenciaComercial = DetalleReferenciaComercial;
                        Entity.DetalleInformacionSocio = DetalleInformacionSocio;
                        return Entity;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool AprobarFormularioCliente(UpdateEstadoYPerfilRequest request)
        {
            using (var Ado = new SQLServer(ConStr))
                try
                {
                    Ado.BeginTransaction();
                    var Parameters = new SqlParameter[]
                    {
                        new SqlParameter{ParameterName="@IdPerfil",SqlDbType=SqlDbType.Int,Size=50,SqlValue=request.IdPerfil},
                        new SqlParameter{ParameterName="@Code",SqlDbType=SqlDbType.VarChar,Size=500,SqlValue=request.Code},
                        new SqlParameter{ParameterName="@UsuarioId",SqlDbType=SqlDbType.Int,Size=50,SqlValue=request.UsuarioId},
                    };

                    Ado.ExecNonQueryProcTransaction("usp_AprobarRegistroByPerfil", Parameters);
                    Ado.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Ado.Rollback();
                    throw ex;
                }
        }

        public bool RechazarFormularioCliente(UpdateEstadoYPerfilRequest request)
        {
            using (var Ado = new SQLServer(ConStr))
                try
                {
                    Ado.BeginTransaction();
                    var Parameters = new SqlParameter[]
                    {
                        new SqlParameter{ParameterName="@IdPerfil",SqlDbType=SqlDbType.Int,Size=50,SqlValue=request.IdPerfil},
                        new SqlParameter{ParameterName="@Code",SqlDbType=SqlDbType.VarChar,Size=500,SqlValue=request.Code},
                        new SqlParameter{ParameterName="@UsuarioId",SqlDbType=SqlDbType.Int,Size=50,SqlValue=request.UsuarioId},
                        new SqlParameter{ParameterName="@MensajeRechazado",SqlDbType=SqlDbType.VarChar,Size=500,SqlValue=request.MensajeRechazado},
                    };

                    Ado.ExecNonQueryProcTransaction("usp_RechazarRegistroByPerfil", Parameters);
                    Ado.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Ado.Rollback();
                    throw ex;
                }
        }
    }
}
