﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_pdv", Name = "ifk_tb_pdv_tb_clasCont2")]
public partial class tb_clasCont2
{
    [Key]
    public long id_clasCont2 { get; set; }

    public long? cc2_clasCont1 { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] cc2_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] cc2_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] cc2_dtAcs { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] cc2_desat { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string cc2_desc { get; set; }

    public long? fk_tb_pdv { get; set; }

    [ForeignKey("fk_tb_pdv")]
    [InverseProperty("tb_clasCont2")]
    public virtual tb_pdv fk_tb_pdvNavigation { get; set; }

    [InverseProperty("fk_tb_clasCont2Navigation")]
    public virtual ICollection<tb_movimentacao> tb_movimentacao { get; set; } = new List<tb_movimentacao>();
}