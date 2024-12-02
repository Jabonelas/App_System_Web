﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

public partial class tb_contGru
{
    [Key]
    public long id_contGru { get; set; }

    public long? cg_contSec { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] cg_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] cg_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] cg_dtAcs { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string cg_desc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] cg_canc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] cg_conc { get; set; }

    [InverseProperty("fk_tb_contGruNavigation")]
    public virtual ICollection<tb_contExtGru> tb_contExtGru { get; set; } = new List<tb_contExtGru>();

    [InverseProperty("fk_tb_contGruNavigation")]
    public virtual ICollection<tb_contSubGru> tb_contSubGru { get; set; } = new List<tb_contSubGru>();
}