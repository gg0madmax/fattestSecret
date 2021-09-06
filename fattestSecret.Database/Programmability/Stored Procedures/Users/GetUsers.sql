create procedure dbo.GetUsers
as
	select Id, Email, UserLogin, [Password], ConfirmPassword, CreateDate, UpdateDate
	from dbo.Users