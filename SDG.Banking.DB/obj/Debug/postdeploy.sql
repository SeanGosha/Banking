/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
BEGIN
	INSERT INTO dbo.tblCustomer(Id, SSN, FirstName, LastName, BirthDate)
	VALUES
    (1, '123-45-6789', 'Carl', 'Wheezer', '19800512'),
    (2, '987-65-4321', 'Sheen', 'Estevez', '19850708'),
    (3, '111-11-1111', 'Jimmy', 'Neutron', '19750226')
END
BEGIN
    INSERT INTO dbo.tblDeposit(Id, CustomerId, DepositDate, Amount)
    VALUES
    (1, 1, '20220512', 350),
	(2, 1, '20220524', 500),
	(3, 1, '20220530', 1000),
	(4, 2, '20220517', 100),
	(5, 2, '20220603', 200),
	(6, 2, '20220613', 300),
	(7, 3, '20220822', 1000),
	(8, 3, '20220924', 2000),
	(9, 3, '20221006', 3000)
END
BEGIN
    INSERT INTO dbo.tblWithdrawal (Id, CustomerId, WithdrawalDate, Amount)
    VALUES
    (1, 1, '20220812', 55),
    (2, 1, '20220824', 150),
	(3, 1, '20220830', 200),
	(4, 2, '20220817', 50),
	(5, 2, '20220903', 100),
	(6, 2, '20220913', 75),
	(7, 3, '20221022', 200),
	(8, 3, '20221124', 100),
	(9, 3, '20221206', 185)
END
GO
