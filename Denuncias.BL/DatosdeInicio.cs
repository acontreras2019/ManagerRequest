using System.Data.Entity;

namespace Denuncias.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Id = 1;
            usuarioAdmin.UsuarioNombre = "admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuario.Add(usuarioAdmin);

            var SAC1 = new Usuario();
            SAC1.Id = 2;
            SAC1.UsuarioNombre = "SAC1";
            SAC1.Contrasena = "123";
            contexto.Usuario.Add(SAC1);


            #region ciudad
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.CiudadNombre = "San Pedro Sula";
            ciudad1.PaisNombre = "Honduras";
            ciudad1.Codigo = "504";
            ciudad1.UsuarioId = 1;
            contexto.Ciudad.Add(ciudad1);

            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.CiudadNombre = "La Lima";
            ciudad2.PaisNombre = "Honduras";
            ciudad2.Codigo = "512";
            ciudad2.UsuarioId = 1;
            contexto.Ciudad.Add(ciudad2);
            #endregion            

            #region company
            var company1 = new Company();
            company1.Id = 1;
            company1.Descripcion = "Municipalidad San Pedro Sula";
            company1.Telefono = "2550-0000";
            company1.Direccion = "Bo. EL Centro, 1 cll, 3-4 avenida";
            company1.Ciudad = ciudad1;
            contexto.Company.Add(company1);

            var company2 = new Company();
            company2.Id = 2;
            company2.Descripcion = "Municipalidad La Lima";
            company2.Telefono = "264-0000";
            company2.Direccion = "Bo. EL Centro, 1 cll, 3-4 avenida";
            company2.Ciudad = ciudad2;
            contexto.Company.Add(company2);
            #endregion

            #region Asuntos
            var asunto1 = new Asunto();
            asunto1.Id = 1;
            asunto1.Company = company1;
            asunto1.Descripcion = "Corte y Poda";
            asunto1.Activo = true;
            asunto1.UsuarioId = 1;
            contexto.Asunto.Add(asunto1);

            var asunto2 = new Asunto();
            asunto2.Id = 2;
            asunto2.Company = company1;
            asunto2.Descripcion = "Instalación de Hidratante";
            asunto2.Activo = true;
            asunto2.UsuarioId = 1;
            contexto.Asunto.Add(asunto2);

            #endregion

            #region Medios
            var tipoMedios1 = new TipoMedio();
            tipoMedios1.Id = 1;
            tipoMedios1.Descripcion = "Correspondencia";
            contexto.TipoMedio.Add(tipoMedios1);

            var tipoMedios2 = new TipoMedio();
            tipoMedios2.Id = 2;
            tipoMedios2.Descripcion = "Presencial";
            contexto.TipoMedio.Add(tipoMedios2);
            #endregion

            //#region Colonias
            var colonia1 = new Colonia();
            colonia1.Id = 1;
            colonia1.ColoniaNombre = "Jardines del Valle";
            colonia1.Sector = "N.O.";
            colonia1.UsuarioId = 1;
            contexto.Colonia.Add(colonia1);
            //#endregion

            //#region TipoDocumento
            var tipoDocumento1 = new TipodeDocumento();
            tipoDocumento1.Id = 1;
            tipoDocumento1.Descripcion = "Solicitud";
            contexto.TipodeDocumento.Add(tipoDocumento1);

            var tipoSolicitante1 = new TipoSolicitante();
            tipoSolicitante1.Id = 1;
            tipoSolicitante1.Descripcion = "Gubernamental";
            contexto.TipoSolicitante.Add(tipoSolicitante1);
            //#endregion

            contexto.Estatus.Add(new Estatus
            {
                Descripcion = "Nueva"
            });
            contexto.Estatus.Add(new Estatus
            {
                Descripcion = "En Proceso"
            });
            contexto.Estatus.Add(new Estatus
            {
                Descripcion = "Terminada"
            });

            base.Seed(contexto);
        }
    }
}
