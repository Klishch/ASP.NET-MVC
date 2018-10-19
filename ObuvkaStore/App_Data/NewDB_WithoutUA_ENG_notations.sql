CREATE TABLE [dbo].[Categories] (
    [id]              INT           IDENTITY (1, 1) NOT NULL,
    [category_name]     NVARCHAR (50) NOT NULL,
    [description]  TEXT          NULL,
    CONSTRAINT [PK_CATEGORIES] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([category_name] ASC)
);
CREATE TABLE [dbo].[Colors] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [color_name]  NVARCHAR (40) NOT NULL,
    CONSTRAINT [PK_COLORS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED (color_name ASC)
);
CREATE TABLE [dbo].[Customers] (
    [id]     INT          NOT NULL,
    [e-mail] VARCHAR (25) NOT NULL,
    [phone]  TEXT         NOT NULL,
    UNIQUE NONCLUSTERED ([e-mail] ASC),
    CONSTRAINT [PK_CUSTOMERS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Customers_fk0] FOREIGN KEY ([id]) REFERENCES [dbo].[UsersInfo] ([id]) ON UPDATE CASCADE
);
CREATE TABLE [dbo].[ForWhoms] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [whom]  NVARCHAR (40) NOT NULL,
    CONSTRAINT [PK_FORWHOMS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([whom] ASC)
	);
