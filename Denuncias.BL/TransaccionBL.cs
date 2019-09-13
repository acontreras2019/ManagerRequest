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
    public class TransaccionBL
    {

        Contexto _contexto;

        public BindingList<Transaccion> ListaTransaccion { get; set; }

        public TransaccionBL()
        {
            _contexto = new Contexto();
            ListaTransaccion = new BindingList<Transaccion>();
        }
        public BindingList<Transaccion> ObtenerTransaccion()
        {
            _contexto.Transaccion.Load();
            ListaTransaccion = _contexto.Transaccion.Local.ToBindingList();

            return ListaTransaccion;
        }

      
            }
}
public class Transaccion

{
    public int Id { get; set; }
    public String status { get; set; }
    public DateTime FechaTransaccion { get; set; }
    public string UsuarioNombre { get; set; }
    public int TipoUsuarioId { get; set; }
    public Usuario TipoUsuario { get; set; }
    public int MedioId { get; set; }
    public TipoMedio TipoMedio { get; set; }
    public DateTime FechaRecibo { get; set; }
    public DateTime FechaRespuesta { get; set; }
    public string Receptor { get; set; }
    public bool Activo { get; set; }


    public Transaccion()
    {
        FechaTransaccion = DateTime.Now;
        Activo = true;
    }
}
    
