using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class E_Materia
    {
        [Key]
        public int IdMateria { get; set; }
        public bool EstadoMateria { get; set; }
        public string ClaveMateria { get; set; } = string.Empty;
        public int HCMateria { get; set; } //horas de clase
        public int HLMateria { get; set; } //horas de laboratorio
        public int HTMateria { get; set; } //horas de taller
        public int HPCMateria { get; set; } //horas practicas de campo
        public int HCLMateria { get; set; } //
        public int HEMateria { get;set; }  //
        public int CRMateria { get; set; } //creditos de la materia
        public string PropositoMateria { get; set; } = string.Empty;
        public string CompetenciaMateria { get; set; } = string.Empty ;
        public string EvidenciaMateria { get; set;} = string.Empty ;
        public string MetodologiaMateria { get; set; } = string .Empty ;
        public string CriteriosMateria { get; set; } = string .Empty ;
        public string BibliografiaBasicaMateria { get; set;} = string .Empty ;
        public string BibliografiaCompletenciaMateria { get; set;} = string .Empty ;
        public string PathPUAMateria { get; set; } = string.Empty;
        public string PerfilDocente {  get; set; } = string .Empty;

        public int? IdNivelAcademico { get; set; }  // FK
        public E_NivelAcademico NivelAcademico { get; set; }  // navegación

    }
}
