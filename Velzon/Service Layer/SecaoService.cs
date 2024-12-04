using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Velzon.Context;
using Velzon.Models;

public class SecaoService
{
    private readonly CApp_SystemApp_System_BancobancoSQLitedbContext context;

    public SecaoService(CApp_SystemApp_System_BancobancoSQLitedbContext _context)
    {
        context = _context;
    }

    public void CadastrarCategoria(tb_categoria_produto _categoria_produto)
    {
        _categoria_produto.cp_dtCri = DateTime.Now;
        _categoria_produto.cp_dtAlt = DateTime.Now;
        _categoria_produto.cp_desat = 0;
        _categoria_produto.cp_desc = _categoria_produto.cp_desc;
        _categoria_produto.fk_tb_secao_produto = _categoria_produto.fk_tb_secao_produto;


        context.tb_categoria_produto.Add(_categoria_produto);
        context.SaveChanges();

        // CadastrarProdutoFiliais(tb_categoria_produto);
    }

    public IEnumerable<dynamic> BuscarSecao()
    {

        var secao = context.tb_secao_produto
                        .Where(x => x.sp_desat == 0)
                        .Select(x => new { x.id_secao_produto, x.sp_desc, x.sp_desat })
                        .ToList();

        return secao;
    }


    public void CadastraSecao(tb_categoria_produto _categoria_produto)
    {

        tb_categoria_produto categoria_produto = new tb_categoria_produto();

        categoria_produto.cp_dtCri = DateTime.Now;
        categoria_produto.cp_dtAlt = DateTime.Now;
        categoria_produto.cp_desat = 0;
        categoria_produto.cp_desc = _categoria_produto.cp_desc;
        categoria_produto.fk_tb_secao_produto = _categoria_produto.fk_tb_secao_produto;

        context.tb_categoria_produto.Add(categoria_produto);
        context.SaveChanges();

    }
}
