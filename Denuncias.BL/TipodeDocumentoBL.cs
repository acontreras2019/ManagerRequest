using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
   public class TipodeDocumentoBL
   
        {
        Contexto _contexto;

        public BindingList<TipodeDocumento> ListatipoDocumento { get; set; }

        public TipodeDocumentoBL()
        {
            _contexto = new Contexto();
            ListatipoDocumento = new BindingList<TipodeDocumento>();

        }
        public BindingList<TipodeDocumento>   Obtenertipodedocumento()
        {
            _contexto.TipodeDocumento.Load();
            ListatipoDocumento = _contexto.TipodeDocumento.Local.ToBindingList();

            return ListatipoDocumento;
        }
    }
public class TipodeDocumento
    {
        public int Id {get; set; }
        public string Descripcion { get; set; }
    }
}
