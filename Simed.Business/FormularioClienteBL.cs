using Simed.Data;
using Simed.Entity.Request;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Business
{
    public class FormularioClienteBL
    {
        private FormularioClienteDA objGuardarFormulario;
        public FormularioClienteBL(string ConStr)
        {
            objGuardarFormulario = new FormularioClienteDA(ConStr);
        }
        public void Disponse()
        {
            GC.SuppressFinalize(this);
        }

        public int GuardarFormulario(EnviarFromulatioRequestCliente request)
        {
            try
            {
                return objGuardarFormulario.GuardarFormulario(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataByCodeResponse DataByCode(string Code)
        {
            try
            {
                return objGuardarFormulario.DataByCode(Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AprobarFormularioCliente(UpdateEstadoYPerfilRequest request)
        {
            return objGuardarFormulario.AprobarFormularioCliente(request);
        }

        public bool RechazarFormularioCliente(UpdateEstadoYPerfilRequest request)
        {
            return objGuardarFormulario.RechazarFormularioCliente(request);
        }

        public bool ReiniciarFormulario(UpdateEstadoYPerfilRequest request)
        {
            return objGuardarFormulario.ReiniciarFormulario(request);
        }

        public bool eliminarUsuarios(EliminarUsuarioRequest request)
        {
            return objGuardarFormulario.eliminarUsuarios(request);
        }
        public ListaUsuarioResponse DataUsuario(string CodeUsuario)
        {
            return objGuardarFormulario.DataUsuario(CodeUsuario);
        }

        public string InsertarEvaluacionDocumento(InsertarEvaluacionDocumento request)
        {
            return objGuardarFormulario.InsertarEvaluacionDocumento(request);
        }

        public string guardarUsuarios(UsuariosRequest request)
        {
            return objGuardarFormulario.guardarUsuarios(request);
        }
        public string guardarinformacionfinanciera(InformacionFinancieraRequest request)
        {
            return objGuardarFormulario.guardarinformacionfinanciera(request);
        }
         
        public List<ListaUsuarioResponse> GetListadoUsuario()
        {
            return objGuardarFormulario.GetListadoUsuario();
        }

    }
}
