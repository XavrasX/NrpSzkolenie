using NRP.KlientMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NRP.KlientMvc.DAS
{


    public class OdpowiedziRepository : IDisposable, IOdpowiedziRepository
    {
        private bool _disposed = false;
        private readonly NrpOdpowiedziEntities _ctx;

        public OdpowiedziRepository()
        {
            _ctx = new NrpOdpowiedziEntities();
        }

        public OdpowiedziRepository(string connectionStringOrName)
        {
            _ctx = new NrpOdpowiedziEntities(connectionStringOrName);
        }

        public List<v_Form_Odpowiedzi> GetOdpowiedzi()
        {
            return _ctx.v_Form_Odpowiedzi.ToList();
        }

        public v_Form_Odpowiedzi GetOdpowiedzi(int id)
        {
            return _ctx.v_Form_Odpowiedzi.Find(id);
        }

        public void UpdateOdpowiedzi(IEnumerable<v_Form_Odpowiedzi> listaOdpowiedzi)
        {
            if (listaOdpowiedzi == null) return;

            const string cmd = "insert Ojk.Klient (Nazwa, Opis)" +
                               " output inserted.*" +
                               " values(concat((select max(Id) + 1 from Ojk.Klient), ' - klient'), 'O nieznajomych trudno cos powiedziec w tym momencie')";

            _ctx.Database.ExecuteSqlCommand(cmd);

            _ctx.SaveChanges();
        }

        // To nie jest zgodne z wzorcem dispose, zapoznać sie i zrobic prawidlowa implentecje
        public void Dispose()
        {
            Dispose(true);
        }

        protected void Dispose(bool dispose)
        {
            if (!_disposed)
                _ctx.Dispose();

            _disposed = true;

            if (dispose)
                GC.SuppressFinalize(this);
        }

        ~OdpowiedziRepository()
        {
            Dispose(false);
        }
    }
}