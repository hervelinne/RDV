CREATE TABLE [dbo].[secretaire] (
    [secretaire_id] INT          IDENTITY (1, 1) NOT NULL,
    [login]         VARCHAR (50) NULL,
    [mdp]           VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([secretaire_id] ASC)
);

