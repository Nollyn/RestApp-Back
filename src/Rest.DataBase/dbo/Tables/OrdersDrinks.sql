CREATE TABLE [dbo].[OrdersDrinks] (
    [IdOrder] INT NOT NULL,
    [IdDrink] INT NOT NULL,
    CONSTRAINT [PK_OrdersDrinks] PRIMARY KEY CLUSTERED ([IdOrder] ASC, [IdDrink] ASC),
    CONSTRAINT [FK_OrdersDrinks_Drinks] FOREIGN KEY ([IdDrink]) REFERENCES [dbo].[Drinks] ([Id]),
    CONSTRAINT [FK_OrdersDrinks_Orders] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Orders] ([Id])
);

