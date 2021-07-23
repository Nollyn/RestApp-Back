CREATE TABLE [dbo].[MenusOptions] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [IdMenu]   INT NOT NULL,
    [IdOption] INT NOT NULL,
    CONSTRAINT [PK_MenusOptions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MenusOptions_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([Id]),
    CONSTRAINT [FK_MenusOptions_Options] FOREIGN KEY ([IdOption]) REFERENCES [dbo].[Options] ([Id])
);



