create procedure dbo.AddUser
@Email nvarchar(50),
@UserLogin nvarchar(50),
@Password nvarchar(50)
as
	insert into dbo.Users (Email, UserLogin, [Password])
	output inserted.Id
	values (@Email, @UserLogin, @Password);