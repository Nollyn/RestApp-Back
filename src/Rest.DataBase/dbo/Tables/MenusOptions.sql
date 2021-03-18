CREATE TABLE [dbo].[MenusOptions] (
    [IdMenuOption] INT IDENTITY (1, 1) NOT NULL,
    [IdMenu]       INT NOT NULL,
    [IdOption]     INT NOT NULL,
    CONSTRAINT [PK_MenusOptions] PRIMARY KEY CLUSTERED ([IdMenuOption] ASC),
    CONSTRAINT [FK_MenusOptions_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([IdMenu]),
    CONSTRAINT [FK_MenusOptions_Options] FOREIGN KEY ([IdOption]) REFERENCES [dbo].[Options] ([IdOption])
);

