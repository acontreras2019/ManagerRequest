using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class AsuntosBL
    {
        Contexto _contexto;
        public BindingList<Asunto> ListaAsuntos { get; set; }
        public AsuntosBL()
        {
            _contexto = new Contexto(); 
            ListaAsuntos = new BindingList<Asunto>();
           
        }

        public BindingList<Asunto> ObtenerAsuntos()
        {

            _contexto.Asunto.Load();
            ListaAsuntos = _contexto.Asunto.Local.ToBindingList();
            return ListaAsuntos;
        }
       
        public string GuardarAsunto(Asunto asunto){

            var vd = validarDatos(asunto);
            if(vd=="OK"){

                _contexto.SaveChanges();


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
                    _contexto.SaveChanges();
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
            //if (!((a.UsuarioIdCreador)>0)) {
            //    validacion = validacion + " -- " + "Error en Usuario";
            //}

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
        public Company Company { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }/*/ *///Quien resuelve el asunto
        //public CreadoresAsunto DescripcionCreador { get; set; }
        public bool Activo { get; set; }
        

    }
}
