--create database Sample4
--create table tblProduct4(ProductId int, Name varchar(20), UnitPrice int, QtyAvailable int)
--insert into tblProduct4 values(1, 'Milk', 23, 3)
--insert into tblProduct4 values(2, 'Laptops', 233, 2)
--insert into tblProduct4 values(3, 'Mouses', 2322, 34)
--select * from tblProductInventory

--Insert into tblProduct4 values (4, 'Server', 23333, 5)

--delete from tblProduct4 where ProductId=3

--update tblProduct4 set  UnitPrice=0 where ProductId = 3


--sql injection attck
--ip'; Delete from tblProductInventory -- which deletes entire table

--exec sp_executesql N'select * from tblProductInventory where ProductName like @ProductName',N'@ProductName nvarchar(3)',@ProductName=N'ip%'


--////////////////////////////
--Creating stored procedure:
spGetProductsByName 'ip%'

--Create Procedure spGetProductsByName
--@ProductName nvarchar(50)
--as
--Begin
--	Select * from tblProductInventory
--	where ProductName like @ProductName + '%'
--End
