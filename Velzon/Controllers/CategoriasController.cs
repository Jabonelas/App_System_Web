using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Velzon.Context;

namespace Velzon.Controllers
{
    public class CategoriasController : Controller
    {


        private CApp_SystemApp_System_BancobancoSQLitedbContext context = new CApp_SystemApp_System_BancobancoSQLitedbContext();

        [ActionName("Categoria")]
        public IActionResult Categoria()
        {
            return View();
        }



        [HttpGet]
        public IActionResult GetCategorias()
        {
            var categorias = context.tb_categoria_produto
                                     .Select(x => new { x.id_categoria_produto, x.cp_desc })
                                     .ToList();

            return Ok(categorias);
        }

    }
}