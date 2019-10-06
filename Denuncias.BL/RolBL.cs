using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace Denuncias.BL
{
    public class RolBL
    {
        Contexto _contexto;

        public BindingList<Rol> ListaRol { get; set; }

        public RolBL()
        {
            _contexto = new Contexto();
            ListaRol = new BindingList<Rol>();
        }
        public BindingList<Rol> ObtenerRol()
        {
            _contexto.Rol.Load();
            ListaRol = _contexto.Rol.Local.ToBindingList();

            return ListaRol;
        }

        public string GuardarColonia(Rol rol)
        {

            var vd = validarDatos(rol);
            if (vd == "OK")
            {

                _contexto.SaveChanges();


                return rol.Id.ToString();
            }
            else
            {
                return vd;
            }
        }
        private string validarDatos(Rol rol)
        {
            var validacion = "";


            if (String.IsNullOrEmpty(rol.Descripcion))
            {
                validacion = validacion + " -- " + "Error en Nombrede la Colonia";
            }
       

            if (validacion.Length == 0)
            {
                validacion = "OK";
            }
            return validacion;
        }
    }

    public class Rol
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

}
