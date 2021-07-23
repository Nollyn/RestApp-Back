CREATE TABLE [dbo].[Drinks] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)   NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [Price]       DECIMAL (18)    NOT NULL,
    [Image]       VARBINARY (MAX) NULL,
    CONSTRAINT [PK_Drinks] PRIMARY KEY CLUSTERED ([Id] ASC)
);



