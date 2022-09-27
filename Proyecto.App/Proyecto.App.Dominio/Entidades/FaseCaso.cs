using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Proyecto.App.Dominio

{
    public class FaseCaso

    {   [Key]
        public int faseCasoId { get;set; }
        [MaxLength(50)]
        public string nombreFase { get;set; }


         //lista de casos

        public List<Caso> casos { get;set; }

    }
}