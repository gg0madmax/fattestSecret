﻿create table dbo.DbVersion
(
	Created datetime not null constraint Def_DbVersion_Created default getutcdate(),
	DbVersion nvarchar(8) not null
)