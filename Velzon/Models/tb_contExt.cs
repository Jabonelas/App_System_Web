﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_cont", Name = "ifk_tb_cont_tb_contExt")]
public partial class tb_contExt
{
    [Key]
    public long id_contExt { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] ce_deb { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] ce_cred { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] ce_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] ce_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] ce_dtAcs { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] ce_canc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] ce_conc { get; set; }

    public long? fk_tb_cont { get; set; }

    [ForeignKey("fk_tb_cont")]
    [InverseProperty("tb_contExt")]
    public virtual tb_cont fk_tb_contNavigation { get; set; }
}