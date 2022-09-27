using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Proyecto.App.Dominio

{
    public class Abogado
    {
        [Key]
        public int abogadoId { get;set; }
        [MaxLength(50)]
        public string nombre { get;set; }
        [MaxLength(50)]
        public string apellido { get;set; }
        [MaxLength(20)]
        public string numeroTarjetaProfesional { get;set; }
        [MaxLength(50)]
        public int anioIngreso { get;set; }

        //lista de casos

        public List<Caso> casos { get;set; }

    }
}