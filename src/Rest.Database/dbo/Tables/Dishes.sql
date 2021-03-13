CREATE TABLE [dbo].[Dishes] (
    [IdDish]      INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)   NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [IdCategory]  INT             NULL,
    [Price]       DECIMAL (18)    NOT NULL,
    [Image]       VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_Dishes] PRIMARY KEY CLUSTERED ([IdDish] ASC),
    CONSTRAINT [FK_Dishes_Categories] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories] ([IdCategory])
);

