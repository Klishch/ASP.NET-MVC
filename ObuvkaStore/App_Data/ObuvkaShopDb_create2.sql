USE [C:\USERS\ВИКТОР\SOURCE\REPOS\OBUVKASHOP\OBUVKASHOP\APP_DATA\OBUVKASHOPDB.MDF]
CREATE TABLE [Products] (
	id integer NOT NULL,
	Name_ua nvarchar(50) NOT NULL,
	Name_ru nvarchar(50) NOT NULL,
	Name_eng nvarchar(50) NOT NULL,
	idPictures integer NOT NULL,
	price float NOT NULL,
  CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ProductsInfo] (
	id integer NOT NULL,
	idColor integer NOT NULL,
	Size float NOT NULL,
	quantity integer NOT NULL,
	availability bit NOT NULL,
	idForWhom integer NOT NULL,
	idCategory integer NOT NULL,
	idProducer integer NOT NULL,
	idSeason integer NOT NULL,
	idMatherial integer NOT NULL,
	idProductDescriptions integer NOT NULL,
	idUsersComments integer NOT NULL,
  CONSTRAINT [PK_PRODUCTSINFO] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Colors] (
	id integer NOT NULL,
	color_ua nvarchar(40) NOT NULL UNIQUE,
	color_ru nvarchar(40) NOT NULL UNIQUE,
	color_eng nvarchar(40) NOT NULL UNIQUE,
  CONSTRAINT [PK_COLORS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Categories] (
	id integer NOT NULL,
	category_ua nvarchar(50) NOT NULL UNIQUE,
	description_ua text NOT NULL,
	category_ru nvarchar(50) NOT NULL UNIQUE,
	description_ru text NOT NULL,
	category_eng nvarchar(50) NOT NULL UNIQUE,
	description_eng text NOT NULL,
  CONSTRAINT [PK_CATEGORIES] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Producers] (
	id integer NOT NULL,
	producerName nvarchar(50) NOT NULL UNIQUE,
	logo text NOT NULL,
	producerCountry_ua nvarchar(50) NOT NULL,
	producerCountry_ru nvarchar(50) NOT NULL,
	producerCountry_eng nvarchar(50) NOT NULL,
  CONSTRAINT [PK_PRODUCERS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Seasons] (
	id integer NOT NULL,
	season_ua nvarchar(50) NOT NULL UNIQUE,
	season_ru nvarchar(50) NOT NULL UNIQUE,
	season_eng nvarchar(50) NOT NULL UNIQUE,
  CONSTRAINT [PK_SEASONS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Matherials] (
	id integer NOT NULL,
	matherial_ua nvarchar(50) NOT NULL UNIQUE,
	matherial_ru nvarchar(50) NOT NULL UNIQUE,
	matherial_eng nvarchar(50) NOT NULL UNIQUE,
  CONSTRAINT [PK_MATHERIALS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Customers] (
	id integer NOT NULL,
	[e-mail] nvarchar NOT NULL UNIQUE,
	phone text NOT NULL,
  CONSTRAINT [PK_CUSTOMERS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [UsersAddress] (
	id integer NOT NULL,
	country nvarchar(50) NOT NULL,
	region nvarchar(50) NOT NULL,
	city nvarchar(50) NOT NULL,
	street nvarchar(70) NOT NULL,
	homeNumb integer NOT NULL,
	flatNumb integer,
	zipCode integer NOT NULL,
  CONSTRAINT [PK_USERSADDRESS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ForWhoms] (
	id integer NOT NULL,
	whom_ua nvarchar(40) NOT NULL UNIQUE,
	whom_ru nvarchar(40) NOT NULL UNIQUE,
	whom_eng nvarchar(40) NOT NULL UNIQUE,
  CONSTRAINT [PK_FORWHOMS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Orders] (
	id integer NOT NULL,
	idCustomer integer NOT NULL,
	orderDate datetime NOT NULL,
	idOrderedProducts integer NOT NULL,
	deliveryCompanyName nvarchar(60) NOT NULL,
	deliveryAdress integer NOT NULL,
	paymentMethod nvarchar(100) NOT NULL,
	orderStatus nvarchar(70) NOT NULL,
  CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [OrderProducts] (
	id integer NOT NULL,
	idOrder integer NOT NULL,
	idProduct integer NOT NULL,
	[count] integer NOT NULL,
	discount float NOT NULL,
	total float NOT NULL,
  CONSTRAINT [PK_ORDERPRODUCTS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ProductsPictures] (
	id integer NOT NULL,
	idProduct integer NOT NULL,
	picture text NOT NULL,
  CONSTRAINT [PK_PRODUCTSPICTURES] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ProductsDescriptions] (
	id integer NOT NULL,
	description_ua text NOT NULL,
	description_ru text NOT NULL,
	description_eng text NOT NULL,
  CONSTRAINT [PK_PRODUCTSDESCRIPTIONS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [UsersInfo] (
	id integer NOT NULL,
	name nvarchar(20),
	surname nvarchar(30),
	picture text NOT NULL DEFAULT 'https://i.pinimg.com/originals/7a/fe/66/7afe66fe7c271112c9ba0ceecc60ec99.png',
	userLanguage nvarchar(50) NOT NULL,
	userStatus nvarchar(50) NOT NULL,
	idAdress text NOT NULL,
	discount float NOT NULL,
  CONSTRAINT [PK_USERSINFO] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [UserComments] (
	id integer NOT NULL,
	idProduct integer NOT NULL,
	idCustomer integer NOT NULL,
	comments text NOT NULL,
  CONSTRAINT [PK_USERCOMMENTS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Products] WITH CHECK ADD CONSTRAINT [Products_fk0] FOREIGN KEY ([id]) REFERENCES [ProductsInfo]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Products] CHECK CONSTRAINT [Products_fk0]
GO
ALTER TABLE [Products] WITH CHECK ADD CONSTRAINT [Products_fk1] FOREIGN KEY ([idPictures]) REFERENCES [ProductsPictures]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Products] CHECK CONSTRAINT [Products_fk1]
GO

ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk0] FOREIGN KEY ([id]) REFERENCES [Products]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk0]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk1] FOREIGN KEY ([idColor]) REFERENCES [Colors]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk1]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk2] FOREIGN KEY ([idForWhom]) REFERENCES [ForWhoms]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk2]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk3] FOREIGN KEY ([idCategory]) REFERENCES [Categories]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk3]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk4] FOREIGN KEY ([idProducer]) REFERENCES [Producers]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk4]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk5] FOREIGN KEY ([idSeason]) REFERENCES [Seasons]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk5]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk6] FOREIGN KEY ([idMatherial]) REFERENCES [Matherials]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk6]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk7] FOREIGN KEY ([idProductDescriptions]) REFERENCES [ProductsDescriptions]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk7]
GO
ALTER TABLE [ProductsInfo] WITH CHECK ADD CONSTRAINT [ProductsInfo_fk8] FOREIGN KEY ([idUsersComments]) REFERENCES [UserComments]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsInfo] CHECK CONSTRAINT [ProductsInfo_fk8]
GO
ALTER TABLE [Customers] WITH CHECK ADD CONSTRAINT [Customers_fk0] FOREIGN KEY ([id]) REFERENCES [UsersInfo]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Customers] CHECK CONSTRAINT [Customers_fk0]
GO
ALTER TABLE [Orders] WITH CHECK ADD CONSTRAINT [Orders_fk0] FOREIGN KEY ([idCustomer]) REFERENCES [Customers]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Orders] CHECK CONSTRAINT [Orders_fk0]
GO
ALTER TABLE [Orders] WITH CHECK ADD CONSTRAINT [Orders_fk1] FOREIGN KEY ([idOrderedProducts]) REFERENCES [OrderProducts]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Orders] CHECK CONSTRAINT [Orders_fk1]
GO
ALTER TABLE [Orders] WITH CHECK ADD CONSTRAINT [Orders_fk2] FOREIGN KEY ([deliveryAdress]) REFERENCES [UsersAddress]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Orders] CHECK CONSTRAINT [Orders_fk2]
GO
ALTER TABLE [OrderProducts] WITH CHECK ADD CONSTRAINT [OrderProducts_fk0] FOREIGN KEY ([idOrder]) REFERENCES [Orders]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [OrderProducts] CHECK CONSTRAINT [OrderProducts_fk0]
GO
ALTER TABLE [OrderProducts] WITH CHECK ADD CONSTRAINT [OrderProducts_fk1] FOREIGN KEY ([idProduct]) REFERENCES [Products]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [OrderProducts] CHECK CONSTRAINT [OrderProducts_fk1]
GO
ALTER TABLE [ProductsPictures] WITH CHECK ADD CONSTRAINT [ProductsPictures_fk0] FOREIGN KEY ([idProduct]) REFERENCES [Products]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsPictures] CHECK CONSTRAINT [ProductsPictures_fk0]
GO
ALTER TABLE [ProductsDescriptions] WITH CHECK ADD CONSTRAINT [ProductsDescriptions_fk0] FOREIGN KEY ([id]) REFERENCES [ProductsInfo]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ProductsDescriptions] CHECK CONSTRAINT [ProductsDescriptions_fk0]
GO
ALTER TABLE [UsersInfo] WITH CHECK ADD CONSTRAINT [UsersInfo_fk0] FOREIGN KEY ([id]) REFERENCES [Customers]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [UsersInfo] CHECK CONSTRAINT [UsersInfo_fk0]
GO
ALTER TABLE [UsersInfo] WITH CHECK ADD CONSTRAINT [UsersInfo_fk1] FOREIGN KEY ([idAdress]) REFERENCES [UsersAddress]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [UsersInfo] CHECK CONSTRAINT [UsersInfo_fk1]
GO
ALTER TABLE [UserComments] WITH CHECK ADD CONSTRAINT [UserComments_fk0] FOREIGN KEY ([idProduct]) REFERENCES [Products]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [UserComments] CHECK CONSTRAINT [UserComments_fk0]
GO
ALTER TABLE [UserComments] WITH CHECK ADD CONSTRAINT [UserComments_fk1] FOREIGN KEY ([idCustomer]) REFERENCES [Customers]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [UserComments] CHECK CONSTRAINT [UserComments_fk1]
GO

