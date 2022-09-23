using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCiclo3.App.Dominio{
    public class Rutas{
        
        public int id {get; set;}
        public string origen {get; set;} 
        public string destino {get; set;} 
        public string tiempo_estimado {get; set;} 
    }
}