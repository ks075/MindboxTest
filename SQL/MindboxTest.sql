--В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

create table Products (ID int primary key, Name nvarchar(128) not null)

insert into Products
values 
(1, N'Молоко'),
(2, N'Рыба'),
(3, N'Яблоки'),
(4, N'Апельсины'),
(5, N'Мандарины'),
(6, N'Кастрюля')

create table Categories (ID int primary key, Name nvarchar(128) not null)

insert into Categories
values 
(1, N'Молочная продукция'),
(2, N'Рыбная продукция'),
(3, N'Фрукты'),
(4, N'Цитрусовые')

create table ProductsCategories (ProductID int foreign key references Products (ID), CategoryID int foreign key references Categories (ID))
insert into ProductsCategories
values
(1, 1),
(2, 2),
(3, 3),
(4, 3),
(5, 3),
(4, 4),
(5, 4),
(6, null)

select p.Name, c.Name from Products p
inner join ProductsCategories pc on pc.ProductID = p.ID
left join Categories c on pc.CategoryID = c.ID