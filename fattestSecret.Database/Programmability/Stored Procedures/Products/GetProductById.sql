create procedure dbo.GetProductById
@dbId bigint
as
	select Id, [Name], Kcals, Proteins, Fats, Carbohydrates, CreateDate, UpdateDate
	from dbo.Products
	where Products.Id = @dbId