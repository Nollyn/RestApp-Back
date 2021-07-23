CREATE TABLE [dbo].[RestaurantsMenus] (
    [IdRestaurant] INT NOT NULL,
    [IdMenu]       INT NOT NULL,
    CONSTRAINT [PK_RestaurantsMenus_1] PRIMARY KEY CLUSTERED ([IdRestaurant] ASC, [IdMenu] ASC),
    CONSTRAINT [FK_RestaurantsMenus_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([Id]),
    CONSTRAINT [FK_RestaurantsMenus_Restaurants] FOREIGN KEY ([IdRestaurant]) REFERENCES [dbo].[Restaurants] ([Id])
);



