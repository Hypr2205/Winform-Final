use master
go

create database ComputerShop
go

use ComputerShop
go

create table Laptop
    (
        LaptopID   varchar(10)    not null,
        LaptopName nvarchar(100)  not null,
        SellPrice  decimal(18, 0) not null,
        Sale       int default 0  not null,
        CategoryID varchar(10)    not null,
        constraint PK_Laptop primary key (LaptopID asc)
    )

    create table LaptopCategory
    (
        CategoryID   varchar(10)   not null,
        CategoryName nvarchar(100) not null,
        constraint PK_Category primary key (CategoryID asc)
    )

    create table Accessory
    (
        AccessoryID   varchar(10)    not null,
        AccessoryName nvarchar(100)  not null,
        SalePrice     decimal(18, 0) not null,
        Sale          int default 0  not null,
        BrandID       varchar(10)    not null,
        CategoryID    varchar(10)    not null,
        constraint PK_Accessory primary key (AccessoryID asc)
    )

    create table AccessoryCategory
    (
        CategoryID   varchar(10)   not null,
        CategoryName nvarchar(100) not null,
        constraint PK_Accessory_Category primary key (CategoryID asc)
    )

    create table AccessoryBrand
    (
        BrandID    varchar(10)   not null,
        BrandName  nvarchar(100) not null,
        constraint PK_Accessory_Brand primary key (BrandID)
    )

    create table LaptopInvoice
    (
        InvoiceID    varchar(10) not null,
        OrderDate    datetime    not null,
        DeliveryDate datetime    not null,
        Note         nvarchar(255),
        constraint PK_Laptop_Invoice primary key (InvoiceID asc)
    )

    create table CustomPCInvoice
    (
         InvoiceID    varchar(10) not null,
        OrderDate    datetime    not null,
        DeliveryDate datetime    not null,
        Note         nvarchar(255),
        constraint  PK_Custom_Invoice primary key (InvoiceID asc)
    )

    create table LaptopOrder
    (
        InvoiceID    varchar(10)    not null,
        OrderID      varchar(10)    not null,
        LaptopID     varchar(10)    not null,
        LaptopName   nvarchar(100)  not null,
        SellPrice    decimal(18, 0) not null,
        Sale         int default 0  not null,
        CategoryID   varchar(10)    not null,
        CategoryName nvarchar(100)  not null,
        constraint PK_Laptop_Order primary key (InvoiceID asc, OrderID asc)
    )
    create table CustomPCOrder
    (
        InvoiceID     varchar(10)    not null,
        OrderID       varchar(10)    not null,
        AccessoryID   varchar(10)    not null,
        AccessoryName nvarchar(100)  not null,
        SalePrice     decimal(18, 0) not null,
        Sale          int default 0  not null,
        BrandID       varchar(10)    not null,
        BrandName     nvarchar(100)  not null,
        CategoryID    varchar(10)    not null,
        CategoryName  nvarchar(100)  not null,
        constraint PK_Custom_PC_Order primary key (InvoiceID asc, OrderID asc)
    )

    alter table Laptop
        with check
            add constraint FK_Laptop_Category foreign key (CategoryID) references LaptopCategory (CategoryID)

    alter table LaptopOrder
        with check
            add
            constraint FK_Laptop_Invoice foreign key (InvoiceID) references LaptopInvoice (InvoiceID),
            constraint FK_Laptop foreign key (LaptopID) references Laptop (LaptopID),
            constraint FK_Laptop_Category_Invoice foreign key (CategoryID) references LaptopCategory (CategoryID)

    alter table Accessory
        with check
            add
            constraint FK_Accessory_Category foreign key (CategoryID) references AccessoryCategory (CategoryID),
            constraint FK_Accessory_Brand foreign key (BrandID) references AccessoryBrand (BrandID)

    alter table CustomPCOrder
        with check
            add
            constraint FK_Custom_Invoice foreign key (InvoiceID) references CustomPCInvoice (InvoiceID),
            constraint FK_Custom_Accessory foreign key (AccessoryID) references Accessory (AccessoryID),
            constraint FK_Custom_Category foreign key (CategoryID) references AccessoryCategory (CategoryID),
            constraint FK_Custom_Brand foreign key (BrandID) references AccessoryBrand (BrandID)