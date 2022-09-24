using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class EditEstacionesModel : PageModel
    {
        private readonly RepositorioEstaciones repositorioEstaciones;
        public Estaciones Estacion {get;set;}

        [BindProperty]
        public Estaciones Estaciones {get;set;}
 
        public EditEstacionesModel(RepositorioEstaciones repositorioEstaciones)
       {
            this.repositorioEstaciones=repositorioEstaciones;
       }
 
        public IActionResult OnGet(int EstacionId)
        {
                Estacion=repositorioEstaciones.GetWithId(EstacionId);
                return Page();
 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Estacion.id>0)
            {
            Estacion = repositorioEstaciones.Update(Estacion);
            }
            return RedirectToPage("./List");
        }

    }
}
