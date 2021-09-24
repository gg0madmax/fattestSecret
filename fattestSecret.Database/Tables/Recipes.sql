create table dbo.Recipes
(
	Id bigint not null identity,
	[Name] nvarchar(300) not null,
	[Type] nvarchar(300),
	Kcals decimal(5,2),
	Proteins decimal(5,2),
	Fats decimal(5,2),
	Carbohydrates decimal(5,2),
	CreateDate datetime2 not null constraint Def_Recipes_CreateDate default getutcdate()

	constraint PK_Recipes primary key(Id)
)