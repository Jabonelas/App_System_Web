﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_ator", Name = "ifk_tb_ator_tb_pdv")]
public partial class tb_pdv
{
    [Key]
    public long id_pdv { get; set; }

    [Column(TypeName = "varchar(300)")]
    public string pdv_serv { get; set; }

    [Column(TypeName = "varchar(300)")]
    public string pdv_host { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] pdv_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] pdv_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] pdv_dtAcs { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_desat { get; set; }

    [Column(TypeName = "smallint")]
    public long pdv_pdvNum { get; set; }

    [Column(TypeName = "smallint")]
    public long pdv_nfeHomSerie { get; set; }

    [Column(TypeName = "INT")]
    public long pdv_nfeHomNum { get; set; }

    [Column(TypeName = "smallint")]
    public long pdv_nfeProdSerie { get; set; }

    [Column(TypeName = "INT")]
    public long pdv_nfeProdNum { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_dskCaption { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_dskIndex { get; set; }

    [Column(TypeName = "varchar(128)")]
    public string pdv_dskSerialNumber { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_dskSignature { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_dskSize { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string pdv_dskStatus { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_nicAdapterType { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_nicAdapterTypeID { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_nicCaption { get; set; }

    [Column(TypeName = "varchar(128)")]
    public string pdv_nicDescription { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_nicInterfaceIndex { get; set; }

    [Column(TypeName = "varchar(32)")]
    public string pdv_nicMacAddress { get; set; }

    [Column(TypeName = "varchar(32)")]
    public string pdv_nicMacAddressVpn { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_nicManufacturer { get; set; }

    [Column(TypeName = "varchar(128)")]
    public string pdv_nicName { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_nicNetEnabled { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_nicSpeed { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_nicCfgDHCPEnabled { get; set; }

    [Column(TypeName = "varchar(48)")]
    public string pdv_nicCfgDHCPServer { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string pdv_nicCfgDNSDomain { get; set; }

    public string pdv_nicCfgIPAddress { get; set; }

    public string pdv_nicCfgIPAddressVpn { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_nicCfgIPConnectionMetric { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_nicCfgIPEnabled { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPgFlAllocatedBaseSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPgFlCurrentUsage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPgFlPeakUsage { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string pdv_pcPowInstanceID { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string pdv_pcPowElementName { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string pdv_pcLdCaption { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcLdCompressed { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcLdConfigManagerErrorCode { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string pdv_pcLdDeviceID { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcLdDriveType { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string pdv_pcLdFileSystem { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcLdFreeSpace { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcLdLastErrorCode { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_pcLdName { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcLdSize { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcLdVolumeDirty { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string pdv_pcLdVolumeSerialNumber { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcAutomaticManagedPagefile { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcAutomaticResetBootOption { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcAutomaticResetCapability { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcBootROMSupported { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string pdv_pcBootupState { get; set; }

    [Column(TypeName = "smallint")]
    public long pdv_pcCurrentTimeZone { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcDaylightInEffect { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string pdv_pcDNSHostName { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcDomainRole { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcEnableDaylightSavingsTime { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcHypervisorPresent { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string pdv_pcManufacturer { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcNetworkServerModeEnabled { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcNumberOfLogicalProcessors { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcNumberOfProcessors { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPCSystemType { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcTotalPhysicalMemory { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string pdv_pcUserName { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcWakeUpType { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_biosCaption { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_biosSerialNumber { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_biosSMBIOSBIOSVersion { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string pdv_biosSoftwareElementID { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string pdv_boardManufacturer { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_boardProduct { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_boardSerialNumber { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string pdv_boardStatus { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_boardVersion { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string pdv_pcOsBuildNumber { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_pcOsCaption { get; set; }

    [Column(TypeName = "varchar(6)")]
    public string pdv_pcOsCodeSet { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string pdv_pcOsCountryCode { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcOsCurrentTimeZone { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcOsFreePhysicalMemory { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcOsFreeSpaceInPagingFiles { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcOsFreeVirtualMemory { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] pdv_pcOsInstallDate { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] pdv_pcOsLastBootUpTime { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] pdv_pcOsLocalDateTime { get; set; }

    [Column(TypeName = "varchar(6)")]
    public string pdv_pcOsLocale { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcOsNumberOfProcesses { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcOsNumberOfUsers { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcOsOperatingSystemSKU { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string pdv_pcOSArchitecture { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcOSLanguage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcOSProductSuite { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcOsPortableOperatingSystem { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcOsPrimary { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcOsProductType { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string pdv_pcOsRegisteredUser { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string pdv_pcOsSerialNumber { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcOsServicePackMajorVersion { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcOsServicePackMinorVersion { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcOsSizeStoredInPagingFiles { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcOsSuiteMask { get; set; }

    [Column(TypeName = "varchar(2)")]
    public string pdv_pcOsSystemDrive { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcOsTotalSwapSpaceSize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcOsTotalVirtualMemorySize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_pcOsTotalVisibleMemorySize { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string pdv_pcOsVersion { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string pdv_procHandle { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procHandleCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procKernelModeTime { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procOtherOperationCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procOtherTransferCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procPageFaults { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procPageFileUsage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procPeakPageFileUsage { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procPeakVirtualSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procPeakWorkingSetSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procPriority { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procPrivatePageCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procProcessId { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procReadOperationCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procReadTransferCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_procThreadCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procUserModeTime { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procVirtualSize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procWorkingSetSize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procWriteOperationCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_procWriteTransferCount { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcAddressWidth { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcArchitecture { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcAvailability { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string pdv_pcPrcCaption { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcCharacteristics { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcConfigManagerErrorCode { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcPrcConfigManagerUserConfig { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcCpuStatus { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcCurrentClockSpeed { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcCurrentVoltage { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcDataWidth { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcExtClock { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcFamily { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcL2CacheSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcL2CacheSpeed { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcL3CacheSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcL3CacheSpeed { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcLevel { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcLoadPercentage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcMaxClockSpeed { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string pdv_pcPrcName { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcNumberOfCores { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcNumberOfEnabledCore { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcNumberOfLogicalProcessors { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcPrcPowerManagementSupported { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string pdv_pcPrcProcessorId { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcProcessorType { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcRevision { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pcPrcSecondLevelAddressTranslationExtensions { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string pdv_pcPrcStatus { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_pcPrcStatusInfo { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string pdv_pcPrcSystemName { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_pcPrcThreadCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_gpuAdapterRAM { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_gpuAvailability { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_gpuConfigManagerErrorCode { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_gpuCurrentBitsPerPixel { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_gpuCurrentHorizontalResolution { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] pdv_gpuCurrentNumberOfColors { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_gpuCurrentRefreshRate { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] pdv_gpuCurrentScanMode { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_gpuCurrentVerticalResolution { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] pdv_gpuDitherType { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string pdv_gpuDriverVersion { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string pdv_gpuStatus { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string pdv_gpuVideoProcessor { get; set; }

    [Column(TypeName = "tinyint")]
    public long pdv_persTim { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] pdv_pdvUpdRunVerDt { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string pdv_pdvUpdRunVer { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] pdv_pdvUpdNewVerDt { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string pdv_pdvUpdNewVer { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] pdv_pdvUpdReady { get; set; }

    public long? fk_tb_ator { get; set; }

    [ForeignKey("fk_tb_ator")]
    [InverseProperty("tb_pdv")]
    public virtual tb_ator fk_tb_atorNavigation { get; set; }

    [InverseProperty("fk_tb_pdvNavigation")]
    public virtual ICollection<tb_clasCont2> tb_clasCont2 { get; set; } = new List<tb_clasCont2>();

    [InverseProperty("fk_tb_pdvNavigation")]
    public virtual ICollection<tb_jornada> tb_jornada { get; set; } = new List<tb_jornada>();

    [InverseProperty("fk_tb_pdvNavigation")]
    public virtual ICollection<tb_nfe_enviada_filial> tb_nfe_enviada_filial { get; set; } = new List<tb_nfe_enviada_filial>();
}