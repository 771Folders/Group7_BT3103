CREATE TABLE [dbo].[Rooms]
(
	[RoomID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [RoomType] VARCHAR(50) NOT NULL, 
    [RoomNumber] INT NOT NULL, 
    [RatePerDay] DECIMAL(10, 2) NOT NULL, 
    [Capacity] INT NOT NULL
)