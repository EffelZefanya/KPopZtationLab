CREATE TABLE [dbo].[Cart] (
    [CustomerId] INT NOT NULL,
    [AlbumId]    INT NOT NULL,
    [Qty]        INT NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC, [AlbumId] ASC),
    CONSTRAINT [FK_Cart_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]),
    CONSTRAINT [FK_Cart_ToAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[Album] ([AlbumId])
);

