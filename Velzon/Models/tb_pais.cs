﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_unidade_monetaria", Name = "ifk_tb_unidade_monetaria_tb_pais")]
public partial class tb_pais
{
    [Key]
    public long id_pais { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] ps_desat { get; set; }

    [Column(TypeName = "smallint")]
    public long? ps_id { get; set; }

    [Column(TypeName = "varchar(3)")]
    public string ps_sigla { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string ps_nome { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] ps_canc { get; set; }

    public long? fk_tb_unidade_monetaria { get; set; }

    [ForeignKey("fk_tb_unidade_monetaria")]
    [InverseProperty("tb_pais")]
    public virtual tb_unidade_monetaria fk_tb_unidade_monetariaNavigation { get; set; }

    [InverseProperty("fk_tb_paisNavigation")]
    public virtual ICollection<tb_regioes_br> tb_regioes_br { get; set; } = new List<tb_regioes_br>();
}