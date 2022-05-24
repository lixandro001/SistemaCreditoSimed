using Simed.Data;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Business
{
    public class BandejaBL : IDisposable
    {
        private BandejaDA objBandejaDL;

        public BandejaBL(string ConStr)
        {
            objBandejaDL = new BandejaDA(ConStr);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<BandejaClienteResponse> GetBandejaCliente(DateTime StartDate, DateTime EndDate, int PerfilId,int UsuarioCreacion)
        {
            var Data = objBandejaDL.GetBandejaCliente(StartDate, EndDate, PerfilId, UsuarioCreacion);
            return Data;
        }

    }
}
