CREATE TABLE [dbo].[DrinksOptions] (
    [IdDrink]  INT NOT NULL,
    [IdOption] INT NOT NULL,
    CONSTRAINT [PK_DrinksOptions_1] PRIMARY KEY CLUSTERED ([IdDrink] ASC, [IdOption] ASC),
    CONSTRAINT [FK_DrinksOptions_Drinks] FOREIGN KEY ([IdDrink]) REFERENCES [dbo].[Drinks] ([Id]),
    CONSTRAINT [FK_DrinksOptions_Options] FOREIGN KEY ([IdOption]) REFERENCES [dbo].[Options] ([Id])
);



