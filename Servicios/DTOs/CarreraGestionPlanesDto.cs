using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DTOs
{
    public class CarreraGestionPlanesDto
    {
        public int IdCarrera { get; set; }
        public string NombreCarrera { get; set; } = string.Empty;
        public string ClaveCarrera { get; set; } = string.Empty;
        public string AliasCarrera { get; set; } = string.Empty;
        public bool EstadoCarrera { get; set; }

        public List<int> IdsPlanesEstudio { get; set; } = new();
    }
}
