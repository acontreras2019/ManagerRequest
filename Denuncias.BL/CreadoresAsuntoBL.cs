using Denuncias.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class CreadoresAsuntoBL
    {
        Contexto _contexto;

        public BindingList<CreadoresAsunto> Listacreadores { get; set; }

        public CreadoresAsuntoBL()
        {
            _contexto = new Contexto();
            Listacreadores = new BindingList<CreadoresAsunto>();

        }
        public BindingList<CreadoresAsunto> ObtenerCreadoresAsunto()
        {
            _contexto..Load();
            ListaCreadoresAsunto = _contexto.CreadoresAsunto.Local.ToBindingList();
            return Listacreadores;
        }

        public class CreadoresAsunto
        {
            public int Id { get; set; }
            public string Descripcion {get; set;}

        }
    }
}
