﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

public partial class tb_rede
{
    [Key]
    public long id_rede { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] re_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] re_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] re_dtAcs { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string re_desc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] re_desat { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] re_desatSinc { get; set; }

    [Column(TypeName = "tinyint")]
    public long re_PersTim { get; set; }

    [InverseProperty("fk_tb_redeNavigation")]
    public virtual ICollection<tb_clasCont1> tb_clasCont1 { get; set; } = new List<tb_clasCont1>();

    [InverseProperty("fk_tb_redeNavigation")]
    public virtual ICollection<tb_forma_pagamento> tb_forma_pagamento { get; set; } = new List<tb_forma_pagamento>();

    [InverseProperty("fk_tb_redeNavigation")]
    public virtual ICollection<tb_marca_produto> tb_marca_produto { get; set; } = new List<tb_marca_produto>();

    [InverseProperty("fk_tb_redeNavigation")]
    public virtual ICollection<tb_matriz> tb_matriz { get; set; } = new List<tb_matriz>();

    [InverseProperty("fk_tb_redeNavigation")]
    public virtual ICollection<tb_produto> tb_produto { get; set; } = new List<tb_produto>();

    [InverseProperty("fk_tb_redeNavigation")]
    public virtual ICollection<tb_secao_produto> tb_secao_produto { get; set; } = new List<tb_secao_produto>();
}