create procedure dbo.UpdateProduct
@Id bigint,
@Name nvarchar(300),
@Kcals decimal(5,2),
@Proteins decimal(5,2),
@Fats decimal(5,2),
@Carbohydrates decimal(5,2),
@UpdateDate datetime
as
	update dbo.Products
	set [Name] = @Name, Kcals = @Kcals, Proteins = @Proteins, Fats = @Fats, Carbohydrates = @Carbohydrates, UpdateDate = @UpdateDate
	from dbo.Products
	where Id = @Id