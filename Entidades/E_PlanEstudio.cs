using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_PlanEstudio
    {
        [Key]
        public int IdPlanEstudio { get; set; }
        public int IdCarrera { get; set; }
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

        // Prop
        public E_Carrera? Carrera { get; set; }
    }
}