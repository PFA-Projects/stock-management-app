ALTER TABLE [dbo].[Deliveries] ALTER COLUMN [DeliveryReceiptNumber] [nvarchar](max) NULL
----------------------------------
DROP TABLE [dbo].[Receivers]
DROP TABLE [dbo].[Senders]
------------------------------------
CREATE TABLE [dbo].[DepartureFiles] (
    [Id] [bigint] NOT NULL IDENTITY,
    [File] [varbinary](max),
    [Reference] [nvarchar](max),
    [Ordre] [int] NOT NULL,
    [DateCreation] [datetime] NOT NULL,
    [DateModification] [datetime] NOT NULL,
    [Departure_Id] [bigint],
    CONSTRAINT [PK_dbo.DepartureFiles] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_Departure_Id] ON [dbo].[DepartureFiles]([Departure_Id])
ALTER TABLE [dbo].[DepartureFiles] ADD CONSTRAINT [FK_dbo.DepartureFiles_dbo.Departures_Departure_Id] FOREIGN KEY ([Departure_Id]) REFERENCES [dbo].[Departures] ([Id])
------------------------------------------------------------------------
CREATE TABLE [dbo].[ArrivalFiles] (
    [Id] [bigint] NOT NULL IDENTITY,
    [File] [varbinary](max),
    [Reference] [nvarchar](max),
    [Ordre] [int] NOT NULL,
    [DateCreation] [datetime] NOT NULL,
    [DateModification] [datetime] NOT NULL,
    [Arrival_Id] [bigint],
    CONSTRAINT [PK_dbo.ArrivalFiles] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_Arrival_Id] ON [dbo].[ArrivalFiles]([Arrival_Id])
ALTER TABLE [dbo].[ArrivalFiles] ADD CONSTRAINT [FK_dbo.ArrivalFiles_dbo.Arrivals_Arrival_Id] FOREIGN KEY ([Arrival_Id]) REFERENCES [dbo].[Arrivals] ([Id])
