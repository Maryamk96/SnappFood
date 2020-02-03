Create database SnappFood;

create table Table_User
(
  UserType nvarchar(100) NOT NULL,
  UserID int not null,
  UserName nvarchar(100) not null,
  UserPassword nvarchar(100) not null,
  UserTell int not null,
  UserFirstName nvarchar(100) not null,
  UserLastName nvarchar(100) not null,
  UserEmail nvarchar(100) not null,
  UserAddress nvarchar(100) not null,
  UserCardNumber int not null,
  Primary Key(UserID)
);

create table City
(
  CityID int not null,
  CityName nvarchar(100) not null,
  CityArea nvarchar(100)  not null,
  Primary Key(CityID),
);

create table MallService
(
  MallCourierID int not null,
  MallCityID int not null,
  MallServiceID int not null,
  MallServiceName nvarchar(100) not null,
  RestaurantServiceType nvarchar(100) not null,
  DeliveryTime nvarchar(100) not null,
  DeliveryArea nvarchar(100) not  null,
  Primary Key(MallServiceID),
  Foreign Key(MallCityID) References City(CityID)

);

create table MallServiceAddress
(
  MallServiceAdd nvarchar(100) not null,
  ServiceID int not null,
  Primary Key(MallServiceAdd , ServiceID),
  Foreign Key(ServiceID) References MallService(MallServiceID)
);

create table Restaurant
(
  ServiceID int not null,
  RestaurantManagerID int not null,
  RestaurantManagerName nvarchar(100) not null,
  Primary Key(RestaurantManagerID),
  Foreign Key(ServiceID) References MallService(MallServiceID),
);

create table ResataurantBranch
(
  Branch nvarchar(100) not null,
  ManagerID int  not null,
  Primary Key(Branch , ManagerID),
  Foreign Key(ManagerID) References Restaurant(RestaurantManagerID)
);

create table CoffeeShop
(
  CoffeeShopServiceID int not null,
  CoffeeShopMnanagerID int  not null,
  CafeManName nvarchar(100) not null,
  Primary Key(CoffeeShopMnanagerID),
  Foreign Key(CoffeeShopServiceID) References MallService(MallServiceID)
);

create table SuperMarket
(
  SuperMarketServiceID int not null,
  SuperMarketMnanagerID int  not null,
  SuperMarketMnanagerName nvarchar(100) not null,
  Primary Key(SuperMarketMnanagerID),
  Foreign Key(SuperMarketServiceID) References MallService(MallServiceID)
);

create table Confectionary
(
  ConfectionaryServiceID int not null,
  ConfectionaryMnanagerID int  not null,
  ConfectionaryMnanagerName nvarchar(100) not null,
  Primary Key(ConfectionaryMnanagerID),
  Foreign Key(ConfectionaryServiceID) References MallService(MallServiceID)
);

create table Account
(
  AccountID int not null,
  AccountUserName nvarchar(100)  not null,
  AccountPassword nvarchar(100) not null,
  Primary Key(AccountID),
  Foreign Key(AccountID) References Table_User(UserID)
);

create table AccountType
(
  AccountTypeCode int not null,
  AccountTypeName nvarchar(100)  not null,
  Primary Key(AccountTypeCode),
  Foreign Key(AccountTypeCode) References Account(AccountID)
);

create table Payment
(
  PaymentAccountID int not null,
  CVV2 int not null,
  CardNumber int  not null,
  SecondPassword int not null,
  DateofCard nvarchar(100) not null,
  EmailAddress nvarchar(100) not null,
  Primary Key(CVV2 , CardNumber),
  Foreign Key(PaymentAccountID) References Account(AccountID)
);

create table Courier
(
  CourierID int not null,
  TheMallServiceID int not null,
  Primary Key(CourierID , TheMallServiceID),
  Foreign Key(TheMallServiceID) References MallService(MallServiceID)
);

create table Menu
(
  MenuMallServiceID int not null,
  MenuID int not null,
  ChoiceName nvarchar(100) not null,
  ChoiceType nvarchar(100)  not null,
  ChoicePrice nvarchar(100) not null,
  Primary Key(MenuID),
  Foreign Key(MenuMallServiceID) References MallService(MallServiceID)
);

create table Menu_PreOrder
(
  MenuPreOrderID int not null,
  MenuID int not null,
  Tax nvarchar(100)  not null,
  DeliveryPrice nvarchar(100) not null,
  PayableValue nvarchar(100) not null,
  BasketPrice nvarchar(100) not null,
  PaymentType nvarchar(100) not null,
  Primary Key(MenuPreOrderID , MenuID),
  Foreign Key(MenuID) References Menu(MenuID)
);

create table MenuInfo
(
  MenuInfoID int not null,
  MenuID int not null,
  OpenHours nvarchar(100)  not null,
  MinimumBasket nvarchar(100) not null,
  Primary Key(MenuInfoID , MenuID),
  Foreign Key(MenuID) References Menu(MenuID)
);