CREATE TABLE [dbo].[tblWithdrawal]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CustomerId] INT NOT NULL,
	[WithdrawalDate] DATETIME NOT NULL,
	[Amount] DECIMAL(20, 2) NOT NULL
)
