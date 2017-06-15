/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     6/4/2017 4:28:12 PM                          */
/*==============================================================*/


/*==============================================================*/
/* Table: Abonent                                               */
/*==============================================================*/
create table Abonent (
   AbonentCode          int                  not null,
   ClientAdress         int                  not null,
   SecondName           varchar(100)         null,
   FirstName            varchar(100)         null,
   Patronymic           varchar(100)         null,
   BirthDay             int                  null
)
go

alter table Abonent
   add constraint PK_ABONENT primary key nonclustered (AbonentCode)
go

/*==============================================================*/
/* Table: Autor                                                 */
/*==============================================================*/
create table Autor (
   AutorCode            bigint               not null,
   SecondName           varchar(100)         null,
   BirthDay             datetime             null
)
go

alter table Autor
   add constraint PK_AUTOR primary key nonclustered (AutorCode)
go

/*==============================================================*/
/* Table: ClientAdress                                          */
/*==============================================================*/
create table ClientAdress (
   ID                   int              identity,
   Region               int                  not null,
   Street               varchar(100)         not null,
   House                smallint             not null,
   Letter               char(1)              null,
   Flat                 smallint             null
)
go

alter table ClientAdress
   add constraint PK_CLIENTADRESS primary key nonclustered (ID)
go

/*==============================================================*/
/* Table: Edition                                               */
/*==============================================================*/
create table Edition (
   ISBN                 varchar(20)          not null,
   Publisher            bigint               not null,
   Autor                bigint               not null,
   Name                 varchar(100)         null
)
go

alter table Edition
   add constraint PK_EDITION primary key nonclustered (ISBN)
go

/*==============================================================*/
/* Table: Mail                                                  */
/*==============================================================*/
create table Mail (
   MailCode             int                  not null,
   TypeMail             int                  not null,
   Sender               int                  not null,
   Reciever             int                  not null
)
go

alter table Mail
   add constraint PK_MAIL primary key nonclustered (MailCode)
go

/*==============================================================*/
/* Table: Postman                                               */
/*==============================================================*/
create table Postman (
   TabelNumber          int                  identity,
   Region               int                  not null,
   SecondName           varchar(50)          not null,
   FirstName            varchar(50)          not null,
   LastName             varchar(50)          null,
   Age                  smallint             not null
)
go

alter table Postman
   add constraint PK_POSTMAN primary key nonclustered (TabelNumber)
go

/*==============================================================*/
/* Table: Publisher                                             */
/*==============================================================*/
create table Publisher (
   Code                 bigint               not null,
   Address              varchar(100)         null
)
go

alter table Publisher
   add constraint PK_PUBLISHER primary key nonclustered (Code)
go

/*==============================================================*/
/* Table: Region                                                */
/*==============================================================*/
create table Region (
   RegionCode           int                  not null,
   Name                 varchar(100)         not null
)
go

alter table Region
   add constraint PK_REGION primary key nonclustered (RegionCode)
go

/*==============================================================*/
/* Table: Subscribe                                             */
/*==============================================================*/
create table Subscribe (
   Code                 numeric              identity,
   Edition              varchar(20)          not null,
   Abonent              int                  not null,
   Period               int                  null,
   Cost                 money                null
)
go

alter table Subscribe
   add constraint PK_SUBSCRIBE primary key nonclustered (Code)
go

/*==============================================================*/
/* Table: TypeMail                                              */
/*==============================================================*/
create table TypeMail (
   ID                   int                  not null,
   Name                 varchar(15)          null,
   Description          text                 null
)
go

alter table TypeMail
   add constraint PK_TYPEMAIL primary key nonclustered (ID)
go

/*==============================================================*/
/* Foreign keys                                                 */
/*==============================================================*/

alter table Abonent
   add constraint FK_ABONENT foreign key (ClientAdress) references ClientAdress(ID)
go

alter table ClientAdress
   add constraint FK_ClientAdressRegion foreign key (Region) references Region(RegionCode)
go

alter table Edition
   add constraint FK_EditionAutor foreign key (Autor) references Autor(AutorCode)
go

alter table Edition
   add constraint FK_EditionPublisher foreign key (Publisher) references Publisher(Code)
go

alter table Postman
   add constraint FK_PostmanRegion foreign key (Region) references Region(RegionCode)
go

alter table Subscribe
   add constraint FK_SubscribeEdition foreign key (Edition) references Edition(ISBN)
go

alter table Subscribe
   add constraint FK_SubscribeAbonent foreign key (Abonent) references Abonent(AbonentCode)
go

alter table Mail
   add constraint FK_MailType foreign key (TypeMail) references TypeMail(ID)
go

alter table Mail
   add constraint FK_MailAbonentSender foreign key (Sender) references Abonent(AbonentCode)
go

alter table Mail
   add constraint FK_MailAbonentReciever foreign key (Reciever) references Abonent(AbonentCode)
go