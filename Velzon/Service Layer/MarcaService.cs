using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Velzon.Context;
using Velzon.Models;

public class MarcasService
{
    private readonly CApp_SystemApp_System_BancobancoSQLitedbContext context;

    public MarcasService(CApp_SystemApp_System_BancobancoSQLitedbContext _context)
    {
        context = _context;
    }

    public void CadastrarMarca(tb_marca_produto _marca_Produto)
    {
        _marca_Produto.mp_dtCri = DateTime.Now;
        _marca_Produto.mp_dtAlt = DateTime.Now;
        _marca_Produto.mp_desat = 0;

        context.tb_marca_produto.Add(_marca_Produto);
        context.SaveChanges();
    }

    public IEnumerable<dynamic> BuscarMarca()
    {

        var marca = context.tb_marca_produto
                        .Where(x => x.mp_desat == 0)
                        .Select(x => new { x.id_marca_produto, x.mp_desc, x.mp_desat })
                        .ToList();

        return marca;
    }

    public void EditarCadastroMarca(tb_marca_produto _marca_produto)
    {
        if (_marca_produto == null)
        {
            throw new ArgumentNullException(nameof(_marca_produto), "A marca não pode ser nulo.");
        }

        tb_marca_produto marca = context.tb_marca_produto.FirstOrDefault(x => x.id_marca_produto == _marca_produto.id_marca_produto);

        if (marca != null)
        {
            marca.mp_dtAlt = DateTime.Now;
            marca.mp_desc = _marca_produto.mp_desc;

            context.SaveChanges();
        }
        else
        {
            throw new KeyNotFoundException("Marca não encontrado.");
        }
    }


    public tb_marca_produto DadosMarcaEditar(int _idMarca)
    {

        tb_marca_produto marca_produto = context.tb_marca_produto
                        .FirstOrDefault(x => x.id_marca_produto == _idMarca);

        return marca_produto;
    }

    public void DeletarMarca(int _idMarca)
    {
        var marcaDesativar = context.tb_marca_produto.FirstOrDefault(x => x.id_marca_produto == _idMarca);

        if (marcaDesativar != null)
        {
            marcaDesativar.mp_desat = 1;
            marcaDesativar.mp_dtAlt = DateTime.Now;

            context.SaveChanges();
        }
        else
        {
            throw new Exception("Marca não encontrada.");
        }

    }
}
