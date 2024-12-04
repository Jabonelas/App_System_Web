using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Velzon.Context;
using Velzon.Models;

namespace Velzon.Controllers
{
    public class SecaoController : Controller
    {
        private readonly SecaoService secaoService;

        public SecaoController(SecaoService _secaoService)
        {
            secaoService = _secaoService;
        }


        [ActionName("Secao")]
        public IActionResult Secao()
        {
            return View();
        }


        [HttpGet]
        public IActionResult GetSecao()
        {
            try
            {
                var secao = secaoService.BuscarSecao();

                return Ok(secao);
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao buscar seção: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("CadastrarProduto", "Produtos");
            }
        }

    }
}