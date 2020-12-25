--This table created inside Sample4 database
--Create Table tblEMployees
--(
--	EmployeeId int identity primary key,
--	Name nvarchar(20),
--	Gender nvarchar(10),
--	Salary int
--)

--Insert into tblEMployees values ('Mike','Male',5000)
--Insert into tblEMployees values ('Sanvi','Female',5000)
--Insert into tblEMployees values ('Mikel','Male',9000)
--Insert into tblEMployees values ('Radha','Female',3000)
--Insert into tblEMployees values ('Raj','Male',50000)
--Insert into tblEMployees values ('Aishwarya','Female',15000)

--select * from tblEmployees

--create  Procedure spAddEmployee
--@Name nvarchar(50),
--@Gender nvarchar(10),
--@Salary int,
--@EmployeeId int out
--as
--Begin
-- Insert into tblEMployees values (@Name, @Gender, @Salary)
-- select @EmployeeId = SCOPE_IDENTITY()
--End


--declaring variable of type integer

--Declare @EmpId int

--Execute spAddEmployee 'Rakesh','Male','7500',@EmpId out
--print 'Employee Id = ' + Cast(@EmpId as nvarchar(2))

select * from tblEMployees