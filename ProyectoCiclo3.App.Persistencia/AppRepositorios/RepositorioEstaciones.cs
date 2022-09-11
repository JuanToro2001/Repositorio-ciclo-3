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
                new Estaciones{id=1,nombre="Centro", dirección="Cra 25", coord_x="5.214", coord_y="61.236", tipo="Principal"},
                new Estaciones{id=2,nombre="Estadio", dirección="Cra 32A", coord_x="3.524", coord_y="10.254", tipo="Principal"},
                new Estaciones{id=3,nombre="Terminal", dirección="Cll 115", coord_x="25.214", coord_y="23.236", tipo="Secundaria"}
 
            };
        }
 
        public IEnumerable<Buses> GetAll()
        {
            return buses;
        }
 
        public Buses GetWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}

