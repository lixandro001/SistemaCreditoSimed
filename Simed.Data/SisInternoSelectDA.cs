using Simed.Entity.SisInternoSelect.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Data
{
    public class SisInternoSelectDA
    {
        private string ConStr;
        public SisInternoSelectDA(string ConStr)
        {
            this.ConStr = ConStr;
        }
        public void Disponse()
        {
            GC.SuppressFinalize(this);
        }

        public List<CategoriaClienteListResponse> GetCategoriaCliente()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<CategoriaClienteListResponse> List = new List<CategoriaClienteListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetCategoriaCliente", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new CategoriaClienteListResponse();
                            if (Dr["Id_S_Categoria_Cliente"] != DBNull.Value) { Entity.Id_S_Categoria_Cliente = (int)Dr["Id_S_Categoria_Cliente"]; }
                            if (Dr["Nombre_S_Categoria_Cliente"] != DBNull.Value) { Entity.Nombre_S_Categoria_Cliente = (string)Dr["Nombre_S_Categoria_Cliente"]; }

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

        public List<PreciosListResponse> GetPrecios()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<PreciosListResponse> List = new List<PreciosListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetListaPrecios", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new PreciosListResponse();
                            if (Dr["Id_S_Lista_Precios"] != DBNull.Value) { Entity.Id_S_Lista_Precios = (int)Dr["Id_S_Lista_Precios"]; }
                            if (Dr["Nombre_S_Lista_Precios"] != DBNull.Value) { Entity.Nombre_S_Lista_Precios = (string)Dr["Nombre_S_Lista_Precios"]; }

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

        public List<TipoIdentificacionListResponse> GetTipoIdentificacion()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<TipoIdentificacionListResponse> List = new List<TipoIdentificacionListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetTipoIdentificacion", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new TipoIdentificacionListResponse();
                            if (Dr["Id_S_Tipo_Identificacion"] != DBNull.Value) { Entity.Id_S_Tipo_Identificacion = (int)Dr["Id_S_Tipo_Identificacion"]; }
                            if (Dr["Nombre_S_Tipo_Identificacion"] != DBNull.Value) { Entity.Nombre_S_Tipo_Identificacion = (string)Dr["Nombre_S_Tipo_Identificacion"]; }

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

        public List<TipoContribuyenteListResponse> GetTipoContribuyente()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<TipoContribuyenteListResponse> List = new List<TipoContribuyenteListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetTipoContribuyente", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new TipoContribuyenteListResponse();
                            if (Dr["Id_S_Tipo_Contribuyente"] != DBNull.Value) { Entity.Id_S_Tipo_Contribuyente = (int)Dr["Id_S_Tipo_Contribuyente"]; }
                            if (Dr["Nombre_S_Tipo_Contribuyente"] != DBNull.Value) { Entity.Nombre_S_Tipo_Contribuyente = (string)Dr["Nombre_S_Tipo_Contribuyente"]; }

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

        public List<TipoSociedadListResponse> GetTipoSociedad()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<TipoSociedadListResponse> List = new List<TipoSociedadListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetTipoSociedad", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new TipoSociedadListResponse();
                            if (Dr["Id_S_Tipo_Sociedad"] != DBNull.Value) { Entity.Id_S_Tipo_Sociedad = (int)Dr["Id_S_Tipo_Sociedad"]; }
                            if (Dr["Nombre_S_Tipo_Sociedad"] != DBNull.Value) { Entity.Nombre_S_Tipo_Sociedad = (string)Dr["Nombre_S_Tipo_Sociedad"]; }

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

        public List<OrigenCapitalListResponse> GetOrigenCapital()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<OrigenCapitalListResponse> List = new List<OrigenCapitalListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetOrigenCapital", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new OrigenCapitalListResponse();
                            if (Dr["Id_S_Origen_Capital"] != DBNull.Value) { Entity.Id_S_Origen_Capital = (int)Dr["Id_S_Origen_Capital"]; }
                            if (Dr["Nombre_S_Origen_Capital"] != DBNull.Value) { Entity.Nombre_S_Origen_Capital = (string)Dr["Nombre_S_Origen_Capital"]; }

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

        public List<PaisListResponse> GetPais()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<PaisListResponse> List = new List<PaisListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetPais", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new PaisListResponse();
                            if (Dr["Id_S_Pais"] != DBNull.Value) { Entity.Id_S_Pais = (int)Dr["Id_S_Pais"]; }
                            if (Dr["Nombre_S_Pais"] != DBNull.Value) { Entity.Nombre_S_Pais = (string)Dr["Nombre_S_Pais"]; }

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

        public List<ActividadEconomicaListResponse> GetActividadEconomica()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<ActividadEconomicaListResponse> List = new List<ActividadEconomicaListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetActividadEconomica", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new ActividadEconomicaListResponse();
                            if (Dr["Id_S_Actividad_Economica"] != DBNull.Value) { Entity.Id_S_Actividad_Economica = (int)Dr["Id_S_Actividad_Economica"]; }
                            if (Dr["Nombre_S_Actividad_Economica"] != DBNull.Value) { Entity.Nombre_S_Actividad_Economica = (string)Dr["Nombre_S_Actividad_Economica"]; }

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

        public List<RegimenListResponse> GetRegimen()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<RegimenListResponse> List = new List<RegimenListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetRegimen", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new RegimenListResponse();
                            if (Dr["Id_S_Regimen"] != DBNull.Value) { Entity.Id_S_Regimen = (int)Dr["Id_S_Regimen"]; }
                            if (Dr["Nombre_S_Regimen"] != DBNull.Value) { Entity.Nombre_S_Regimen = (string)Dr["Nombre_S_Regimen"]; }

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

        public List<NacionalidadListResponse> GetNacionalidad()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<NacionalidadListResponse> List = new List<NacionalidadListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetNacionalidad", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new NacionalidadListResponse();
                            if (Dr["Id_S_Nacionalidad"] != DBNull.Value) { Entity.Id_S_Nacionalidad = (int)Dr["Id_S_Nacionalidad"]; }
                            if (Dr["Nombre_S_Nacionalidad"] != DBNull.Value) { Entity.Nombre_S_Nacionalidad = (string)Dr["Nombre_S_Nacionalidad"]; }

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

        public List<BiocienciasListResponse> GetBiociencias()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<BiocienciasListResponse> List = new List<BiocienciasListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetBiociencias", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new BiocienciasListResponse();
                            if (Dr["Id_S_Biocencia"] != DBNull.Value) { Entity.Id_S_Biocencia = (int)Dr["Id_S_Biocencia"]; }
                            if (Dr["Nombre_S_Biocencia"] != DBNull.Value) { Entity.Nombre_S_Biocencia = (string)Dr["Nombre_S_Biocencia"]; }

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

        public List<SubUnidadListResponse> GetSubUnidad()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<SubUnidadListResponse> List = new List<SubUnidadListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetSubUnidad", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new SubUnidadListResponse();
                            if (Dr["Id_S_Sub_Unidad"] != DBNull.Value) { Entity.Id_S_Sub_Unidad = (int)Dr["Id_S_Sub_Unidad"]; }
                            if (Dr["Nombre_S_Sub_Unidad"] != DBNull.Value) { Entity.Nombre_S_Sub_Unidad = (string)Dr["Nombre_S_Sub_Unidad"]; }

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

        public List<AsesorComercialListResponse> GetAsesorComercial()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<AsesorComercialListResponse> List = new List<AsesorComercialListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetAsesorComercial", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new AsesorComercialListResponse();
                            if (Dr["Id_S_Asesor_Comercial"] != DBNull.Value) { Entity.Id_S_Asesor_Comercial = (int)Dr["Id_S_Asesor_Comercial"]; }
                            if (Dr["Nombre_S_Asesor_Comercial"] != DBNull.Value) { Entity.Nombre_S_Asesor_Comercial = (string)Dr["Nombre_S_Asesor_Comercial"]; }

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

        public List<UnidadListResponse> GetUnidad()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<UnidadListResponse> List = new List<UnidadListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetUnidad", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new UnidadListResponse();
                            if (Dr["IdUnidad"] != DBNull.Value) { Entity.IdUnidad = (int)Dr["IdUnidad"]; }
                            if (Dr["DescripcionUnidad"] != DBNull.Value) { Entity.DescripcionUnidad = (string)Dr["DescripcionUnidad"]; }

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

        public List<TipoPagoListResponse> GetTipoPago()
        {
            using (var Ado = new SQLServer(ConStr))
            {
                try
                {
                    List<TipoPagoListResponse> List = new List<TipoPagoListResponse>();
                    var Dr = Ado.ExecDataReaderProc("usp_GetTipoPago", null);
                    {
                        if (!Dr.HasRows) { return List; }
                        while (Dr.Read())
                        {
                            var Entity = new TipoPagoListResponse();
                            if (Dr["IdTipoPago"] != DBNull.Value) { Entity.IdTipoPago = (int)Dr["IdTipoPago"]; }
                            if (Dr["Descripcion"] != DBNull.Value) { Entity.Descripcion = (string)Dr["Descripcion"]; }

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
