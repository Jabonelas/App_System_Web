﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_rede", Name = "ifk_tb_rede_tb_matriz")]
public partial class tb_matriz
{
    [Key]
    public long id_matriz { get; set; }

    [Column(TypeName = "varchar(18)")]
    public string mt_cnpj { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string mt_nomeFant { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string mt_razSoc { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] mt_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] mt_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] mt_dtAcs { get; set; }

    [Column(TypeName = "smallint")]
    public long mt_hrAbertLj { get; set; }

    [Column(TypeName = "smallint")]
    public long mt_hrFchLj { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] mt_efetuaTestesEletro { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public int mt_desat { get; set; }

    [Column(TypeName = "tinyint")]
    public long mt_persTim { get; set; }

    public long? fk_tb_rede { get; set; }

    [ForeignKey("fk_tb_rede")]
    [InverseProperty("tb_matriz")]
    public virtual tb_rede fk_tb_redeNavigation { get; set; }

    [InverseProperty("fk_tb_matrizNavigation")]
    public virtual ICollection<tb_ator> tb_ator { get; set; } = new List<tb_ator>();
}