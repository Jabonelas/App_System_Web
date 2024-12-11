using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Velzon.Context;
using Velzon.Models;

public class ConsumidorService
{
    private readonly CApp_SystemApp_System_BancobancoSQLitedbContext context;

    public ConsumidorService(CApp_SystemApp_System_BancobancoSQLitedbContext _context)
    {
        context = _context;
    }


    public void CadastrarSecao(tb_secao_produto _secao_Produto)
    {
        _secao_Produto.sp_dtCri = DateTime.Now;
        _secao_Produto.sp_dtAlt = DateTime.Now;
        _secao_Produto.sp_desat = 0;


        context.tb_secao_produto.Add(_secao_Produto);
        context.SaveChanges();
    }

    public IEnumerable<dynamic> BuscarSecao()
    {

        var secao = context.tb_secao_produto
                        .Where(x => x.sp_desat == 0)
                        .Select(x => new { x.id_secao_produto, x.sp_desc, x.sp_desat })
                        .ToList();

        return secao;
    }

    public void EditarCadastroSecao(tb_secao_produto _secao_produto)
    {
        if (_secao_produto == null)
        {
            throw new ArgumentNullException(nameof(_secao_produto), "A secao não pode ser nulo.");
        }

        tb_secao_produto secao = context.tb_secao_produto.FirstOrDefault(x => x.id_secao_produto == _secao_produto.id_secao_produto);

        if (secao != null)
        {
            secao.sp_dtAlt = DateTime.Now;
            secao.sp_desc = _secao_produto.sp_desc;

            context.SaveChanges();
        }
        else
        {
            throw new KeyNotFoundException("Seção não encontrado.");
        }
    }


    public tb_secao_produto DadosSecaoEditar(int _idSecao)
    {

        tb_secao_produto secao_produto = context.tb_secao_produto
                        .FirstOrDefault(x => x.id_secao_produto == _idSecao);

        return secao_produto;
    }

    public void DeletarSecao(int _idSecao)
    {
        var secaoDesativar = context.tb_secao_produto.FirstOrDefault(x => x.id_secao_produto == _idSecao);

        if (secaoDesativar != null)
        {
            secaoDesativar.sp_desat = 1;
            secaoDesativar.sp_dtAlt = DateTime.Now;

            context.SaveChanges();
        }
        else
        {
            throw new Exception("Secao não encontrada.");
        }

    }


}
