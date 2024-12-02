﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_contGru", Name = "ifk_tb_contGru_tb_contSubGru")]
public partial class tb_contSubGru
{
    [Key]
    public long id_contSubGru { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] csg_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] csg_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] csg_dtAcs { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string csg_desc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] csg_canc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] csg_conc { get; set; }

    public long? fk_tb_contGru { get; set; }

    [ForeignKey("fk_tb_contGru")]
    [InverseProperty("tb_contSubGru")]
    public virtual tb_contGru fk_tb_contGruNavigation { get; set; }

    [InverseProperty("fk_tb_contSubGruNavigation")]
    public virtual ICollection<tb_cont> tb_cont { get; set; } = new List<tb_cont>();

    [InverseProperty("fk_tb_contSubGruNavigation")]
    public virtual ICollection<tb_contExtSubGru> tb_contExtSubGru { get; set; } = new List<tb_contExtSubGru>();
}