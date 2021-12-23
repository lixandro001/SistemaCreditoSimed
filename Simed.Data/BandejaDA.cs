﻿using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Simed.Data
{
    public class BandejaDA
    {
        private string ConStr;
        public BandejaDA(string ConStr)
        {
            this.ConStr = ConStr;
        }
        public void Disponse()
        {
            GC.SuppressFinalize(this);
        }

        public List<BandejaClienteResponse> GetBandejaCliente(DateTime StartDate, DateTime EndDate, int PerfilId)
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<BandejaClienteResponse> List = new List<BandejaClienteResponse>();
                    var Parameters = new SqlParameter[]
                    {
                        new SqlParameter{ ParameterName = "@PerfilId", SqlDbType = SqlDbType.Int,SqlValue=PerfilId},
                        new SqlParameter{ ParameterName = "@StartDate", SqlDbType = SqlDbType.DateTime, SqlValue = StartDate},
                        new SqlParameter{ ParameterName = "@EndDate", SqlDbType = SqlDbType.DateTime, SqlValue= EndDate }
                    };
                    var Dr = Ado.ExecDataReaderProc("usp_GetBandejaCliente", Parameters);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new BandejaClienteResponse();                            
                            if (Dr["CodeClienteDatosGenerales"] != DBNull.Value) { Entity.CodeClienteDatosGenerales = Convert.ToString(Dr["CodeClienteDatosGenerales"]); }
                            if (Dr["Nombre_RazonSocialDatosGenerales"] != DBNull.Value) { Entity.Nombre_RazonSocialDatosGenerales = Convert.ToString(Dr["Nombre_RazonSocialDatosGenerales"]); }
                            if (Dr["DireccionDatosGenerales"] != DBNull.Value) { Entity.DireccionDatosGenerales = Convert.ToString(Dr["DireccionDatosGenerales"]); }
                            if (Dr["CiudadSedePrincipalDatosGenerales"] != DBNull.Value) { Entity.CiudadSedePrincipalDatosGenerales = Convert.ToString(Dr["CiudadSedePrincipalDatosGenerales"]); }
                            if (Dr["CelularDatosGenerales"] != DBNull.Value) { Entity.CelularDatosGenerales = Convert.ToString(Dr["CelularDatosGenerales"]); }
                            if (Dr["Nombre_S_PAIS"] != DBNull.Value) { Entity.Nombre_S_PAIS = Convert.ToString(Dr["Nombre_S_PAIS"]); }
                            if (Dr["Estado"] != DBNull.Value) { Entity.Estado = Convert.ToString(Dr["Estado"]); }

                            List.Add(Entity);
                        }
                        return List;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
