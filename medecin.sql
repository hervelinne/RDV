CREATE TABLE [dbo].[medecin] (
    [medecin_Id] INT           IDENTITY (1, 1) NOT NULL,
    [nom]        VARCHAR (50)  NULL,
    [prenom]     VARCHAR (50)  NULL,
    [specialite] VARCHAR (50)  NULL,
    [adresse]    VARCHAR (200) NULL,
    [tel]        NUMERIC (18)  NULL,
    [login]      VARCHAR (50)  NULL,
    [mdp]        VARCHAR (50)  NULL,
    [ville] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([medecin_Id] ASC)
);

