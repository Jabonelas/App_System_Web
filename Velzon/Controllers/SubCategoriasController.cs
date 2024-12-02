using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Velzon.Context;

namespace Velzon.Controllers
{
    public class SubCategoriasController : Controller
    {


        private CApp_SystemApp_System_BancobancoSQLitedbContext context = new CApp_SystemApp_System_BancobancoSQLitedbContext();

        [ActionName("SubCategoria")]
        public IActionResult SubCategoria()
        {
            return View();
        }



        [HttpGet]
        public IActionResult GetSubCategorias()
        {
            var SubCategorias = context.tb_subcategoria_produto
                                     .Select(x => new { x.id_subcategoria_produto, x.scp_desc })
                                     .ToList();

            return Ok(SubCategorias);
        }

    }
}