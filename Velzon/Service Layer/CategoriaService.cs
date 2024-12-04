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
        _categoria_produto.cp_desc = _categoria_produto.cp_desc;
        _categoria_produto.fk_tb_secao_produto = _categoria_produto.fk_tb_secao_produto;


        context.tb_categoria_produto.Add(_categoria_produto);
        context.SaveChanges();

        // CadastrarProdutoFiliais(tb_categoria_produto);
    }



    public IEnumerable<dynamic> BuscarCategoria()
    {

        var categorias = context.tb_categoria_produto
                        .Select(x => new { x.id_categoria_produto, x.cp_desc })
                        .ToList();

        return categorias;

    }


    public void CadastrarProdutoFiliais(tb_produto _produto)
    {

        var listaFiliaisAtivasCadastradas = BuscarFiliaisCadastrosAtivos();

        foreach (var filial in listaFiliaisAtivasCadastradas)
        {

            tb_produto_filial _produto_Filial = new tb_produto_filial();

            _produto_Filial.pf_codRef = _produto.pd_codRef;
            _produto_Filial.pf_desc = _produto.pd_desc;
            _produto_Filial.pf_descCurta = _produto.pd_descCurta;
            _produto_Filial.pf_proTipo = _produto.pd_proTipo;
            _produto_Filial.pf_unMedCom = _produto.pd_unMedCom;
            _produto_Filial.pf_dtCri = DateTime.Now;
            _produto_Filial.pf_dtAlt = DateTime.Now;
            _produto_Filial.pf_vlrUnCom = _produto.pd_vlrUnComBase;
            _produto_Filial.pf_cstUnCom = _produto.pd_cstUnComBase;
            _produto_Filial.pf_estMin = _produto.pd_estMinBase;
            _produto_Filial.pf_estMax = _produto.pd_estMaxBase;
            _produto_Filial.pf_desat = _produto.pd_desat;
            _produto_Filial.pf_canc = 0;
            _produto_Filial.fk_tb_produto = _produto.id_produto;
            _produto_Filial.fk_tb_ator = filial.id_ator;


            context.tb_produto_filial.Add(_produto_Filial);
            context.SaveChanges();

        }
    }


    public IEnumerable<dynamic> BuscarFiliaisCadastrosAtivos()
    {


        var filiaisCadastradas = context.tb_ator
        .Where(x => x.at_atorTipo == 11 && x.at_desat == 0)
        .Select(x => new { x.id_ator, x.at_atorTipo, x.at_desat })
        .ToList();

        return filiaisCadastradas;


    }



    public void EditarProduto(tb_produto _produto)
    {
        if (_produto == null)
        {
            throw new ArgumentNullException(nameof(_produto), "O produto não pode ser nulo.");
        }

        tb_produto produto = context.tb_produto.FirstOrDefault(x => x.pd_codRef == _produto.pd_codRef);

        if (produto != null)
        {

            produto.pd_dtAlt = DateTime.Now;
            produto = _produto;

            context.SaveChanges();
        }
        else
        {
            throw new KeyNotFoundException("Produto não encontrado.");
        }
    }


    // public void EditarProduto(tb_produto _produto)
    // {
    //     tb_produto produto = context.tb_produto.FirstOrDefault(x => x.pd_codRef == _produto.pd_codRef);

    //     if (produto != null)
    //     {
    //         // Atualiza os campos específicos
    //         produto.pd_desc = _produto.pd_desc;
    //         produto.pd_descCurta = _produto.pd_descCurta;
    //         // Continue com os outros campos necessários...

    //         // Atualiza a data de alteração
    //         produto.pd_dtAlt = DateTime.Now;

    //         // Salva as alterações
    //         context.SaveChanges();
    //     }
    //     else
    //     {
    //         throw new Exception("Produto não encontrado.");
    //     }
    // }


    public long BuscarCodigoProduto()
    {

        long codProd = context.tb_produto
                        .OrderByDescending(x => x.pd_codRef)
                        .Select(x => x.pd_codRef)
                        .FirstOrDefault();

        return codProd;

    }


    public IEnumerable<dynamic> CarregarListaProdutos()
    {

        // //Executar a sua query LINQ (Claramente não preciso dizer que voce deve construir a sua propria linq ne? de acordo com sua necessidade)
        var listaProdutosCadastrados = from produto in context.tb_produto
                                       join marca in context.tb_marca_produto on produto.fk_tb_marca_produto equals marca.id_marca_produto
                                       join categoria in context.tb_categoria_produto on produto.fk_tb_categoria_produto equals categoria.id_categoria_produto
                                       join subcategoria in context.tb_subcategoria_produto on produto.fk_tb_subcategoria_produto equals subcategoria.id_subcategoria_produto
                                       where produto.pd_desat == 0
                                       orderby produto.pd_codRef ascending
                                       select new
                                       {
                                           produto.id_produto,
                                           //  produto.pd_dtCri,
                                           //  produto.pd_dtAlt,
                                           //  produto.pd_desat,
                                           //  produto.pd_genero,
                                           //  produto.pd_unMedCom,
                                           produto.pd_codRef,
                                           //  produto.pd_codRefStr,
                                           //  produto.pd_barras,
                                           //  produto.pd_impRef,
                                           //  produto.pd_proTipo,
                                           //  produto.pd_especie,
                                           produto.pd_estTot,
                                           //  produto.pd_invend,
                                           produto.pd_descCurta,
                                           produto.pd_desc,
                                           //  produto.pd_fxEta,
                                           produto.pd_vlrUnComBase,
                                           //  produto.pd_cstUnComBase,
                                           //  produto.pd_estMinBase,
                                           //  produto.pd_estMaxBase,
                                           //  produto.pd_nfeProdOrigem,
                                           //  produto.pd_nfeCsosn,
                                           //  produto.pd_vend,
                                           //  produto.pd_tmpStr,
                                           //  produto.pd_ativo,
                                           //  produto.fk_tb_est,
                                           //  produto.fk_tb_rede,
                                           //  produto.fk_tb_ncm,
                                           //  produto.fk_tb_ator,
                                           //  produto.fk_tb_relacao_produto_cadastro_XML,
                                           //  produto.fk_tb_marca_produto,
                                           //  produto.fk_tb_subcategoria_produto,
                                           //  produto.fk_tb_categoria_produto,
                                           marca.mp_desc,
                                           categoria.cp_desc,
                                           subcategoria.scp_desc

                                       };





        return listaProdutosCadastrados;
    }


    public IEnumerable<dynamic> ListaEstoqueProdutoFiliais(int _codRef)
    {

        var listaEstoqueProdutoFiliais = from produtoFilial in context.tb_produto_filial
                                         join produto in context.tb_produto
                                         on produtoFilial.fk_tb_produto equals produto.id_produto
                                         join filial in context.tb_ator
                                         on produtoFilial.fk_tb_ator equals filial.id_ator
                                         where produto.pd_desat == 0
                                         && produtoFilial.pf_codRef == _codRef
                                         orderby produtoFilial.pf_est descending
                                         select new
                                         {
                                             produtoFilial.id_produto_filial,
                                             produtoFilial.pf_codRef,
                                             produtoFilial.pf_desc,
                                             produtoFilial.pf_vlrUnCom,
                                             produtoFilial.pf_desat,
                                             produtoFilial.pf_est,
                                             filial.at_cnpj,
                                             filial.at_nomeFant,
                                         };

        return listaEstoqueProdutoFiliais;
    }

    public tb_produto DadosProdutoEditar(int _codRef)
    {

        tb_produto produtoEditar = context.tb_produto
                        .FirstOrDefault(x => x.pd_codRef == _codRef);

        return produtoEditar;
    }



    public void DeletarProduto(int _idProduto)
    {
        var produtoDesativar = context.tb_produto.FirstOrDefault(x => x.id_produto == _idProduto);

        if (produtoDesativar != null)
        {
            produtoDesativar.pd_desat = 0;

            context.SaveChanges();
        }
        else
        {
            throw new Exception("Produto não encontrado.");
        }

    }


}
