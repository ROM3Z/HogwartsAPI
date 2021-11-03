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

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Su Nombre debe tener un minimo de 3 caracteres y un maximo de 20")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Su Apellido debe tener un minimo de 3 caracteres y un maximo de 20")]
        public string Apellido { get; set; }

        [Range(1, 100000000000)]
        public int Identificacion { get; set; }

        [Range(1, 99)]
        public int Edad { get; set; }

 
        public string IdCasa { get; set; }
      
    }

  
    }
