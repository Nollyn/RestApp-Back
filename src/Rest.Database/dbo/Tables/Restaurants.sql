CREATE TABLE [dbo].[Restaurants] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (250) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Address]     NVARCHAR (MAX) NOT NULL,
    [Phone]       NVARCHAR (50)  NOT NULL,
    [NIF]         NVARCHAR (50)  NOT NULL,
    [PostalCode]  NVARCHAR (50)  NOT NULL,
    [City]        NVARCHAR (50)  NOT NULL,
    [Country]     NVARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Restaurants] PRIMARY KEY CLUSTERED ([Id] ASC)
);



