using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace Denuncias.BL
{
    public class EstatusBL
    {
        Contexto _contexto;
        public BindingList<Estatus> ListaEstatus { get; set; }

        public EstatusBL()
        {
            _contexto = new Contexto();
            ListaEstatus = new BindingList<Estatus>();

        }
        public BindingList<Estatus> ObtenerEstatus()
        {

            _contexto.Estatus.Load();
            ListaEstatus = _contexto.Estatus.Local.ToBindingList();
            return ListaEstatus;
        }
        public string GuardarEstatus(Estatus Estatus)
        {

            var vd = validarDatos(Estatus);
            if (vd == "OK")
            {

                _contexto.SaveChanges();


                return Estatus.Id.ToString();
            }
            else
            {
                return vd;
            }

        }
        private string validarDatos(Estatus a)
        {
            var validacion = "";


            if (String.IsNullOrEmpty(a.Descripcion))
            {
                validacion = validacion + " -- " + "Error en Descripción del Estado";
            }
           

            if (validacion.Length == 0)
            {
                validacion = "OK";
            }
            return validacion;
        }




    }
    public class Estatus
    { 
        public int Id { get; set; }
        public string Descripcion { get; set; }
        //public string DescripcionEstatus { get; set; }
        //public DateTime FechaInicio { get; set; }
        //public DateTime FechaFin { get; set; }
        //public Transaccion Transaccion { get; set; }
        //public int TransaccionId { get; set; }
        //public Usuario Usuario { get; set; }
        //public int UsuarioId { get; set; }
        //    public string Comentario { get; set; }

    }
}
