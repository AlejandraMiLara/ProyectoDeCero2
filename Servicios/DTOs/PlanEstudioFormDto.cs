using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DTOs
{
    public class PlanEstudioFormDto
    {
        public int IdPlanEstudio { get; set; }
        public string PlanEstudio { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public int TotalCreditos { get; set; }
        public int CreditosOptativos { get; set; }
        public int CreditosObligatorios { get; set; }
        public string PerfilDeIngreso { get; set; } = string.Empty;
        public string PerfilDeEgreso { get; set; } = string.Empty;
        public string CampoOcupacional { get; set; } = string.Empty;
        public string Comentarios { get; set; } = string.Empty;
        public bool EstadoPlanEstudio { get; set; } = true;
    }
}
