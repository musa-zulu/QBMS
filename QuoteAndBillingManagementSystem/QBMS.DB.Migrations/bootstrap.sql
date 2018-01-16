-- bootstrap script for SPAR.Liquor application
-- Please run before attempting to start the application
------ uncomment next few lines if you'd *really* like to recreate the database
-- use master;
-- go
-- ALTER DATABASE  [QBMS]
-- SET SINGLE_USER
-- WITH ROLLBACK IMMEDIATE
-- drop database [QBMS]
-- go
------ normal creation after here
use master;
go
if not exists (select name from master..syslogins where name = 'QBMSWeb')
    begin
        create login LendingLibraryWeb with password = 'P4$$w0rd';
    end;
go


if not exists (select name from master..sysdatabases where name = 'QBMS')
begin
create database QBMS
end;
GO

use QBMS
if not exists (select * from sysusers where name = 'QBMSWeb')
begin
create user QBMSWeb
	for login QBMSWeb
	with default_schema = dbo
end;
GO
grant connect to QBMSWeb
go
exec sp_addrolemember N'db_datareader', N'QBMSWeb';
go
exec sp_addrolemember N'db_datawriter', N'QBMSWeb';
go
exec sp_addrolemember N'db_owner', N'QBMSWeb';
GO
use master;
GO

