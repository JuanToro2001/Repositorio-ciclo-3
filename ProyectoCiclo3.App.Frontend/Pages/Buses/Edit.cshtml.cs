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
    public class EditBusesModel : PageModel
    {
       private readonly RepositorioBuses repositorioBuses;
              public Buses Bus {get;set;}

        [BindProperty]
        public Buses Bus {get;set;}

 
        public EditBusesModel(RepositorioBuses repositorioBuses)
       {
            this.repositorioBuses=repositorioBuses;
       }
 
        public IActionResult OnGet(int busesId)
        {
                Bus=repositorioBuses.GetWithId(busesId);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Bus.id>0)
            {
            Bus = repositorioBuses.Update(Bus);
            }
            return RedirectToPage("./List");
        

        }
    }
}