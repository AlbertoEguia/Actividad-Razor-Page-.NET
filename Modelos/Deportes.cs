using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadRazorPage.Modelos
{
    public class Deportes
    {
        public int ID { get; set; }
        
        [Display(Name = "Nombre del Deporte")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Nombre { get; set; }
        
        [Display(Name = "Deporte en equipo")]
        public bool Coperativo { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Display(Name = "tipo de deporte")]
        public string Tipo { get; set; }

        //el rango son en minutos
        [Range(1, 900)]
        [Column(TypeName = "decimal(20,12")]
        public float Duracion { get; set; }

    }
}
