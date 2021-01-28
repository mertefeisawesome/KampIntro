--Select 
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products order by UnitPrice desc

Select count(*) from Products where CategoryID = 2