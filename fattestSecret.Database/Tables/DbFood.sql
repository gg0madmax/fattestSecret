create table dbo.DbFood
(
	Id int not null primary key,
	[Name] nvarchar(300),
	Kcals decimal(5,2),
	Proteins decimal(5,2),
	Fats decimal(5,2),
	Carbohydrates decimal(5,2),
	CreateDate datetime not null constraint Def_DbFood_CreateDate default getutcdate(),
	UpdateDate datetime
)