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

        [ActionName("Categorias")]
        public IActionResult Categorias()
        {
            try
            {
                var listaCategorias = categoriaService.CarregarListaCategorias();

                ViewData["ListaCategorias"] = listaCategorias;

                return View();
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir todas as categorias: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("CadastrarCategorias", "Categorias");
            }
        }


        [HttpGet]
        public IActionResult GetCategorias()
        {
            try
            {
                var listaCategorias = categoriaService.BuscarCategorias();

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


        [HttpPatch]
        public IActionResult DeletarCategoria(int _idCategoria)
        {

            try
            {
                categoriaService.DeletarCategoria(_idCategoria);

                TempData["mensagem"] = "A categoria foi deletada com sucesso!";

                return RedirectToAction("Categorias", "Categorias");

            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao desativar categoria: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                return RedirectToAction("Categorias", "Categorias");
            }
        }


        [ActionName("EditarCategoria")]
        public IActionResult EditarCategoria(int idCategoria)
        {
            try
            {
                var categoria = categoriaService.DadosCategoriaEditar(idCategoria);


                return View(categoria);
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir dados da categoria selecionada: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("Produtos", "Produtos");
            }
        }

        [HttpPut]
        [HttpPost]
        public IActionResult EditarCategoria(tb_categoria_produto _categoria_produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Chamada ao serviço para atualizar o cadastro da categoria
                    categoriaService.EditarCadastroCategoria(_categoria_produto);

                    TempData["mensagem"] = "A categoria foi atualizada com sucesso!";
                    return RedirectToAction("Categorias", "Categorias");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao editar os dados da categoria: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("Categorias", "Categorias");
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