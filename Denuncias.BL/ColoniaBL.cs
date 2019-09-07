using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace Denuncias.BL
{
   public class ColoniaBL
    {
        Contexto _contexto;

        public BindingList<Colonia> ListaColonia { get; set; }

        public ColoniaBL()
        {
            _contexto = new Contexto();
            ListaColonia = new BindingList<Colonia>();
        }
        public BindingList<Colonia> ObtenerCompanies()
        {
            _contexto.Colonia.Load();
            ListaColonia = _contexto.Colonia.Local.ToBindingList();

            return ListaColonia;
        }
        private string validarDatos(Colonia a)
        {
            var validacion = "";


            if (String.IsNullOrEmpty(a.ColoniaNombre))
            {
                validacion = validacion + " -- " + "Error en Nombrede la Colonia";
            }
            if (String.IsNullOrEmpty(a.Sector))
            {
                validacion = validacion + " -- " + "Error en Sector";
            }
            
            if (validacion.Length == 0)
            {
                validacion = "OK";
            }
            return validacion;
        }
    }


public class Colonia
    {
        public int Id { get; set; }
        public string ColoniaNombre { get; set; }
        public string Sector { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}


