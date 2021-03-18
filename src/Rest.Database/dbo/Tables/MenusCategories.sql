CREATE TABLE [dbo].[MenusCategories] (
    [IdMenuCategory] INT IDENTITY (1, 1) NOT NULL,
    [IdMenu]         INT NOT NULL,
    [IdCategory]     INT NOT NULL,
    CONSTRAINT [PK_MenusCategories] PRIMARY KEY CLUSTERED ([IdMenuCategory] ASC),
    CONSTRAINT [FK_MenusCategories_Categories] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories] ([IdCategory]),
    CONSTRAINT [FK_MenusCategories_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([IdMenu])
);

