CREATE TABLE [dbo].[Orders] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Code]   NVARCHAR (50) NOT NULL,
    [Amount] DECIMAL (18)  NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

