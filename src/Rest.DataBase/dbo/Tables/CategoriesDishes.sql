CREATE TABLE [dbo].[CategoriesDishes] (
    [IdCategoryDish] INT IDENTITY (1, 1) NOT NULL,
    [IdCategory]     INT NOT NULL,
    [IdDish]         INT NOT NULL,
    CONSTRAINT [PK_CategoriesDishes] PRIMARY KEY CLUSTERED ([IdCategoryDish] ASC),
    CONSTRAINT [FK_CategoriesDishes_Categories] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories] ([IdCategory]),
    CONSTRAINT [FK_CategoriesDishes_Dishes] FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dishes] ([IdDish])
);

