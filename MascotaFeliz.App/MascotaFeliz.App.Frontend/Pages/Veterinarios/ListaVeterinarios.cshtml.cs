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
    public class ListaVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario;

        public IEnumerable<Veterinario> listaVeterinarios { get; set; }

        public ListaVeterinariosModel()
        {
            this._repoVeterinario =
                new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public void OnGet()
        {
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
        }
    }
}
