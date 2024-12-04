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
    public class CategoriasController : Controller
    {
        private readonly CategoriaService categoriaService;

        public CategoriasController(CategoriaService _categoriaService)
        {
            categoriaService = _categoriaService;
        }

        [ActionName("Categoria")]
        public IActionResult Categoria()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCategorias()
        {
            try
            {
                var listaCategorias = categoriaService.BuscarCategoria();

                return Ok(listaCategorias);

            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao buscar lista de categorias com id e descrição: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                return RedirectToAction("CadastrarCategoria", "Categorias");
            }

        }


        [ActionName("CadastrarCategoria")]
        public IActionResult CadastrarCategoria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarCategoria(tb_categoria_produto _categoria_produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    categoriaService.CadastrarCategoria(_categoria_produto);

                    TempData["mensagem"] = "Operação realizada com sucesso!";

                    return RedirectToAction("CadastrarCategoria", "Categorias");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao cadastrar categoria: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("CadastrarCategoria", "Categorias");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatórios para continuar.";
                return View(_categoria_produto);
            }
        }


    }
}