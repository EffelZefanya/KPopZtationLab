CREATE TABLE [dbo].[TransactionHeader] (
    [TransactionId]   INT  NOT NULL,
    [TransactionDate] DATE NOT NULL,
    [CustomerId]      INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionId] ASC),
    CONSTRAINT [FK_TransactionHeader_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId])
);

