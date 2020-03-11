using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartLoadManagement.Models
{
    public partial class SmartLoadManagementContext : DbContext
    {
        public SmartLoadManagementContext()
        {
        }

        public SmartLoadManagementContext(DbContextOptions<SmartLoadManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AchvAlarmtamper> AchvAlarmtamper { get; set; }
        public virtual DbSet<AchvAlarmtamperMeter> AchvAlarmtamperMeter { get; set; }
        public virtual DbSet<AchvBasicset> AchvBasicset { get; set; }
        public virtual DbSet<AchvBasicsetMeter> AchvBasicsetMeter { get; set; }
        public virtual DbSet<AchvClockset> AchvClockset { get; set; }
        public virtual DbSet<AchvClocksetMeter> AchvClocksetMeter { get; set; }
        public virtual DbSet<AchvCustomer> AchvCustomer { get; set; }
        public virtual DbSet<AchvDebt> AchvDebt { get; set; }
        public virtual DbSet<AchvDisplayset> AchvDisplayset { get; set; }
        public virtual DbSet<AchvDisplaysetMeter> AchvDisplaysetMeter { get; set; }
        public virtual DbSet<AchvLineloss> AchvLineloss { get; set; }
        public virtual DbSet<AchvLinelossPowergrid> AchvLinelossPowergrid { get; set; }
        public virtual DbSet<AchvLoadctrl> AchvLoadctrl { get; set; }
        public virtual DbSet<AchvLoadctrlMeter> AchvLoadctrlMeter { get; set; }
        public virtual DbSet<AchvMeter> AchvMeter { get; set; }
        public virtual DbSet<AchvMeterpwd> AchvMeterpwd { get; set; }
        public virtual DbSet<AchvMeterpwdMeter> AchvMeterpwdMeter { get; set; }
        public virtual DbSet<AchvOuterRelay> AchvOuterRelay { get; set; }
        public virtual DbSet<AchvOuterRelayMeter> AchvOuterRelayMeter { get; set; }
        public virtual DbSet<AchvPoc> AchvPoc { get; set; }
        public virtual DbSet<AchvPowergrid> AchvPowergrid { get; set; }
        public virtual DbSet<AchvSim> AchvSim { get; set; }
        public virtual DbSet<AchvThreshold> AchvThreshold { get; set; }
        public virtual DbSet<AchvThresholdMeter> AchvThresholdMeter { get; set; }
        public virtual DbSet<AchvTml> AchvTml { get; set; }
        public virtual DbSet<AchvUpgrade> AchvUpgrade { get; set; }
        public virtual DbSet<AchvUpgradeDevice> AchvUpgradeDevice { get; set; }
        public virtual DbSet<DataCElec> DataCElec { get; set; }
        public virtual DbSet<DataCElecDay> DataCElecDay { get; set; }
        public virtual DbSet<DataCElecMonthfrozen> DataCElecMonthfrozen { get; set; }
        public virtual DbSet<DataCEvt> DataCEvt { get; set; }
        public virtual DbSet<DataCEvtBalancealarm> DataCEvtBalancealarm { get; set; }
        public virtual DbSet<DataCEvtPowerofftime> DataCEvtPowerofftime { get; set; }
        public virtual DbSet<DataCLoad> DataCLoad { get; set; }
        public virtual DbSet<DataCMaxdemand> DataCMaxdemand { get; set; }
        public virtual DbSet<DataCOnline> DataCOnline { get; set; }
        public virtual DbSet<DataCPostpaidBilling> DataCPostpaidBilling { get; set; }
        public virtual DbSet<DataFeeGhana> DataFeeGhana { get; set; }
        public virtual DbSet<DataLineloss> DataLineloss { get; set; }
        public virtual DbSet<DataMtKwhDay> DataMtKwhDay { get; set; }
        public virtual DbSet<DataMtKwhMonth> DataMtKwhMonth { get; set; }
        public virtual DbSet<DataTmlOnline> DataTmlOnline { get; set; }
        public virtual DbSet<LogCommTime> LogCommTime { get; set; }
        public virtual DbSet<LogDeleteMtTml> LogDeleteMtTml { get; set; }
        public virtual DbSet<LogEmailSms> LogEmailSms { get; set; }
        public virtual DbSet<LogLogin> LogLogin { get; set; }
        public virtual DbSet<LogManualTask> LogManualTask { get; set; }
        public virtual DbSet<LogMeterFriendlyTime> LogMeterFriendlyTime { get; set; }
        public virtual DbSet<LogMeterTou> LogMeterTou { get; set; }
        public virtual DbSet<LogMeterstatus> LogMeterstatus { get; set; }
        public virtual DbSet<LogMsg> LogMsg { get; set; }
        public virtual DbSet<LogOperating> LogOperating { get; set; }
        public virtual DbSet<LogPassword> LogPassword { get; set; }
        public virtual DbSet<LogPocMeter> LogPocMeter { get; set; }
        public virtual DbSet<LogServiceSession> LogServiceSession { get; set; }
        public virtual DbSet<LogTaskResult> LogTaskResult { get; set; }
        public virtual DbSet<LogTaskResultAnalysis> LogTaskResultAnalysis { get; set; }
        public virtual DbSet<LogTmlTask> LogTmlTask { get; set; }
        public virtual DbSet<OrdManage> OrdManage { get; set; }
        public virtual DbSet<OrdReissue> OrdReissue { get; set; }
        public virtual DbSet<OrdReversed> OrdReversed { get; set; }
        public virtual DbSet<OrdSpc> OrdSpc { get; set; }
        public virtual DbSet<OrdTrn> OrdTrn { get; set; }
        public virtual DbSet<OrdTrnDebt> OrdTrnDebt { get; set; }
        public virtual DbSet<OrdTrnDetail> OrdTrnDetail { get; set; }
        public virtual DbSet<OrdTrnOrdno> OrdTrnOrdno { get; set; }
        public virtual DbSet<OrdTrnStep> OrdTrnStep { get; set; }
        public virtual DbSet<PrmCfg> PrmCfg { get; set; }
        public virtual DbSet<PrmCfgDtl> PrmCfgDtl { get; set; }
        public virtual DbSet<PrmCollect> PrmCollect { get; set; }
        public virtual DbSet<PrmCollectObis> PrmCollectObis { get; set; }
        public virtual DbSet<PrmCollectPlan> PrmCollectPlan { get; set; }
        public virtual DbSet<PrmCollectPlanObis> PrmCollectPlanObis { get; set; }
        public virtual DbSet<PrmDeviceDeleted> PrmDeviceDeleted { get; set; }
        public virtual DbSet<PrmEvtClass1> PrmEvtClass1 { get; set; }
        public virtual DbSet<PrmEvtClass2> PrmEvtClass2 { get; set; }
        public virtual DbSet<PrmEvtDef> PrmEvtDef { get; set; }
        public virtual DbSet<PrmFeeind> PrmFeeind { get; set; }
        public virtual DbSet<PrmFeeindGhana> PrmFeeindGhana { get; set; }
        public virtual DbSet<PrmFeetbl> PrmFeetbl { get; set; }
        public virtual DbSet<PrmFeetblGhana> PrmFeetblGhana { get; set; }
        public virtual DbSet<PrmMetertype> PrmMetertype { get; set; }
        public virtual DbSet<PrmPowergridtype> PrmPowergridtype { get; set; }
        public virtual DbSet<PrmSg> PrmSg { get; set; }
        public virtual DbSet<PrmSgkey> PrmSgkey { get; set; }
        public virtual DbSet<PrmSupplier> PrmSupplier { get; set; }
        public virtual DbSet<PrmTmltype> PrmTmltype { get; set; }
        public virtual DbSet<PrmTrfind> PrmTrfind { get; set; }
        public virtual DbSet<PrmTrftbl> PrmTrftbl { get; set; }
        public virtual DbSet<ScrcardBatch> ScrcardBatch { get; set; }
        public virtual DbSet<ScrcardCard> ScrcardCard { get; set; }
        public virtual DbSet<SmsserverCalls> SmsserverCalls { get; set; }
        public virtual DbSet<SmsserverIn> SmsserverIn { get; set; }
        public virtual DbSet<SmsserverOut> SmsserverOut { get; set; }
        public virtual DbSet<SysBase> SysBase { get; set; }
        public virtual DbSet<SysChangelog> SysChangelog { get; set; }
        public virtual DbSet<SysHelp> SysHelp { get; set; }
        public virtual DbSet<SysNotice> SysNotice { get; set; }
        public virtual DbSet<SysNoticeUser> SysNoticeUser { get; set; }
        public virtual DbSet<SysPage> SysPage { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysRolePage> SysRolePage { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<SysUserSubscribe> SysUserSubscribe { get; set; }
        public virtual DbSet<SysUsergroup> SysUsergroup { get; set; }
        public virtual DbSet<SysUsergroupObj> SysUsergroupObj { get; set; }
        public virtual DbSet<SysUsergroupUser> SysUsergroupUser { get; set; }
        public virtual DbSet<VndClientkey> VndClientkey { get; set; }
        public virtual DbSet<VndMch> VndMch { get; set; }
        public virtual DbSet<VndMchCredit> VndMchCredit { get; set; }
        public virtual DbSet<VndMchUser> VndMchUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source= FS01;Database=SmartLoadManagement;Trusted_Connection=False; User ID= ChevonRodgers; Password= THbSLC1p");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AchvAlarmtamper>(entity =>
            {
                entity.ToTable("ACHV_ALARMTAMPER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBY")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datatype)
                    .IsRequired()
                    .HasColumnName("DATATYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datavalue)
                    .HasColumnName("DATAVALUE")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBY")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Protocol)
                    .HasColumnName("protocol")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<AchvAlarmtamperMeter>(entity =>
            {
                entity.ToTable("ACHV_ALARMTAMPER_METER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlarmtamperId)
                    .HasColumnName("ALARMTAMPER_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Result).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AchvBasicset>(entity =>
            {
                entity.ToTable("ACHV_BASICSET");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Commspeed)
                    .HasColumnName("COMMSPEED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Demanddigit)
                    .HasColumnName("DEMANDDIGIT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Demandnumberperiods)
                    .HasColumnName("DEMANDNUMBERPERIODS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Demandperiod)
                    .HasColumnName("DEMANDPERIOD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Energydigit)
                    .HasColumnName("ENERGYDIGIT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Modulereset)
                    .HasColumnName("MODULERESET")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AchvBasicsetMeter>(entity =>
            {
                entity.ToTable("ACHV_BASICSET_METER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BasicsetId)
                    .HasColumnName("BASICSET_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Result).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AchvClockset>(entity =>
            {
                entity.ToTable("ACHV_CLOCKSET");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetime)
                    .HasColumnName("DATETIME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Daylightbegin)
                    .HasColumnName("DAYLIGHTBEGIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Daylightdeviation)
                    .HasColumnName("DAYLIGHTDEVIATION")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Daylightenabled)
                    .HasColumnName("DAYLIGHTENABLED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Daylightend)
                    .HasColumnName("DAYLIGHTEND")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Timezone)
                    .HasColumnName("TIMEZONE")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AchvClocksetMeter>(entity =>
            {
                entity.ToTable("ACHV_CLOCKSET_METER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClocksetId)
                    .HasColumnName("CLOCKSET_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Result).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AchvCustomer>(entity =>
            {
                entity.ToTable("ACHV_CUSTOMER");

                entity.HasComment("用于 存储客户基础数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNo)
                    .HasColumnName("AccountNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100)
                    .HasComment("地址");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.CustomerType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("客户类型 SYS_BASE.CustomerType");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("邮箱");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasComment("姓");

                entity.Property(e => e.IdentityId)
                    .IsRequired()
                    .HasColumnName("IdentityID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("客户ID号");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasComment("名");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("移动电话");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("密码");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasColumnType("numeric(10, 0)")
                    .HasComment("邮编");

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("性别  0：男  1：女");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态  SYS_BASE.CustomerStat");

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("固定电话");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");
            });

            modelBuilder.Entity<AchvDebt>(entity =>
            {
                entity.ToTable("ACHV_DEBT");

                entity.HasComment("用于 存储债务数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("总额");

                entity.Property(e => e.Balance)
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("余额");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("合同编号");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("客户编号");

                entity.Property(e => e.DebtAmountPct)
                    .HasColumnName("DebtAmountPCT")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("债务总额百分比");

                entity.Property(e => e.DebtType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("类型");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("固定额还债");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.PurchaseAmountPct)
                    .HasColumnName("PurchaseAmountPCT")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("购电金额百分比");

                entity.Property(e => e.RepayLatest)
                    .HasColumnType("datetime")
                    .HasComment("最迟还完日期");

                entity.Property(e => e.RepayTimes)
                    .HasColumnType("numeric(6, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("还债次数");

                entity.Property(e => e.RepayType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("还债类型");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");
            });

            modelBuilder.Entity<AchvDisplayset>(entity =>
            {
                entity.ToTable("ACHV_DISPLAYSET");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AutoScroll).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Backlight).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Obis)
                    .IsRequired()
                    .HasColumnName("OBIS")
                    .IsUnicode(false);

                entity.Property(e => e.Protocol)
                    .HasColumnName("protocol")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<AchvDisplaysetMeter>(entity =>
            {
                entity.ToTable("ACHV_DISPLAYSET_METER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplaysetId)
                    .HasColumnName("DISPLAYSET_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Result).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AchvLineloss>(entity =>
            {
                entity.ToTable("ACHV_LINELOSS");

                entity.HasComment("用于存储线损方案数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CalcLatest)
                    .HasColumnName("Calc_Latest")
                    .HasColumnType("datetime")
                    .HasComment("最近计算日期");

                entity.Property(e => e.CalcMonthLatest)
                    .HasColumnName("Calc_MonthLatest")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalcTimes)
                    .HasColumnName("Calc_Times")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("计算次数");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.DayCalc)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("日线损");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.GatewayMeterId)
                    .HasColumnName("GatewayMeter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("总表表号");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MonthCalc)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("月线损");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");
            });

            modelBuilder.Entity<AchvLinelossPowergrid>(entity =>
            {
                entity.HasKey(e => new { e.LineLossId, e.PowerGridId })
                    .HasName("PK_ACHV_LINELOSS_POWERGRID_1");

                entity.ToTable("ACHV_LINELOSS_POWERGRID");

                entity.HasComment("用于存储线损方案与电网的关联关系");

                entity.Property(e => e.LineLossId)
                    .HasColumnName("LineLoss_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("线损方案编号");

                entity.Property(e => e.PowerGridId)
                    .HasColumnName("PowerGrid_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("电网表号");

                entity.HasOne(d => d.LineLoss)
                    .WithMany(p => p.AchvLinelossPowergrid)
                    .HasForeignKey(d => d.LineLossId)
                    .HasConstraintName("FK_ACHV_LINELOSS_POWERGRID_ACHV_LINELOSS");

                entity.HasOne(d => d.PowerGrid)
                    .WithMany(p => p.AchvLinelossPowergrid)
                    .HasForeignKey(d => d.PowerGridId)
                    .HasConstraintName("FK_ACHV_LINELOSS_POWERGRID_ACHV_POWERGRID");
            });

            modelBuilder.Entity<AchvLoadctrl>(entity =>
            {
                entity.ToTable("ACHV_LOADCTRL");

                entity.HasComment("用于存储负荷方案数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActionOver1)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActionOver2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActionUnder1)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActionUnder2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveTime1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveTimeRelay11)
                    .HasColumnName("ActiveTimeRelay1_1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Duration1).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.DurationRelay11)
                    .HasColumnName("DurationRelay1_1")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MinOverThresholdDuration)
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("最小过载时间");

                entity.Property(e => e.MinOverThresholdDuration1).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MinUnderThresholdDuration).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MinUnderThresholdDuration1).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Mode1).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Mode2).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MonitoredValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("监测 值");

                entity.Property(e => e.MonitoredValue1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.RelayEnabled1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scheme)
                    .IsUnicode(false)
                    .HasComment("方案");

                entity.Property(e => e.Scheme1).IsUnicode(false);

                entity.Property(e => e.ThresholdEmergency).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.ThresholdEmergency1).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.ThresholdNormal)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("正常阀值");

                entity.Property(e => e.ThresholdNormal1).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("类型");
            });

            modelBuilder.Entity<AchvLoadctrlMeter>(entity =>
            {
                entity.ToTable("ACHV_LOADCTRL_METER");

                entity.HasComment("用于存储表计负荷方案数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.LoadctrlId)
                    .HasColumnName("LOADCTRL_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("负荷方案编号");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表号");

                entity.Property(e => e.Result)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("结果");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("补发次数");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.HasOne(d => d.Loadctrl)
                    .WithMany(p => p.AchvLoadctrlMeter)
                    .HasForeignKey(d => d.LoadctrlId)
                    .HasConstraintName("FK_ACHV_LOADCTRL_METER_ACHV_LOADCTRL");

                entity.HasOne(d => d.Meter)
                    .WithMany(p => p.AchvLoadctrlMeter)
                    .HasForeignKey(d => d.MeterId)
                    .HasConstraintName("FK_ACHV_LOADCTRL_METER_ACHV_METER");
            });

            modelBuilder.Entity<AchvMeter>(entity =>
            {
                entity.ToTable("ACHV_METER");

                entity.HasComment("用于存储表计基础数据");

                entity.HasIndex(e => e.Msno);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AssetNo)
                    .HasMaxLength(20)
                    .HasComment("资产编号");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.CurrentMonthMoney)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("当月充值金额");

                entity.Property(e => e.CurrentMonthUnits)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("当月充值电量");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .HasComment("描述");

                entity.Property(e => e.Dlmsaesgcm128)
                    .HasColumnName("DLMSAESGCM128")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Dlmsak)
                    .HasColumnName("DLMSAK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dlmsauthentication)
                    .HasColumnName("DLMSAuthentication")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("DLMS认证");

                entity.Property(e => e.Dlmsek)
                    .HasColumnName("DLMSEK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dlmspassword)
                    .HasColumnName("DLMSPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("DLMS通讯密码");

                entity.Property(e => e.IsRegister)
                    .HasColumnName("is_register")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ken)
                    .HasColumnName("KEN")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("KEN");

                entity.Property(e => e.Krn)
                    .HasColumnName("KRN")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("密钥版本");

                entity.Property(e => e.LastFreeVending)
                    .HasColumnType("datetime")
                    .HasComment("最近免费日期");

                entity.Property(e => e.LastVending)
                    .HasColumnType("datetime")
                    .HasComment("最近购电日期");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MeterTypeId)
                    .HasColumnName("MeterType_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("表计类型");

                entity.Property(e => e.Msno)
                    .IsRequired()
                    .HasColumnName("MSNO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("表号");

                entity.Property(e => e.PrmCfgId)
                    .HasColumnName("prm_cfg_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrmCollectId)
                    .HasColumnName("PRM_COLLECT_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("采集任务ID");

                entity.Property(e => e.PrmDeviceId)
                    .HasColumnName("PRM_DEVICE_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("设备配置ID");

                entity.Property(e => e.Sgc)
                    .HasColumnName("SGC")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应组编码");

                entity.Property(e => e.SimId)
                    .HasColumnName("SIM_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("SIM卡ID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态  SYS_BASE.MeterStatus");

                entity.Property(e => e.Ti)
                    .HasColumnName("TI")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率索引号");

                entity.HasOne(d => d.MeterType)
                    .WithMany(p => p.AchvMeter)
                    .HasForeignKey(d => d.MeterTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_METER_PRM_METERTYPE");

                entity.HasOne(d => d.PrmCollect)
                    .WithMany(p => p.AchvMeter)
                    .HasForeignKey(d => d.PrmCollectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_METER_PRM_COLLECT");

                entity.HasOne(d => d.PrmDevice)
                    .WithMany(p => p.AchvMeter)
                    .HasForeignKey(d => d.PrmDeviceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_METER_PRM_DEVICE");
            });

            modelBuilder.Entity<AchvMeterpwd>(entity =>
            {
                entity.ToTable("ACHV_METERPWD");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwdtype)
                    .HasColumnName("PWDTYPE")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<AchvMeterpwdMeter>(entity =>
            {
                entity.ToTable("ACHV_METERPWD_METER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MeterpwdId)
                    .HasColumnName("METERPWD_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Result).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AchvOuterRelay>(entity =>
            {
                entity.ToTable("ACHV_OUTER_RELAY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActionOver)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActionUnder)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duration).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinOverThresholdDuration).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MinUnderThresholdDuration).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Mode).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MonitoredValue)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Protocol)
                    .HasColumnName("protocol")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ThresholdEmergency).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.ThresholdNormal).HasColumnType("numeric(12, 2)");
            });

            modelBuilder.Entity<AchvOuterRelayMeter>(entity =>
            {
                entity.ToTable("ACHV_OUTER_RELAY_METER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OuterrelayId)
                    .HasColumnName("OUTERRELAY_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Result).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AchvPoc>(entity =>
            {
                entity.ToTable("ACHV_POC");

                entity.HasComment("用于存储计量点基础数据");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_ACHV_POC_CUSTOMER");

                entity.HasIndex(e => e.MeterId)
                    .HasName("IX_ACHV_POC_Meter");

                entity.HasIndex(e => e.PowerGridId)
                    .HasName("IX_ACHV_POC_PG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("地址");

                entity.Property(e => e.Capacity)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("容量");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Ct)
                    .HasColumnName("CT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("CT变比SYS_BASE.CT");

                entity.Property(e => e.Ctptratio)
                    .HasColumnName("CTPTRatio")
                    .HasColumnType("numeric(12, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("客户ID");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("纬度");

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("经度");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计ID ACHV_METER.ID");

                entity.Property(e => e.PowerGridId)
                    .HasColumnName("PowerGrid_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("电网结构ID");

                entity.Property(e => e.Pt)
                    .HasColumnName("PT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("PT变比SYS_BASE.PT");

                entity.Property(e => e.SgId)
                    .HasColumnName("SG_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应组ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("SN");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("表计状态  SYS_BASE.DataStatus");

                entity.Property(e => e.TrfIndId)
                    .HasColumnName("TrfInd_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费率ID");

                entity.Property(e => e.VoltageGrade)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("电压等级");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AchvPoc)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_POC_ACHV_CUSTOMER1");

                entity.HasOne(d => d.Meter)
                    .WithMany(p => p.AchvPoc)
                    .HasForeignKey(d => d.MeterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_POC_ACHV_METER");

                entity.HasOne(d => d.PowerGrid)
                    .WithMany(p => p.AchvPoc)
                    .HasForeignKey(d => d.PowerGridId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_POC_ACHV_POWERGRID");

                entity.HasOne(d => d.Sg)
                    .WithMany(p => p.AchvPoc)
                    .HasForeignKey(d => d.SgId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_POC_PRM_SG");

                entity.HasOne(d => d.TrfInd)
                    .WithMany(p => p.AchvPoc)
                    .HasForeignKey(d => d.TrfIndId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_POC_PRM_TRFIND");
            });

            modelBuilder.Entity<AchvPowergrid>(entity =>
            {
                entity.ToTable("ACHV_POWERGRID");

                entity.HasComment("用于 存储电网结构基础数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("纬度");

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("经度");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("父ID");

                entity.Property(e => e.PowerGridType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("电网结构类型  PRM_POWERGRIDTYPE.ID");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SN");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态 SYS_BASE.DataStatus   0：有效  1：无效");

                entity.Property(e => e.VoltageGrade)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("电压等级 ");
            });

            modelBuilder.Entity<AchvSim>(entity =>
            {
                entity.ToTable("ACHV_SIM");

                entity.HasComment("用于 存储SIM卡基础数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Simapn)
                    .HasColumnName("SIMAPN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Simiccid)
                    .HasColumnName("SIMICCID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Simip)
                    .HasColumnName("SIMIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Simmodel)
                    .HasColumnName("SIMMODEL")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("短信猫");

                entity.Property(e => e.Simno)
                    .IsRequired()
                    .HasColumnName("SIMNO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("卡号");

                entity.Property(e => e.Simport)
                    .HasColumnName("SIMPORT")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("SIM卡端口");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态 SYS_BASE.DataStutas 0:有效  1：无效");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应商ID  PRM_SUPPLIER.ID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.AchvSim)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_SIM_PRM_SUPPLIER");
            });

            modelBuilder.Entity<AchvThreshold>(entity =>
            {
                entity.ToTable("ACHV_THRESHOLD");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivePowerOver)
                    .HasColumnName("activePowerOver")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.ApOverTime)
                    .HasColumnName("apOverTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CBypassTime)
                    .HasColumnName("cBypassTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CImbalanceTime)
                    .HasColumnName("cImbalanceTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.COverTime)
                    .HasColumnName("cOverTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CUnderTime)
                    .HasColumnName("cUnderTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentBypass)
                    .HasColumnName("currentBypass")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.CurrentImbalance)
                    .HasColumnName("currentImbalance")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.CurrentOver)
                    .HasColumnName("currentOver")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.CurrentUnder)
                    .HasColumnName("currentUnder")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PfAunder)
                    .HasColumnName("pfAUnder")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PfAunderTime)
                    .HasColumnName("pfAUnderTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PfBunder)
                    .HasColumnName("pfBUnder")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PfBunderTime)
                    .HasColumnName("pfBUnderTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PfCunder)
                    .HasColumnName("pfCUnder")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PfCunderTime)
                    .HasColumnName("pfCUnderTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PfUnderTime)
                    .HasColumnName("pfUnderTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PowerFactorUnder)
                    .HasColumnName("powerFactorUnder")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Protocol)
                    .HasColumnName("protocol")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ReactivePowerOver)
                    .HasColumnName("reactivePowerOver")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.RpOverTime)
                    .HasColumnName("rpOverTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.VOverTime)
                    .HasColumnName("vOverTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.VUnderTime)
                    .HasColumnName("vUnderTime")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.VoltageOver)
                    .HasColumnName("voltageOver")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.VoltageUnder)
                    .HasColumnName("voltageUnder")
                    .HasColumnType("numeric(12, 4)");
            });

            modelBuilder.Entity<AchvThresholdMeter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACHV_THRESHOLD_METER");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Result).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryTimes)
                    .HasColumnName("RETRY_TIMES")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ThresholdId)
                    .HasColumnName("THRESHOLD_ID")
                    .HasColumnType("numeric(6, 0)");
            });

            modelBuilder.Entity<AchvTml>(entity =>
            {
                entity.ToTable("ACHV_TML");

                entity.HasComment("用于存储终端基础数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(8, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AssetNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("资产编号");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasColumnName("IMEI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.PowerGridId)
                    .HasColumnName("PowerGrid_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("电网结构ID");

                entity.Property(e => e.PrmCfgId)
                    .HasColumnName("prm_cfg_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrmCollectId)
                    .HasColumnName("PRM_COLLECT_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("采集任务ID");

                entity.Property(e => e.PrmDeviceId)
                    .HasColumnName("PRM_DEVICE_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("设备配置ID");

                entity.Property(e => e.SimId)
                    .HasColumnName("SIM_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("SIM卡ID");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SN");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("状态 SYS_BASE.DataStatus 0：有效  1：无效");

                entity.Property(e => e.TmltypeId)
                    .HasColumnName("TMLType_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("终端类型ID PRM_TMLTYPE.ID");

                entity.HasOne(d => d.PowerGrid)
                    .WithMany(p => p.AchvTml)
                    .HasForeignKey(d => d.PowerGridId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_TML_ACHV_POWERGRID");

                entity.HasOne(d => d.PrmCollect)
                    .WithMany(p => p.AchvTml)
                    .HasForeignKey(d => d.PrmCollectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_TML_PRM_COLLECT");

                entity.HasOne(d => d.PrmDevice)
                    .WithMany(p => p.AchvTml)
                    .HasForeignKey(d => d.PrmDeviceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_TML_PRM_DEVICE");

                entity.HasOne(d => d.Tmltype)
                    .WithMany(p => p.AchvTml)
                    .HasForeignKey(d => d.TmltypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ACHV_TML_PRM_TMLTYPE");
            });

            modelBuilder.Entity<AchvUpgrade>(entity =>
            {
                entity.ToTable("ACHV_UPGRADE");

                entity.HasComment("用于存储终端升级方案数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CommProtocolId)
                    .HasColumnName("COMM_PROTOCOL_ID")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("通讯规约");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.IsCommModule)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("通讯模块");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("终端类型");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.UpgradeFile)
                    .IsRequired()
                    .HasColumnName("UPGRADE_FILE")
                    .IsUnicode(false)
                    .HasComment("升级文件");

                entity.Property(e => e.UpgradeStartTime)
                    .HasColumnName("UPGRADE_START_TIME")
                    .HasColumnType("datetime")
                    .HasComment("升级开始时间");

                entity.Property(e => e.UpgradeVersion)
                    .IsRequired()
                    .HasColumnName("UPGRADE_VERSION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("升级版本号");
            });

            modelBuilder.Entity<AchvUpgradeDevice>(entity =>
            {
                entity.ToTable("ACHV_UPGRADE_DEVICE");

                entity.HasComment("用于存储终端升级方案设备数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.MtTmlId)
                    .HasColumnName("MT_TML_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("终端编号");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("终端类型ID");

                entity.Property(e => e.UpgradeEndTime)
                    .HasColumnName("UPGRADE_END_TIME")
                    .HasColumnType("datetime")
                    .HasComment("升级结束时间");

                entity.Property(e => e.UpgradeErr)
                    .HasColumnName("UPGRADE_ERR")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("错误信息");

                entity.Property(e => e.UpgradeId)
                    .HasColumnName("UPGRADE_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("升级方案ID");

                entity.Property(e => e.UpgradeProgress)
                    .HasColumnName("UPGRADE_PROGRESS")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("进度");

                entity.Property(e => e.UpgradeResult)
                    .HasColumnName("UPGRADE_RESULT")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("升级结果");

                entity.Property(e => e.UpgradeStartTime)
                    .HasColumnName("UPGRADE_START_TIME")
                    .HasColumnType("datetime")
                    .HasComment("开始升级时间");
            });

            modelBuilder.Entity<DataCElec>(entity =>
            {
                entity.HasKey(e => new { e.DataTime, e.MeterId, e.TariffId })
                    .IsClustered(false);

                entity.ToTable("DATA_C_ELEC");

                entity.HasIndex(e => e.DataTime);

                entity.Property(e => e.DataTime)
                    .HasColumnName("DATA_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TariffId)
                    .HasColumnName("TARIFF_ID")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ConsumptionCredit)
                    .HasColumnName("CONSUMPTION_CREDIT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.CuKwMdi)
                    .HasColumnName("CU_KW_MDI")
                    .HasColumnType("numeric(12, 3)")
                    .HasComment("累计最大需量");

                entity.Property(e => e.CuMdiTime)
                    .HasColumnName("CU_MDI_TIME")
                    .HasColumnType("datetime")
                    .HasComment("累计需量时间");

                entity.Property(e => e.Currentblance)
                    .HasColumnName("CURRENTBLANCE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvahExport)
                    .HasColumnName("KVAH_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvahImport)
                    .HasColumnName("KVAH_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhAbs)
                    .HasColumnName("KVARH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhExport)
                    .HasColumnName("KVARH_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhImport)
                    .HasColumnName("KVARH_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhQi)
                    .HasColumnName("KVARH_QI")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhQii)
                    .HasColumnName("KVARH_QII")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhQiii)
                    .HasColumnName("KVARH_QIII")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhQiv)
                    .HasColumnName("KVARH_QIV")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwMdi)
                    .HasColumnName("KW_MDI")
                    .HasColumnType("numeric(12, 3)")
                    .HasComment("最在需量");

                entity.Property(e => e.KwhAbs)
                    .HasColumnName("KWH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhExport)
                    .HasColumnName("KWH_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhImport)
                    .HasColumnName("KWH_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MdiResetCnt)
                    .HasColumnName("MDI_RESET_CNT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("需量清零次数");

                entity.Property(e => e.MdiResetTime)
                    .HasColumnName("MDI_RESET_TIME")
                    .HasColumnType("datetime")
                    .HasComment("需量清零时间");

                entity.Property(e => e.MdiTime)
                    .HasColumnName("MDI_TIME")
                    .HasColumnType("datetime")
                    .HasComment("最在需量时间");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusWord)
                    .HasColumnName("STATUS_WORD")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DataCElecDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATA_C_ELEC_DAY");

                entity.Property(e => e.ConsumptionCredit)
                    .HasColumnName("CONSUMPTION_CREDIT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Currentblance)
                    .HasColumnName("CURRENTBLANCE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.DataTime)
                    .HasColumnName("DATA_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.KvahExport)
                    .HasColumnName("KVAH_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvahImport)
                    .HasColumnName("KVAH_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhAbs)
                    .HasColumnName("KVARH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhExport)
                    .HasColumnName("KVARH_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhImport)
                    .HasColumnName("KVARH_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhAbs)
                    .HasColumnName("KWH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhExport)
                    .HasColumnName("KWH_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhImport)
                    .HasColumnName("KWH_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.TariffId)
                    .HasColumnName("TARIFF_ID")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<DataCElecMonthfrozen>(entity =>
            {
                entity.HasKey(e => new { e.DataTime, e.MeterId, e.TariffId })
                    .HasName("PK_DATA_C_ELEC_MONTHFROZEN_1");

                entity.ToTable("DATA_C_ELEC_MONTHFROZEN");

                entity.HasComment("月冻结数据");

                entity.Property(e => e.DataTime)
                    .HasColumnName("DATA_TIME")
                    .HasColumnType("datetime")
                    .HasComment("时间数据");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计号");

                entity.Property(e => e.TariffId)
                    .HasColumnName("TARIFF_ID")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率ID");

                entity.Property(e => e.ConsumptionCredit)
                    .HasColumnName("CONSUMPTION_CREDIT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.ConsumptionEnergy)
                    .HasColumnName("CONSUMPTION_ENERGY")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Currentblance)
                    .HasColumnName("CURRENTBLANCE")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("当前余额");

                entity.Property(e => e.KvahExport)
                    .HasColumnName("KVAH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出视在电量");

                entity.Property(e => e.KvahImport)
                    .HasColumnName("KVAH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入视在电量");

                entity.Property(e => e.KvarDemandCumulativeExport)
                    .HasColumnName("KVAR_DEMAND_CUMULATIVE_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarDemandCumulativeImport)
                    .HasColumnName("KVAR_DEMAND_CUMULATIVE_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhAbs)
                    .HasColumnName("KVARH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhExport)
                    .HasColumnName("KVARH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出无功电量");

                entity.Property(e => e.KvarhImport)
                    .HasColumnName("KVARH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入无功电量");

                entity.Property(e => e.KvarhQi)
                    .HasColumnName("KVARH_QI")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhQii)
                    .HasColumnName("KVARH_QII")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhQiii)
                    .HasColumnName("KVARH_QIII")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhQiv)
                    .HasColumnName("KVARH_QIV")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwDemandCumulativeExport)
                    .HasColumnName("KW_DEMAND_CUMULATIVE_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwDemandCumulativeImport)
                    .HasColumnName("KW_DEMAND_CUMULATIVE_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhAbs)
                    .HasColumnName("KWH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhExport)
                    .HasColumnName("KWH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出有功电量");

                entity.Property(e => e.KwhImport)
                    .HasColumnName("KWH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入有功电量");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime")
                    .HasComment("保存时间");

                entity.Property(e => e.TimesBilling)
                    .HasColumnName("TIMES_BILLING")
                    .HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<DataCEvt>(entity =>
            {
                entity.HasKey(e => new { e.EvtTime, e.MtTmlId, e.MtTmlType, e.EvtId, e.Class2Id, e.Class1Id, e.TmlProtocolId })
                    .HasName("PK_EVT")
                    .IsClustered(false);

                entity.ToTable("DATA_C_EVT");

                entity.HasIndex(e => e.EvtTime);

                entity.Property(e => e.EvtTime)
                    .HasColumnName("EVT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MtTmlId)
                    .HasColumnName("MT_TML_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EvtId)
                    .HasColumnName("EVT_ID")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Class2Id)
                    .HasColumnName("CLASS2_ID")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Class1Id)
                    .HasColumnName("CLASS1_ID")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TmlProtocolId)
                    .HasColumnName("TML_PROTOCOL_ID")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Descr).HasMaxLength(1000);

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusword)
                    .HasColumnName("STATUSWORD")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataCEvtBalancealarm>(entity =>
            {
                entity.HasKey(e => new { e.EvtTime, e.MeterId, e.EvtId })
                    .HasName("PK__DATA_C_E__DA1A607938AC3341")
                    .IsClustered(false);

                entity.ToTable("DATA_C_EVT_BALANCEALARM");

                entity.Property(e => e.EvtTime)
                    .HasColumnName("EVT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EvtId)
                    .HasColumnName("EVT_ID")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Currentblance)
                    .HasColumnName("CURRENTBLANCE")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsNoticed).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DataCEvtPowerofftime>(entity =>
            {
                entity.HasKey(e => new { e.MeterId, e.Date })
                    .HasName("PK_DATA_C_EVT_POWEROFFTIME_1");

                entity.ToTable("DATA_C_EVT_POWEROFFTIME");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OffTimes).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.OnTimes).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.PfCulTime)
                    .HasColumnName("PF_CUL_TIME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SaveTime)
                    .HasColumnName("SAVE_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DataCLoad>(entity =>
            {
                entity.HasKey(e => new { e.DataTime, e.MeterId })
                    .HasName("PK_DATA_C_LOAD1")
                    .IsClustered(false);

                entity.ToTable("DATA_C_LOAD");

                entity.HasIndex(e => e.DataTime);

                entity.Property(e => e.DataTime)
                    .HasColumnName("DATA_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AngleUiA)
                    .HasColumnName("ANGLE_UI_A")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.AngleUiB)
                    .HasColumnName("ANGLE_UI_B")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.AngleUiC)
                    .HasColumnName("ANGLE_UI_C")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Current0)
                    .HasColumnName("CURRENT_0")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.CurrentA)
                    .HasColumnName("CURRENT_A")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.CurrentAvgA)
                    .HasColumnName("CURRENT_AVG_A")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.CurrentAvgB)
                    .HasColumnName("CURRENT_AVG_B")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.CurrentAvgC)
                    .HasColumnName("CURRENT_AVG_C")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.CurrentB)
                    .HasColumnName("CURRENT_B")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.CurrentC)
                    .HasColumnName("CURRENT_C")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Frequence)
                    .HasColumnName("FREQUENCE")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.KvaA)
                    .HasColumnName("KVA_A")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvaAExport)
                    .HasColumnName("KVA_A_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvaB)
                    .HasColumnName("KVA_B")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvaBExport)
                    .HasColumnName("KVA_B_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvaC)
                    .HasColumnName("KVA_C")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvaCExport)
                    .HasColumnName("KVA_C_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvaExport)
                    .HasColumnName("KVA_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvaImport)
                    .HasColumnName("KVA_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarA)
                    .HasColumnName("KVAR_A")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarAExport)
                    .HasColumnName("KVAR_A_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarB)
                    .HasColumnName("KVAR_B")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarBExport)
                    .HasColumnName("KVAR_B_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarC)
                    .HasColumnName("KVAR_C")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarCExport)
                    .HasColumnName("KVAR_C_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarDemandAvgExport)
                    .HasColumnName("KVAR_DEMAND_AVG_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarDemandAvgImport)
                    .HasColumnName("KVAR_DEMAND_AVG_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarExport)
                    .HasColumnName("KVAR_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarImport)
                    .HasColumnName("KVAR_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwA)
                    .HasColumnName("KW_A")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwAExport)
                    .HasColumnName("KW_A_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwB)
                    .HasColumnName("KW_B")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwBExport)
                    .HasColumnName("KW_B_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwC)
                    .HasColumnName("KW_C")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwCExport)
                    .HasColumnName("KW_C_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwDemandAvgExport)
                    .HasColumnName("KW_DEMAND_AVG_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwDemandAvgImport)
                    .HasColumnName("KW_DEMAND_AVG_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwExport)
                    .HasColumnName("KW_EXPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwImport)
                    .HasColumnName("KW_IMPORT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.PfA)
                    .HasColumnName("PF_A")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.PfB)
                    .HasColumnName("PF_B")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.PfC)
                    .HasColumnName("PF_C")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.PfTotal)
                    .HasColumnName("PF_TOTAL")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SignalStrength)
                    .HasColumnName("SIGNAL_STRENGTH")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.StatusWord)
                    .HasColumnName("status_word")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VolA)
                    .HasColumnName("VOL_A")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.VolAvgA)
                    .HasColumnName("VOL_AVG_A")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.VolAvgB)
                    .HasColumnName("VOL_AVG_B")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.VolAvgC)
                    .HasColumnName("VOL_AVG_C")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.VolB)
                    .HasColumnName("VOL_B")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.VolC)
                    .HasColumnName("VOL_C")
                    .HasColumnType("numeric(8, 0)");
            });

            modelBuilder.Entity<DataCMaxdemand>(entity =>
            {
                entity.HasKey(e => new { e.MeterId, e.DataTime, e.TariffId })
                    .IsClustered(false);

                entity.ToTable("DATA_C_MAXDEMAND");

                entity.HasComment("最大需量数据");

                entity.HasIndex(e => e.DataTime);

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计号");

                entity.Property(e => e.DataTime)
                    .HasColumnName("DATA_TIME")
                    .HasColumnType("datetime")
                    .HasComment("数据时间");

                entity.Property(e => e.TariffId)
                    .HasColumnName("TARIFF_ID")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率ID");

                entity.Property(e => e.KvarDemandExport)
                    .HasColumnName("KVAR_DEMAND_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("无功输出需量");

                entity.Property(e => e.KvarDemandExportTime)
                    .HasColumnName("KVAR_DEMAND_EXPORT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("无功输出需量发生时间");

                entity.Property(e => e.KvarDemandImport)
                    .HasColumnName("KVAR_DEMAND_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("无功输入需量");

                entity.Property(e => e.KvarDemandImportTime)
                    .HasColumnName("KVAR_DEMAND_IMPORT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("无功输入需量发生时间");

                entity.Property(e => e.KwDemandExport)
                    .HasColumnName("KW_DEMAND_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("有功输出需量");

                entity.Property(e => e.KwDemandExportTime)
                    .HasColumnName("KW_DEMAND_EXPORT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("有功输出需量发生时间");

                entity.Property(e => e.KwDemandImport)
                    .HasColumnName("KW_DEMAND_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("有功输入需量");

                entity.Property(e => e.KwDemandImportTime)
                    .HasColumnName("KW_DEMAND_IMPORT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("有功输入需量发生时间");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime")
                    .HasComment("保存时间");

                entity.Property(e => e.StatusWord)
                    .HasColumnName("STATUS_WORD")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DataCOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATA_C_ONLINE");

                entity.HasIndex(e => e.OccurTime);

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasMaxLength(20);

                entity.Property(e => e.IsOnline)
                    .HasColumnName("IS_ONLINE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MtTmlId)
                    .HasColumnName("MT_TML_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OccurTime)
                    .HasColumnName("OCCUR_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DataCPostpaidBilling>(entity =>
            {
                entity.HasKey(e => new { e.DataTime, e.MeterId });

                entity.ToTable("DATA_C_POSTPAID_BILLING");

                entity.Property(e => e.DataTime)
                    .HasColumnName("DATA_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BillingState)
                    .HasColumnName("BILLING_STATE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.BillingValue)
                    .HasColumnName("BILLING_VALUE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SaveTime)
                    .HasColumnName("SAVE_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DataFeeGhana>(entity =>
            {
                entity.ToTable("DATA_FEE_GHANA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FeeindGhanaId)
                    .HasColumnName("FEEIND_GHANA_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.FeetblGhanaId)
                    .HasColumnName("FEETBL_GHANA_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.GovLevy).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.KWh)
                    .HasColumnName("kWh")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计ID ACHV_METER.ID");

                entity.Property(e => e.Nhil)
                    .HasColumnName("NHIL")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PocId)
                    .HasColumnName("POC_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Relief).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.ServiceCharge).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Status).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StreetLight).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Subside1).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Subside2).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.UnitsCharge).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("numeric(12, 4)");
            });

            modelBuilder.Entity<DataLineloss>(entity =>
            {
                entity.HasKey(e => new { e.LineLossId, e.Date, e.Type });

                entity.ToTable("DATA_LINELOSS");

                entity.HasComment("用于存储线损数据");

                entity.Property(e => e.LineLossId)
                    .HasColumnName("LineLoss_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("线路表号");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.Type)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("线损类型");

                entity.Property(e => e.GatewayMeterId)
                    .HasColumnName("GatewayMeter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("总表表号");

                entity.Property(e => e.GatewayMeterKWh)
                    .HasColumnName("GatewayMeter_kWh")
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("总表电量");

                entity.Property(e => e.GatewayMeterKWhEnd)
                    .HasColumnName("GatewayMeter_kWh_End")
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("总表结束电量");

                entity.Property(e => e.GatewayMeterKWhStart)
                    .HasColumnName("GatewayMeter_kWh_Start")
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("总表开始电量");

                entity.Property(e => e.MetersSumKWh)
                    .HasColumnName("MetersSum_kWh")
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("分表总电量");

                entity.Property(e => e.MetersSumNumber)
                    .HasColumnName("MetersSum_Number")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("统计分表数量");

                entity.Property(e => e.MetersTotalNumber)
                    .HasColumnName("MetersTotal_Number")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("分表总数量");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime")
                    .HasComment("保存时间");
            });

            modelBuilder.Entity<DataMtKwhDay>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.MeterId, e.TariffId });

                entity.ToTable("DATA_MT_KWH_DAY");

                entity.HasComment("表计电量日数据");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计ID");

                entity.Property(e => e.TariffId)
                    .HasColumnName("TARIFF_ID")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率ID");

                entity.Property(e => e.Begintime)
                    .HasColumnName("BEGINTIME")
                    .HasColumnType("datetime")
                    .HasComment("有效开始时间");

                entity.Property(e => e.Endtime)
                    .HasColumnName("ENDTIME")
                    .HasColumnType("datetime")
                    .HasComment("有效结束时间");

                entity.Property(e => e.KvahExport)
                    .HasColumnName("KVAH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出视在电量");

                entity.Property(e => e.KvahExportEnd)
                    .HasColumnName("KVAH_EXPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出视在结束电量");

                entity.Property(e => e.KvahExportStart)
                    .HasColumnName("KVAH_EXPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出视在开始电量");

                entity.Property(e => e.KvahImport)
                    .HasColumnName("KVAH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入视在电量");

                entity.Property(e => e.KvahImportEnd)
                    .HasColumnName("KVAH_IMPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入视在结束电量");

                entity.Property(e => e.KvahImportStart)
                    .HasColumnName("KVAH_IMPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入视在开始电量");

                entity.Property(e => e.KvarhAbs)
                    .HasColumnName("KVARH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhAbsEnd)
                    .HasColumnName("KVARH_ABS_END")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhAbsStart)
                    .HasColumnName("KVARH_ABS_START")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhExport)
                    .HasColumnName("KVARH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出无功电量");

                entity.Property(e => e.KvarhExportEnd)
                    .HasColumnName("KVARH_EXPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出无功结束电量");

                entity.Property(e => e.KvarhExportStart)
                    .HasColumnName("KVARH_EXPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出无功开始电量");

                entity.Property(e => e.KvarhImport)
                    .HasColumnName("KVARH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入无功电量");

                entity.Property(e => e.KvarhImportEnd)
                    .HasColumnName("KVARH_IMPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入无功结束电量");

                entity.Property(e => e.KvarhImportStart)
                    .HasColumnName("KVARH_IMPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入无功开始电量");

                entity.Property(e => e.KwhAbs)
                    .HasColumnName("KWH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhAbsEnd)
                    .HasColumnName("KWH_ABS_END")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhAbsStart)
                    .HasColumnName("KWH_ABS_START")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhExport)
                    .HasColumnName("KWH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出有功电量");

                entity.Property(e => e.KwhExportEnd)
                    .HasColumnName("KWH_EXPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出有功结束电量");

                entity.Property(e => e.KwhExportStart)
                    .HasColumnName("KWH_EXPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出有功开始电量");

                entity.Property(e => e.KwhImport)
                    .HasColumnName("KWH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入有功电量");

                entity.Property(e => e.KwhImportEnd)
                    .HasColumnName("KWH_IMPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入有功结束电量");

                entity.Property(e => e.KwhImportStart)
                    .HasColumnName("KWH_IMPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入有功开始电量");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime")
                    .HasComment("保存日期");
            });

            modelBuilder.Entity<DataMtKwhMonth>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.MeterId, e.TariffId })
                    .HasName("PK_DATA_MT_KWH_MONTH_1");

                entity.ToTable("DATA_MT_KWH_MONTH");

                entity.HasComment("表计电量月数据");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.MeterId)
                    .HasColumnName("METER_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计ID");

                entity.Property(e => e.TariffId)
                    .HasColumnName("TARIFF_ID")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率ID");

                entity.Property(e => e.Begintime)
                    .HasColumnName("BEGINTIME")
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.Endtime)
                    .HasColumnName("ENDTIME")
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.KvahExport)
                    .HasColumnName("KVAH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出视在电量");

                entity.Property(e => e.KvahExportEnd)
                    .HasColumnName("KVAH_EXPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出视在结束电量");

                entity.Property(e => e.KvahExportStart)
                    .HasColumnName("KVAH_EXPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出视在开始电量");

                entity.Property(e => e.KvahImport)
                    .HasColumnName("KVAH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入视在电量");

                entity.Property(e => e.KvahImportEnd)
                    .HasColumnName("KVAH_IMPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入视在结束电量");

                entity.Property(e => e.KvahImportStart)
                    .HasColumnName("KVAH_IMPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入视在开始电量");

                entity.Property(e => e.KvarhAbs)
                    .HasColumnName("KVARH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhAbsEnd)
                    .HasColumnName("KVARH_ABS_END")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhAbsStart)
                    .HasColumnName("KVARH_ABS_START")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KvarhExport)
                    .HasColumnName("KVARH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出无功电量");

                entity.Property(e => e.KvarhExportEnd)
                    .HasColumnName("KVARH_EXPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出无功结束电量");

                entity.Property(e => e.KvarhExportStart)
                    .HasColumnName("KVARH_EXPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出无功开始电量");

                entity.Property(e => e.KvarhImport)
                    .HasColumnName("KVARH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入无功电量");

                entity.Property(e => e.KvarhImportEnd)
                    .HasColumnName("KVARH_IMPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入无功结束电量");

                entity.Property(e => e.KvarhImportStart)
                    .HasColumnName("KVARH_IMPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入无功开始电量");

                entity.Property(e => e.KwhAbs)
                    .HasColumnName("KWH_ABS")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhAbsEnd)
                    .HasColumnName("KWH_ABS_END")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhAbsStart)
                    .HasColumnName("KWH_ABS_START")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.KwhExport)
                    .HasColumnName("KWH_EXPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出有功电量");

                entity.Property(e => e.KwhExportEnd)
                    .HasColumnName("KWH_EXPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出有功结束电量");

                entity.Property(e => e.KwhExportStart)
                    .HasColumnName("KWH_EXPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输出有功开始电量");

                entity.Property(e => e.KwhImport)
                    .HasColumnName("KWH_IMPORT")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入有功电量");

                entity.Property(e => e.KwhImportEnd)
                    .HasColumnName("KWH_IMPORT_END")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入有功结束电量");

                entity.Property(e => e.KwhImportStart)
                    .HasColumnName("KWH_IMPORT_START")
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("输入有功开始电量");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime")
                    .HasComment("保存时间");
            });

            modelBuilder.Entity<DataTmlOnline>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.MtTmlId, e.MtTmlType })
                    .HasName("PK_DATA_TML_ONLINE_1");

                entity.ToTable("DATA_TML_ONLINE");

                entity.HasComment("终端在线数据");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.MtTmlId)
                    .HasColumnName("MT_TML_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计终端ID");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("表计终端类型");

                entity.Property(e => e.OfflineTimes)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("下线时间");

                entity.Property(e => e.OnlineMinutes)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("在线分钟数");

                entity.Property(e => e.OnlineTimes)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("上线时间");
            });

            modelBuilder.Entity<LogCommTime>(entity =>
            {
                entity.HasKey(e => new { e.MtTmlId, e.MtTmlType })
                    .IsClustered(false);

                entity.ToTable("LOG_COMM_TIME");

                entity.HasComment("用于 存储公用时间日志数据");

                entity.Property(e => e.MtTmlId)
                    .HasColumnName("MT_TML_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计终端ID");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("表计终端类型");

                entity.Property(e => e.LatestTime)
                    .HasColumnName("LATEST_TIME")
                    .HasColumnType("datetime")
                    .HasComment("最新时间");
            });

            modelBuilder.Entity<LogDeleteMtTml>(entity =>
            {
                entity.HasKey(e => new { e.MtTmlId, e.MtTmlType })
                    .IsClustered(false);

                entity.ToTable("LOG_DELETE_MT_TML");

                entity.Property(e => e.MtTmlId)
                    .HasColumnName("MT_TML_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CommType).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msno)
                    .IsRequired()
                    .HasColumnName("MSNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogEmailSms>(entity =>
            {
                entity.ToTable("LOG_EMAIL_SMS");

                entity.HasComment("用于 存储发送邮件短信日志数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasComment("内容");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Readed)
                    .HasMaxLength(2000)
                    .HasComment("已读");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("主题");

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasColumnName("TO")
                    .HasMaxLength(2000)
                    .HasComment("接受者");

                entity.Property(e => e.Type)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("类型");
            });

            modelBuilder.Entity<LogLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_LOGIN");

                entity.HasComment("用于 存储登陆日志数据 ");

                entity.Property(e => e.Browse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("浏览器类型");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("IP地址");

                entity.Property(e => e.Os)
                    .HasColumnName("OS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作系统类型");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SessionID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("类型");

                entity.HasOne(d => d.CrtbyNavigation)
                    .WithMany(p => p.LogLogin)
                    .HasForeignKey(d => d.Crtby)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LOG_LOGIN_SYS_USER");
            });

            modelBuilder.Entity<LogManualTask>(entity =>
            {
                entity.HasKey(e => new { e.RtuId, e.RtuNo, e.DataitemId, e.NextStartTime, e.RelayToMeter, e.CollectPlanId });

                entity.ToTable("LOG_MANUAL_TASK");

                entity.HasComment("用于 存储任务日志数据");

                entity.Property(e => e.RtuId)
                    .HasColumnName("RTU_ID")
                    .HasColumnType("numeric(5, 0)")
                    .HasComment("RTU ID");

                entity.Property(e => e.RtuNo)
                    .HasColumnName("RTU_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("RTU 号");

                entity.Property(e => e.DataitemId)
                    .HasColumnName("DATAITEM_ID")
                    .HasColumnType("numeric(5, 0)")
                    .HasComment("数据项ID");

                entity.Property(e => e.NextStartTime)
                    .HasColumnName("NEXT_START_TIME")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("下一次启动时间");

                entity.Property(e => e.RelayToMeter)
                    .HasColumnName("RELAY_TO_METER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("关联表");

                entity.Property(e => e.CollectPlanId)
                    .HasColumnName("COLLECT_PLAN_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("采集计划ID");

                entity.Property(e => e.MaxCount)
                    .HasColumnName("MAX_COUNT")
                    .HasColumnType("numeric(11, 0)")
                    .HasComment("最大次数");

                entity.Property(e => e.MeterNo)
                    .IsRequired()
                    .HasColumnName("METER_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("表号");

                entity.Property(e => e.RetryCount)
                    .HasColumnName("RETRY_COUNT")
                    .HasColumnType("numeric(11, 0)")
                    .HasComment("重试次数");

                entity.Property(e => e.SavedbTime)
                    .HasColumnName("SAVEDB_TIME")
                    .HasColumnType("datetime")
                    .HasComment("保存时间");

                entity.Property(e => e.TaskInterval)
                    .HasColumnName("TASK_INTERVAL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("任务间隔");

                entity.Property(e => e.TaskStatus)
                    .HasColumnName("TASK_STATUS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("任务状态");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<LogMeterFriendlyTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_METER_FRIENDLY_TIME");

                entity.HasComment("用于 存储表计FRIENDLY_TIME日志数据");

                entity.Property(e => e.EndTime)
                    .HasColumnName("EndTIme")
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计ID");

                entity.Property(e => e.Result)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("结果");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.TmlId)
                    .HasColumnName("Tml_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("终端ID");

                entity.Property(e => e.TrfIndId)
                    .HasColumnName("TrfInd_ID")
                    .HasColumnType("numeric(6, 0)");
            });

            modelBuilder.Entity<LogMeterTou>(entity =>
            {
                entity.ToTable("LOG_METER_TOU");

                entity.HasComment("用于存储表计TOU日志数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BeginDate)
                    .HasColumnType("datetime")
                    .HasComment("起始时间");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计ID");

                entity.Property(e => e.Result)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("结果");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.TmlId)
                    .HasColumnName("Tml_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("终端ID");

                entity.Property(e => e.TrfIndId)
                    .HasColumnName("TrfInd_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费率ID");

                entity.Property(e => e.TrfTblId)
                    .HasColumnName("TrfTbl_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费率明细ID");
            });

            modelBuilder.Entity<LogMeterstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_METERSTATUS");

                entity.HasComment("用于 存储表计状态日志数据");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Kvarh)
                    .HasColumnName("KVARH")
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("无功电量");

                entity.Property(e => e.Kwh)
                    .HasColumnName("KWH")
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("有功电量");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计ID");

                entity.Property(e => e.OperatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作人");

                entity.Property(e => e.OperatedOn)
                    .HasColumnType("datetime")
                    .HasComment("操作时间");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");
            });

            modelBuilder.Entity<LogMsg>(entity =>
            {
                entity.ToTable("LOG_MSG");

                entity.HasComment("用于 存储消息日志数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Msg)
                    .HasColumnName("MSG")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("消息");

                entity.Property(e => e.SendTo)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("接收人ID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.HasOne(d => d.CrtbyNavigation)
                    .WithMany(p => p.LogMsg)
                    .HasForeignKey(d => d.Crtby)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LOG_MSG_SYS_USER");
            });

            modelBuilder.Entity<LogOperating>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_OPERATING");

                entity.HasComment("用于 存储操作日志数据");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Forms)
                    .IsUnicode(false)
                    .HasComment("数据来源");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("IP地址");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SessionID");

                entity.Property(e => e.Type)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("操作类型");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("URL");

                entity.HasOne(d => d.CrtbyNavigation)
                    .WithMany(p => p.LogOperating)
                    .HasForeignKey(d => d.Crtby)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LOG_OPERATING_SYS_USER");
            });

            modelBuilder.Entity<LogPassword>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_PASSWORD");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogPassword)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LOG_PASSWORD_SYS_USER");
            });

            modelBuilder.Entity<LogPocMeter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_POC_METER");

                entity.HasComment("用于 存储计量点与表计日志数据");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.NewMeterId)
                    .HasColumnName("New_Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("新表计ID");

                entity.Property(e => e.NewMeterKvarh)
                    .HasColumnName("New_Meter_KVARH")
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("新表计无功电量");

                entity.Property(e => e.NewMeterKwh)
                    .HasColumnName("New_Meter_KWH")
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("新表计有功电量");

                entity.Property(e => e.OldMeterId)
                    .HasColumnName("Old_Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("旧表计ID");

                entity.Property(e => e.OldMeterKvarh)
                    .HasColumnName("Old_Meter_KVARH")
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("旧表计无功电量");

                entity.Property(e => e.OldMeterKwh)
                    .HasColumnName("Old_Meter_KWH")
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("旧表计有功电量");

                entity.Property(e => e.OperatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作人");

                entity.Property(e => e.OperatedOn)
                    .HasColumnType("datetime")
                    .HasComment("操作时间");

                entity.Property(e => e.PocId)
                    .HasColumnName("POC_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("计量点ID");
            });

            modelBuilder.Entity<LogServiceSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_SERVICE_SESSION");

                entity.HasComment("用于 存储服务日志数据");

                entity.Property(e => e.CduId)
                    .HasColumnName("Cdu_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("Cdu_ID");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("IP");

                entity.Property(e => e.LatesAction)
                    .HasColumnType("datetime")
                    .HasComment("最新操作时间");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasComment("登录时间");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SessionId");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("用户ID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户名");
            });

            modelBuilder.Entity<LogTaskResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_TASK_RESULT");

                entity.HasIndex(e => e.ExecuteTime);

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExecuteTime)
                    .HasColumnName("EXECUTE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishTime)
                    .HasColumnName("FINISH_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MtTmlId)
                    .HasColumnName("MT_TML_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTmlType)
                    .HasColumnName("MT_TML_TYPE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Result)
                    .HasColumnName("RESULT")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasColumnName("TASK_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Times)
                    .HasColumnName("TIMES")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<LogTaskResultAnalysis>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("LOG_TASK_RESULT_ANALYSIS");

                entity.HasComment("用于 存储任务结果分析日志数据");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.AvgScd)
                    .HasColumnName("AVG_SCD")
                    .HasColumnType("numeric(10, 0)")
                    .HasComment("平均秒数");

                entity.Property(e => e.MaxScd)
                    .HasColumnName("MAX_SCD")
                    .HasColumnType("numeric(10, 0)")
                    .HasComment("最大秒数");

                entity.Property(e => e.MinScd)
                    .HasColumnName("MIN_SCD")
                    .HasColumnType("numeric(10, 0)")
                    .HasComment("最小秒数");

                entity.Property(e => e.TotalMeter)
                    .HasColumnName("TOTAL_METER")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("总表计数");

                entity.Property(e => e.TotalSuccess)
                    .HasColumnName("TOTAL_SUCCESS")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("总成功数");

                entity.Property(e => e.TotalTask)
                    .HasColumnName("TOTAL_TASK")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("总任务数");
            });

            modelBuilder.Entity<LogTmlTask>(entity =>
            {
                entity.HasKey(e => new { e.DataitemId, e.TmlId });

                entity.ToTable("LOG_TML_TASK");

                entity.HasComment("用于 存储终端任务日志数据");

                entity.Property(e => e.DataitemId)
                    .HasColumnName("DATAITEM_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("数据项ID");

                entity.Property(e => e.TmlId)
                    .HasColumnName("TML_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("终端ID");

                entity.Property(e => e.MeterNo)
                    .HasColumnName("METER_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("表计号");

                entity.Property(e => e.NextTaskPtNo)
                    .HasColumnName("NEXT_TASK_PT_NO")
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("下一次任务PT号");

                entity.Property(e => e.NextTaskTime)
                    .HasColumnName("NEXT_TASK_TIME")
                    .HasColumnType("datetime")
                    .HasComment("下一次任务时间");

                entity.Property(e => e.RtuNo)
                    .HasColumnName("RTU_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdManage>(entity =>
            {
                entity.ToTable("ORD_MANAGE");

                entity.HasComment("管理码订单");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("客户id");

                entity.Property(e => e.Ken)
                    .HasColumnName("KEN")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("密钥期满");

                entity.Property(e => e.KenNew)
                    .HasColumnName("KEN_NEW")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("新秘钥期满");

                entity.Property(e => e.Krn)
                    .HasColumnName("KRN")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("密钥版本");

                entity.Property(e => e.KrnNew)
                    .HasColumnName("KRN_NEW")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("新秘钥版本");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计id");

                entity.Property(e => e.PocId)
                    .HasColumnName("POC_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("计量点id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sgc)
                    .HasColumnName("SGC")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应组编码");

                entity.Property(e => e.SgcNew)
                    .HasColumnName("SGC_NEW")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("新供应组编码");

                entity.Property(e => e.Ti)
                    .HasColumnName("TI")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率索引号");

                entity.Property(e => e.TiNew)
                    .HasColumnName("TI_NEW")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("新费率索引号");

                entity.Property(e => e.Token1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("管理码1");

                entity.Property(e => e.Token2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("管理码2");

                entity.Property(e => e.TokenType)
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("管理码类型");

                entity.Property(e => e.TrnId)
                    .HasColumnName("TRN_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("交易ID");

                entity.Property(e => e.Val)
                    .HasColumnName("VAL")
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("值");
            });

            modelBuilder.Entity<OrdReissue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORD_REISSUE");

                entity.HasComment("订单补打");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.TrnId)
                    .HasColumnName("TRN_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("交易ID");
            });

            modelBuilder.Entity<OrdReversed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORD_REVERSED");

                entity.HasComment("撤单订单");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.OrderReversedReason)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("撤单原因");

                entity.Property(e => e.TrnId)
                    .HasColumnName("TRN_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("交易ID");
            });

            modelBuilder.Entity<OrdSpc>(entity =>
            {
                entity.ToTable("ORD_SPC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("客户id");

                entity.Property(e => e.Energy)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("电量");

                entity.Property(e => e.Ken)
                    .HasColumnName("KEN")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("密钥期满");

                entity.Property(e => e.Krn)
                    .HasColumnName("KRN")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("密钥版本");

                entity.Property(e => e.MchId)
                    .HasColumnName("MCH_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("销售商id");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计id");

                entity.Property(e => e.Money)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("支付费用");

                entity.Property(e => e.PayType)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("支付类型");

                entity.Property(e => e.PocId)
                    .HasColumnName("POC_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("计量点id");

                entity.Property(e => e.Sgc)
                    .HasColumnName("SGC")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应组编码");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.Property(e => e.Ti)
                    .HasColumnName("TI")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率索引号");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferMsno)
                    .HasColumnName("TransferMSNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdTrn>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ORD_TRN");

                entity.HasComment("订单总表");

                entity.HasIndex(e => e.Crton);

                entity.HasIndex(e => new { e.Crton, e.Crtby })
                    .HasName("IX_ORD_TRN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Change)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("找零");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("客户id");

                entity.Property(e => e.Energy)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("电量");

                entity.Property(e => e.EnergyMoney)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("电量金额");

                entity.Property(e => e.IsFree)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("费用列表");

                entity.Property(e => e.Ken)
                    .HasColumnName("KEN")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("密钥期满");

                entity.Property(e => e.Krn)
                    .HasColumnName("KRN")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("密钥版本");

                entity.Property(e => e.MchId)
                    .HasColumnName("MCH_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("销售商id");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.MeterId)
                    .HasColumnName("Meter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("表计id");

                entity.Property(e => e.Ordno)
                    .HasColumnName("ORDNO")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("订单号");

                entity.Property(e => e.PayAll)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("总费用");

                entity.Property(e => e.PayMoney)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("支付费用");

                entity.Property(e => e.PayType)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("支付类型");

                entity.Property(e => e.PocId)
                    .HasColumnName("POC_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("计量点id");

                entity.Property(e => e.Reqid)
                    .HasColumnName("REQID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("请求ID");

                entity.Property(e => e.Sgc)
                    .HasColumnName("SGC")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应组编码");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.Property(e => e.Ti)
                    .HasColumnName("TI")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率索引号");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDebt)
                    .HasColumnType("numeric(12, 4)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("总债务");

                entity.Property(e => e.TotalFee)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("总税费");

                entity.Property(e => e.TrfTblId)
                    .HasColumnName("TrfTbl_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费率id");
            });

            modelBuilder.Entity<OrdTrnDebt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORD_TRN_DEBT");

                entity.HasComment("债务详情");

                entity.Property(e => e.BalanceAfterRepay)
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("支付后余额");

                entity.Property(e => e.BalanceBeforeRepay)
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("支付前余额");

                entity.Property(e => e.DebtId)
                    .HasColumnName("Debt_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("债务编号");

                entity.Property(e => e.RepayAmount)
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("支付金额");

                entity.Property(e => e.TrnId)
                    .HasColumnName("TRN_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("订单ID");
            });

            modelBuilder.Entity<OrdTrnDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORD_TRN_DETAIL");

                entity.HasComment("订单收费明细");

                entity.Property(e => e.FeeTblId)
                    .HasColumnName("FeeTbl_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费用ID");

                entity.Property(e => e.FeeType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费用类型");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.TrnId)
                    .HasColumnName("TRN_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("订单ID");

                entity.Property(e => e.UnitValue)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("电量值");

                entity.Property(e => e.Value)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("值");

                entity.HasOne(d => d.Trn)
                    .WithMany(p => p.OrdTrnDetail)
                    .HasForeignKey(d => d.TrnId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ORD_TRN_DETAIL_ORD_TRN");
            });

            modelBuilder.Entity<OrdTrnOrdno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORD_TRN_ORDNO");

                entity.HasComment("订单号请求");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.MchId)
                    .HasColumnName("MCH_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("销售商id");

                entity.Property(e => e.Ordno)
                    .HasColumnName("ORDNO")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("订单ID");
            });

            modelBuilder.Entity<OrdTrnStep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORD_TRN_STEP");

                entity.HasComment("订单阶梯费率明细");

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("消耗值");

                entity.Property(e => e.KWh)
                    .HasColumnName("kWh")
                    .HasColumnType("numeric(12, 1)")
                    .HasComment("电量");

                entity.Property(e => e.Step)
                    .HasColumnType("numeric(8, 0)")
                    .HasComment("阶梯");

                entity.Property(e => e.TrfTblId)
                    .HasColumnName("TrfTbl_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费用id");

                entity.Property(e => e.TrnId)
                    .HasColumnName("TRN_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("订单ID");

                entity.Property(e => e.Value)
                    .HasColumnType("numeric(8, 4)")
                    .HasComment("值");

                entity.HasOne(d => d.Trn)
                    .WithMany(p => p.OrdTrnStep)
                    .HasForeignKey(d => d.TrnId)
                    .HasConstraintName("FK_ORD_TRN_STEP_ORD_TRN");
            });

            modelBuilder.Entity<PrmCfg>(entity =>
            {
                entity.ToTable("PRM_CFG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<PrmCfgDtl>(entity =>
            {
                entity.ToTable("PRM_CFG_DTL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CfgId)
                    .HasColumnName("CFG_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Scheme)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Type)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment(@"基本设置；
通讯参数；
阀值设置；
事件告警使能；
液晶显示；
负荷控制；
拉合闸方案；
");
            });

            modelBuilder.Entity<PrmCollect>(entity =>
            {
                entity.ToTable("PRM_COLLECT");

                entity.HasComment("用于存储采集方案");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CommProtocol)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("通讯协议");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("varchar(50)");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态  SYS_BASE.DataStutas 0：有效 1：锁定");
            });

            modelBuilder.Entity<PrmCollectObis>(entity =>
            {
                entity.HasKey(e => e.Obis);

                entity.ToTable("PRM_COLLECT_OBIS");

                entity.HasComment("采集DLMS OBIS");

                entity.Property(e => e.Obis)
                    .HasColumnName("OBIS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("OBIS");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("类ID");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("类名称");

                entity.Property(e => e.CollectPlanStatus)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("采集计划状态");

                entity.Property(e => e.GroupNo)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("分组号");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Phase)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("相限");

                entity.Property(e => e.ReadRemotelyStatus)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("远程点抄状态");

                entity.Property(e => e.SettingRemotelyStatus).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SortNo)
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("排序号");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("单位");

                entity.Property(e => e.Vld)
                    .HasColumnName("VLD")
                    .HasMaxLength(500);

                entity.Property(e => e.XmlRoot).HasMaxLength(50);
            });

            modelBuilder.Entity<PrmCollectPlan>(entity =>
            {
                entity.ToTable("PRM_COLLECT_PLAN");

                entity.HasComment("用于存储采集方案计划数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CollectId)
                    .HasColumnName("Collect_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("采集方案ID");

                entity.Property(e => e.CollectInterval)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("采集间隔");

                entity.Property(e => e.CollectUnit)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("采集数");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MetergingUnit)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("响应间隔");

                entity.Property(e => e.MeteringInterval)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("响应间隔");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Offset)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("偏移");

                entity.Property(e => e.OffsetUnit)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("偏移数");

                entity.Property(e => e.RetryTimes)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("再次采集次数");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("类型");

                entity.HasOne(d => d.Collect)
                    .WithMany(p => p.PrmCollectPlan)
                    .HasForeignKey(d => d.CollectId)
                    .HasConstraintName("FK_PRM_COLLECT_PLAN_PRM_COLLECT");
            });

            modelBuilder.Entity<PrmCollectPlanObis>(entity =>
            {
                entity.HasKey(e => new { e.CollectPlanId, e.Obis });

                entity.ToTable("PRM_COLLECT_PLAN_OBIS");

                entity.HasComment("用于存储采集计划OBIS数据");

                entity.Property(e => e.CollectPlanId)
                    .HasColumnName("Collect_Plan_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("采集计划ID");

                entity.Property(e => e.Obis)
                    .HasColumnName("OBIS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("OBIS");

                entity.Property(e => e.OrderNo)
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("排序号");

                entity.HasOne(d => d.CollectPlan)
                    .WithMany(p => p.PrmCollectPlanObis)
                    .HasForeignKey(d => d.CollectPlanId)
                    .HasConstraintName("FK_PRM_COLLECT_PLAN_OBIS_PRM_COLLECT_PLAN");
            });

            modelBuilder.Entity<PrmDeviceDeleted>(entity =>
            {
                entity.ToTable("PRM_DEVICE_DELETED");

                entity.HasComment("用于存储设备服务参数数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.Port)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("端口");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("服务");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");
            });

            modelBuilder.Entity<PrmEvtClass1>(entity =>
            {
                entity.HasKey(e => new { e.TmlProtocolId, e.Class1Id });

                entity.ToTable("PRM_EVT_CLASS1");

                entity.HasComment("用于存储事件类1基础数据");

                entity.Property(e => e.TmlProtocolId)
                    .HasColumnName("TML_PROTOCOL_ID")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("终端通讯协议");

                entity.Property(e => e.Class1Id)
                    .HasColumnName("CLASS1_ID")
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("类1ID");

                entity.Property(e => e.Class1Desc)
                    .HasColumnName("CLASS1_DESC")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");
            });

            modelBuilder.Entity<PrmEvtClass2>(entity =>
            {
                entity.HasKey(e => new { e.Class2Id, e.Class1Id, e.TmlProtocolId });

                entity.ToTable("PRM_EVT_CLASS2");

                entity.HasComment("用于存储事件类2基础数据");

                entity.Property(e => e.Class2Id)
                    .HasColumnName("CLASS2_ID")
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("类2ID");

                entity.Property(e => e.Class1Id)
                    .HasColumnName("CLASS1_ID")
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("类1ID");

                entity.Property(e => e.TmlProtocolId)
                    .HasColumnName("TML_PROTOCOL_ID")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("终端通讯协议");

                entity.Property(e => e.Class2Desc)
                    .HasColumnName("CLASS2_DESC")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");
            });

            modelBuilder.Entity<PrmEvtDef>(entity =>
            {
                entity.HasKey(e => new { e.TmlProtocolId, e.EvtId, e.Class2Id, e.Class1Id });

                entity.ToTable("PRM_EVT_DEF");

                entity.HasComment("用于存储事件基础数据");

                entity.Property(e => e.TmlProtocolId)
                    .HasColumnName("TML_PROTOCOL_ID")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("终端通讯协议");

                entity.Property(e => e.EvtId)
                    .HasColumnName("EVT_ID")
                    .HasColumnType("numeric(5, 0)")
                    .HasComment("事件ID");

                entity.Property(e => e.Class2Id)
                    .HasColumnName("CLASS2_ID")
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("类2ID");

                entity.Property(e => e.Class1Id)
                    .HasColumnName("CLASS1_ID")
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("类1ID");

                entity.Property(e => e.EvtDesc)
                    .HasColumnName("EVT_DESC")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.IfUrgentNotice)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("是否紧急通知");
            });

            modelBuilder.Entity<PrmFeeind>(entity =>
            {
                entity.ToTable("PRM_FEEIND");

                entity.HasComment("用于存储费用基础数据，为售电时提供费用统计用。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态 SYS_BASE.DataStutas   0：有效 1：锁定");
            });

            modelBuilder.Entity<PrmFeeindGhana>(entity =>
            {
                entity.ToTable("PRM_FEEIND_GHANA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Type).HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<PrmFeetbl>(entity =>
            {
                entity.ToTable("PRM_FEETBL");

                entity.HasComment("用于存储费用项数据 ");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.FeeIndId)
                    .HasColumnName("FeeInd_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费用ID");

                entity.Property(e => e.FeeType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费用类型  SYS_BASE.FeeType 1：Fixed charge with transaction amount ratio (VAT %)  2：Fixed charge with per transaction  3：Fixed charge with month  4：Fixed charge with days from last purchase");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("费用项名称");

                entity.Property(e => e.Value)
                    .HasColumnType("numeric(8, 4)")
                    .HasComment("费用项值");

                entity.HasOne(d => d.FeeInd)
                    .WithMany(p => p.PrmFeetbl)
                    .HasForeignKey(d => d.FeeIndId)
                    .HasConstraintName("FK_PRM_FEETBL_PRM_FEEIND");
            });

            modelBuilder.Entity<PrmFeetblGhana>(entity =>
            {
                entity.ToTable("PRM_FEETBL_GHANA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeeIndId)
                    .HasColumnName("FeeInd_ID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.GovLevy).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.KWh)
                    .HasColumnName("kWh")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nhil)
                    .HasColumnName("NHIL")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Price).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Relief).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.ServiceCharge).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.StreetLight).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Subside1).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Subside2).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("numeric(12, 4)");
            });

            modelBuilder.Entity<PrmMetertype>(entity =>
            {
                entity.ToTable("PRM_METERTYPE");

                entity.HasComment("表计勒类型基础数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ADecimalDigits)
                    .HasColumnName("A_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("电流精度");

                entity.Property(e => e.Accuracy)
                    .HasColumnType("numeric(3, 1)")
                    .HasComment("精度");

                entity.Property(e => e.AngleDecimalDigits)
                    .HasColumnName("ANGLE_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("相位角精度");

                entity.Property(e => e.CommProtocol)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("通讯协议 SYS_BASE.CommProtocol1：IEC 62056-21 2：DL/T645_2007 3：DL/T645_1997");

                entity.Property(e => e.CommType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("通讯方式");

                entity.Property(e => e.ConnectType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("接线方式  SYS_BASE. ConnectType 1P1W：1P1W 3P3W：3P3W 3P4W：3P4W");

                entity.Property(e => e.CreditDecimalDigits)
                    .HasColumnName("CREDIT_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("余额精度");

                entity.Property(e => e.CreditType)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("充值类型  0:kWh  4:Money");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CurrentGrade)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("电流等级 SYS_BASE. CurrentGrade");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.HzDecimalDigits)
                    .HasColumnName("HZ_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("频率");

                entity.Property(e => e.IsCascade).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.KvaDecimalDigits)
                    .HasColumnName("KVA_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("视在功率精度");

                entity.Property(e => e.KvahDecimalDigits)
                    .HasColumnName("KVAH_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("视在电量精度");

                entity.Property(e => e.KvarDecimalDigits)
                    .HasColumnName("KVAR_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("无功功率精度");

                entity.Property(e => e.KvarhDecimalDigits)
                    .HasColumnName("KVARH_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("无功电量精度");

                entity.Property(e => e.KwDecimalDigits)
                    .HasColumnName("KW_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("有功功率精度");

                entity.Property(e => e.KwhDecimalDigits)
                    .HasColumnName("KWH_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("有功电量精度");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.PfDecimalDigits)
                    .HasColumnName("PF_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("功率因数精度");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应商ID");

                entity.Property(e => e.VDecimalDigits)
                    .HasColumnName("V_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("电压精度");

                entity.Property(e => e.VarDecimalDigits)
                    .HasColumnName("VAR_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VersionHardware)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionSoftware)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoltageGrade)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("电压等级 SYS_BASE.VoltageGrade");

                entity.Property(e => e.WDecimalDigits)
                    .HasColumnName("W_DECIMAL_DIGITS")
                    .HasColumnType("numeric(1, 0)");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PrmMetertype)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PRM_METERTYPE_PRM_SUPPLIER");
            });

            modelBuilder.Entity<PrmPowergridtype>(entity =>
            {
                entity.ToTable("PRM_POWERGRIDTYPE");

                entity.HasComment("用于存储电网结构类型基础数据，为电网结构提供数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("ID");

                entity.Property(e => e.Ico)
                    .HasMaxLength(50)
                    .HasComment("图标");

                entity.Property(e => e.IsEnd)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("是否最后节点");

                entity.Property(e => e.IsGps)
                    .HasColumnName("IsGPS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("是否开启定位");

                entity.Property(e => e.IsVoltage)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("是否有电压等级");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.SubId)
                    .HasColumnName("SubID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("子ID 如：2，3，4");
            });

            modelBuilder.Entity<PrmSg>(entity =>
            {
                entity.ToTable("PRM_SG");

                entity.HasComment("用于 存储供应组基础数据，为供应组密钥提供数据来源。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Sgc)
                    .HasColumnName("SGC")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("编码");
            });

            modelBuilder.Entity<PrmSgkey>(entity =>
            {
                entity.ToTable("PRM_SGKEY");

                entity.HasComment("用于存储供应组密钥基础数据，售电时使用");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Baseline)
                    .HasColumnType("datetime")
                    .HasComment("基础时间 目前未使用");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.Ken)
                    .HasColumnName("KEN")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("密钥期满 根据STS协议生成");

                entity.Property(e => e.Krn)
                    .HasColumnName("KRN")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("密钥版本号");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.SgId)
                    .HasColumnName("SG_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应组ID");

                entity.HasOne(d => d.Sg)
                    .WithMany(p => p.PrmSgkey)
                    .HasForeignKey(d => d.SgId)
                    .HasConstraintName("FK_PRM_SGKEY_PRM_SG");
            });

            modelBuilder.Entity<PrmSupplier>(entity =>
            {
                entity.ToTable("PRM_SUPPLIER");

                entity.HasComment("供应商基础数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("公司地址");

                entity.Property(e => e.BizContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("商务联系人");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("电子地址");

                entity.Property(e => e.Http)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("网站地址");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("电话");
            });

            modelBuilder.Entity<PrmTmltype>(entity =>
            {
                entity.ToTable("PRM_TMLTYPE");

                entity.HasComment("用于存储终端类型基础数据，为档案终端提供终端类型。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CommProtocol)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("通讯协议  SYS_BASE.CommProtocol 1：IEC 62056-21 2：DL/T645_2007 3：DL/T645_1997");

                entity.Property(e => e.CommType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("通讯方式");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("numeric(6, 0)");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.MeterCommType)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("表通讯方式");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("供应商ID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PrmTmltype)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PRM_TMLTYPE_PRM_SUPPLIER");
            });

            modelBuilder.Entity<PrmTrfind>(entity =>
            {
                entity.ToTable("PRM_TRFIND");

                entity.HasComment("用于存储费率基础数据，为售电时提供费率统计用。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.FeeIndId)
                    .HasColumnName("FeeInd_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费用ID");

                entity.Property(e => e.FriendlyTime)
                    .IsUnicode(false)
                    .HasComment("友好时间  XML格式");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态  SYS_BASE.DataStutas 0：有效 1：锁定");

                entity.Property(e => e.Ti)
                    .HasColumnName("TI")
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("费率索引号");

                entity.Property(e => e.Type)
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("费率类型  0	Single&Blcok(energy meter)  1	Block(currency meter) 2	Tou(currency meter)");

                entity.HasOne(d => d.FeeInd)
                    .WithMany(p => p.PrmTrfind)
                    .HasForeignKey(d => d.FeeIndId)
                    .HasConstraintName("FK_PRM_TRFIND_PRM_FEEIND");
            });

            modelBuilder.Entity<PrmTrftbl>(entity =>
            {
                entity.ToTable("PRM_TRFTBL");

                entity.HasComment("用于存储费率项基础数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BeginDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Scheme)
                    .IsUnicode(false)
                    .HasComment("阶梯方案");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态 SYS_BASE.DataStutas 0：有效 1：锁定");

                entity.Property(e => e.TrfIndId)
                    .HasColumnName("TrfInd_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("费率ID");

                entity.HasOne(d => d.TrfInd)
                    .WithMany(p => p.PrmTrftbl)
                    .HasForeignKey(d => d.TrfIndId)
                    .HasConstraintName("FK_PRM_TRFTBL_PRM_TRFIND");
            });

            modelBuilder.Entity<ScrcardBatch>(entity =>
            {
                entity.ToTable("SCRCARD_BATCH");

                entity.HasComment("用于存储刮刮卡批次基础数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("面值金额");

                entity.Property(e => e.CardQuantity).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人ID");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .HasComment("描述");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasComment("发行时间");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人ID");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.PrivateKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("私钥");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("SN");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");
            });

            modelBuilder.Entity<ScrcardCard>(entity =>
            {
                entity.ToTable("SCRCARD_CARD");

                entity.HasComment("用于存储刮刮卡数据");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActiveByPhone)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("激活电话");

                entity.Property(e => e.ActiveOn)
                    .HasColumnType("datetime")
                    .HasComment("激活时间");

                entity.Property(e => e.ActivePassword)
                    .HasColumnType("numeric(16, 0)")
                    .HasComment("激活码");

                entity.Property(e => e.BatchId)
                    .HasColumnName("BATCH_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("批次ID");

                entity.Property(e => e.CardNo)
                    .HasColumnType("numeric(10, 0)")
                    .HasComment("卡号");

                entity.Property(e => e.Ordno)
                    .HasColumnName("ORDNO")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("订单号");

                entity.Property(e => e.RandNo)
                    .HasColumnType("numeric(12, 0)")
                    .HasComment("随机号");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.ScrcardCard)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("FK_SCRCARD_CARD_SCRCARD_BATCH");
            });

            modelBuilder.Entity<SmsserverCalls>(entity =>
            {
                entity.ToTable("SMSSERVER_CALLS");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.CallDate)
                    .HasColumnName("call_date")
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.CallerId)
                    .IsRequired()
                    .HasColumnName("caller_id")
                    .HasMaxLength(64)
                    .HasComment("CALLER ID");

                entity.Property(e => e.GatewayId)
                    .IsRequired()
                    .HasColumnName("gateway_id")
                    .HasMaxLength(64)
                    .HasComment("网关ID");
            });

            modelBuilder.Entity<SmsserverIn>(entity =>
            {
                entity.ToTable("SMSSERVER_IN");

                entity.HasComment("用于存储接收短信数据");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.Encoding)
                    .IsRequired()
                    .HasColumnName("encoding")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("编码");

                entity.Property(e => e.GatewayId)
                    .IsRequired()
                    .HasColumnName("gateway_id")
                    .HasMaxLength(64)
                    .HasComment("网关ID");

                entity.Property(e => e.MessageDate)
                    .HasColumnName("message_date")
                    .HasColumnType("datetime")
                    .HasComment("消息时间");

                entity.Property(e => e.OriginalReceiveDate)
                    .HasColumnName("original_receive_date")
                    .HasColumnType("datetime")
                    .HasComment("原件接收时间");

                entity.Property(e => e.OriginalRefNo)
                    .HasColumnName("original_ref_no")
                    .HasMaxLength(64)
                    .HasComment("原件号");

                entity.Property(e => e.Originator)
                    .HasColumnName("originator")
                    .HasMaxLength(30)
                    .HasComment("发送人");

                entity.Property(e => e.Process)
                    .HasColumnName("process")
                    .HasComment("处理状态");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime")
                    .HasComment("接收时间");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(1000)
                    .HasComment("内容");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("类型");
            });

            modelBuilder.Entity<SmsserverOut>(entity =>
            {
                entity.ToTable("SMSSERVER_OUT");

                entity.HasComment("用于存储发送短信数据");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.DstPort)
                    .HasColumnName("dst_port")
                    .HasDefaultValueSql("((-1))")
                    .HasComment("目标端口");

                entity.Property(e => e.Encoding)
                    .IsRequired()
                    .HasColumnName("encoding")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('8')")
                    .HasComment("编码");

                entity.Property(e => e.Errors)
                    .HasColumnName("errors")
                    .HasComment("错误");

                entity.Property(e => e.FlashSms).HasColumnName("flash_sms");

                entity.Property(e => e.GatewayId)
                    .IsRequired()
                    .HasColumnName("gateway_id")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('*')")
                    .HasComment("网关");

                entity.Property(e => e.Originator)
                    .IsRequired()
                    .HasColumnName("originator")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .HasComment("发起人");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasComment("优先级");

                entity.Property(e => e.Recipient)
                    .IsRequired()
                    .HasColumnName("recipient")
                    .HasMaxLength(30)
                    .HasComment("收件人");

                entity.Property(e => e.RefNo)
                    .HasColumnName("ref_no")
                    .HasMaxLength(64);

                entity.Property(e => e.SentDate)
                    .HasColumnName("sent_date")
                    .HasColumnType("datetime")
                    .HasComment("发送时间");

                entity.Property(e => e.SrcPort)
                    .HasColumnName("src_port")
                    .HasDefaultValueSql("((-1))")
                    .HasComment("源端口");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('U')")
                    .HasComment("状态");

                entity.Property(e => e.StatusReport)
                    .HasColumnName("status_report")
                    .HasComment("Report状态");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(1000)
                    .HasComment("内容");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('O')")
                    .HasComment("类型");

                entity.Property(e => e.WapExpiryDate)
                    .HasColumnName("wap_expiry_date")
                    .HasColumnType("datetime")
                    .HasComment("包有效期限");

                entity.Property(e => e.WapSignal)
                    .HasColumnName("wap_signal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("包信号");

                entity.Property(e => e.WapUrl)
                    .HasColumnName("wap_url")
                    .HasMaxLength(100)
                    .HasComment("包URL");
            });

            modelBuilder.Entity<SysBase>(entity =>
            {
                entity.HasKey(e => new { e.Tag, e.Key });

                entity.ToTable("SYS_BASE");

                entity.HasComment("用于 存储系统基础数据");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类名");

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("键值");

                entity.Property(e => e.AllowMdf)
                    .HasColumnName("AllowMDF")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("允许修改");

                entity.Property(e => e.IsShow)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("是否显示");

                entity.Property(e => e.OrderNo)
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("排序号");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("值");

                entity.Property(e => e.Vld)
                    .HasColumnName("VLD")
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("验证表单");
            });

            modelBuilder.Entity<SysChangelog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_CHANGELOG");

                entity.HasComment("用于存储系统修改与升级的日志");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("版本");
            });

            modelBuilder.Entity<SysHelp>(entity =>
            {
                entity.ToTable("SYS_HELP");

                entity.HasComment("用于存储系统使用帮助文档");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("标题");
            });

            modelBuilder.Entity<SysNotice>(entity =>
            {
                entity.ToTable("SYS_NOTICE");

                entity.HasComment("用于存储系统通知信息");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasComment("过期日期");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasComment("描述");

                entity.Property(e => e.Hits)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("点击次数");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.NoticeAll)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("是否通知所有操作员");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("标题");
            });

            modelBuilder.Entity<SysNoticeUser>(entity =>
            {
                entity.HasKey(e => new { e.NoticeId, e.UserId });

                entity.ToTable("SYS_NOTICE_USER");

                entity.HasComment("用于存储系统通知接受人员列表");

                entity.Property(e => e.NoticeId)
                    .HasColumnName("Notice_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("通知ID");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("用户ID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.HasOne(d => d.Notice)
                    .WithMany(p => p.SysNoticeUser)
                    .HasForeignKey(d => d.NoticeId)
                    .HasConstraintName("FK_SYS_NOTICE_USER_SYS_NOTICE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysNoticeUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SYS_NOTICE_USER_SYS_USER");
            });

            modelBuilder.Entity<SysPage>(entity =>
            {
                entity.ToTable("SYS_PAGE");

                entity.HasComment("用于存储系统基本功能列表");

                entity.HasIndex(e => e.Url)
                    .HasName("IX_SYS_PAGE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID");

                entity.Property(e => e.Ico)
                    .HasColumnName("ICO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("ICON图标");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.OrderNo)
                    .HasColumnType("numeric(2, 0)")
                    .HasComment("排序号");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("父ID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("URL");
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.ToTable("SYS_ROLE");

                entity.HasComment("用于存储系统角色列表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .HasComment("描述");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");
            });

            modelBuilder.Entity<SysRolePage>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.PageId });

                entity.ToTable("SYS_ROLE_PAGE");

                entity.HasComment("用于存储系统基本功能与角色的关联关系");

                entity.Property(e => e.RoleId)
                    .HasColumnName("Role_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("角色ID");

                entity.Property(e => e.PageId)
                    .HasColumnName("Page_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("功能ID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.SysRolePage)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_SYS_ROLE_PAGE_SYS_PAGE");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysRolePage)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SYS_ROLE_PAGE_SYS_ROLE");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.ToTable("SYS_USER");

                entity.HasComment("用于存储系统账号列表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasComment("地址");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasComment("过期时间");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("邮箱");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasComment("名");

                entity.Property(e => e.Gender)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("性别");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasComment("姓");

                entity.Property(e => e.LatestLogin)
                    .HasColumnType("datetime")
                    .HasComment("最后登录时间");

                entity.Property(e => e.LatestMdfpwd)
                    .HasColumnName("LatestMDFPWD")
                    .HasColumnType("datetime")
                    .HasComment("密码期限");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasComment("手机号码");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("密码");

                entity.Property(e => e.RoleId)
                    .HasColumnName("Role_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("角色ID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .HasComment("电话");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("用户名");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysUser)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SYS_USER_SYS_ROLE");
            });

            modelBuilder.Entity<SysUserSubscribe>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("SYS_USER_SUBSCRIBE");

                entity.HasComment("系统用户订阅表");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("用户ID");

                entity.Property(e => e.Event)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("事件");

                entity.Property(e => e.Login)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("登录");

                entity.Property(e => e.MerchantCredit).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OrderReversal)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("订阅撤销");

                entity.Property(e => e.ViaEmail)
                    .HasColumnName("ViaEMail")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("邮箱订阅");

                entity.Property(e => e.ViaSms)
                    .HasColumnName("ViaSMS")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("短信订阅");

                entity.Property(e => e.ViaSystem)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("系统订阅");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.SysUserSubscribe)
                    .HasForeignKey<SysUserSubscribe>(d => d.UserId)
                    .HasConstraintName("FK_SYS_USER_SUBSCRIBE_SYS_USER");
            });

            modelBuilder.Entity<SysUsergroup>(entity =>
            {
                entity.ToTable("SYS_USERGROUP");

                entity.HasComment("用于存储系统用户组列表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .HasComment("描述");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");
            });

            modelBuilder.Entity<SysUsergroupObj>(entity =>
            {
                entity.HasKey(e => new { e.UserGroupId, e.ObjId });

                entity.ToTable("SYS_USERGROUP_OBJ");

                entity.HasComment("用于存储系统用户组与对象的关联关系");

                entity.Property(e => e.UserGroupId)
                    .HasColumnName("UserGroup_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("用户组ID");

                entity.Property(e => e.ObjId)
                    .HasColumnName("Obj_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("对象ID");

                entity.HasOne(d => d.Obj)
                    .WithMany(p => p.SysUsergroupObj)
                    .HasForeignKey(d => d.ObjId)
                    .HasConstraintName("FK_SYS_USERGROUP_OBJ_ACHV_POWERGRID");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.SysUsergroupObj)
                    .HasForeignKey(d => d.UserGroupId)
                    .HasConstraintName("FK_SYS_USERGROUP_OBJ_SYS_USERGROUP");
            });

            modelBuilder.Entity<SysUsergroupUser>(entity =>
            {
                entity.HasKey(e => new { e.UserGroupId, e.UserId });

                entity.ToTable("SYS_USERGROUP_USER");

                entity.HasComment("用于存储系统用户组与用户的关联关系");

                entity.Property(e => e.UserGroupId)
                    .HasColumnName("UserGroup_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("用户组ID");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("用户ID");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.SysUsergroupUser)
                    .HasForeignKey(d => d.UserGroupId)
                    .HasConstraintName("FK_SYS_USERGROUP_USER_SYS_USERGROUP");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysUsergroupUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SYS_USERGROUP_USER_SYS_USER");
            });

            modelBuilder.Entity<VndClientkey>(entity =>
            {
                entity.ToTable("VND_CLIENTKEY");

                entity.HasComment("用于 存储客户端秘钥数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClientKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("客户端密钥");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTON")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.LimitCduId)
                    .HasColumnName("Limit_CDU_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("限制CDU_ID");

                entity.Property(e => e.LimitType)
                    .HasColumnName("Limit_Type")
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("限制类型");

                entity.Property(e => e.LimitUserId)
                    .HasColumnName("Limit_USER_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("限制用户ID");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("供应商ID");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFON")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.RegBy)
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("注册人");

                entity.Property(e => e.RegOn)
                    .HasColumnName("RegON")
                    .HasColumnType("datetime")
                    .HasComment("注册日期");
            });

            modelBuilder.Entity<VndMch>(entity =>
            {
                entity.ToTable("VND_MCH");

                entity.HasComment("用于 存储销售商基础数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("地址");

                entity.Property(e => e.CommissionType)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("佣金类型");

                entity.Property(e => e.CommissionValue)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("佣金值");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("联系人");

                entity.Property(e => e.CreditAmount)
                    .HasColumnType("numeric(12, 4)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("当前余额");

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("最低余额");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.Descr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("邮箱");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("有效结束时间");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("销售商名称");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SN");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("有效开始时间");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("电话");

                entity.Property(e => e.TotalCharge)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("充值总额");

                entity.Property(e => e.TotalSale)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("销售总额");

                entity.Property(e => e.VendMaxPerTime)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("一次最大限额");

                entity.Property(e => e.VendMinPerTime)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("一次最小限额");
            });

            modelBuilder.Entity<VndMchCredit>(entity =>
            {
                entity.ToTable("VND_MCH_CREDIT");

                entity.HasComment("用于 存储销售商充值数据。");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(12, 4)")
                    .HasComment("充值金额");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.MchId)
                    .HasColumnName("MCH_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("销售商ID");

                entity.Property(e => e.Mdfby)
                    .HasColumnName("MDFBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("修改人");

                entity.Property(e => e.Mdfon)
                    .HasColumnName("MDFOn")
                    .HasColumnType("datetime")
                    .HasComment("修改日期");

                entity.Property(e => e.PayMethod)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("支付方式");

                entity.Property(e => e.RefNo)
                    .HasColumnName("RefNO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票号/转账号");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(1, 0)")
                    .HasComment("状态");

                entity.HasOne(d => d.Mch)
                    .WithMany(p => p.VndMchCredit)
                    .HasForeignKey(d => d.MchId)
                    .HasConstraintName("FK_VND_MCHCREDIT_VND_MCH");
            });

            modelBuilder.Entity<VndMchUser>(entity =>
            {
                entity.HasKey(e => new { e.MchId, e.UserId });

                entity.ToTable("VND_MCH_USER");

                entity.HasComment("用于 存储销售商用户关系数据。");

                entity.Property(e => e.MchId)
                    .HasColumnName("MCH_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("销售商ID");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("用户ID");

                entity.Property(e => e.Crtby)
                    .HasColumnName("CRTBy")
                    .HasColumnType("numeric(6, 0)")
                    .HasComment("创建人");

                entity.Property(e => e.Crton)
                    .HasColumnName("CRTOn")
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.HasOne(d => d.Mch)
                    .WithMany(p => p.VndMchUser)
                    .HasForeignKey(d => d.MchId)
                    .HasConstraintName("FK_VND_MCH_USER_VND_MCH");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VndMchUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_VND_MCH_USER_SYS_USER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
