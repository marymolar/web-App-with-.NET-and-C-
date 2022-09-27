using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.App.Persistencia;
using Proyecto.App.Dominio;

namespace Proyecto.SitioWeb.App.Pages
{
    public class DeleteModel : PageModel
    {
        private IRepositorioCliente _repoCliente{ get;set;}
        [BindProperty]
        public Cliente cliente {get;set;}

         public DeleteModel()
        {
             _repoCliente = new RepositorioCliente(new Proyecto.App.Persistencia.ApplicationContext());
        }


        public void OnGet(int id)
        {

            cliente = _repoCliente.ObtenerPorId(id);
        }

        public IActionResult OnPost()
        {
            _repoCliente.Eliminar(cliente.clienteId);
            return RedirectToPage("/Cliente/List");
        }
    }
}
