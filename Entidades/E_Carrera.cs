using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class E_Carrera
    {
        [Key]
        public int IdCarrera { get; set; }
        public int IdCoordinador { get; set; }
        public string ClaveCarrera { get; set; } = string.Empty;
        public string NombreCarrera { get; set; } = string.Empty;
        public string AliasCarrera { get; set; } = string.Empty;
        public bool EstadoCarrera { get; set; } = true;

        public ICollection<E_PlanEstudio> PlanesDeEstudio { get; set; } = new List<E_PlanEstudio>();

    }
}
