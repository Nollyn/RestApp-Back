CREATE TABLE [dbo].[DrinksOptions] (
    [IdDrinkOption] INT IDENTITY (1, 1) NOT NULL,
    [IdDrink]       INT NOT NULL,
    [IdOption]      INT NOT NULL,
    CONSTRAINT [PK_DrinksOptions] PRIMARY KEY CLUSTERED ([IdDrinkOption] ASC),
    CONSTRAINT [FK_DrinksOptions_Drinks] FOREIGN KEY ([IdDrink]) REFERENCES [dbo].[Drinks] ([IdDrink]),
    CONSTRAINT [FK_DrinksOptions_Options] FOREIGN KEY ([IdOption]) REFERENCES [dbo].[Options] ([IdOption])
);



