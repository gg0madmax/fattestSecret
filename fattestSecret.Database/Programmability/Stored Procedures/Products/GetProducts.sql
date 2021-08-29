create procedure dbo.GetProducts
as
	select Id, [Name], Kcals, Proteins, Fats, Carbohydrates, CreateDate, UpdateDate
	from dbo.Products