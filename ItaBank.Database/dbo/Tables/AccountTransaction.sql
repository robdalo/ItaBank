CREATE TABLE [dbo].[AccountTransaction] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [AccountId] INT             NOT NULL,
    [Code]      NVARCHAR (20)   NOT NULL,
    [Timestamp] DATETIME        NOT NULL,
    [Type]      NVARCHAR (20)   NOT NULL,
    [Amount]    DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_AccountTransaction] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AccountTransaction_Account_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Account] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [IX_AccountTransaction_AccountIdCode]
    ON [dbo].[AccountTransaction]([AccountId] ASC, [Code] ASC);

