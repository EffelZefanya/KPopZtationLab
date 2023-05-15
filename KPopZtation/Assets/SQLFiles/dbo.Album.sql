CREATE TABLE [dbo].[Album] (
    [AlbumId]          INT           NOT NULL,
    [ArtistId]         INT           NOT NULL,
    [AlbumName]        VARCHAR (50)  NOT NULL,
    [AlbumImage]       VARCHAR (50)  NOT NULL,
    [AlbumPrice]       INT           NOT NULL,
    [AlbumStock]       INT           NOT NULL,
    [AlbumDescription] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([AlbumId] ASC),
    CONSTRAINT [FK_Album_ToArtist] FOREIGN KEY ([ArtistId]) REFERENCES [dbo].[Artist] ([ArtistId])
);

