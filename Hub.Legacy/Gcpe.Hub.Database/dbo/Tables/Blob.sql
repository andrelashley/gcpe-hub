﻿CREATE TABLE [dbo].[Blob] (
    [Id]   UNIQUEIDENTIFIER NOT NULL,
    [Data] VARBINARY (MAX)  NOT NULL,
    CONSTRAINT [PK_Blob] PRIMARY KEY CLUSTERED ([Id] ASC)
);

