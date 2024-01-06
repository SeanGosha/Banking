BEGIN
	INSERT INTO dbo.tblCustomer(Id, SSN, FirstName, LastName, BirthDate)
	VALUES
    (1, '123-45-6789', 'Carl', 'Wheezer', '19800512'),
    (2, '987-65-4321', 'Sheen', 'Estevez', '19850708'),
    (3, '111-11-1111', 'Jimmy', 'Neutron', '19750226')
END