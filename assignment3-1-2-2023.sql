---1)
create procedure hexaware
as
--begin 
print 'welcome to SQL server'
--end
exec hexaware

2)
select * from tblemployee
create proc hexa1 (@gender varchar(20),@Departmentid int)
as
begin 
select name,gender,salary from tblemployee
where @gender=Gender and @Departmentid=departmentid
end
exec hexa1 'female',1

3)
create procedure Hexa
(@gender varchar(10), @deptid int,
@totalcount int output)
as
BEGIN
select name,gender,salary from tblemployee
where @gender=gender and @deptid=Departmentid
select @totalcount=@@ROWCOUNT
END

declare @count int;
exec hexa  @gender='male',@deptid=2,@totalcount=@count output
select @count as 'Number of employee'

--4)
drop proc hexa2
create proc hexa2(@gender varchar(10))                           
as
begin 
select count(gender)  as totalemployeecount from tblemployee
where @gender=gender
end

exec hexa2 'male'
--5)
drop proc add_three_numbers
CREATE PROCEDURE add_three_numbers(@num1 INT default 0,@num2 INT default 0,@num3 INT default 0)
as
BEGIN
DECLARE @result int
SET @result = @num1+@num2+@num3
SELECT @result
END

exec add_three_numbers 12,23,12


 CREATE PROCEDURE add_three_numbers (@num1 INT=10, @num2 INT=0, @num3 INT=5)
AS
BEGIN
  DECLARE @result INT

  SET @result = @num1 + @num2 + @num3

  SELECT @result AS [Sum]
END

exec add_three_numbers @num2=0
