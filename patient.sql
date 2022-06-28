CREATE TABLE [dbo].[patient] (
    [patient_Id] INT          NOT NULL IDENTITY(1,1),
    [nom]        VARCHAR (50) NULL,
    [prenom]     VARCHAR (50) NULL,
    [email]      VARCHAR (50) NULL,
    [age]        INT          NULL,
    [tel]        INT          NULL,
    [login]      VARCHAR (50) NULL,
    [mdp]        VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([patient_Id] ASC)
);

