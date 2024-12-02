using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Velzon.Context;

namespace Velzon.Controllers
{
    public class MarcaController : Controller
    {


        private CApp_SystemApp_System_BancobancoSQLitedbContext context = new CApp_SystemApp_System_BancobancoSQLitedbContext();

        [ActionName("Marca")]
        public IActionResult Marca()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetMarcas()
        {
            var marcas = context.tb_marca_produto
                                     .Select(x => new { x.id_marca_produto, x.mp_desc })
                                     .ToList();

            return Ok(marcas);
        }
    }
}