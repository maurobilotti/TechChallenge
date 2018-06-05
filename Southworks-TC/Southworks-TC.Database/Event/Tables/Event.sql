CREATE TABLE [Event]
(
	[Id]			INT		NOT NULL IDENTITY (1,1), 
	[Title]			NVARCHAR(250)		NOT NULL, 
	[Technology]	NVARCHAR(250)		NOT NULL, 
	[StartingDate]	DATETIME  NOT NULL   DEFAULT getdate(),
	[RegistrationLink]	NVARCHAR(250)		NULL 
	
	CONSTRAINT [pk_Events] PRIMARY KEY CLUSTERED ([Id] ASC)		
)