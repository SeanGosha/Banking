CREATE TABLE [dbo].[tblDeposit]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CustomerId] INT NOT NULL,
	[DepositDate] DATETIME NOT NULL,
	[Amount] DECIMAL(20, 2) NOT NULL
)
