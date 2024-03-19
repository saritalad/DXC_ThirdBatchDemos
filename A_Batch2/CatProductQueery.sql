use batch2DB;
create table Category (id int primary key identity(101,1),name varchar(20))
create table Products(id int primary key identity(1,1),name varchar(20), price decimal(12,2),catId int)
insert into category values('Soap'),('oil'),('grain')
insert into Products values('Lux',23,101),('Lyril',45,101),('Dove',67,101)
insert into Products values('SunFlower',223,102),('Gemini',145,102),('Rice Bran',167,102)
insert into Products values('Wheat',35,103),('Rice',65,103),('Bajra',40,103)

select  * from Category
select * from Products