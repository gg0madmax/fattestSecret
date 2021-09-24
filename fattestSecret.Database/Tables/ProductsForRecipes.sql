create table dbo.ProductsForRecipes
(
	RecipeId bigint not null primary key,
	ProductId bigint not null,
	[Weight] decimal(5,2)
)