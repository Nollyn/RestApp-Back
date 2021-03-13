CREATE TABLE [dbo].[Options] (
    [IdOption]    INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (250) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [IdMenu]      INT            NOT NULL,
    CONSTRAINT [PK_Options] PRIMARY KEY CLUSTERED ([IdOption] ASC),
    CONSTRAINT [FK_Options_Menus] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[Menus] ([IdMenu])
);



