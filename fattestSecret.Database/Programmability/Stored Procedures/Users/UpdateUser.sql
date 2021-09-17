create procedure dbo.UpdateUser
@Id bigint,
@Email nvarchar(50),
@UserLogin nvarchar(50),
@Password nvarchar(50),
@ConfirmPassword bit,
@UpdateDate datetime2
as
	update dbo.Users
	set [Email] = @Email, UserLogin = @UserLogin, [Password] = @Password, ConfirmPassword = @ConfirmPassword, UpdateDate = @UpdateDate
	from dbo.Users
	where Id = @Id