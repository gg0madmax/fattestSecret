create procedure dbo.GetVersion
as
	select DbVersion as [Version]
	from dbo.DbVersion