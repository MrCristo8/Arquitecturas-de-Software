/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     09/06/2019 16:21:19                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TEDEF_DETFAC') and o.name = 'FK_TEDEF_DE_TR_TEFAC__TEFAC_FA')
alter table TEDEF_DETFAC
   drop constraint FK_TEDEF_DE_TR_TEFAC__TEFAC_FA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TEDEF_DETFAC') and o.name = 'FK_TEDEF_DE_TR_TELCP__TELCP_LO')
alter table TEDEF_DETFAC
   drop constraint FK_TEDEF_DE_TR_TELCP__TELCP_LO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TEFAC_FACTUR') and o.name = 'FK_TEFAC_FA_TR_TECLI__TECLI_CL')
alter table TEFAC_FACTUR
   drop constraint FK_TEFAC_FA_TR_TECLI__TECLI_CL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TELCP_LOCPTD') and o.name = 'FK_TELCP_LO_TR_TEPAF__TEPAF_PA')
alter table TELCP_LOCPTD
   drop constraint FK_TELCP_LO_TR_TEPAF__TEPAF_PA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TECLI_CLIENT')
            and   type = 'U')
   drop table TECLI_CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TEDEF_DETFAC')
            and   name  = 'TR_TEFAC_TEDEF_FK'
            and   indid > 0
            and   indid < 255)
   drop index TEDEF_DETFAC.TR_TEFAC_TEDEF_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TEDEF_DETFAC')
            and   name  = 'TR_TELCP_TEDEF_FK'
            and   indid > 0
            and   indid < 255)
   drop index TEDEF_DETFAC.TR_TELCP_TEDEF_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TEDEF_DETFAC')
            and   type = 'U')
   drop table TEDEF_DETFAC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TEFAC_FACTUR')
            and   name  = 'TR_TECLI_TEFAC_FK'
            and   indid > 0
            and   indid < 255)
   drop index TEFAC_FACTUR.TR_TECLI_TEFAC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TEFAC_FACTUR')
            and   type = 'U')
   drop table TEFAC_FACTUR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TELCP_LOCPTD')
            and   name  = 'TR_TEPAF_TELCP_FK'
            and   indid > 0
            and   indid < 255)
   drop index TELCP_LOCPTD.TR_TEPAF_TELCP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TELCP_LOCPTD')
            and   type = 'U')
   drop table TELCP_LOCPTD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TEPAF_PARFUT')
            and   type = 'U')
   drop table TEPAF_PARFUT
go

/*==============================================================*/
/* Table: TECLI_CLIENT                                          */
/*==============================================================*/
create table TECLI_CLIENT (
   TECLI_CODIGO         varchar(6)           not null,
   TECLI_NOMBRE         varchar(50)          not null,
   constraint PK_TECLI_CLIENT primary key (TECLI_CODIGO)
)
go

/*==============================================================*/
/* Table: TEDEF_DETFAC                                          */
/*==============================================================*/
create table TEDEF_DETFAC (
   TEFAC_CODIGO         int                  not null,
   TELCP_CODIGO         varchar(45)          not null,
   TEPAF_CODIGO         varchar(10)          not null,
   TEDEF_CANTID         int                  not null,
   TEDEF_SUBTOT         float                not null,
   constraint PK_TEDEF_DETFAC primary key (TEFAC_CODIGO, TELCP_CODIGO, TEPAF_CODIGO)
)
go

/*==============================================================*/
/* Index: TR_TELCP_TEDEF_FK                                     */
/*==============================================================*/




create nonclustered index TR_TELCP_TEDEF_FK on TEDEF_DETFAC (TELCP_CODIGO ASC,
  TEPAF_CODIGO ASC)
go

/*==============================================================*/
/* Index: TR_TEFAC_TEDEF_FK                                     */
/*==============================================================*/




create nonclustered index TR_TEFAC_TEDEF_FK on TEDEF_DETFAC (TEFAC_CODIGO ASC)
go

/*==============================================================*/
/* Table: TEFAC_FACTUR                                          */
/*==============================================================*/
create table TEFAC_FACTUR (
   TEFAC_CODIGO         int                  identity,
   TECLI_CODIGO         varchar(6)           not null,
   TEFAC_FECHA          datetime             not null,
   TEFAC_MODPAG         varchar(20)          not null,
   TEFAC_TOTAL          float                not null,
   constraint PK_TEFAC_FACTUR primary key (TEFAC_CODIGO)
)
go

/*==============================================================*/
/* Index: TR_TECLI_TEFAC_FK                                     */
/*==============================================================*/




create nonclustered index TR_TECLI_TEFAC_FK on TEFAC_FACTUR (TECLI_CODIGO ASC)
go

/*==============================================================*/
/* Table: TELCP_LOCPTD                                          */
/*==============================================================*/
create table TELCP_LOCPTD (
   TELCP_CODIGO         varchar(45)          not null,
   TEPAF_CODIGO         varchar(10)          not null,
   TELCP_DISPON         int                  not null,
   TELCP_PRECIO         float                not null,
   TELCP_CANBAS         int                  not null,
   constraint PK_TELCP_LOCPTD primary key (TELCP_CODIGO, TEPAF_CODIGO)
)
go

/*==============================================================*/
/* Index: TR_TEPAF_TELCP_FK                                     */
/*==============================================================*/




create nonclustered index TR_TEPAF_TELCP_FK on TELCP_LOCPTD (TEPAF_CODIGO ASC)
go

/*==============================================================*/
/* Table: TEPAF_PARFUT                                          */
/*==============================================================*/
create table TEPAF_PARFUT (
   TEPAF_CODIGO         varchar(10)          not null,
   TEPAF_LOCAL          varchar(45)          not null,
   TEPAF_VISITA         varchar(45)          not null,
   TEPAF_FECHA          datetime             not null,
   TEPAF_LUGAR          varchar(45)          not null,
   constraint PK_TEPAF_PARFUT primary key (TEPAF_CODIGO)
)
go

alter table TEDEF_DETFAC
   add constraint FK_TEDEF_DE_TR_TEFAC__TEFAC_FA foreign key (TEFAC_CODIGO)
      references TEFAC_FACTUR (TEFAC_CODIGO)
go

alter table TEDEF_DETFAC
   add constraint FK_TEDEF_DE_TR_TELCP__TELCP_LO foreign key (TELCP_CODIGO, TEPAF_CODIGO)
      references TELCP_LOCPTD (TELCP_CODIGO, TEPAF_CODIGO)
go

alter table TEFAC_FACTUR
   add constraint FK_TEFAC_FA_TR_TECLI__TECLI_CL foreign key (TECLI_CODIGO)
      references TECLI_CLIENT (TECLI_CODIGO)
go

alter table TELCP_LOCPTD
   add constraint FK_TELCP_LO_TR_TEPAF__TEPAF_PA foreign key (TEPAF_CODIGO)
      references TEPAF_PARFUT (TEPAF_CODIGO)
go

