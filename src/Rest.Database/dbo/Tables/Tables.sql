CREATE TABLE [dbo].[Tables] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Code]         NVARCHAR (50)  NOT NULL,
    [IdRestaurant] INT            NOT NULL,
    [QR]           NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Tables] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tables_Restaurants] FOREIGN KEY ([IdRestaurant]) REFERENCES [dbo].[Restaurants] ([Id])
);



