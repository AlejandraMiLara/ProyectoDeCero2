using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class E_Docente
    {
        [Key]
        public int IdDocente { get; set; }
        public string NumeroEmpleadoDocente {  get; set; } = string.Empty;
        public string NombreDocente {  get; set; } = string.Empty;
        public string ApPatDocente {  get; set; } = string.Empty;
        public string ApMatDocente { get; set; } = string.Empty ;
        public string EmailDocente {  get; set; } = string.Empty;
        public bool EstadoDocente { get; set; } = true;
    }
}
