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
INSERT INTO [dbo].[Patients] 
(FirstName, LastName, MiddleName, DateOfBirth, Gender, Phone, Address, Email, EmergencyContact, EmergencyContactPhone) VALUES
('Liam', 'Turner', 'Robert', '1970-05-15', 'Male', '123-456-7890', '123 Oak St, Cityville, CA', 'liam.t@email.com', 'Sarah Turner', '321-654-0987'),
('Olivia', 'Carter', 'Marie', '1957-08-20', 'Female', '234-567-8901', '456 Pine Ave, Townsville, CA', 'olivia.c@email.com', 'James Carter', '432-765-1098'),
('Noah', 'Williams', 'Andrew', '1983-02-10', 'Male', '345-678-9012', '789 Elm Blvd, Villageton, CA', 'noah.w@email.com', 'Emily Williams', '543-876-2109'),
('Emma', 'Davis', 'Louise', '1994-11-25', 'Female', '456-789-0123', '101 Maple Dr, Cityburg, CA', 'emma.d@email.com', 'David Davis', '654-987-3210'),
('Mason', 'Miller', 'James', '1948-03-05', 'Male', '567-890-1234', '202 Birch Rd, Countyton, CA', 'mason.m@email.com', 'Linda Miller', '765-098-4321'),
('Isabella', 'Wilson', 'Kate', '2001-09-08', 'Female', '678-901-2345', '303 Cedar Ln, Metropolis, CA', 'isabella.w@email.com', 'Maria Wilson', '876-109-5432'),
('Sophia', 'Moore', 'Bethany', '1967-04-12', 'Female', '789-012-3456', '404 Spruce Ct, Hometowne, CA', 'sophia.m@email.com', 'Robert Moore', '987-210-6543'),
('Jacob', 'Taylor', 'Samuel', '1959-07-30', 'Male', '890-123-4567', '505 Willow St, Sunnyside, CA', 'jacob.t@email.com', 'Jessica Taylor', '210-321-7654'),
('Ava', 'Anderson', 'Danielle', '2006-01-18', 'Female', '901-234-5678', '606 Ash St, Riverdale, CA', 'ava.a@email.com', 'Chris Anderson', '321-432-8765'),
('William', 'Thomas', 'Patrick', '1945-12-01', 'Male', '012-345-6789', '707 Poplar Ln, Lakeland, CA', 'william.t@email.com', 'Susan Thomas', '432-543-9876'),
('Charlotte', 'Jackson', 'Grace', '1976-10-22', 'Female', '123-111-2222', '808 Cherry Dr, Meadowville, CA', 'charlotte.j@email.com', 'Thomas Jackson', '543-654-0987'),
('James', 'White', 'Oliver', '1972-06-03', 'Male', '234-222-3333', '909 Palm St, Hilltop, CA', 'james.w@email.com', 'Patricia White', '654-765-1098'),
('Amelia', 'Harris', 'Elizabeth', '1996-03-17', 'Female', '345-333-4444', '111 Sycamore Ave, Seaside, CA', 'amelia.h@email.com', 'Michael Harris', '765-876-2109'),
('Benjamin', 'Clark', 'Francis', '1954-09-09', 'Male', '456-444-5555', '222 Walnut Rd, Forestville, CA', 'benjamin.c@email.com', 'Jennifer Clark', '876-987-3210'),
('Mia', 'Lewis', 'Theresa', '1962-08-01', 'Female', '567-555-6666', '333 Oakwood St, Lakeside, CA', 'mia.l@email.com', 'Daniel Lewis', '987-098-4321'),
('Elijah', 'Hall', 'Christopher', '1987-04-28', 'Male', '678-666-7777', '444 Pinecone Dr, Greenfield, CA', 'elijah.h@email.com', 'Sarah Hall', '210-109-5432'),
('Harper', 'Young', 'Diana', '1998-07-06', 'Female', '789-777-8888', '555 Evergreen Ln, Mountainview, CA', 'harper.y@email.com', 'Mark Young', '321-210-6543'),
('Lucas', 'King', 'Victor', '1966-02-14', 'Male', '890-888-9999', '666 Redwood St, Bayside, CA', 'lucas.k@email.com', 'Lisa King', '432-321-7654'),
('Evelyn', 'Scott', 'Paige', '1947-05-29', 'Female', '901-999-0000', '777 Fir Ave, Parkdale, CA', 'evelyn.s@email.com', 'John Scott', '543-432-8765'),
('Logan', 'Green', 'Nathaniel', '1978-01-21', 'Male', '012-000-1111', '888 Willow Rd, Lakeview, CA', 'logan.g@email.com', 'Amanda Green', '654-543-9876'),
('Abigail', 'Baker', 'Hannah', '1991-10-10', 'Female', '123-111-2222', '999 Spruce Ct, Riverton, CA', 'abigail.b@email.com', 'Chris Baker', '765-654-0987'),
('Alexander', 'Adams', 'Joseph', '1965-03-19', 'Male', '234-222-3333', '100 Poplar Blvd, Seaside, CA', 'alexander.a@email.com', 'Jessica Adams', '876-765-1098'),
('Ella', 'Nelson', 'Katherine', '1974-08-05', 'Female', '345-333-4444', '200 Oakwood Dr, Forestville, CA', 'ella.n@email.com', 'Paul Nelson', '987-876-2109'),
('Daniel', 'Hill', 'Matthew', '1961-09-13', 'Male', '456-444-5555', '300 Pinecone Ln, Greenfield, CA', 'daniel.h@email.com', 'Laura Hill', '210-987-3210'),
('Scarlett', 'Ramirez', 'Rose', '1943-02-28', 'Female', '567-555-6666', '400 Evergreen St, Mountainview, CA', 'scarlett.r@email.com', 'Maria Ramirez', '321-098-4321'),
('Henry', 'Foster', 'George', '1984-11-03', 'Male', '678-666-7777', '500 Redwood Ave, Bayside, CA', 'henry.f@email.com', 'Lisa Foster', '432-109-5432'),
('Grace', 'Wood', 'Taylor', '1989-06-27', 'Female', '789-777-8888', '600 Fir Rd, Parkdale, CA', 'grace.w@email.com', 'David Wood', '543-210-6543'),
('Jackson', 'Ward', 'Peter', '1969-07-09', 'Male', '890-888-9999', '700 Willow Dr, Lakeview, CA', 'jackson.w@email.com', 'Nancy Ward', '654-321-7654'),
('Lily', 'Cook', 'Sophia', '1955-04-14', 'Female', '901-999-0000', '800 Spruce St, Riverton, CA', 'lily.c@email.com', 'Michael Cook', '765-432-8765'),
('Sebastian', 'Cox', 'Anthony', '2003-09-20', 'Male', '012-000-1111', '900 Poplar Ave, Seaside, CA', 'sebastian.c@email.com', 'John Cox', '876-543-9876'),
('Avery', 'Phillips', 'Claire', '1981-01-30', 'Female', '123-111-2222', '110 Oakwood Rd, Forestville, CA', 'avery.p@email.com', 'Sarah Phillips', '987-654-0987'),
('Gabriel', 'Rogers', 'Henry', '1958-05-22', 'Male', '234-222-3333', '220 Pinecone Dr, Greenfield, CA', 'gabriel.r@email.com', 'Rebecca Rogers', '210-765-1098'),
('Chloe', 'Morgan', 'Lauren', '1975-12-08', 'Female', '345-333-4444', '330 Evergreen St, Mountainview, CA', 'chloe.m@email.com', 'Paul Morgan', '321-876-2109'),
('Carter', 'Reed', 'Jonathan', '1999-02-18', 'Male', '456-444-5555', '440 Redwood Ave, Bayside, CA', 'carter.r@email.com', 'Jennifer Reed', '432-987-3210'),
('Layla', 'Gray', 'Sophia', '1986-08-03', 'Female', '567-555-6666', '550 Fir Rd, Parkdale, CA', 'layla.g@email.com', 'Thomas Gray', '543-098-4321'),
('Owen', 'Hughes', 'Richard', '1952-07-25', 'Male', '678-666-7777', '660 Willow Dr, Lakeview, CA', 'owen.h@email.com', 'Susan Hughes', '654-109-5432'),
('Zoe', 'Butler', 'Emily', '1995-04-04', 'Female', '789-777-8888', '770 Spruce St, Riverton, CA', 'zoe.b@email.com', 'Chris Butler', '765-210-6543'),
('Wyatt', 'Cooper', 'David', '1964-10-11', 'Male', '890-888-9999', '880 Poplar Ave, Seaside, CA', 'wyatt.c@email.com', 'Lisa Cooper', '876-321-7654'),
('Victoria', 'Richardson', 'Marie', '1971-03-23', 'Female', '901-999-0000', '990 Oakwood Rd, Forestville, CA', 'victoria.r@email.com', 'David Richardson', '987-432-8765'),
('Jack', 'Price', 'Benjamin', '1977-09-07', 'Male', '012-000-1111', '101 Pinecone Dr, Greenfield, CA', 'jack.p@email.com', 'Mary Price', '210-543-9876'),
('Hannah', 'Mitchell', 'Sophia', '1960-12-21', 'Female', '123-111-2222', '202 Evergreen St, Mountainview, CA', 'hannah.m@email.com', 'Robert Mitchell', '321-654-0987'),
('Luke', 'Bell', 'Alexander', '2000-06-02', 'Male', '234-222-3333', '303 Redwood Ave, Bayside, CA', 'luke.b@email.com', 'Jessica Bell', '432-765-1098'),
('Natalie', 'Rodriguez', 'Faith', '1949-01-29', 'Female', '345-333-4444', '404 Fir Rd, Parkdale, CA', 'natalie.r@email.com', 'Thomas Rodriguez', '543-876-2109'),
('Isaac', 'Watson', 'Leonard', '1990-11-16', 'Male', '456-444-5555', '505 Willow Dr, Lakeview, CA', 'isaac.w@email.com', 'Susan Watson', '654-987-3210'),
('Madison', 'Evans', 'Claire', '1968-04-24', 'Female', '567-555-6666', '606 Spruce St, Riverton, CA', 'madison.e@email.com', 'Chris Evans', '765-098-4321'),
('Leo', 'Bennett', 'Gregory', '1956-08-11', 'Male', '678-666-7777', '707 Poplar Ave, Seaside, CA', 'leo.b@email.com', 'Nancy Bennett', '876-109-5432'),
('Aubrey', 'Perry', 'Jane', '1979-05-26', 'Female', '789-777-8888', '808 Oakwood Rd, Forestville, CA', 'aubrey.p@email.com', 'Paul Perry', '987-210-6543'),
('Julian', 'Rivera', 'Kyle', '1953-09-19', 'Male', '890-888-9999', '909 Pinecone Dr, Greenfield, CA', 'julian.r@email.com', 'Laura Rivera', '210-321-7654'),
('Liliana', 'Long', 'Daisy', '1944-07-04', 'Female', '901-999-0000', '110 Evergreen St, Mountainview, CA', 'liliana.l@email.com', 'Michael Long', '321-432-8765'),
('Nolan', 'Peterson', 'Thomas', '1973-03-08', 'Male', '012-000-1111', '220 Redwood Ave, Bayside, CA', 'nolan.p@email.com', 'Jennifer Peterson', '432-543-9876');
