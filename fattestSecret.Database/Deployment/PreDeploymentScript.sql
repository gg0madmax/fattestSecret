if exists(select 1 from master.dbo.sysdatabases where name = N'$(DatabaseName)'
and exists(select 1 from sys.objects where Name = 'DbVersion' and type = 'U'))
begin

	print N'Begin PreDeployment.'

	declare @currentver nvarchar(8)
	select @currentver = cast(DbVersion as nvarchar(8)) from dbo.DbVersion
	
	print N'Current version:' + @currentver

	print N'End PreDeployment.'

end