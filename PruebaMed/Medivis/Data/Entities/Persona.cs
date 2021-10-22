using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medivis.Data.Entities
{
    public class Persona
    {
        public int Id { get; set; }

        [Display(Name ="Tipo de Documento")]
        [Required(ErrorMessage ="El campo {0}  es obligatorio")]
        public string TipoDocumento { get; set; }
        [Display(Name = "Numero de Documento")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public int NumeroDocumento { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public string Apellido { get; set; }
        [Display(Name = "Edad")]
        [Required(ErrorMessage = "El campo {0}  es obligatorio")]
        public string Edad { get; set; }
    }
}
