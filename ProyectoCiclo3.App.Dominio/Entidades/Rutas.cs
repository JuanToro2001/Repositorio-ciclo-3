using System;
namespace ProyectoCiclo3.App.Dominio{
    public class Rutas{
        
        public int id {get; set;}
        public Estaciones origen {get; set;} 
        public Estaciones destino {get; set;} 
        public int tiempo_estimado {get; set;} 
    }
}