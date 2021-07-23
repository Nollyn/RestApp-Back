CREATE TABLE [dbo].[MenusCategories] (
    [IdMenu]     INT NOT NULL,
    [IdCategory] INT NOT NULL,
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_MenusCategories] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MenusCategories_Categories] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories] ([Id]),
    CONSTRAINT [FK_MenusCategories_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([Id])
);



