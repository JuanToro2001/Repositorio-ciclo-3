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
    public class ListEstacionesModel : PageModel
    {
       
        private readonly RepositorioEstaciones repositorioEstaciones;
        public IEnumerable<Estaciones> Estaciones {get;set;}

        [BindProperty]
        public Estaciones Estacion {get;set;}
 
    public ListEstacionesModel(RepositorioEstaciones repositorioEstaciones)
    {
        this.repositorioEstaciones=repositorioEstaciones;
     }
 
    public void OnGet()
    {
        Estaciones=repositorioEstaciones.GetAll();
    }

    public IActionResult OnPost()
    {
        if(Estacion.id>0)
        {
        Estacion = repositorioEstaciones.Delete(Estacion);
        }
        return RedirectToPage("./List");
    }

    }
}
