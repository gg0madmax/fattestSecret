create procedure dbo.AddProduct
@Name nvarchar(300),
@Kcals decimal(5,2),
@Proteins decimal(5,2),
@Fats decimal(5,2),
@Carbohydrates decimal(5,2)
as
	insert into dbo.Products ([Name], Kcals, Proteins, Fats, Carbohydrates)
	output inserted.Id
	values (@Name, @Kcals, @Proteins, @Fats, @Carbohydrates);