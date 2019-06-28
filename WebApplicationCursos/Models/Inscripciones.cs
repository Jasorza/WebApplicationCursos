using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCursos.Models
{
    public class Inscripciones
    {
        public int InscripcionesID { get; set; }
        public int Grado { get; set; }
        [Display(Name = "Curso")]
        public int CursoID { get; set; }
        [Display(Name = "Estudiante")]
        public int EstudianteID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime Fecha { get; set; }
        public Decimal Pago { get; set; }

    }
}
