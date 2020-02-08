create table LoginDetails
(
UserID varchar(50) Primary Key,
Password varchar (50) NOT NULL,
UserType varchar(10) NOT NULL CHECK (UserType IN ('Admin', 'Public','Employee')),
)
