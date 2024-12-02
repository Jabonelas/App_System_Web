﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_forma_pagamento", Name = "ifk_tb_forma_pagamento_tb_sub_forma_pagamento")]
public partial class tb_sub_forma_pagamento
{
    [Key]
    public long id_sub_forma_pagamento { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] sfp_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] sfp_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] sfp_dtAcs { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] sfp_desat { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string sfp_desc { get; set; }

    [Column(TypeName = "smallint")]
    public long sfp_ordExib { get; set; }

    [Column(TypeName = "nchar(1)")]
    public string sfp_atalhoTecl { get; set; }

    [Column(TypeName = "smallint")]
    public long sfp_intParc { get; set; }

    [Column(TypeName = "tinyint")]
    public long sfp_nfeTipoBand { get; set; }

    public long? fk_tb_forma_pagamento { get; set; }

    [ForeignKey("fk_tb_forma_pagamento")]
    [InverseProperty("tb_sub_forma_pagamento")]
    public virtual tb_forma_pagamento fk_tb_forma_pagamentoNavigation { get; set; }

    [InverseProperty("fk_tb_sub_forma_pagamentoNavigation")]
    public virtual ICollection<tb_movimentacao_pagamento> tb_movimentacao_pagamento { get; set; } = new List<tb_movimentacao_pagamento>();

    [InverseProperty("fk_tb_sub_forma_pagamentoNavigation")]
    public virtual ICollection<tb_movimentacao_pagamento_parcela> tb_movimentacao_pagamento_parcela { get; set; } = new List<tb_movimentacao_pagamento_parcela>();
}