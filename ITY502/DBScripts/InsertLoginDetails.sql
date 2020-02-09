insert into LoginDetails values(
'TestAdmin',
'TestAdmin',
'Admin'
)
insert into LoginDetails values(
'TestPublic',
'TestPublic',
'Public'
)
insert into LoginDetails values(
'TestEmployee',
'TestEmployee',
'Employee'
)
select * from LoginDetails
update  LoginDetails
set UserName='TestAdmin'
where UserID='TestAdmin'

update  LoginDetails
set UserName='TestPublic'
where UserID='TestPublic'

update  LoginDetails
set UserName='TestEmployee'
where UserID='TestEmployee'
