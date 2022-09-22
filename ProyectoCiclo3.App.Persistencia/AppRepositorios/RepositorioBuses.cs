using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses;
 
    public RepositorioBuses()
        {
            buses= new List<Buses>()
            {
                new Buses{id=1,marca="Audi",modelo= 2020,kilometraje= 100000,numero_asientos= 4,placa= "POP678"},
                new Buses{id=2,marca="Toyota",modelo= 2021,kilometraje= 90000,numero_asientos= 16,placa= "OIU859"},
                new Buses{id=3,marca="Mazda",modelo= 2000,kilometraje= 150000,numero_asientos= 24,placa= "YUH859"}
 
            };
        }
 
        public IEnumerable<Buses> GetAll()
        {
            return buses;
        }
 
        public Buses GetWithId(int id){
            return buses.SingleOrDefault(b => b.id == id);
        }

        public Buses Create(Buses newBus)
        {
           if(buses.Count > 0){
           newBus.id=buses.Max(r => r.id) +1; 
            }else{
               newBus.id = 1; 
            }
               buses.Add(newBus);
           return newBus;
        }



        public Buses Update(Buses newBus){
            var bus= buses.SingleOrDefault(b => b.id == newBus.id);
            if(bus != null){
                bus.marca = newBus.marca;
                bus.modelo = newBus.modelo;
                bus.kilometraje = newBus.kilometraje;
                bus.numero_asientos = newBus.numero_asientos;
                bus.placa = newBus.placa;
            }
        return bus;
        }
        
        public Buses Delete(int id)
        {
        var bus= buses.SingleOrDefault(b => b.id == id);
        buses.Remove(bus);
        return bus;
        }


    }
}
