using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class TipoSolicitanteBL  //Pendiente agregar la clase a TransaccionBL
    {
        Contexto _contexto;

        public BindingList<TipoSolicitante> Listasolicitantes { get; set; }

        public TipoSolicitanteBL()
        {
            _contexto = new Contexto();
            Listasolicitantes = new BindingList<TipoSolicitante>();

        }
        public BindingList<TipoSolicitante> ObtenerSolicitantes()
        {
            _contexto.TipoSolicitante.Load();
            Listasolicitantes = _contexto.TipoSolicitante.Local.ToBindingList();

            return Listasolicitantes;
        }
    }
    public class TipoSolicitante
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
