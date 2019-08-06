using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class AsuntosBL
    {
        public BindingList<Asunto> ListaAsuntos { get; set; }
        public AsuntosBL()
        {
            ListaAsuntos = new BindingList<Asunto>();
            var Asunto1 = new Asunto();
            Asunto1.Id = 1;
            Asunto1.CompanyId = 1;
            Asunto1.Descripcion = "Recoleccion Regular";
            Asunto1.UsuarioIdCreador = 1;
            Asunto1.Activo = true;
            

            var Asunto2 = new Asunto();
            Asunto2.Id = 2;
            Asunto2.CompanyId = 1;
            Asunto2.Descripcion = "Limpieza Vertedero Clandestino";
            Asunto2.UsuarioIdCreador = 1;
            Asunto2.Activo = true;
      

            var Asunto3 = new Asunto();
            Asunto3.Id = 3;
            Asunto3.CompanyId = 1;
            Asunto3.Descripcion = "Actividad de Apoyo";
            Asunto3.UsuarioIdCreador = 1;
            Asunto3.Activo = true;
            

            ListaAsuntos.Add(Asunto1);
            ListaAsuntos.Add(Asunto2);
            ListaAsuntos.Add(Asunto3);


        }

        public BindingList<Asunto> ObtenerAsuntos(){

            return ListaAsuntos;
        }
       
        public string GuardarAsunto(Asunto asunto){

            var vd = validarDatos(asunto);
            if(vd=="OK"){
                if (asunto.Id == 0){
                    asunto.Id = ListaAsuntos.Max(item => item.Id) + 1;
                }
                return asunto.Id.ToString();
            }
            else
            {
                return vd;
            }

        }

        public void AgregarAsunto(){
            var nuevoAsunto = new Asunto();
            ListaAsuntos.Add(nuevoAsunto);
        }

        public bool EliminarAsunto(int id)
        {
            foreach (var asunto in ListaAsuntos)
            {
                if (asunto.Id == id)
                {
                    ListaAsuntos.Remove(asunto);

                    return true;
                }
            }

            return false;
        }

        private string validarDatos( Asunto a)
        {
            var validacion = "";
            if(!((a.CompanyId)>0)){
                validacion = "Error en Compania";
            }

            if (String.IsNullOrEmpty(a.Descripcion)){
                validacion = validacion + " -- " + "Error en Descripcion";
            }
            if (!((a.UsuarioIdCreador)>0)) {
                validacion = validacion + " -- " + "Error en Usuario";
            }

            if(validacion.Length==0){
               validacion = "OK";
            }
            return validacion;
        }
    }

    public class Asunto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioIdCreador { get; set; } //Quien resuelve el asunto
        public bool Activo { get; set; }
        

    }
}
