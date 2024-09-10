CREATE DATABASE ClinicDB

use ClinicDB
create table Doctor
(
	Id int primary key identify(1,1),
	FirstName nvarchar(100) not null,
	LastName nvarchar(100) not null
)
