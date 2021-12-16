using Simed.Entity.Request;
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

        public int GuardarFormulario(FormularioRequestCliente datos)
        {
            using (var Ado = new SQLServer(ConStr))
                try
                {
                    string strsql = "usp_GuardarFormularioCliente";
                    var parametros = new SqlParameter[]
                    {
                       new SqlParameter { ParameterName = "@IdClienteDatosGenerales", SqlDbType = SqlDbType.Int, Direction= ParameterDirection.Output},
                       new SqlParameter { ParameterName = "@Nombre_RazonSocialDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.NombreRazonSocialDG },
                       new SqlParameter { ParameterName = "@DireccionDatosGenerales", SqlDbType = SqlDbType.VarChar, Size = 100, SqlValue = datos.DireccionDG },
                       new SqlParameter { ParameterName = "@IdPaisDatosGenerales", SqlDbType = SqlDbType.Int, SqlValue = datos.PaisId },
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
                       new SqlParameter { ParameterName = "@IdUsuario", SqlDbType = SqlDbType.Int, SqlValue = 0},
                    };
                    Ado.ExecNonQueryProc(strsql, parametros);
                    var idcliente = Convert.ToInt32(parametros[0].Value.ToString());

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

                    string strsql9 = "usp_GuardarReferenciasComerciales";
                    foreach(var item in datos.DetalleReferenciasComerciales)
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

                    return idcliente;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

    }
}
