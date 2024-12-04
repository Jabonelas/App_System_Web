﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_rede", Name = "ifk_tb_rede_tb_secao_produto")]
public partial class tb_secao_produto
{
    [Key]
    public long id_secao_produto { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] sp_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] sp_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] sp_dtAcs { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public int sp_desat { get; set; }

    [Column(TypeName = "varchar(48)")]
    public string sp_desc { get; set; }

    public long? fk_tb_rede { get; set; }

    [ForeignKey("fk_tb_rede")]
    [InverseProperty("tb_secao_produto")]
    public virtual tb_rede fk_tb_redeNavigation { get; set; }

    [InverseProperty("fk_tb_secao_produtoNavigation")]
    public virtual ICollection<tb_categoria_produto> tb_categoria_produto { get; set; } = new List<tb_categoria_produto>();
}