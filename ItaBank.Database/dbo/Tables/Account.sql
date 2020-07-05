CREATE TABLE [dbo].[Account] (
    [Id]      INT             IDENTITY (1, 1) NOT NULL,
    [Code]    NVARCHAR (20)   NOT NULL,
    [Name]    NVARCHAR (100)  NOT NULL,
    [Address] NVARCHAR (255)  NOT NULL,
    [Balance] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Account_Code]
    ON [dbo].[Account]([Code] ASC);

