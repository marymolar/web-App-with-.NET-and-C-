using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace  Proyecto.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Cliente Agregar(Cliente clientenuevo);
        Cliente modificar(Cliente clienteactualizar);
        void Eliminar (int id);
        Cliente ObtenerPorId(int id);

        //IEnumerable -> List
        IEnumerable<Cliente> ObtenerTodos();


    }
}