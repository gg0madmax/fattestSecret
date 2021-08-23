create procedure dbo.SetDbVersion
@dbVersion nvarchar(8)
as
	delete from dbo.DbVersion;
	insert into dbo.DbVersion(DbVersion, Created)
	select @dbVersion, getutcdate();
return 0