using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Pratico.Infra.API;
using Velzon.Context;
using Velzon.Models;

namespace Velzon.Controllers
{
    public class CEPController : Controller
    {
        private readonly CEPService cepService;

        public CEPController(CEPService _cepService)
        {
            cepService = _cepService;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarCEP(string cep)
        {
            try
            {
                API_Correios apiCorreios = new API_Correios();

                //Tratando o CEP para enviar a requisição
                string cepValido = cep.Replace("-", "").Replace(".", "");

                //Pegando os dados que retornam da requisição
                var dadosCep = await apiCorreios.APICorreios(cepValido);

                return Ok(dadosCep);
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna uma mensagem de erro
                return Json(new { sucesso = false, mensagem = $"Erro ao buscar o CEP: {ex.Message}" });
            }
        }

        [HttpGet]
        public IActionResult GetMunicipio()
        {
            try
            {
                var listaMunicipio = cepService.BuscarMunicipios();

                return Ok(listaMunicipio);
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao buscar lista de municipio com id e nome: {ex.Message}");

                TempData["mensagem"] = "Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.";

                return RedirectToAction("CadastrarConsumidor", "Consumidores");
            }

        }

    }
}