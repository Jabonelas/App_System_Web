using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Velzon.Context;
using Velzon.Models;

public class SubCategoriaService
{
    private readonly CApp_SystemApp_System_BancobancoSQLitedbContext context;

    public SubCategoriaService(CApp_SystemApp_System_BancobancoSQLitedbContext _context)
    {
        context = _context;
    }

    public void CadastrarSubCategoria(tb_subcategoria_produto _subcategoria_produto)
    {
        _subcategoria_produto.scp_dtCri = DateTime.Now;
        _subcategoria_produto.scp_dtAlt = DateTime.Now;
        _subcategoria_produto.scp_desat = 0;

        context.tb_subcategoria_produto.Add(_subcategoria_produto);
        context.SaveChanges();

    }


    public IEnumerable<dynamic> BuscarSubCategorias()
    {

        var categorias = context.tb_categoria_produto
                        .Select(x => new { x.id_categoria_produto, x.cp_desc })
                        .ToList();

        return categorias;

    }


    public IEnumerable<dynamic> BuscarSubCategoriaSelecionada(int _idCategoria)
    {

        var categorias = context.tb_categoria_produto
                        .Select(x => new { x.id_categoria_produto, x.cp_desc })
                        .ToList();

        return categorias;


    }


    public void EditarCadastroSubCategoria(tb_subcategoria_produto _subcategoria_produto)
    {
        if (_subcategoria_produto == null)
        {
            throw new ArgumentNullException(nameof(_subcategoria_produto), "A subcategoria não pode ser nulo.");
        }

        tb_subcategoria_produto subcategoria = context.tb_subcategoria_produto.FirstOrDefault(x => x.id_subcategoria_produto == _subcategoria_produto.id_subcategoria_produto);

        if (subcategoria != null)
        {

            subcategoria.scp_dtAlt = DateTime.Now;
            subcategoria.fk_tb_categoria_produto = _subcategoria_produto.fk_tb_categoria_produto;
            subcategoria.scp_desc = _subcategoria_produto.scp_desc;


            context.SaveChanges();
        }
        else
        {
            throw new KeyNotFoundException("SubCategoria não encontrado.");
        }
    }


    public IEnumerable<dynamic> CarregarListaSubCategorias()
    {

        // //Executar a sua query LINQ (Claramente não preciso dizer que voce deve construir a sua propria linq ne? de acordo com sua necessidade)
        var listaSubCategoriasCadastradas = from categoria in context.tb_categoria_produto
                                            join secao in context.tb_secao_produto
                                                on categoria.fk_tb_secao_produto equals secao.id_secao_produto
                                            join subcategoria in context.tb_subcategoria_produto
                                                on categoria.id_categoria_produto equals subcategoria.fk_tb_categoria_produto
                                            where subcategoria.scp_desat == 0
                                            orderby categoria.cp_desc ascending
                                            select new
                                            {
                                                subcategoria.id_subcategoria_produto,
                                                subcategoria.scp_desc,
                                                secao.sp_desc,
                                                categoria.cp_desc,
                                            };



        return listaSubCategoriasCadastradas;
    }


    public tb_subcategoria_produto DadosSubCategoriaEditar(int _idSubCategoria)
    {

        tb_subcategoria_produto subcategoria_produto = context.tb_subcategoria_produto
                        .FirstOrDefault(x => x.id_subcategoria_produto == _idSubCategoria);

        return subcategoria_produto;
    }


    public void DeletarSubCategoria(int _idSubCategoria)
    {
        var subCategoriaDesativar = context.tb_subcategoria_produto.FirstOrDefault(x => x.id_subcategoria_produto == _idSubCategoria);

        if (subCategoriaDesativar != null)
        {
            subCategoriaDesativar.scp_desat = 1;
            subCategoriaDesativar.scp_dtAlt = DateTime.Now;

            context.SaveChanges();
        }
        else
        {
            throw new Exception("SubCategoria não encontrada.");
        }

    }
}
