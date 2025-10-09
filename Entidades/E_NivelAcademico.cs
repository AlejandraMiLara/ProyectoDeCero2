using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class E_NivelAcademico
    {
        [Key]
        public int IdNivelAcademico { get; set; }
        public string NombreNivelAcademico { get; set; } = string.Empty;

        public ICollection<E_Materia> Materias { get; set; } = new List<E_Materia>();
    }
}
