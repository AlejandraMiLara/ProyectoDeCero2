using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DTOs
{
    public class PlanEstudioResumenDto
    {
        public int IdPlanEstudio {  get; set; }
        public string PlanEstudio { get; set; } = string.Empty;
        public int TotalCreditos { get; set; }
        public bool EstadoPlanEstudio { get; set; }
    }
}
