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

        public int GuardarFormulario(FormularioRequestCliente request)
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

    }
}
