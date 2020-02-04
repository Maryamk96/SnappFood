create proc update1
@name nvarchar(100),
@family nvarchar(100),
@user nvarchar(100),
@pass nvarchar(100),
@tell int,
@email nvarchar(100),
@address nvarchar(100),
@card int,

@usertype nvarchar(100)
as
update Table_User set UserType=@usertype,UserName=@user,UserPassword=@pass,UserTell=@tell,UserFirstName=@name,UserLastName=@family,UserEmail=@email,UserAddress=@address,UserCardNumber=@card
go