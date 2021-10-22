using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medivis.Data.Entities
{
    public class MotivoCitas
    {
        public int Id { get; set; }

        
      
        [Display(Name = "Descripcion de la cita")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public int DescripcionC { get; set; }
       
       
    }
}
