create proc addmember
@name nvarchar(100),
@family nvarchar(100),
@user nvarchar(100),
@pass nvarchar(100),
@tell int,
@email nvarchar(100),
@address nvarchar(100),
@card int,
@userid int,
@usertype nvarchar(100)
as
insert into Table_User(UserType,UserID,UserName,UserPassword,UserTell,UserFirstName,UserLastName,UserEmail,UserAddress,UserCardNumber)
values 
(@usertype,@userid,@user,@pass,@tell,@name,@family,@email,@address,@card)
go
