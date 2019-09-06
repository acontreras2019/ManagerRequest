using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class TipoMedioBL
    {
        Contexto _contexto;

        public BindingList<TipoMedio> Listamedio { get; set; }
        public TipoMedioBL()
        {
            _contexto = new Contexto();
            Listamedio = new BindingList<TipoMedio>();

        }
        public BindingList<TipoMedio> Obtenermedios()
        {
            _contexto.TipoMedio.Load();
            Listamedio = _contexto.TipoMedio.Local.ToBindingList();

            return Listamedio;
        }
    }
    public class TipoMedio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

}
