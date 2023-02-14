--Assignment 4---
---1. create a function to display student information by BranchId
create table studentdetails
(
studentid int primary key,name varchar(100),
Gender varchar(10),
DOB date,
Email varchar(100),
ContactNo bigint,
Branchid int foreign key references Branch(id)
)
create table Branch(
id int primary key,
Branchname varchar(50),
branchHead varchar(50))

SELECT * FROM BRANCH
SELECT * FROM studentdetails
create function GetStudentbybranchid
(@branchid int)
returns table
as
return (select * from studentdetails where Branchid=@branchid)
select * from dbo.GetStudentbybranchid(301)

--2. create a function to display student information by Gender
drop function GetStudent
create function GetStudent(@gender varchar(10))
returns table
as 
return(
select studentdetails.studentid,name,gender,dob,email,contactno,branchid from studentdetails
join
Branch
on studentdetails.Branchid=branch.id
where Gender=@gender)


select * from dbo.GetStudent('male')

--3. calculate NetSales amount for all order_Id using Functions. Refer the below table
select * from sales.order_items
drop function netsales
CREATE FUNCTION NetSales1 (@orderID INT)
RETURNS TABLE
AS
RETURN (
   SELECT order_id, SUM(list_price) AS NetSales
   FROM sales.order_items
   WHERE order_id = @orderID
   GROUP BY order_id
)
select * from netsales1(1)

CREATE FUNCTION NetSales()
RETURNS TABLE
AS
RETURN (
   SELECT order_id, SUM(list_price) AS NetSales
   FROM sales.order_items
   GROUP BY order_id
)
select * from netsales()


----trigger---
drop table tblemployee
create table tblEmployee
(
Id INT,
Name VARCHAR(50),
Gender VARCHAR(10),
salary int,
DepartmentId int
)
Insert into tblEmployee values (1,'John', 'Male', 5000, 3)

Insert into tblEmployee values ( 2,'Mike', 'Male', 3400, 2)

Insert into tblEmployee values ( 3,'Pam',  'Female',6000, 1)
insert into tblemployee values (4,'charan','male',7000,1)
insert into tblemployee values (5,'charani','female',5000,2)
select * from tblemployee
select * from tblemployeeaudit
create table tblemployeeaudit
(
id int,
name varchar(100),
gender varchar(10),
salary int,
Departmentid int
)



CREATE TRIGGER trg_DeleteEmployee
AFTER DELETE ON tblEmployee
FOR EACH ROW
as
BEGIN
  INSERT INTO tblEmployeeAudit (id, name, gender, salary, departmentid)
  VALUES (OLD.id, OLD.name, OLD.gender, OLD.salary, OLD.departmentid)
END
GO



select * from tblemployeeaudit
-----subquery--
select * from tblproducts
select * from tblproductsales

create table tblproducts
(
[id] int identity primary key,
[name] nvarchar(50),
[Description] nvarchar(250)
)
Create table tblProductsales
(
id int primary key identity,
productId int foreign key references tblProducts(id),
unitprice int,
Quantitysold int)


Insert into tblProducts values ('TV', '52 inch black color LCD TV')

Insert into tblProducts values ('Laptop', 'Very thin black color acer laptop')

Insert into tblProducts values ('Desktop', 'HP high performance desktop')

Insert into tblProductSales values(3, 450, 5)

Insert into tblProductSales values (2, 250, 7)

Insert into tblProductSales values (3, 450, 4)

Insert into tblProductSales values (3, 450, 9)
Insert into tblProductSales values (1, 420,0 )


select Id, Name, description from tblProducts where Id in
(
select productid from tblProductsales  where Quantitysold=0
)
