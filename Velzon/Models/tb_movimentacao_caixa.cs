﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_movimentacao", Name = "ifk_tb_movimentacao_tb_movimentacao_caixa")]
public partial class tb_movimentacao_caixa
{
    [Key]
    public long id_movimentacao_caixa { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] mc_canc { get; set; }

    public long? fk_tb_movimentacao { get; set; }

    [ForeignKey("fk_tb_movimentacao")]
    [InverseProperty("tb_movimentacao_caixa")]
    public virtual tb_movimentacao fk_tb_movimentacaoNavigation { get; set; }
}