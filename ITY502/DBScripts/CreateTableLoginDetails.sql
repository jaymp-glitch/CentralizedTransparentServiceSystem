create table LoginDetails
(
UserID varchar(50) Primary Key,
Password varchar (50) NOT NULL,
UserType varchar(10) NOT NULL CHECK (UserType IN ('Admin', 'Public','Employee')),
)
alter table LoginDetails
add UserName varchar(50) 

alter table LoginDetails
alter column UserName varchar(50)  NOT NULL