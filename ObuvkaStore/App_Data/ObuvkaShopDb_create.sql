USE [C:\USERS\¬» “Œ–\SOURCE\REPOS\OBUVKASHOP\OBUVKASHOP\APP_DATA\OBUVKASHOPDB.MDF]
CREATE TABLE [dbo].[Products] (
    [id]         INT          NOT NULL,
    [Name_ua]    NVARCHAR (50) NOT NULL,
    [Name_ru]    NVARCHAR (50) NOT NULL,
    [Name_eng]   VARCHAR (50) NOT NULL,
    [idPictures] INT          NOT NULL,
    [price]      FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Products_fk0] FOREIGN KEY ([id]) REFERENCES [dbo].[ProductsInfo] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Products_fk1] FOREIGN KEY ([idPictures]) REFERENCES [dbo].[ProductsPictures] ([id]) ON UPDATE CASCADE
)
GO;
CREATE TABLE [dbo].[ProductsInfo] (
    [id]                    INT        NOT NULL,
    [idColor]               INT        NOT NULL,
    [Size]                  FLOAT (53) NOT NULL,
    [quantity]              INT        NOT NULL,
    [availability]          BIT        NOT NULL,
    [idForWhom]             INT        NOT NULL,
    [idCategory]            INT        NOT NULL,
    [idProducer]            INT        NOT NULL,
    [idSeason]              INT        NOT NULL,
    [idMatherial]           INT        NOT NULL,
    [idProductDescriptions] INT        NOT NULL,
    [idUsersComments]       INT        NOT NULL,
    CONSTRAINT [PK_PRODUCTSINFO] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [ProductsInfo_fk1] FOREIGN KEY ([idColor]) REFERENCES [dbo].[Colors] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk2] FOREIGN KEY ([idForWhom]) REFERENCES [dbo].[ForWhoms] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk3] FOREIGN KEY ([idCategory]) REFERENCES [dbo].[Categories] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk4] FOREIGN KEY ([idProducer]) REFERENCES [dbo].[Producers] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk5] FOREIGN KEY ([idSeason]) REFERENCES [dbo].[Seasons] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk6] FOREIGN KEY ([idMatherial]) REFERENCES [dbo].[Matherials] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk7] FOREIGN KEY ([idProductDescriptions]) REFERENCES [dbo].[ProductsDescriptions] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk8] FOREIGN KEY ([idUsersComments]) REFERENCES [dbo].[UserComments] ([id]) ON UPDATE CASCADE
)
GO;
CREATE TABLE [dbo].[Colors] (
    [id]        INT          NOT NULL,
    [color_ua]  NVARCHAR (40) NOT NULL,
    [color_ru]  NVARCHAR (40) NOT NULL,
    [color_eng] NVARCHAR (40) NOT NULL,
    CONSTRAINT [PK_COLORS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([color_eng] ASC),
    UNIQUE NONCLUSTERED ([color_ru] ASC),
    UNIQUE NONCLUSTERED ([color_ua] ASC)
)
GO;
CREATE TABLE [dbo].[Categories] (
    [id]              INT          NOT NULL,
    [category_ua]     NVARCHAR (50) NOT NULL,
    [description_ua]  TEXT         NULL,
    [category_ru]     NVARCHAR (50) NOT NULL,
    [description_ru]  TEXT         NULL,
    [category_eng]    NVARCHAR (50) NOT NULL,
    [description_eng] TEXT         NULL,
    UNIQUE NONCLUSTERED ([category_eng] ASC),
    UNIQUE NONCLUSTERED ([category_ru] ASC),
    UNIQUE NONCLUSTERED ([category_ua] ASC),
    CONSTRAINT [PK_CATEGORIES] PRIMARY KEY CLUSTERED ([id] ASC)
)
GO;
CREATE TABLE [dbo].[Producers] (
    [id]                  INT          NOT NULL,
    [producerName]        NVARCHAR (50) NOT NULL,
    [logo]                TEXT         NULL,
    [producerCountry_ua]  NVARCHAR (50) NOT NULL,
    [producerCountry_ru]  NVARCHAR (50) NOT NULL,
    [producerCountry_eng] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_PRODUCERS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([producerName] ASC)
)
GO;
CREATE TABLE [dbo].[Seasons] (
    [id]         INT          NOT NULL,
    [season_ua]  NVARCHAR (50) NOT NULL,
    [season_ru]  NVARCHAR (50) NOT NULL,
    [season_eng] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SEASONS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([season_eng] ASC),
    UNIQUE NONCLUSTERED ([season_ru] ASC),
    UNIQUE NONCLUSTERED ([season_ua] ASC)
)
GO;
CREATE TABLE [dbo].[Matherials] (
    [id]            INT          NOT NULL,
    [matherial_ua]  NVARCHAR (50) NOT NULL,
    [matherial_ru]  NVARCHAR (50) NOT NULL,
    [matherial_eng] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MATHERIALS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([matherial_eng] ASC),
    UNIQUE NONCLUSTERED ([matherial_ru] ASC),
    UNIQUE NONCLUSTERED ([matherial_ua] ASC)
)
GO;
CREATE TABLE [dbo].[Customers] (
    [id]     INT         NOT NULL,
    [e-mail] VARCHAR (25) NOT NULL,
    [phone]  TEXT        NOT NULL,
    CONSTRAINT [PK_CUSTOMERS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([e-mail] ASC),
    CONSTRAINT [Customers_fk0] FOREIGN KEY ([id]) REFERENCES [dbo].[UsersInfo] ([id]) ON UPDATE CASCADE
)
GO;
CREATE TABLE [dbo].[UsersAddress] (
    [id]       INT          NOT NULL,
    [country]  NVARCHAR (50) NOT NULL,
    [region]   NVARCHAR (50) NOT NULL,
    [city]     NVARCHAR (50) NOT NULL,
    [street]   NVARCHAR (70) NOT NULL,
    [homeNumb] INT          NOT NULL,
    [flatNumb] INT          NULL,
    [zipCode]  INT          NOT NULL,
    CONSTRAINT [PK_USERSADDRESS] PRIMARY KEY CLUSTERED ([id] ASC)
)
GO;
CREATE TABLE [dbo].[ForWhoms] (
    [id]       INT          NOT NULL,
    [whom_ua]  NVARCHAR (40) NOT NULL,
    [whom_ru]  NVARCHAR (40) NOT NULL,
    [whom_eng] VARCHAR (40) NOT NULL,
    CONSTRAINT [PK_FORWHOMS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([whom_eng] ASC),
    UNIQUE NONCLUSTERED ([whom_ru] ASC),
    UNIQUE NONCLUSTERED ([whom_ua] ASC)
)
GO;
CREATE TABLE [dbo].[Orders] (
    [id]                  INT           NOT NULL,
    [idCustomer]          INT           NOT NULL,
    [orderDate]           DATETIME      NOT NULL,
    [idOrderedProducts]   INT           NOT NULL,
    [deliveryCompanyName] NVARCHAR (60)  NOT NULL,
    [deliveryAdress]      INT           NOT NULL,
    [paymentMethod]       NVARCHAR (100) NOT NULL,
    [orderStatus]         NVARCHAR (70)  NOT NULL,
    CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Orders_fk0] FOREIGN KEY ([idCustomer]) REFERENCES [dbo].[Customers] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Orders_fk1] FOREIGN KEY ([idOrderedProducts]) REFERENCES [dbo].[OrderProducts] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Orders_fk2] FOREIGN KEY ([deliveryAdress]) REFERENCES [dbo].[UsersAddress] ([id]) ON UPDATE CASCADE
)
GO;
CREATE TABLE [dbo].[OrderProducts] (
    [id]        INT        NOT NULL,
    [idOrder]   INT        NOT NULL,
    [idProduct] INT        NOT NULL,
    [count]     INT        NOT NULL,
    [discount]  FLOAT (53) NULL,
    [total]     FLOAT (53) NOT NULL,
    CONSTRAINT [PK_ORDERPRODUCTS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [OrderProducts_fk1] FOREIGN KEY ([idProduct]) REFERENCES [dbo].[Products] ([id]) ON UPDATE CASCADE
)
GO;
CREATE TABLE [dbo].[ProductsPictures] (
    [id]        INT  NOT NULL,
    [idProduct] INT  NOT NULL,
    [picture]   TEXT NOT NULL,
    CONSTRAINT [PK_PRODUCTSPICTURES] PRIMARY KEY CLUSTERED ([id] ASC)
)
GO;
CREATE TABLE [dbo].[ProductsDescriptions] (
    [id]              INT  NOT NULL,
    [description_ua]  TEXT NOT NULL,
    [description_ru]  TEXT NOT NULL,
    [description_eng] TEXT NOT NULL,
    CONSTRAINT [PK_PRODUCTSDESCRIPTIONS] PRIMARY KEY CLUSTERED ([id] ASC)
)
GO;
CREATE TABLE [dbo].[UsersInfo] (
    [id]           INT          NOT NULL,
    [name]         NVARCHAR (20) NULL,
    [surname]      NVARCHAR (30) NULL,
    [picture]      TEXT         DEFAULT ('https://i.pinimg.com/originals/7a/fe/66/7afe66fe7c271112c9ba0ceecc60ec99.png') NOT NULL,
    [userLanguage] NVARCHAR (50) NOT NULL,
    [userStatus]   NVARCHAR (50) NOT NULL,
    [idAdress]     TEXT         NOT NULL,
    [discount]     FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_USERSINFO] PRIMARY KEY CLUSTERED ([id] ASC)
)
GO;
CREATE TABLE [dbo].[UserComments] (
    [id]         INT  NOT NULL,
    [idProduct]  INT  NOT NULL,
    [idCustomer] INT  NOT NULL,
    [comments]   TEXT NOT NULL,
    CONSTRAINT [PK_USERCOMMENTS] PRIMARY KEY CLUSTERED ([id] ASC)
)
GO;

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

