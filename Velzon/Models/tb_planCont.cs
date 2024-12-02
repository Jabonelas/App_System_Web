﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

public partial class tb_planCont
{
    [Key]
    public long id_planCont { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string pc_desc { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] pc_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] pc_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] pc_dtAcs { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pc_desat { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pc_canc { get; set; }
}