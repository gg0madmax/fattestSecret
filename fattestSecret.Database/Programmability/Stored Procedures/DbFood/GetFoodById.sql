create procedure dbo.GetFoodById
@dbId int
as
	select Id, [Name], Kcals, Proteins, Fats, Carbohydrates, CreateDate, UpdateDate
	from dbo.DbFood
	where DbFood.Id = @dbId