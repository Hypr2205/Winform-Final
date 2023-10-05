use master
go

if not exists(select *
              from sys.databases
              where name = 'ProductDB')
    begin
        create database ProductDB
    end
go

use ProductDB
go

begin
    create table Product
    (
        ProductID   varchar(8)     not null,
        ProductName nvarchar(255)  not null,
        Unit        nvarchar(20)   not null,
        Quantity    int            not null,
        SellPrice   decimal(18, 0) not null,
        Sale        int default 0,
        CategoryID  varchar(8)     not null,
        constraint PK_Product primary key (ProductID asc)
    )

    create table Category
    (
        CategoryID   varchar(8)    not null,
        CategoryName nvarchar(100) not null,
        constraint PK_Category primary key (CategoryID asc)
    )

    create table Invoice
    (
        InvoiceID    varchar(10)   not null,
        OrderDate    datetime      not null,
        DeliveryDate datetime      not null,
        Note         nvarchar(255) not null,
        constraint PK_Invoice primary key (InvoiceID asc)
    )

    create table Orders
    (
        InvoiceID    varchar(10)    not null,
        No           int            not null,
        ProductID    varchar(8)     not null,
        ProductName  nvarchar(255)  not null,
        CategoryID   varchar(8)     not null,
        CategoryName nvarchar(100)  not null,
        Unit         nvarchar(20)   not null,
        Quantity     int            not null,
        SellPrice    decimal(18, 0) not null,
        Sale         int default 0,
        constraint PK_Order primary key (InvoiceID asc, No asc)
    )

    alter table Product
        with check
            add constraint FK_Category foreign key (CategoryID) references Category (CategoryID)

    alter table Orders
        with check
            add
            constraint FK_Invoice_Order foreign key (InvoiceID) references Invoice (InvoiceID),
            constraint FK_Product_Order foreign key (ProductID) references Product (ProductID),
            constraint FK_Category_Order foreign key (CategoryID) references Category (CategoryID)
end