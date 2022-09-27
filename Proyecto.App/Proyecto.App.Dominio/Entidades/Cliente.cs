using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Proyecto.App.Dominio

{

    public class Cliente
    {
        [Key]
        public int clienteId { get;set; }
        [MaxLength(50)]
        public string nombre { get;set; }
        [MaxLength(50)]
        public string apellido { get;set; }
        public int edad { get;set; }
        public Genero genero { get;set; }

        //llaves foraneas ciudad y pais

        public int? paisId { get;set; }
        public Pais pais { get;set; }

        public int? ciudadId { get;set; }
        public Ciudad ciudad { get;set; }


        //lista de casos

        public List<Caso> casos { get;set; }
     
    }
}

