CREATE TABLE [dbo].[Menus] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (250) NOT NULL,
    [Description]  NVARCHAR (MAX) NULL,
    [DayMenu]      BIT            NOT NULL,
    [Date]         DATE           NULL,
    [IdMenuParent] INT            NULL,
    CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Menus_Menus] FOREIGN KEY ([Id]) REFERENCES [dbo].[Menus] ([Id])
);



