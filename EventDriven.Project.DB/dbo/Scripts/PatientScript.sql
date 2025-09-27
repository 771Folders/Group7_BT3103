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
INSERT INTO [dbo].[Patients] (FirstName, LastName, MiddleName, DateOfBirth, Gender, Phone, Address, Email, EmergencyContact) VALUES
('Liam', 'Turner', 'R.', '1970-05-15', 'Male', '123-456-7890', '123 Oak St, Cityville, CA', 'liam.t@email.com', 'Sarah Turner'),
('Olivia', 'Carter', 'M.', '1957-08-20', 'Female', '234-567-8901', '456 Pine Ave, Townsville, CA', 'olivia.c@email.com', 'James Carter'),
('Noah', 'Williams', 'A.', '1983-02-10', 'Male', '345-678-9012', '789 Elm Blvd, Villageton, CA', 'noah.w@email.com', 'Emily Williams'),
('Emma', 'Davis', 'L.', '1994-11-25', 'Female', '456-789-0123', '101 Maple Dr, Cityburg, CA', 'emma.d@email.com', 'David Davis'),
('Mason', 'Miller', 'J.', '1948-03-05', 'Male', '567-890-1234', '202 Birch Rd, Countyton, CA', 'mason.m@email.com', 'Linda Miller'),
('Isabella', 'Wilson', 'K.', '2001-09-08', 'Female', '678-901-2345', '303 Cedar Ln, Metropolis, CA', 'isabella.w@email.com', 'Maria Wilson'),
('Sophia', 'Moore', 'B.', '1967-04-12', 'Female', '789-012-3456', '404 Spruce Ct, Hometowne, CA', 'sophia.m@email.com', 'Robert Moore'),
('Jacob', 'Taylor', 'S.', '1959-07-30', 'Male', '890-123-4567', '505 Willow St, Sunnyside, CA', 'jacob.t@email.com', 'Jessica Taylor'),
('Ava', 'Anderson', 'D.', '2006-01-18', 'Female', '901-234-5678', '606 Ash St, Riverdale, CA', 'ava.a@email.com', 'Chris Anderson'),
('William', 'Thomas', 'P.', '1945-12-01', 'Male', '012-345-6789', '707 Poplar Ln, Lakeland, CA', 'william.t@email.com', 'Susan Thomas'),
('Charlotte', 'Jackson', 'G.', '1976-10-22', 'Female', '123-111-2222', '808 Cherry Dr, Meadowville, CA', 'charlotte.j@email.com', 'Thomas Jackson'),
('James', 'White', 'O.', '1972-06-03', 'Male', '234-222-3333', '909 Palm St, Hilltop, CA', 'james.w@email.com', 'Patricia White'),
('Amelia', 'Harris', 'E.', '1996-03-17', 'Female', '345-333-4444', '111 Sycamore Ave, Seaside, CA', 'amelia.h@email.com', 'Michael Harris'),
('Benjamin', 'Clark', 'F.', '1954-09-09', 'Male', '456-444-5555', '222 Walnut Rd, Forestville, CA', 'benjamin.c@email.com', 'Jennifer Clark'),
('Mia', 'Lewis', 'T.', '1962-08-01', 'Female', '567-555-6666', '333 Oakwood St, Lakeside, CA', 'mia.l@email.com', 'Daniel Lewis'),
('Elijah', 'Hall', 'C.', '1987-04-28', 'Male', '678-666-7777', '444 Pinecone Dr, Greenfield, CA', 'elijah.h@email.com', 'Sarah Hall'),
('Harper', 'Young', 'D.', '1998-07-06', 'Female', '789-777-8888', '555 Evergreen Ln, Mountainview, CA', 'harper.y@email.com', 'Mark Young'),
('Lucas', 'King', 'V.', '1966-02-14', 'Male', '890-888-9999', '666 Redwood St, Bayside, CA', 'lucas.k@email.com', 'Lisa King'),
('Evelyn', 'Scott', 'P.', '1947-05-29', 'Female', '901-999-0000', '777 Fir Ave, Parkdale, CA', 'evelyn.s@email.com', 'John Scott'),
('Logan', 'Green', 'N.', '1978-01-21', 'Male', '012-000-1111', '888 Willow Rd, Lakeview, CA', 'logan.g@email.com', 'Amanda Green'),
('Abigail', 'Baker', 'H.', '1991-10-10', 'Female', '123-111-2222', '999 Spruce Ct, Riverton, CA', 'abigail.b@email.com', 'Chris Baker'),
('Alexander', 'Adams', 'J.', '1965-03-19', 'Male', '234-222-3333', '100 Poplar Blvd, Seaside, CA', 'alexander.a@email.com', 'Jessica Adams'),
('Ella', 'Nelson', 'K.', '1974-08-05', 'Female', '345-333-4444', '200 Oakwood Dr, Forestville, CA', 'ella.n@email.com', 'Paul Nelson'),
('Daniel', 'Hill', 'M.', '1961-09-13', 'Male', '456-444-5555', '300 Pinecone Ln, Greenfield, CA', 'daniel.h@email.com', 'Laura Hill'),
('Scarlett', 'Ramirez', 'R.', '1943-02-28', 'Female', '567-555-6666', '400 Evergreen St, Mountainview, CA', 'scarlett.r@email.com', 'Maria Ramirez'),
('Henry', 'Foster', 'G.', '1984-11-03', 'Male', '678-666-7777', '500 Redwood Ave, Bayside, CA', 'henry.f@email.com', 'Lisa Foster'),
('Grace', 'Wood', 'T.', '1989-06-27', 'Female', '789-777-8888', '600 Fir Rd, Parkdale, CA', 'grace.w@email.com', 'David Wood'),
('Jackson', 'Ward', 'P.', '1969-07-09', 'Male', '890-888-9999', '700 Willow Dr, Lakeview, CA', 'jackson.w@email.com', 'Nancy Ward'),
('Lily', 'Cook', 'S.', '1955-04-14', 'Female', '901-999-0000', '800 Spruce St, Riverton, CA', 'lily.c@email.com', 'Michael Cook'),
('Sebastian', 'Cox', 'A.', '2003-09-20', 'Male', '012-000-1111', '900 Poplar Ave, Seaside, CA', 'sebastian.c@email.com', 'John Cox'),
('Avery', 'Phillips', 'C.', '1981-01-30', 'Female', '123-111-2222', '110 Oakwood Rd, Forestville, CA', 'avery.p@email.com', 'Sarah Phillips'),
('Gabriel', 'Rogers', 'H.', '1958-05-22', 'Male', '234-222-3333', '220 Pinecone Dr, Greenfield, CA', 'gabriel.r@email.com', 'Rebecca Rogers'),
('Chloe', 'Morgan', 'L.', '1975-12-08', 'Female', '345-333-4444', '330 Evergreen St, Mountainview, CA', 'chloe.m@email.com', 'Paul Morgan'),
('Carter', 'Reed', 'J.', '1999-02-18', 'Male', '456-444-5555', '440 Redwood Ave, Bayside, CA', 'carter.r@email.com', 'Jennifer Reed'),
('Layla', 'Gray', 'S.', '1986-08-03', 'Female', '567-555-6666', '550 Fir Rd, Parkdale, CA', 'layla.g@email.com', 'Thomas Gray'),
('Owen', 'Hughes', 'R.', '1952-07-25', 'Male', '678-666-7777', '660 Willow Dr, Lakeview, CA', 'owen.h@email.com', 'Susan Hughes'),
('Zoe', 'Butler', 'E.', '1995-04-04', 'Female', '789-777-8888', '770 Spruce St, Riverton, CA', 'zoe.b@email.com', 'Chris Butler'),
('Wyatt', 'Cooper', 'D.', '1964-10-11', 'Male', '890-888-9999', '880 Poplar Ave, Seaside, CA', 'wyatt.c@email.com', 'Lisa Cooper'),
('Victoria', 'Richardson', 'M.', '1971-03-23', 'Female', '901-999-0000', '990 Oakwood Rd, Forestville, CA', 'victoria.r@email.com', 'David Richardson'),
('Jack', 'Price', 'B.', '1977-09-07', 'Male', '012-000-1111', '101 Pinecone Dr, Greenfield, CA', 'jack.p@email.com', 'Mary Price'),
('Hannah', 'Mitchell', 'S.', '1960-12-21', 'Female', '123-111-2222', '202 Evergreen St, Mountainview, CA', 'hannah.m@email.com', 'Robert Mitchell'),
('Luke', 'Bell', 'A.', '2000-06-02', 'Male', '234-222-3333', '303 Redwood Ave, Bayside, CA', 'luke.b@email.com', 'Jessica Bell'),
('Natalie', 'Rodriguez', 'F.', '1949-01-29', 'Female', '345-333-4444', '404 Fir Rd, Parkdale, CA', 'natalie.r@email.com', 'Thomas Rodriguez'),
('Isaac', 'Watson', 'L.', '1990-11-16', 'Male', '456-444-5555', '505 Willow Dr, Lakeview, CA', 'isaac.w@email.com', 'Susan Watson'),
('Madison', 'Evans', 'C.', '1968-04-24', 'Female', '567-555-6666', '606 Spruce St, Riverton, CA', 'madison.e@email.com', 'Chris Evans'),
('Leo', 'Bennett', 'G.', '1956-08-11', 'Male', '678-666-7777', '707 Poplar Ave, Seaside, CA', 'leo.b@email.com', 'Nancy Bennett'),
('Aubrey', 'Perry', 'J.', '1979-05-26', 'Female', '789-777-8888', '808 Oakwood Rd, Forestville, CA', 'aubrey.p@email.com', 'Paul Perry'),
('Julian', 'Rivera', 'K.', '1953-09-19', 'Male', '890-888-9999', '909 Pinecone Dr, Greenfield, CA', 'julian.r@email.com', 'Laura Rivera'),
('Liliana', 'Long', 'D.', '1944-07-04', 'Female', '901-999-0000', '110 Evergreen St, Mountainview, CA', 'liliana.l@email.com', 'Michael Long'),
('Nolan', 'Peterson', 'T.', '1973-03-08', 'Male', '012-000-1111', '220 Redwood Ave, Bayside, CA', 'nolan.p@email.com', 'Jennifer Peterson');