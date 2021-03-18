CREATE TABLE [dbo].[Extras] (
    [IdExtra]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (250) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [IdCategory]  INT            NOT NULL,
    CONSTRAINT [PK_Extras] PRIMARY KEY CLUSTERED ([IdExtra] ASC),
    CONSTRAINT [FK_Extras_Categories] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories] ([IdCategory])
);

