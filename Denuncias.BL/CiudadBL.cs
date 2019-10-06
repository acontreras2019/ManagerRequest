using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace Denuncias.BL
{
    public class CiudadBL
    {
        Contexto _contexto;
        public BindingList<Ciudad> ListaCiudad { get; set; }
        public CiudadBL()
        {
            _contexto = new Contexto();
            ListaCiudad = new BindingList<Ciudad>();

        }

        public BindingList<Ciudad> ObtenerCiudad()
        {

            _contexto.Ciudad.Load();
            ListaCiudad = _contexto.Ciudad.Local.ToBindingList();
            return ListaCiudad;
        }

        public string GuardarCiudad(Ciudad Ciudad)
        {

            var vd = validarDatos(Ciudad);
            if (vd == "OK")
            {

                _contexto.SaveChanges();


                return Ciudad.Id.ToString();
            }
            else
            {
                return vd;
            }

        }



        public void AgregarCiudad()
        {
            var nuevoCiudad = new Ciudad();
            ListaCiudad.Add(nuevoCiudad);
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public bool EliminarCiudad(int id)
        {
            foreach (var Ciudad in ListaCiudad)
            {
                if (Ciudad.Id == id)
                {
                    ListaCiudad.Remove(Ciudad);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }
      
        private string validarDatos(Ciudad a)
        {
            var validacion = "";
            

            if (String.IsNullOrEmpty(a.CiudadNombre))
            {
                validacion = validacion + " -- " + "Error en Nombrede la Ciudad";
            }
            if (String.IsNullOrEmpty(a.Codigo))
            {
                validacion = validacion + " -- " + "Error en Codigo";
            }
            if (String.IsNullOrEmpty(a.PaisNombre))
            {
                validacion = validacion + " -- " + "Error en Nombre de Pais";
            }

            if (validacion.Length == 0)
            {
                validacion = "OK";
            }
            return validacion;
        }
     
    }

    public class Ciudad
    {
        public int Id { get; set; }
        public string CiudadNombre { get; set; }
        public string Codigo { get; set; }
        public string PaisNombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


    }
}

