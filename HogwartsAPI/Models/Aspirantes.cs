using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsAPI.Models
{
    public class Aspirantes
    {

        public int Id { get; set; }

      
    
        public string Nombre { get; set; }

      
        public string Apellido { get; set; }

      
        public int Identificacion { get; set; }

   

        public int Edad { get; set; }

 
        public string IdCasa { get; set; }
    }

  
    }
