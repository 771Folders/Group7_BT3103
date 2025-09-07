Create Table tblUser
(
	UserID INT PRIMARY KEY IDENTITY(1,1),
	Username NVARCHAR(50) NOT NULL,
	Password NVARCHAR(50) NOT NULL,
	Role NVARCHAR(50) NOT NULL
);

INSERT INTO tblUser ([Username], [Password], [Role])
Values ('Doctor', 'pass1', 'Doctor'),
	   ('Nurse', 'pass2', 'Nurse'),
	   ('Admin', 'pass3', 'Admin'),
	   ('Receptionist', 'pass4', 'Receptionist'),
	   ('Cashier', 'pass5', 'Cashier');