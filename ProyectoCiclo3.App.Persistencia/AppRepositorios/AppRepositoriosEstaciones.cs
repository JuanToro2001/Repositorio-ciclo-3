using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Centro", direccion= "Cra 25", coord_x= "5.213", coord_y= "13.258", tipo= "Principal"},
                new Estaciones{id=1,nombre="Terminal", direccion= "Calle 115", coord_x= "8.236", coord_y= "42.326", tipo= "Principal"},
                new Estaciones{id=1,nombre="Estadio", direccion= "Ave San Diego", coord_x= "4.265", coord_y= "84.236", tipo= "Secundaria"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
        
    }
}