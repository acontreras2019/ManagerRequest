using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class CompanyBL
    {
        Contexto _contexto;

        public BindingList<Company> ListaCompany { get; set; }

        public CompanyBL()
        {
            _contexto = new Contexto();
            ListaCompany = new BindingList<Company>();
        }
        public BindingList<Company> ObtenerCompanies()
        {
            _contexto.Company.Load();
            ListaCompany = _contexto.Company.Local.ToBindingList();

            return ListaCompany;
        }
    }
    public class Company
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}

