create procedure dbo.GetUserByEmail
@Email nvarchar(50)
as
    select Id, Email, UserLogin, [Password], ConfirmPassword, CreateDate, UpdateDate
    from dbo.Users
    where Email = @Email