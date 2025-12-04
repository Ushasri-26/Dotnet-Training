create database SQLAssignment
--Customers Table
create table Customers(
CustID int primary key,
CustName varchar(100),
Email varchar(200),
City varchar(100)
);
--Products Table
create table Products(
ProductID int primary key,
ProductName varchar(100),
Price decimal(10,2),
Stock int check (Stock>=0)
);
--Orders Table
create table Orders(
OrderID int primary key,
CustID int foreign key references Customers(CustID),
OrderDate date,
Status varchar(20)
);
--Order Details
create table OrderDetails(
DetailID int primary key,
OrderID int foreign key references Orders(OrderID),
ProductID int foreign key references Products(ProductID),
Qty int check(Qty>0)
);
--Payments
create table Payments(
PaymentID int primary key,
OrderID int foreign key references Orders(OrderID),
Amount int,
PaymentDate date
);
--Inserting values into Customers Table
INSERT INTO Customers (CustID, CustName, Email, City) VALUES
(1, 'Amit Sharma', 'amit.sharma@gmail.com', 'Mumbai'),
(2, 'Ravi Kumar', 'ravi.kumar@yahoo.com', 'Delhi'),
(3, 'Priya Singh', 'priya.singh@gmail.com', 'Pune'),
(4, 'John Mathew', 'john.mathew@hotmail.com', 'Bangalore'),
(5, 'Sara Thomas', 'sara.thomas@gmail.com', 'Kochi'),
(6, 'Nidhi Jain', 'nidhi.jain@gmail.com', NULL);
--Inserting values into Products Table
INSERT INTO Products (ProductID, ProductName, Price, Stock) VALUES
(101, 'Laptop Pro 14', 75000, 15),
(102, 'Laptop Air 13', 55000, 8),
(103, 'Wireless Mouse', 800, 50),
(104, 'Mechanical Keyboard', 3000, 20),
(105, 'USB-C Charger', 1200, 5),
(106, '27-inch Monitor', 18000, 10),
(107, 'Pen Drive 64GB', 600, 80);
--Inserting values into Orders Table
INSERT INTO Orders (OrderID, CustID, OrderDate, Status) VALUES
(5001, 1, '2025-01-05', 'Pending'),
(5002, 2, '2025-01-10', 'Completed'),
(5003, 1, '2025-01-20', 'Completed'),
(5004, 3, '2025-02-01', 'Pending'),
(5005, 4, '2025-02-15', 'Completed'),
(5006, 5, '2025-02-18', 'Pending');
--Inserting values into OrdersDetails Tables 
INSERT INTO OrderDetails (DetailID, OrderID, ProductID, Qty) VALUES
(9001, 5001, 101, 1),
(9002, 5001, 103, 2),
(9003, 5002, 104, 1),
(9004, 5002, 103, 1),
(9005, 5003, 102, 1),
(9006, 5003, 105, 1),
(9007, 5003, 103, 3),
(9008, 5004, 106, 1),
(9009, 5005, 107, 4),
(9010, 5005, 104, 1),
(9011, 5006, 101, 1),
(9012, 5006, 107, 2);
--Inserting values into a Payments Table
INSERT INTO Payments (PaymentID, OrderID, Amount, PaymentDate) VALUES
(7001, 5002, 3300, '2025-01-11'),
(7002, 5003, 62000, '2025-01-22'),
(7003, 5005, 4500, '2025-02-16');

--Queries
--Q1. List customers who placed an order in the last 30 days. 
--(Use joins)
select distinct c.CustID,c.CustName,c.Email,c.City
from Customers c
join Orders o on c.CustID=o.CustID where o.OrderDate>=dateadd(day,-30,getdate());
select * from Customers;
--Q2. Display top 3 products that generated the highest total sales amount. 
--(Use aggregate + joins) 
select top 3 p.ProductID,p.ProductName,sum(od.Qty*p.Price) as TotalSales
from OrderDetails od 
join Products p on od.ProductID=p.ProductID
group by p.ProductID,p.ProductName
order by TotalSales desc;