CREATE TABLE [dbo].[Matherials] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [matherial]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MATHERIALS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([matherial] ASC)
);
CREATE TABLE [dbo].[OrderProducts] (
    [id]        INT        IDENTITY (1, 1) NOT NULL,
    [idOrder]   INT        NOT NULL,
    [idProduct] INT        NOT NULL,
    [count]     INT        NOT NULL,
    [discount]  FLOAT (53) NULL,
    [total]     FLOAT (53) NOT NULL,
    CONSTRAINT [PK_ORDERPRODUCTS] PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [OrderProducts_fk1] FOREIGN KEY ([idOrder]) REFERENCES [dbo].[Orders] ([id]) ON UPDATE CASCADE,
	CONSTRAINT [OrderProducts_fk2] FOREIGN KEY ([idProduct]) REFERENCES [dbo].[Products] ([id]) ON UPDATE CASCADE
);
CREATE TABLE [dbo].[Orders] (
    [id]                  INT            IDENTITY (1, 1) NOT NULL,
    [idCustomer]          INT            NOT NULL,
    [orderDate]           DATETIME       NOT NULL,
    [idOrderedProducts]   INT            NOT NULL,
    [deliveryCompanyName] NVARCHAR (60)  NOT NULL,
    [deliveryAdress]      INT            NOT NULL,
    [paymentMethod]       NVARCHAR (100) NOT NULL,
    [orderStatus]         NVARCHAR (70)  NOT NULL,
    CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Orders_fk0] FOREIGN KEY ([idCustomer]) REFERENCES [dbo].[Customers] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Orders_fk2] FOREIGN KEY ([deliveryAdress]) REFERENCES [dbo].[UsersAddress] ([id]) ON UPDATE CASCADE
);
CREATE TABLE [dbo].[Producers] (
    [id]                  INT           IDENTITY (1, 1) NOT NULL,
    [producerName]        NVARCHAR (50) NOT NULL,
    [logo]                TEXT          NULL,
    [producerCountry]  NVARCHAR (50)  NULL,
    CONSTRAINT [PK_PRODUCERS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([producerName] ASC)
);
CREATE TABLE [dbo].[Products] (
    [id]       INT           NOT NULL,
    [name]  NVARCHAR (50) NOT NULL,
    [price]    FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Products_fk0] FOREIGN KEY ([id]) REFERENCES [dbo].[ProductsInfo] ([id]) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE [dbo].[ProductsDescriptions] (
    [id]              INT  IDENTITY (1, 1) NOT NULL,
    [description]  TEXT NULL,
    CONSTRAINT [PK_PRODUCTSDESCRIPTIONS] PRIMARY KEY CLUSTERED ([id] ASC)
);
CREATE TABLE [dbo].[ProductsInfo] (
    [id]                    INT IDENTITY (1, 1) NOT NULL,
    [idColor]               INT NOT NULL,
    [availability]          BIT NOT NULL,
    [idForWhom]             INT NOT NULL,
    [idCategory]            INT NOT NULL,
    [idProducer]            INT NOT NULL,
    [idSeason]              INT NOT NULL,
    [idMatherial]           INT NOT NULL,
    [idProductDescriptions] INT NOT NULL,
    CONSTRAINT [PK_PRODUCTSINFO] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [ProductsInfo_fk1] FOREIGN KEY ([idColor]) REFERENCES [dbo].[Colors] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk2] FOREIGN KEY ([idForWhom]) REFERENCES [dbo].[ForWhoms] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk3] FOREIGN KEY ([idCategory]) REFERENCES [dbo].[Categories] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk4] FOREIGN KEY ([idProducer]) REFERENCES [dbo].[Producers] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk5] FOREIGN KEY ([idSeason]) REFERENCES [dbo].[Seasons] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk6] FOREIGN KEY ([idMatherial]) REFERENCES [dbo].[MatherialS] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [ProductsInfo_fk7] FOREIGN KEY ([idProductDescriptions]) REFERENCES [dbo].[ProductSDescriptions] ([id]) ON UPDATE CASCADE
);
CREATE TABLE [dbo].[ProductSizes] (
    [id]        INT        IDENTITY (1, 1) NOT NULL,
	[idProduct] INT        NOT NULL,
    [size]      FLOAT (53) NOT NULL,
    [quantity]  INT        NOT NULL,
    CONSTRAINT [PK_dbo.ProductSizes] PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [ProductSizes_fk1] FOREIGN KEY ([idProduct]) REFERENCES [dbo].[Products] ([id]) ON UPDATE CASCADE
);
CREATE TABLE [dbo].[ProductsPictures] (
    [id]        INT  IDENTITY (1, 1) NOT NULL,
    [idProduct] INT  NOT NULL,
    [picture]   TEXT NULL,
    CONSTRAINT [PK_dbo.ProductsPictures] PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [ProductsPictures_fk1] FOREIGN KEY ([idProduct]) REFERENCES [dbo].[Products] ([id]) ON UPDATE CASCADE 
);
CREATE TABLE [dbo].[Seasons] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [season]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SEASONS] PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([season] ASC)
);
CREATE TABLE [dbo].[UserComments] (
    [idProduct]  INT  NOT NULL,
    [idCustomer] INT  NOT NULL,
    [comments]   TEXT NOT NULL,
    CONSTRAINT [UserComments_fk1] FOREIGN KEY ([idProduct]) REFERENCES [dbo].[Products] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [UserComments_fk2] FOREIGN KEY ([idCustomer]) REFERENCES [dbo].[Customers] ([id]) ON UPDATE CASCADE
);
CREATE TABLE [dbo].[UsersAddress] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [country]  NVARCHAR (50) NOT NULL,
    [region]   NVARCHAR (50) NOT NULL,
    [city]     NVARCHAR (50) NOT NULL,
    [street]   NVARCHAR (70) NOT NULL,
    [homeNumb] INT           NOT NULL,
    [flatNumb] INT           NULL,
    [zipCode]  INT           NOT NULL,
    CONSTRAINT [PK_USERSADDRESS] PRIMARY KEY CLUSTERED ([id] ASC)
);
CREATE TABLE [dbo].[UsersInfo] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [name]         NVARCHAR (20) NOT NULL,
    [surname]      NVARCHAR (30) NOT NULL,
    [picture]      TEXT          DEFAULT ('https://i.pinimg.com/originals/7a/fe/66/7afe66fe7c271112c9ba0ceecc60ec99.png') NOT NULL,
    [userLanguage] NVARCHAR (50) NULL,
    [userStatus]   NVARCHAR (50) NULL,
    [idAdress]     INT          NOT NULL,
    [discount]     FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_USERSINFO] PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [UsersInfo_fk2] FOREIGN KEY ([idAdress]) REFERENCES [dbo].[UsersAddress] ([id]) ON UPDATE CASCADE
);
