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
    public class ConsumidoresController : Controller
    {
        private readonly ConsumidorService consumidorService;

        public ConsumidoresController(ConsumidorService _consumidorService)
        {
            consumidorService = _consumidorService;
        }


        [ActionName("Secoes")]
        public IActionResult Secoes()
        {
            try
            {
                var listaSecoes = consumidorService.BuscarSecao();

                ViewData["ListaSecoes"] = listaSecoes;

                return View();
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir todas as seções: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("CadastrarSecao", "Secoes");
            }
        }


        [HttpGet]
        public IActionResult GetSecao()
        {
            try
            {
                var secao = consumidorService.BuscarSecao();

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

        [ActionName("CadastrarConsumidor")]
        public IActionResult CadastrarConsumidor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarConsumidor(tb_produto _secao_produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // consumidorService.CadastrarSecao(_secao_produto);

                    TempData["mensagem"] = "Operação realizada com sucesso!";

                    return RedirectToAction("CadastrarSecao", "Secoes");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao cadastrar secao: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("CadastrarSecao", "Secoes");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatórios para continuar.";
                return View(_secao_produto);
            }
        }

        [ActionName("EditarSecao")]
        public IActionResult EditarSecao(int idSecao)
        {
            try
            {
                var secao = consumidorService.DadosSecaoEditar(idSecao);


                return View(secao);
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir dados da secao selecionada: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("Produtos", "Produtos");
            }
        }

        [HttpPut]
        [HttpPost]
        public IActionResult EditarSecao(tb_secao_produto _secao_produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    consumidorService.EditarCadastroSecao(_secao_produto);

                    TempData["mensagem"] = "A seção foi atualizada com sucesso!";
                    return RedirectToAction("Secoes", "Secoes");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao editar os dados da secao: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("Secoes", "Secoes");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatórios para continuar.";
                return View(_secao_produto);
            }
        }

        [HttpPatch]
        public IActionResult DeletarSecao(int _idSecao)
        {
            try
            {
                consumidorService.DeletarSecao(_idSecao);

                TempData["mensagem"] = "A secao foi deletada com sucesso!";

                return RedirectToAction("Secoes", "Secoes");

            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao desativar secao: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                return RedirectToAction("Secoes", "Secoes");
            }
        }

    }
}