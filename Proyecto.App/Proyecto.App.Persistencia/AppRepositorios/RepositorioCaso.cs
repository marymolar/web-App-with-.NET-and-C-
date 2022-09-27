using System.Collections.Generic;
using Proyecto.App.Dominio;
using System.Linq;

namespace Proyecto.App.Persistencia
{
    public class RepositorioCaso : IRepositorioCaso
    {

        private readonly ApplicationContext _appContext;

        public RepositorioCaso(ApplicationContext contexto)
        {
            _appContext = contexto;
        }

        Caso IRepositorioCaso.Agregar(Caso caso)

        {
            var casoAdicionado = _appContext.Casos.Add(caso);
            _appContext.SaveChanges();
            return casoAdicionado.Entity;
        }

         Caso IRepositorioCaso.ObtenerPorId(int id)

        {
            return _appContext.Casos.FirstOrDefault(c => c.casoId ==id);
        }

    }

}