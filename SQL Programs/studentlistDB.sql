create table studentlist 
(
[ID] INT NOT NULL PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NULL,
[Address] NVARCHAR(50) NULL,
[Mobno] Int Null
)

ALTER TABLE studentlist
ADD Mobno varchar(50);

ALTER TABLE studentlist
ALTER COLUMN Mobno NVARCHAR(50);

select * from studentlist


