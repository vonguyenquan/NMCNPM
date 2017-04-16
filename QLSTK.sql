create database QLSTK
use QLSTK

create table Customers
(
	CustomerID char(5) primary key not null,
	FullName varchar(30),
	Addr varchar(50),
	IdNumber char(13)
)

create table Books
(
	BookID char(5) primary key not null,
	CustomerID char(5),
	ServiceType smallint,
	StartedDay smalldatetime,
	Amount money
)

create table Transactions
(
	TransactionID char(10) primary key not null,
	CustomerID char(5),
	BookID char(5),
	Deposite money,
	Withdraw money
)

create table ServiceTypes
(
	ServiceType smallint primary key not null,
	InterestRate real,
	Period smallint,
)

insert into ServiceTypes(ServiceType, InterestRate, Period) values (0, 0.15, 1);
insert into ServiceTypes(ServiceType, InterestRate, Period) values (1, 0.5, 3);
insert into ServiceTypes(ServiceType, InterestRate, Period) values (2, 0.55, 6);

create table Accounts
(
	AccName varchar(16) primary key not null,
	Pass varchar(16),
	AccType char(1)
)

insert into Accounts(AccName, Pass, AccType) values ('admin', 'admin', 'f');
insert into Accounts(AccName, Pass, AccType) values ('user', 'user', 'n');

alter table Books add constraint FK_CustID_Cus_Books foreign key (CustomerID) references Customers(CustomerID);
alter table Books add constraint FK_ServType_ServTypes_Books foreign key (ServiceType) references ServiceTypes(ServiceType);
alter table Transactions add constraint FK_CustID_Cus_Transac foreign key (CustomerID) references Customers(CustomerID);
alter table Transactions add constraint FK_BookID_Books_Transac foreign key (BookID) references Books(BookID); 