--Q3. For each city, show number of customers and total order count. 
select c.City,count(distinct c.CustID) as CustCount,
count(o.OrderID) as OrderCount from Customers c
left join Orders o on c.CustID=o.CustID group by c.City;

--Q4. Retrieve orders that contain more than 2 different products. 
select OrderID from OrderDetails group by OrderID having count(distinct ProductID)>2;

--Q5. Show orders where total payable amount is greater than 10,000. 
--(Hint: SUM(Qty * Price)) 
select od.OrderID,sum(od.Qty*p.Price) as TotalAmount from OrderDetails od
join products p on od.ProductID=p.ProductID group by od.OrderID 
having sum(od.Qty*p.Price)>10000;

--Q6. List customers who ordered the same product more than once. 
select distinct c.CustID,c.CustName from Customers c 
join Orders o on c.CustID=o.CustID
join OrderDetails od on o.OrderID=od.OrderID
group by c.CustID,c.CustName,od.ProductID having count(od.ProductID)>1;

--Q7. Display employee-wise order processing details 
--(Assume Orders table has EmployeeID column)
create table Employees(
EmployeeID int primary key,
EmployeeName varchar(100));
insert into Employees values
(1,'Usha sri'),
(2,'Monika'),
(3,'Uday Kiran'),
(4,'Satwik'),
(5,'Sravani');
alter table Orders 
add EmployeeID int NULL;
alter table Orders add constraint fk_Orders_Employees
foreign key (EmployeeID) references Employees(EmployeeID);
update Orders set EmployeeID=1 where OrderID=5001;
update Orders set EmployeeID=2 where OrderID=5002;
update Orders set EmployeeID=3 where OrderID=5003;
update Orders set EmployeeID=4 where OrderID=5004;
update Orders set EmployeeID=5 where OrderID=5005;
update Orders set EmployeeID=1 where OrderID=5006;

select e.EmployeeID,e.EmployeeName,count(o.OrderID) as EmpwiseOrder from Employees e
left join Orders o on e.EmployeeID=o.EmployeeID
group by e.EmployeeID,e.EmployeeName;
--Views
--1. Create a view vw_LowStockProducts 
--Show only products with stock < 5. 
--View should be WITH SCHEMABINDING and Encrypted
create view vw_LowStockProducts 
with schemabinding,encryption
as
select ProductID,ProductName,Price,Stock from dbo.Products
where Stock<5;
update Products set Stock=2 where ProductID=105;
select * from vw_LowStockProducts;

--Functions
--1. Create a table-valued function: fn_GetCustomerOrderHistory(@CustID) 
--Return: OrderID, OrderDate, TotalAmount.
create function fn_GetCustomerOrderHistory(@CustID int) 
returns table
as
return
(select o.OrderID,o.OrderDate,sum(od.Qty*p.Price) as TotalAmount
from Orders o
join OrderDetails od on o.OrderID=od.OrderID
join Products p on od.ProductID=p.ProductID
where o.CustID=@CustID
group by o.OrderID,o.OrderDate);
select * from fn_GetCustomerOrderHistory(1);
--2. Create a function fn_GetCustomerLevel(@CustID) 
--Logic: 
--• Total purchase > 1,00,000 → "Platinum" 
--• 50,000–1,00,000 → "Gold" 
--• Else → "Silver"
create function fn_GetCustomerLevel(@CustID int)
returns varchar(20)
as
begin
declare @Total decimal(10,2);
select @Total=sum(od.Qty*p.Price) from Orders o 
join OrderDetails od on o.OrderID=od.OrderID
join Products p on od.ProductID=p.ProductID where o.CustID=@CustID;
if @Total>100000 return 'Platinum';
if @Total between 50000 and 100000 return 'Gold';
return 'Silver';
end;
select dbo.fn_GetCustomerLevel(1) as CustomerLevel;

--Procedures
--1. Create a stored procedure to update product price 
--Rules: 
--• Old price must be logged in a PriceHistory table 
--• New price must be > 0 
--• If invalid, throw custom error. 

