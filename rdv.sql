CREATE TABLE [dbo].[Table]
(
	[rdv_id] INT NOT NULL PRIMARY KEY, 
    [date] NCHAR(10) NULL, 
    [heure] TIME NULL, 
    [medecin_id] INT FOREIGN KEY  REFERENCES [medecin]([medecin_id]), 
    [patient_id] INT FOREIGN KEY  REFERENCES [patient]([patient_id]), 
)
