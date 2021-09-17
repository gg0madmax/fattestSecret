create table dbo.Users
(
    Id bigint not null identity,
    Email nvarchar(50) not null,
    UserLogin nvarchar(50) not null,
    [Password] nvarchar(50) not null,
    ConfirmPassword bit,
    CreateDate datetime2 not null constraint Def_Users_CreateDate default getutcdate(),
    UpdateDate datetime2

    constraint PK_Users primary key(Id)
    constraint AK_Email unique(Email)
)