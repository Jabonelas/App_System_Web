﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Velzon.Models;

[Index("fk_tb_matriz", Name = "ifk_tb_matriz_tb_est")]
public partial class tb_est
{
    [Key]
    public long id_est { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] es_dtCri { get; set; }

    [Required]
    [Column(TypeName = "DATETIME")]
    public byte[] es_dtAlt { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] es_dtAcs { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_dskCaption { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_dskIndex { get; set; }

    [Column(TypeName = "varchar(128)")]
    public string es_dskSerialNumber { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_dskSignature { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_dskSize { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string es_dskStatus { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_nicAdapterType { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_nicAdapterTypeID { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_nicCaption { get; set; }

    [Column(TypeName = "varchar(128)")]
    public string es_nicDescription { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_nicInterfaceIndex { get; set; }

    [Column(TypeName = "varchar(32)")]
    public string es_nicMacAddress { get; set; }

    [Column(TypeName = "varchar(32)")]
    public string es_nicMacAddressVpn { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_nicManufacturer { get; set; }

    [Column(TypeName = "varchar(128)")]
    public string es_nicName { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_nicNetEnabled { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_nicSpeed { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_nicCfgDHCPEnabled { get; set; }

    [Column(TypeName = "varchar(48)")]
    public string es_nicCfgDHCPServer { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string es_nicCfgDNSDomain { get; set; }

    public string es_nicCfgIPAddress { get; set; }

    public string es_nicCfgIPAddressVpn { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_nicCfgIPConnectionMetric { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_nicCfgIPEnabled { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPgFlAllocatedBaseSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPgFlCurrentUsage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPgFlPeakUsage { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string es_pcPowInstanceID { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string es_pcPowElementName { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string es_pcLdCaption { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcLdCompressed { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcLdConfigManagerErrorCode { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string es_pcLdDeviceID { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcLdDriveType { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string es_pcLdFileSystem { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcLdFreeSpace { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcLdLastErrorCode { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_pcLdName { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcLdSize { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcLdVolumeDirty { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string es_pcLdVolumeSerialNumber { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcAutomaticManagedPagefile { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcAutomaticResetBootOption { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcAutomaticResetCapability { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcBootROMSupported { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string es_pcBootupState { get; set; }

    [Column(TypeName = "smallint")]
    public long es_pcCurrentTimeZone { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcDaylightInEffect { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string es_pcDNSHostName { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcDomainRole { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcEnableDaylightSavingsTime { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcHypervisorPresent { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string es_pcManufacturer { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcNetworkServerModeEnabled { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcNumberOfLogicalProcessors { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcNumberOfProcessors { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPCSystemType { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcTotalPhysicalMemory { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string es_pcUserName { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcWakeUpType { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_biosCaption { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_biosSerialNumber { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_biosSMBIOSBIOSVersion { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string es_biosSoftwareElementID { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string es_boardManufacturer { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_boardProduct { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_boardSerialNumber { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string es_boardStatus { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_boardVersion { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string es_pcOsBuildNumber { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_pcOsCaption { get; set; }

    [Column(TypeName = "varchar(6)")]
    public string es_pcOsCodeSet { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string es_pcOsCountryCode { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcOsCurrentTimeZone { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcOsFreePhysicalMemory { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcOsFreeSpaceInPagingFiles { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcOsFreeVirtualMemory { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] es_pcOsInstallDate { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] es_pcOsLastBootUpTime { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] es_pcOsLocalDateTime { get; set; }

    [Column(TypeName = "varchar(6)")]
    public string es_pcOsLocale { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcOsNumberOfProcesses { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcOsNumberOfUsers { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcOsOperatingSystemSKU { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string es_pcOSArchitecture { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcOSLanguage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcOSProductSuite { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcOsPortableOperatingSystem { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcOsPrimary { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcOsProductType { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string es_pcOsRegisteredUser { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string es_pcOsSerialNumber { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcOsServicePackMajorVersion { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcOsServicePackMinorVersion { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcOsSizeStoredInPagingFiles { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcOsSuiteMask { get; set; }

    [Column(TypeName = "varchar(2)")]
    public string es_pcOsSystemDrive { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcOsTotalSwapSpaceSize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcOsTotalVirtualMemorySize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_pcOsTotalVisibleMemorySize { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string es_pcOsVersion { get; set; }

    [Column(TypeName = "varchar(256)")]
    public string es_procHandle { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procHandleCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procKernelModeTime { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procOtherOperationCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procOtherTransferCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procPageFaults { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procPageFileUsage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procPeakPageFileUsage { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procPeakVirtualSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procPeakWorkingSetSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procPriority { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procPrivatePageCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procProcessId { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procReadOperationCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procReadTransferCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_procThreadCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procUserModeTime { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procVirtualSize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procWorkingSetSize { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procWriteOperationCount { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_procWriteTransferCount { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcAddressWidth { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcArchitecture { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcAvailability { get; set; }

    [Column(TypeName = "varchar(64)")]
    public string es_pcPrcCaption { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcCharacteristics { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcConfigManagerErrorCode { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcPrcConfigManagerUserConfig { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcCpuStatus { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcCurrentClockSpeed { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcCurrentVoltage { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcDataWidth { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcExtClock { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcFamily { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcL2CacheSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcL2CacheSpeed { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcL3CacheSize { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcL3CacheSpeed { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcLevel { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcLoadPercentage { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcMaxClockSpeed { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string es_pcPrcName { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcNumberOfCores { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcNumberOfEnabledCore { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcNumberOfLogicalProcessors { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcPrcPowerManagementSupported { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string es_pcPrcProcessorId { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcProcessorType { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcRevision { get; set; }

    [Column(TypeName = "NUMERIC(1, 0)")]
    public byte[] es_pcPrcSecondLevelAddressTranslationExtensions { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string es_pcPrcStatus { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_pcPrcStatusInfo { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string es_pcPrcSystemName { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_pcPrcThreadCount { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_gpuAdapterRAM { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_gpuAvailability { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_gpuConfigManagerErrorCode { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_gpuCurrentBitsPerPixel { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_gpuCurrentHorizontalResolution { get; set; }

    [Column(TypeName = "NUMERIC(20, 0)")]
    public byte[] es_gpuCurrentNumberOfColors { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_gpuCurrentRefreshRate { get; set; }

    [Column(TypeName = "NUMERIC(5, 0)")]
    public byte[] es_gpuCurrentScanMode { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_gpuCurrentVerticalResolution { get; set; }

    [Column(TypeName = "NUMERIC(10, 0)")]
    public byte[] es_gpuDitherType { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string es_gpuDriverVersion { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string es_gpuStatus { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string es_gpuVideoProcessor { get; set; }

    public long? fk_tb_matriz { get; set; }

    [ForeignKey("fk_tb_matriz")]
    [InverseProperty("tb_est")]
    public virtual tb_marca_produto fk_tb_matrizNavigation { get; set; }

    [InverseProperty("fk_tb_estNavigation")]
    public virtual ICollection<tb_historico> tb_historico { get; set; } = new List<tb_historico>();

    [InverseProperty("fk_tb_estNavigation")]
    public virtual ICollection<tb_jornada> tb_jornada { get; set; } = new List<tb_jornada>();

    [InverseProperty("fk_tb_estNavigation")]
    public virtual ICollection<tb_produto> tb_produto { get; set; } = new List<tb_produto>();
}