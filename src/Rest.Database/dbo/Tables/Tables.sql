CREATE TABLE [dbo].[Tables] (
    [IdTable]      INT            IDENTITY (1, 1) NOT NULL,
    [Code]         NVARCHAR (50)  NOT NULL,
    [IdRestaurant] INT            NOT NULL,
    [QR]           NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Tables] PRIMARY KEY CLUSTERED ([IdTable] ASC),
    CONSTRAINT [FK_Tables_Restaurants] FOREIGN KEY ([IdRestaurant]) REFERENCES [dbo].[Restaurants] ([IdRestaurant])
);



