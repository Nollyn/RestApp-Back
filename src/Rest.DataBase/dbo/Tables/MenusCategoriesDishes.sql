CREATE TABLE [dbo].[MenusCategoriesDishes] (
    [IdMenuCategory] INT NOT NULL,
    [IdDish]         INT NOT NULL,
    CONSTRAINT [PK_MenusCategoriesDishes_1] PRIMARY KEY CLUSTERED ([IdMenuCategory] ASC, [IdDish] ASC),
    CONSTRAINT [FK_MenusCategoriesDishes_Dishes] FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dishes] ([Id]),
    CONSTRAINT [FK_MenusCategoriesDishes_MenusCategories] FOREIGN KEY ([IdMenuCategory]) REFERENCES [dbo].[MenusCategories] ([Id])
);