create table PriceHistory(
HistoryID int identity primary key,
ProductID int,
OldPrice decimal(10,2),
NewPrice decimal(10,2),
Changedate datetime default getdate());
create procedure sp_UpdateProductPrice
(@ProductID int,@NewPrice decimal(10,2))
as
begin
if @NewPrice<=0
begin
RAISERROR('New Price must be greater than 0',16,1);
return;
end
declare @OldPrice decimal(10,2);
select @OldPrice=Price from Products where ProductID=@ProductID;
insert into PriceHistory(ProductID,OldPrice,NewPrice)
values(@ProductID,@OldPrice,@NewPrice);
update Products set Price=@NewPrice where ProductID=@ProductID;
end;
exec sp_UpdateProductPrice 103,1000;
exec sp_UpdateProductPrice 103,-50;
select * from PriceHistory;

--2. Create a procedure sp_SearchOrders 
--Search orders by: 
--• Customer Name 
--• City 
--• Product Name 
--• Date range 
--(Any parameter can be NULL → Dynamic WHERE)
create procedure sp_SearchOrders(
@CustName varchar(100)=NULL,
@City varchar(100)=NULL,
@ProductName varchar(100)=NULL,
@StartDate date=NULL,
@EndDate date=NULL)
as
begin
select distinct o.OrderID,o.OrderDate,c.CustName,c.City from Orders o
join Customers c on o.CustID=c.CustID
join OrderDetails od on o.OrderID=od.OrderID
join Products p on od.ProductID=p.ProductID
where(c.CustName like '%' +@CustName+'%' or @CustName is NULL)
and (c.City=@City or @City is NULL)
and(p.ProductName like '%' +@ProductName + '%' or @ProductName is NULL)
and(o.OrderDate between @StartDate and @EndDate or @StartDate is NULL or @EndDate is NULL);
end;
exec sp_SearchOrders @CustName='Amit';
exec sp_SearchOrders @ProductName='Mechanical Keyboard';
exec sp_SearchOrders @StartDate='2025-02-01', @EndDate='2025-03-01';
--Triggers
--1. Create a trigger on Products 
--Prevent deletion of a product if it is part of any OrderDetails. 
create trigger prevdeletion 
on Products
instead of delete 
as
begin
if exists(select 1 from OrderDetails od join deleted d on od.ProductID=d.ProductID)
begin
raiserror('Cannot delete product which is part of OrderDetails',16,1);
return
end
delete from Products where ProductID in (select ProductID from deleted);
end;
insert into products values(700,'Watch',100,5);
delete from Products where ProductID=700;
select * from Products;
--2. Create an AFTER UPDATE trigger on Payments 
--Log old and new payment values into a PaymentAudit table. 
create table PaymentAudit(
AuditID int identity primary key,
PaymentID int,
OldAmount decimal(10,2),
NewAmount decimal(10,2),
Changedate datetime default getdate());
create trigger PaymentsAudit on Payments
after update
as
begin
insert into PaymentAudit(PaymentID,OldAmount,NewAmount)
select d.PaymentID,d.Amount,i.Amount from deleted d
join inserted i on d.PaymentID=i.PaymentID;
end;
update Payments set Amount=1680 where PaymentID=7001;
select * from Payments

--3. Create an INSTEAD OF DELETE trigger on Customers 
--Logic: 
--• If customer has orders → mark status as “Inactive” instead of deleting 
--• If no orders → allow deletion
create trigger cust on Customers
instead of delete
as
begin
update Customers set City='Inactive' where CustID in(
select d.CustID from deleted d join Orders o on d.CustID=o.CustID);
delete from Customers where CustID in(
select d.CustID from deleted d left join Orders o on
d.CustID=o.CustID where o.CustID is NULL);
end;
delete from Customers where CustID=1;
select * from Customers;
insert into Customers values(7,'Usha','usha@gmail.com','Hyderabad');
delete from Customers where CustID=7;
select * from Customers;