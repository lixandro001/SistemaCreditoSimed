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
                    return idcliente;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

    }
}
