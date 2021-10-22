using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medivis.Data.Entities
{
    public class Cita
    {
        public int Id { get; set; }

        [Display(Name = "Persona")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public Persona Persona { get; set; }

        public DateTime GetDateTime { get; set; }
        [Display(Name = "Fecha de la cita")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public int Fecha_cita { get; set; }
        [Display(Name = "Nombre Doctor")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public string Doctor { get; set; }
       
    }
}
