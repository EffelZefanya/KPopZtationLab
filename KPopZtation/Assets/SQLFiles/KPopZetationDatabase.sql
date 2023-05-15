CREATE TABLE [dbo].[Cart]
(
	[CustomerId] int NOT NULL,
	[AlbumId] int not null,
	[Qty] int not null, 
	PRIMARY KEY (CustomerId, AlbumId),
    CONSTRAINT [FK_Cart_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId]), 
    CONSTRAINT [FK_Cart_ToAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [Album]([AlbumId]),

)
CREATE TABLE [dbo].[Artist]
(
	[ArtistId] int NOT NULL PRIMARY KEY,
	[ArtistName] varchar(50) not null,
	[ArtistImage] varchar(50) not null
)
CREATE TABLE [dbo].[Album]
(
	[AlbumId] int NOT NULL PRIMARY KEY,
	[ArtistId] int not null,
	[AlbumName] varchar(50) not null,
	[AlbumImage] varchar(50) not null,
	[AlbumPrice] int not null,
	[AlbumStock] int not null,
	[AlbumDescription] varchar(255), 
    CONSTRAINT [FK_Album_ToArtist] FOREIGN KEY ([ArtistId]) REFERENCES [Artist]([ArtistId])
)
CREATE TABLE [dbo].[TansactionDetail]
(
	[TransactionId] int NOT NULL,
	[AlbumId] int not null,
	[Qty] int not null, 
	PRIMARY KEY (TransactionId, AlbumId),
    CONSTRAINT [FK_TansactionDetail_ToAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [Album]([AlbumId]), 
    CONSTRAINT [FK_TansactionDetail_ToTransactionHeader] FOREIGN KEY ([TransactionId]) REFERENCES[TransactionHeader]([TransactionId])
)
CREATE TABLE [dbo].[TransactionHeader]
(
	[TransactionId] int NOT NULL PRIMARY KEY,
	[TransactionDate] date not null,
	[CustomerId] int not null, 
    CONSTRAINT [FK_TransactionHeader_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId]) 
)
CREATE TABLE [dbo].[Customer]
(
	[CustomerId] int NOT NULL PRIMARY KEY,
	[CustomerName] varchar(50) NOT NULL,
	[CustomerEmail] varchar(50) NOT NULL, 
    [CustomerPasword] VARCHAR(50) NULL, 
    [CustomerGender] VARCHAR(6) NULL, 
    [CustomerAddress] VARCHAR(100) NULL, 
    [CustomerRole] VARCHAR(5) NULL,
)
