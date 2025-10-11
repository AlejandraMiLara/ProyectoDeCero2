using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DTOs
{
    public class PlanEstudioListadoDto
    {
        public int IdPlanEstudio { get; set; }
        public string PlanEstudio { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public int TotalCreditos { get; set; }
        public bool EstadoPlanEstudio { get; set; } = true;
        public string Comentarios { get; set; } = string.Empty;
    }
}
