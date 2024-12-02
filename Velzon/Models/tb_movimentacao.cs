﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_ator_atend", Name = "ifk_tb_ator_atend_tb_movimentacao")]
[Index("fk_tb_ator_dest", Name = "ifk_tb_ator_dest_tb_movimentacao")]
[Index("fk_tb_ator_emit", Name = "ifk_tb_ator_emit_tb_movimentacao")]
[Index("fk_tb_clasCont2", Name = "ifk_tb_clasCont2_tb_movimentacao")]
[Index("fk_tb_jornada", Name = "ifk_tb_jornada_tb_movimentacao")]
public partial class tb_movimentacao
{
    [Key]
    public long id_movimentacao { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeTipoAmb { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] mv_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] mv_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] mv_dtAcs { get; set; }

    [Column(TypeName = "bigint")]
    public long mv_qtdItens { get; set; }

    [Column(TypeName = "bigint")]
    public long mv_numSeq { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] mv_canc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] mv_conc { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] mv_quit { get; set; }

    [Column(TypeName = "smallint")]
    public long mv_movTipo { get; set; }

    [Column(TypeName = "bigint")]
    public long mv_codSeqAbertFechCx { get; set; }

    public long? mv_movAbertCx { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] mv_cxAberto { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] mv_nfeEnfilGer { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string mv_nfeNatOp { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotProd { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotNF { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotDesc { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrIcmsDeson { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotIcmsSt { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotFcpRetSt { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotFrete { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotSeg { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotOutro { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotImpImp { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotIpi { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotIpiDevol { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTroco { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeBcIcms { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrBcIcmsSt { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotTrib { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string mv_nfeChave { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotCofins { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotFcp { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotFcpSt { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotIcms { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_nfeVlrTotPis { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeIdentLocDestOp { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeMod { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeIndOpConsumFin { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeFinEmis { get; set; }

    [Column(TypeName = "INT")]
    public long mv_nfeIndInterm { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeIndPresCompEstMomOp { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeTipo { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeTipoImpDanfe { get; set; }

    [Column(TypeName = "varchar(3)")]
    public string mv_nfeCfop { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeProcEmis { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string mv_nfeVerProcEmis { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeModFrete { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] mv_nfeDtEmis { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeTipoEmis { get; set; }

    [Column(TypeName = "tinyint")]
    public long mv_nfeTipoDfe { get; set; }

    public string mv_nfeXmlProcRes { get; set; }

    [Column(TypeName = "NUMERIC(13, 2)")]
    public byte[] mv_vlrTotPag { get; set; }

    [Column(TypeName = "varchar(11)")]
    public string mv_cpf_tmp { get; set; }

    public long? fk_tb_clasCont2 { get; set; }

    public long? fk_tb_jornada { get; set; }

    public long? fk_tb_ator_atend { get; set; }

    public long? fk_tb_ator_dest { get; set; }

    public long? fk_tb_ator_emit { get; set; }

    [ForeignKey("fk_tb_ator_atend")]
    [InverseProperty("tb_movimentacaofk_tb_ator_atendNavigation")]
    public virtual tb_ator fk_tb_ator_atendNavigation { get; set; }

    [ForeignKey("fk_tb_ator_dest")]
    [InverseProperty("tb_movimentacaofk_tb_ator_destNavigation")]
    public virtual tb_ator fk_tb_ator_destNavigation { get; set; }

    [ForeignKey("fk_tb_ator_emit")]
    [InverseProperty("tb_movimentacaofk_tb_ator_emitNavigation")]
    public virtual tb_ator fk_tb_ator_emitNavigation { get; set; }

    [ForeignKey("fk_tb_clasCont2")]
    [InverseProperty("tb_movimentacao")]
    public virtual tb_clasCont2 fk_tb_clasCont2Navigation { get; set; }

    [ForeignKey("fk_tb_jornada")]
    [InverseProperty("tb_movimentacao")]
    public virtual tb_jornada fk_tb_jornadaNavigation { get; set; }

    [InverseProperty("fk_tb_movimentacaoNavigation")]
    public virtual ICollection<tb_movimentacao_caixa> tb_movimentacao_caixa { get; set; } = new List<tb_movimentacao_caixa>();

    [InverseProperty("fk_tb_movimentacaoNavigation")]
    public virtual ICollection<tb_movimentacao_impressao> tb_movimentacao_impressao { get; set; } = new List<tb_movimentacao_impressao>();

    [InverseProperty("fk_tb_movimentacaoNavigation")]
    public virtual ICollection<tb_movimentacao_pagamento> tb_movimentacao_pagamento { get; set; } = new List<tb_movimentacao_pagamento>();

    [InverseProperty("fk_tb_movimentacaoNavigation")]
    public virtual ICollection<tb_movimentacao_produto> tb_movimentacao_produto { get; set; } = new List<tb_movimentacao_produto>();

    [InverseProperty("fk_tb_movimentacaoNavigation")]
    public virtual ICollection<tb_nfe> tb_nfe { get; set; } = new List<tb_nfe>();
}