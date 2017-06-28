ALTER TABLE [dbo].[Deliveries] ALTER COLUMN [DeliveryReceiptNumber] [nvarchar](max) NULL
----------------------------------
DROP TABLE [dbo].[Receivers]
DROP TABLE [dbo].[Senders]
------------------------------------
ALTER TABLE [dbo].[Departures] ADD [DepartureFile] [varbinary](max)
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
DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Departures')
AND col_name(parent_object_id, parent_column_id) = 'DepartureFile';
IF @var0 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Departures] DROP CONSTRAINT [' + @var0 + ']')
ALTER TABLE [dbo].[Departures] DROP COLUMN [DepartureFile]
ALTER TABLE [dbo].[DepartureFiles] ADD CONSTRAINT [FK_dbo.DepartureFiles_dbo.Departures_Departure_Id] FOREIGN KEY ([Departure_Id]) REFERENCES [dbo].[Departures] ([Id])