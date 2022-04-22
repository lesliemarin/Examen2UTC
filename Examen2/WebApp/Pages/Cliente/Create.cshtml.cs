using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.dbo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Cliente
{
    public class CreateModel : PageModel
    {
        private readonly IClienteService _cliente;

        public string Mensaje { get; set; } = "";


        public CreateModel(IClienteService cliente)
        {
            this._cliente = cliente;
        }


        public async Task<IActionResult> OnPost(ClienteEntity entity)
        {

            try
            {
                var result = await _cliente.CREATE(entity);

                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);

                }

                TempData["Msg"] = "El registro fue agregado correctamente";

                return Redirect("Grid");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);

            }
        }

        //public async Task<IActionResult> OnGet()
        //{

        //try
        //{
        //    ListCliente = await _cliente.GET();

        //    if (TempData.ContainsKey("Msg"))
        //    {
        //        Mensaje = TempData["Msg"] as string;
        //    }

        //    TempData.Clear();

        //    return Page();
        //}
        //catch (Exception ex)
        //{

        //    return Content(ex.Message);
        //}

        //}
    }
}
