﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_nfe", Name = "ifk_tb_nfe_tb_nfe_enviada_filial")]
[Index("fk_tb_pdv", Name = "ifk_tb_pdv_tb_nfe_enviada_filial")]
public partial class tb_nfe_enviada_filial
{
    [Key]
    public long id_nfe_enviada_filial { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] nef_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] nef_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] nef_dtAcs { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] nef_desat { get; set; }

    public long? fk_tb_pdv { get; set; }

    public long? fk_tb_nfe { get; set; }

    [ForeignKey("fk_tb_nfe")]
    [InverseProperty("tb_nfe_enviada_filial")]
    public virtual tb_nfe fk_tb_nfeNavigation { get; set; }

    [ForeignKey("fk_tb_pdv")]
    [InverseProperty("tb_nfe_enviada_filial")]
    public virtual tb_pdv fk_tb_pdvNavigation { get; set; }
}