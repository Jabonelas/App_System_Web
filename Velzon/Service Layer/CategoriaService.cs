using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Velzon.Context;
using Velzon.Models;

public class CategoriaService
{
    private readonly CApp_SystemApp_System_BancobancoSQLitedbContext context;

    public CategoriaService(CApp_SystemApp_System_BancobancoSQLitedbContext _context)
    {
        context = _context;
    }

    public void CadastrarCategoria(tb_categoria_produto _categoria_produto)
    {
        _categoria_produto.cp_dtCri = DateTime.Now;
        _categoria_produto.cp_dtAlt = DateTime.Now;
        _categoria_produto.cp_desat = 0;

        context.tb_categoria_produto.Add(_categoria_produto);
        context.SaveChanges();
    }


    public IEnumerable<dynamic> BuscarCategorias()
    {

        var categorias = context.tb_categoria_produto
                        .Select(x => new { x.id_categoria_produto, x.cp_desc })
                        .ToList();

        return categorias;
    }


    public IEnumerable<dynamic> BuscarCategoriaSelecionada(int _idCategoria)
    {

        var categorias = context.tb_categoria_produto
                        .Select(x => new { x.id_categoria_produto, x.cp_desc })
                        .ToList();

        return categorias;
    }


    public void EditarCadastroCategoria(tb_categoria_produto _categoria_produto)
    {
        if (_categoria_produto == null)
        {
            throw new ArgumentNullException(nameof(_categoria_produto), "A categoria não pode ser nulo.");
        }

        tb_categoria_produto categoria = context.tb_categoria_produto.FirstOrDefault(x => x.id_categoria_produto == _categoria_produto.id_categoria_produto);

        if (categoria != null)
        {

            categoria.cp_dtAlt = DateTime.Now;
            categoria.fk_tb_secao_produto = _categoria_produto.fk_tb_secao_produto;
            categoria.cp_desc = _categoria_produto.cp_desc;


            context.SaveChanges();
        }
        else
        {
            throw new KeyNotFoundException("Categoria não encontrado.");
        }
    }


    public IEnumerable<dynamic> CarregarListaCategorias()
    {

        // //Executar a sua query LINQ (Claramente não preciso dizer que voce deve construir a sua propria linq ne? de acordo com sua necessidade)
        var listaCategoriasCadastradas = from categoria in context.tb_categoria_produto
                                         join secao in context.tb_secao_produto on categoria.fk_tb_secao_produto equals secao.id_secao_produto
                                         where categoria.cp_desat == 0
                                         orderby categoria.id_categoria_produto ascending
                                         select new
                                         {
                                             categoria.id_categoria_produto,
                                             categoria.cp_desc,
                                             secao.sp_desc

                                         };

        return listaCategoriasCadastradas;
    }


    public tb_categoria_produto DadosCategoriaEditar(int _idCategoria)
    {

        tb_categoria_produto categoria_produto = context.tb_categoria_produto
                        .FirstOrDefault(x => x.id_categoria_produto == _idCategoria);

        return categoria_produto;
    }


    public void DeletarCategoria(int _idCategoria)
    {
        var categoriaDesativar = context.tb_categoria_produto.FirstOrDefault(x => x.id_categoria_produto == _idCategoria);

        if (categoriaDesativar != null)
        {
            categoriaDesativar.cp_desat = 1;
            categoriaDesativar.cp_dtAlt = DateTime.Now;

            context.SaveChanges();
        }
        else
        {
            throw new Exception("Categoria não encontrada.");
        }

    }

}
