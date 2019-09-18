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
            _contexto.Transaccion
                .Include("TipoMedio")
                .Include("Ciudad")
                .Include("Colonia")
                .Include("TipoSolicitante")
                .Include("Asunto")
                .Include("Estatus")
                .Include("Usuario").Load();

            ListaTransaccion = _contexto.Transaccion.Local.ToBindingList();

            return ListaTransaccion;
        }

        public void AgregarTransacciom()
        {
            var nuevaTransaccion = new Transaccion();
            _contexto.Transaccion.Add(nuevaTransaccion);
        }

        public string GuardarTransaccion(Transaccion transaccion)
        {
            var vd = validarDatos(transaccion);
            if (vd == "OK")
            {
                transaccion.UsuarioId = transaccion.Usuario.Id;

                _contexto.SaveChanges();
            }

            return vd;
        }

        private string validarDatos(Transaccion a)
        {
            var validacion = "";
            if (!((a.Id) >= 0))
            {
                validacion = "Error en Transaccion";
            }

            if (string.IsNullOrEmpty(a.UsuarioNombre))
            {
                validacion = validacion + " -- " + "Error en Usuario Nombre";
            }
            //if (!((a.UsuarioIdCreador)>0)) {
            //    validacion = validacion + " -- " + "Error en Usuario";
            //}

            if (a.AsuntoId == 0)
            {
                validacion = validacion + " -- " + "Error en Asunto";
            }

            if (validacion.Length == 0)
            {
                validacion = "OK";
            }
            return validacion;
        }


    
    }
    public class Transaccion

    {
        public int Id { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string UsuarioNombre { get; set; }
        public int TipoSolicitanteId { get; set; }
        public TipoSolicitante TipoSolicitante { get; set; }
        public int TipoMedioId { get; set; }
        public TipoMedio TipoMedio { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
        public int ColoniaId { get; set; }
        public Colonia Colonia { get; set; }
        public int EstatusId { get; set; }
        public Estatus Estatus { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int AsuntoId { get; set; }
        public Asunto Asunto { get; set; }


        public Transaccion()
        {
            FechaTransaccion = DateTime.Now;
        }
    }
}

    
