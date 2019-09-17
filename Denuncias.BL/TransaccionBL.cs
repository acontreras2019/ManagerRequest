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
        public BindingList<Transaccion> AgregarTransaccion()
        {
            _contexto.Transaccion.Load();
            ListaTransaccion = _contexto.Transaccion.Local.ToBindingList();

            return ListaTransaccion;
        }
        public string GuardarTransaccion(Transaccion transaccion)
        {

            var vd = validarDatos(transaccion);
            if (vd == "OK")
            {

                _contexto.SaveChanges();


                return transaccion.Id.ToString();
            }
            else
            {
                return vd;
            }
        }
            
             private string validarDatos(Transaccion a)
        {
            var validacion = "";
            if (!((a.Id) > 0))
            {
                validacion = "Error en Compania";
            }

            if (string.IsNullOrEmpty(a.UsuarioNombre))
            {
                validacion = validacion + " -- " + "Error en Usuario Nombre";
            }
            //if (!((a.UsuarioIdCreador)>0)) {
            //    validacion = validacion + " -- " + "Error en Usuario";
            //}

            if (validacion.Length == 0)
            {
                validacion = "OK";
            }
            return validacion;
        }


    }
    }
    public class Transaccion

    {
        public int Id { get; set; }
        public string status { get; set; }
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
        public Usuario Usuario { get; set; }


        public Transaccion()
        {
            FechaTransaccion = DateTime.Now;
            FechaRecibo = DateTime.Now;
            FechaRespuesta = DateTime.Now;
        Activo = true;
        }
    }


    
