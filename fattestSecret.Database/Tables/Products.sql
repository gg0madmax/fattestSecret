create table dbo.Products
(
	Id bigint not null identity,
	[Name] nvarchar(300) not null,
	Kcals decimal(5,2),
	Proteins decimal(5,2),
	Fats decimal(5,2),
	Carbohydrates decimal(5,2),
	CreateDate datetime2 not null constraint Def_Products_CreateDate default getutcdate(),
	UpdateDate datetime2

	constraint PK_Products primary key(Id)
)