using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace  Proyecto.App.Persistencia
{
    public interface IRepositorioPais
    {
        //IEnumerable -> List
        IEnumerable<Pais> ObtenerTodos();


    }
}