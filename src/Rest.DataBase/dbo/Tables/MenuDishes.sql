CREATE TABLE [dbo].[MenuDishes] (
    [IdMenu]     INT          NOT NULL,
    [IdDish]     INT          NOT NULL,
    [IdCategory] INT          NOT NULL,
    [Price]      DECIMAL (18) NOT NULL,
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_MenuDishes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MenuDishes_Categories] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories] ([Id]),
    CONSTRAINT [FK_MenuDishes_Dishes] FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dishes] ([Id]),
    CONSTRAINT [FK_MenuDishes_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([Id])
);

