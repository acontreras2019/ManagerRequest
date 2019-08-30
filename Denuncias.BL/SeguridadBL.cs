using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace Denuncias.BL
{
    public class SeguridadBL
    {
        //public bool Autorizar(string usuario, string contraseña)
        //{
        //    if (usuario == "admin" && contraseña == "123")
        //    {
        //        return  true;
        //    }
        //    else
        //    {
        //        if (usuario == "user" && contraseña == "456")
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        Contexto _contexto;
        public BindingList<Usuario> ListaUsuarios { get; set; }
        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();

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
        }

        public class Usuario
    {
        public int Id { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contrasena { get; set; }
    }
}
