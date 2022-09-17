using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;

        public IEnumerable<Dueno> listaDuenos { get; set; }

        public ListaDuenosModel()
        {
            this._repoDueno =
                new RepositorioDueno(new Persistencia.AppContext());
        }

        public void OnGet()
        {
            listaDuenos = _repoDueno.GetAllDuenos();
        }
    }
}
