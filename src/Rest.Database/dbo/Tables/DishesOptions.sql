CREATE TABLE [dbo].[DishesOptions] (
    [IdDishOption] INT IDENTITY (1, 1) NOT NULL,
    [IdDish]       INT NOT NULL,
    [IdOption]     INT NOT NULL,
    CONSTRAINT [PK_DishesOptions] PRIMARY KEY CLUSTERED ([IdDishOption] ASC),
    CONSTRAINT [FK_DishesOptions_Dishes] FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dishes] ([IdDish]),
    CONSTRAINT [FK_DishesOptions_Options] FOREIGN KEY ([IdOption]) REFERENCES [dbo].[Options] ([IdOption])
);



