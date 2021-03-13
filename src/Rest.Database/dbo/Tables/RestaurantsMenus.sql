CREATE TABLE [dbo].[RestaurantsMenus] (
    [IdRestaurantMenu] INT IDENTITY (1, 1) NOT NULL,
    [IdRestaurant]     INT NOT NULL,
    [IdMenu]           INT NOT NULL,
    CONSTRAINT [PK_RestaurantsMenus] PRIMARY KEY CLUSTERED ([IdRestaurantMenu] ASC),
    CONSTRAINT [FK_RestaurantsMenus_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([IdMenu]),
    CONSTRAINT [FK_RestaurantsMenus_Restaurants] FOREIGN KEY ([IdRestaurant]) REFERENCES [dbo].[Restaurants] ([IdRestaurant])
);

