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
    public class SubCategoriasController : Controller
    {


        private readonly SubCategoriaService subCategoriaService;

        public SubCategoriasController(SubCategoriaService _subCategoriaService)
        {
            subCategoriaService = _subCategoriaService;
        }


        // [HttpGet]
        public async Task<IActionResult> SubCategorias()
        {
            try
            {
                var listaSubCategorias = subCategoriaService.CarregarListaSubCategorias();

                ViewData["ListaSubCategorias"] = listaSubCategorias;

                return View();
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir todas as SubCategorias: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("CadastrarProduto", "Produtos");
            }
        }

        [HttpPost]
        public IActionResult CadastrarSubCategoria(tb_subcategoria_produto _subcategoria_produto)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    subCategoriaService.CadastrarSubCategoria(_subcategoria_produto);

                    TempData["mensagem"] = "Operação realizada com sucesso!";

                    return RedirectToAction("CadastrarSubCategoria", "SubCategorias");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error ao cadastrar subcategoria: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("CadastrarSubCategoria", "SubCategorias");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatorios para continuar.";

                return View(_subcategoria_produto);
            }

        }



        [HttpPatch]
        public IActionResult DeletarSubCategoria(int _idCategoria)
        {

            try
            {
                subCategoriaService.DeletarSubCategoria(_idCategoria);

                TempData["mensagem"] = "A subcategoria foi deletada com sucesso!";

                return RedirectToAction("SubCategorias", "SubCategorias");

            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao desativar subcategoria: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                return RedirectToAction("SubCategorias", "SubCategorias");
            }
        }

        [HttpGet]
        public IActionResult GetSubCategorias()
        {

            var SubCategorias = subCategoriaService.BuscarSubCategorias();

            return Ok(SubCategorias);
        }

    }
}