CREATE TABLE [dbo].[logInForm] (
    [Username] VARCHAR (4000) NOT NULL,
    [Password] VARCHAR (50) NULL,
    [Status]   VARCHAR (50) NULL,
    [ProfilePath] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

