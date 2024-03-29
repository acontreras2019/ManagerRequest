﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace Denuncias.BL
{
    public class SeguridadBL
    {
       

        Contexto _contexto = new Contexto();
        public BindingList<Usuario> listaUsuarios { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            listaUsuarios = new BindingList<Usuario>();

        }

        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Usuario
                .Include("Rol")
                .Load();

            //.Include("Usuario").Load();
    
            listaUsuarios = _contexto.Usuario.Local.ToBindingList();
            return listaUsuarios;
        }
        public void AgregarUsuario()
        {
           var nuevousuario = new Usuario();
           _contexto.Usuario.Add(nuevousuario);
        }



        public Usuario Autorizar(string usuario, string contraseña)
        {
            var usuarios = _contexto.Usuario.ToList();
            
            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.UsuarioNombre && contraseña == usuarioDB.Contrasena)
                {                   
                    return usuarioDB;
                }

            }
            return null;

        }
      
       
        private string validarDatos(Usuario u)
        {
            var validacion = "";
            if (!((u.Id) >= 0))
            {
                validacion = "Error en Usuario";
            }

            if (string.IsNullOrEmpty(u.UsuarioNombre))
            {
                validacion = validacion + " -- " + "Error en Usuario Nombre";
            }
          

            if (u.RolId == 0)
            {
                validacion = validacion + " -- " + "Error en tipoUsuario";
            }
            if (validacion.Length == 0)
            {
                validacion = "OK";
            }
            return validacion;
        }
        public Resultado GuardarUsuario(Usuario usuarion)
        {
            Resultado res = new Resultado();
            var resultado = validarDatos(usuarion);
            res.Mensaje = resultado;
            if (resultado != "OK")
            {
                res.Exitoso = false;
                
                return res;
            }
            res.Exitoso = true;
            _contexto.SaveChanges();
            return res; 
        }
        private Resultado Validar (Usuario usuarion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
             if (usuarion.UsuarioNombre == "")
            {
                resultado.Mensaje="Ingrese un nombre de usuario";
                resultado.Exitoso = false;
            }

           
            return resultado;
        }
      
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }


        public class Usuario
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contrasena { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
