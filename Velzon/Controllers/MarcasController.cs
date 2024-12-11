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
    public class MarcasController : Controller
    {
        private readonly MarcasService marcasService;

        public MarcasController(MarcasService _marcasService)
        {
            marcasService = _marcasService;
        }

        [HttpGet]
        public IActionResult GetMarcas()
        {
            var marcas = marcasService.BuscarMarca();


            return Ok(marcas);
        }



        [ActionName("Marcas")]
        public IActionResult Marcas()
        {
            try
            {
                var listaMarcas = marcasService.BuscarMarca();

                ViewData["ListaMarcas"] = listaMarcas;

                return View();
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir todas as marcas: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("CadastrarMarcas", "Marcas");
            }
        }




        [ActionName("CadastrarMarca")]
        public IActionResult CadastrarMarca()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarMarca(tb_marca_produto _marca_produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    marcasService.CadastrarMarca(_marca_produto);

                    TempData["mensagem"] = "Operação realizada com sucesso!";

                    return RedirectToAction("CadastrarMarca", "Marcas");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao cadastrar marca: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("CadastrarMarca", "Marcas");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatórios para continuar.";
                return View(_marca_produto);
            }
        }

        [ActionName("EditarMarca")]
        public IActionResult EditarMarca(int idMarca)
        {
            try
            {
                var marca = marcasService.DadosMarcaEditar(idMarca);


                return View(marca);
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao exibir dados da marca selecionada: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";
                return RedirectToAction("Marcas", "Marcas");
            }
        }

        [HttpPut]
        [HttpPost]
        public IActionResult EditarMarca(tb_marca_produto _marca_produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    marcasService.EditarCadastroMarca(_marca_produto);

                    TempData["mensagem"] = "A marca foi atualizada com sucesso!";
                    return RedirectToAction("Marcas", "Marcas");
                }
                catch (Exception ex)
                {
                    // Log do erro
                    Console.WriteLine($"Erro ao editar os dados da marca: {ex.Message}");

                    TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                    return RedirectToAction("Marcas", "Marcas");
                }
            }
            else
            {
                TempData["mensagem"] = "Por favor, preencha todos os campos obrigatórios para continuar.";
                return View(_marca_produto);
            }
        }

        [HttpPatch]
        public IActionResult DeletarMarca(int _idMarca)
        {
            try
            {
                marcasService.DeletarMarca(_idMarca);

                TempData["mensagem"] = "A marca foi deletada com sucesso!";

                return RedirectToAction("Marcas", "Marcas");

            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao desativar marca: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                return RedirectToAction("Marcas", "Marcas");
            }
        }
    }
}