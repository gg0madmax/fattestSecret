print N'Begin PostDeployment.'

declare @currentver nvarchar(8)
select @currentver = cast(DbVersion as nvarchar(8)) from dbo.DbVersion

print N'Current version: ' + @currentver

if @currentver is null
begin
	print N'DataBase initial setup...'

	exec dbo.SetDbVersion '20210720'
	set @currentver = '20210720'
end

print N'Set up version: ' + @currentver
update dbo.DbVersion set DbVersion = @currentver, Created = getutcdate()

print N'End PostDeployment.'