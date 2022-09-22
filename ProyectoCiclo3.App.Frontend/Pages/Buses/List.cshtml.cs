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
    public class ListBusesModel : PageModel
    {
       
        private readonly RepositorioBuses repositorioBuses;
        public IEnumerable<Buses> Buses {get;set;}
        [BindProperty]
        public Buses Bus {get;set;}
 
        public ListBusesModel(RepositorioBuses repositorioBuses)
    {
        this.repositorioBuses=repositorioBuses;
     }
 
    public void OnGet()
    {
        Buses=repositorioBuses.GetAll();
    }
    public IActionResult OnPost()
    {
        if(Bus.id>0)
        {
        Bus = repositorioBuses.Delete(Bus.id);
        }
        return RedirectToPage("./List");
    }

    }
}
