using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
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

            var ciudad1 = new Ciudad();
            ciudad1.CiudadNombre = "San Pedro Sula";
            ciudad1.PaisNombre = "Honduras";
            ciudad1.Codigo = "504";
            contexto.Ciudad.Add(ciudad1);

            var ciudad2 = new Ciudad();
            ciudad2.CiudadNombre = "La Lima";
            ciudad2.PaisNombre = "Honduras";
            ciudad2.Codigo = "512";
            contexto.Ciudad.Add(ciudad1);

            base.Seed(contexto);
        }
    }
}
