using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen="Centro",destino= "Estadio",tiempo_estimado= "45min"},
                new Rutas{id=1,origen="Estadio",destino= "Terminal",tiempo_estimado= "1hra"},
                new Rutas{id=1,origen="Terminal",destino= "Centro",tiempo_estimado= "30min"}
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }
    }
}