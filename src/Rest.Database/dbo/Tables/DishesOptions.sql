CREATE TABLE [dbo].[DishesOptions] (
    [IdDish]   INT NOT NULL,
    [IdOption] INT NOT NULL,
    CONSTRAINT [PK_DishesOptions_1] PRIMARY KEY CLUSTERED ([IdDish] ASC, [IdOption] ASC),
    CONSTRAINT [FK_DishesOptions_Dishes] FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dishes] ([Id]),
    CONSTRAINT [FK_DishesOptions_Options] FOREIGN KEY ([IdOption]) REFERENCES [dbo].[Options] ([Id])
);



