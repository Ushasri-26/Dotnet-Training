create database example
--Creating Customers table
create table customers (
custid INT PRIMARY KEY,
custname VARCHAR(50),
age INT,
caddress VARCHAR(50),
cphone VARCHAR(20)
);
--Creating Ordres Table
create table orders(
custid INT,
orderid INT PRIMARY KEY,
orderdate DATE,
product VARCHAR(50),
price DECIMAL(10,2),
qty INT,
FOREIGN KEY (custid) REFERENCES customers(custid)
);
--Inserting Values into Customers Table
INSERT INTO customers VALUES
(1,'Usha sri',22,'Vizag',9876543210),
(2,'Uday Kiran',25,'Hyderabad',6281341892),
(3,'Bhavya',20,'Guntur',9398986754),
(4,'Ravi',31,'Hyderabad',9818998899),
(5,'Anurag',21,'Ongole',8075432145),
(6,'Satwik',20,'Bangalore',9398765420),
(7,'Sravani',26,'Pune',8976543270),
(8,'Pooji',22,'Chennai',9087654320),
(9,'Srinivas',54,'Mumbai',9498970596);

--Inserting Values into Orders Table
INSERT INTO orders VALUES
(1,100,'2025-11-25','Books', 120,3),
(2,101,'2024-08-02','Earpods', 5000,1),
(3,102,'2023-10-25','Laptop', 75000,1),
(4,103,'1999-01-25','Mobile', 125000,1),
(5,104,'2018-03-25','Keyboard', 12000,2),
(6,105,'2020-05-25','Chairs', 4000,6),
(7,106,'2023-07-25','Camera', 150000,1),
(8,107,'2005-12-25','Pens', 300,15),
(9,108,'2022-02-25','Bag', 10000,4);
--1--Customers who reside in Bangalore
select * from customers where caddress='Bangalore';
--2--Customers who reside in Bangalore
select * from customers where caddress NOT IN ('Bangalore','Chennai');
--3--Customers age > 50 AND not in Bangalore
select * from customers where age>50 AND caddress NOT IN ('Bangalore');
--4--Customers name starting with A
select * from customers where custname LIKE 'A%';
--5--Customers whose name contains 'Br'
select * from customers where custname LIKE '%Br%';
--6--Customers whose name starts between A and K
select * from customers where custname LIKE '[A-K]%';
--7--Customers whose name is 5 characters long
select * from customers where custname LIKE '_____';
--8--Name checks Starts with S Third character is C Ends with E
select * from customers where custname LIKE 'S_c%e';
--9--Display unique customer names
select DISTINCT custname from customers;
--10--Orders where qty is between 100 200 OR 700 1200
select * from orders where qty between 100 and 200 OR qty between 700 and 1200;
--11--Customer name starting with AL and ending with N
select * from customers where custname LIKE 'AL%N';
--12--20% price increase   show old & new price
select custid,price AS OldPrice,price * 1.20 AS NewPrice from orders;
--13--Top 3 highest qty
select TOP 3 * from orders ORDER BY qty DESC;
--14--How many times each customer purchased (count orders)
select custid,COUNT(*) AS PurchaseCount from orders GROUP BY custid;
--15--Orders made earlier than 5 years from today
select * from orders where orderdate < DATEADD(YEAR, -5, GETDATE());
--16--Customers where name is NULL
select * from customers where custname IS NULL;
--17--Display order details in format: OrderID-Date Total
select CONCAT(orderid, '-', FORMAT(orderdate, 'dd/MM/yyyy')) 
AS [OrderID-Date],(price*qty) AS Total from orders;
--18--Decrease price by 20% where qty > 50
UPDATE orders SET price=price*0.80 where qty>50;
--19--Orders on '1-12-90' with price 4000 6000 sorted desc
select * from orders where orderdate = '1990-12-01' and price between 4000 and 6000 ORDER BY price DESC;
--20--Display: custid | sum(price) | count(qty)
select custid,SUM(price) AS TotalPrice,SUM(qty) AS TotalQuantity from orders GROUP BY custid;
--21--Above details only where sum(price) > 4000
select custid,SUM(price) AS TotalPrice,SUM(qty) AS TotalQtyCount from orders GROUP BY custid HAVING SUM(price)>4000;
--22--Create duplicate table to custhistory
select * INTO custhistory from customers;
--a--Delete all records
DELETE from custhistory;
--b--Copy customers where age > 30
INSERT INTO custhistory select * from customers where age>30;
