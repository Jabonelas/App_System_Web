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
    public class ProdutosController : Controller
    {
        private readonly ProdutoService produtoService;

        public ProdutosController(ProdutoService _produtoService)
        {
            produtoService = _produtoService;
        }


        [ActionName("ExibirProdutos")]
        public IActionResult ExibirProdutos(int codRef)
        {
            try
            {
                var listaEstoqueProdutoFiliais = produtoService.ListaEstoqueProdutoFiliais(codRef);

                ViewData["ListaEstoqueProdutoFilial"] = listaEstoqueProdutoFiliais;

                return View();
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir todos os produtos: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("Produtos", "Produtos");
            }
        }


        [ActionName("EditarProduto")]
        public IActionResult EditarProduto(int codRef)
        {
            try
            {
                var listaProdutos = produtoService.DadosProdutoEditar(codRef);

                // ViewData["DadosPodutoEditar"] = listaProdutos;

                return View(listaProdutos);
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir todos os produtos: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("Produtos", "Produtos");
            }
        }


        [HttpPut]
        [HttpPost]
        public IActionResult EditarProduto(tb_produto _tb_Produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Chamada ao serviço para atualizar o cadastro do produto
                    produtoService.EditarProduto(_tb_Produto);

                    TempData["mensagem"] = "O produto foi atualizado com sucesso!";
                    return RedirectToAction("Produtos", "Produtos");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao editar os dados do produto: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("Produtos", "Produtos");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatórios para continuar.";
                return View(_tb_Produto);
            }
        }


        [ActionName("CadastrarProduto")]
        public IActionResult CadastrarProduto()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CadastrarProduto(tb_produto _tb_Produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Chamada ao serviço para cadastrar o produto
                    produtoService.CadastrarProduto(_tb_Produto);

                    TempData["mensagem"] = "Operação realizada com sucesso!";
                    return RedirectToAction("CadastrarProduto", "Produtos");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("CadastrarProduto", "Produtos");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatórios para continuar.";
                return View(_tb_Produto);
            }
        }


        [HttpGet]
        public IActionResult GetCodProduto()
        {
            try
            {
                long codProd = produtoService.BuscarCodigoProduto();

                if (codProd != 0)
                {
                    return Ok(new { pd_codRef = ++codProd }); // Retorna no formato esperado
                }

                return NotFound("Nenhum produto encontrado.");
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao buscar codigo produto: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("CadastrarProduto", "Produtos");
            }
        }


        // [HttpGet]
        public async Task<IActionResult> Produtos()
        {
            try
            {
                var listaProdutos = produtoService.CarregarListaProdutos();

                ViewData["ListaProdutos"] = listaProdutos;

                return View();
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir todos os produtos: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("CadastrarProduto", "Produtos");
            }
        }


        [HttpPatch]
        public IActionResult DeletarProduto(int _idProduto)
        {
            try
            {
                produtoService.DeletarProduto(_idProduto);

                TempData["mensagem"] = "O produto foi deletado com sucesso!";

                return RedirectToAction("Produtos", "Produtos");
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao desativar produto: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                return RedirectToAction("CadastrarProduto", "Produtos");
            }
        }


    }
}