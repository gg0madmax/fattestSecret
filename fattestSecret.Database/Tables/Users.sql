create table dbo.Users
(
    Id bigint not null identity,
    Email nvarchar(50),
    UserLogin nvarchar(50) not null,
    [Password] nvarchar(50) not null,
    ConfirmPassword bit,
    CreateDate datetime not null constraint Def_Users_CreateDate default getutcdate(),
    UpdateDate datetime

    constraint PK_Users primary key(Id)
)