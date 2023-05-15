CREATE TABLE [dbo].[TansactionDetail] (
    [TransactionId] INT NOT NULL,
    [AlbumId]       INT NOT NULL,
    [Qty]           INT NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionId] ASC, [AlbumId] ASC),
    CONSTRAINT [FK_TansactionDetail_ToAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[Album] ([AlbumId]),
    CONSTRAINT [FK_TansactionDetail_ToTransactionHeader] FOREIGN KEY ([TransactionId]) REFERENCES [dbo].[TransactionHeader] ([TransactionId])
);

