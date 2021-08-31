create procedure dbo.GetUserById
@dbId bigint
as
    select Id, Email, UserLogin, [Password], ConfirmPassword, CreateDate, UpdateDate
    from dbo.Users
    where Id = @dbId