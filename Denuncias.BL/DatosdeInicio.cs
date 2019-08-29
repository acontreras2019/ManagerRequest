using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>//Agregar DocumentBL
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.UsuarioNombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuario.Add(usuarioAdmin);

            var company1 = new Company();
            company1.Descripcion = "Municipalidad San Pedro Sula";
            contexto.Company.Add(company1);

             var company2 = new Company();
            company2.Descripcion = "Municipalidad La Lima";
            contexto.Company.Add(company2);

            var company3 = new Company();
            company3.Descripcion = "Municipalidad San Manuel";
            contexto.Company.Add(company3);

            base.Seed(contexto);
        }
    }
}
