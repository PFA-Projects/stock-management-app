ALTER TABLE [dbo].[Deliveries] ALTER COLUMN [DeliveryReceiptNumber] [nvarchar](max) NULL
----------
DROP TABLE [dbo].[Receivers]
DROP TABLE [dbo].[Senders]
------------
ALTER TABLE [dbo].[Departures] ADD [DepartureFile] [varbinary](max)