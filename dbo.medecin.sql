CREATE TABLE [dbo].[medecin] (
    [medecin_Id] INT           NOT NULL IDENTITY(1,1),
    [nom]        VARCHAR (50)  NULL,
    [prenom]     VARCHAR (50)  NULL,
    [specialite] VARCHAR (50)  NULL,
    [adresse]    VARCHAR (200) NULL,
    [tel]        INT           NULL,
    [login]      VARCHAR (50)  NULL,
    [mdp]        VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([medecin_Id] ASC)
);

