CREATE TABLE [dbo].[Customer] (
    [CustomerId]      INT           NOT NULL,
    [CustomerName]    VARCHAR (50)  NOT NULL,
    [CustomerEmail]   VARCHAR (50)  NOT NULL,
    [CustomerPasword] VARCHAR (50)  NULL,
    [CustomerGender]  VARCHAR (6)   NULL,
    [CustomerAddress] VARCHAR (100) NULL,
    [CustomerRole]    VARCHAR (5)   NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

