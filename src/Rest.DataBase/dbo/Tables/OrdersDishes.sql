CREATE TABLE [dbo].[OrdersDishes] (
    [IdDish]  INT NOT NULL,
    [IdOrder] INT NOT NULL,
    CONSTRAINT [PK_OrdersDishes] PRIMARY KEY CLUSTERED ([IdDish] ASC, [IdOrder] ASC),
    CONSTRAINT [FK_OrdersDishes_Dishes] FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dishes] ([Id]),
    CONSTRAINT [FK_OrdersDishes_Orders] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Orders] ([Id])
);

