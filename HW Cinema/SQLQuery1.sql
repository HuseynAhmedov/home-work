CREATE TABLE [Movies]
(
ID int IDENTITY PRIMARY KEY,
[Name] nvarchar(50) NOT NULL,
);

CREATE TABLE [Languages]
(
ID int IDENTITY PRIMARY KEY,
[Name] nvarchar(50) NOT NULL,
);

CREATE TABLE [MovieLanguages]
(
ID int IDENTITY PRIMARY KEY,
MovieID int NOT NULL FOREIGN KEY REFERENCES Movies(ID),
LanguageID int NOT NULL FOREIGN KEY REFERENCES Languages(ID),
);

CREATE TABLE [Branches]
(
ID int IDENTITY PRIMARY KEY,
[Name] nvarchar(50) NOT NULL,
);

CREATE TABLE [Halls]
(
ID int IDENTITY PRIMARY KEY,
[Name] nvarchar(30) NOT NULL,
BranchID int NOT NULL FOREIGN KEY REFERENCES Branches(ID),
);

CREATE TABLE [Seanses]
(
ID int IDENTITY PRIMARY KEY,
MovieLanguageID int NOT NULL FOREIGN KEY REFERENCES MovieLanguages(ID),
HallID int NOT NULL FOREIGN KEY REFERENCES Halls(ID),
SubtitleLanguageID int NOT NULL FOREIGN KEY REFERENCES Languages(ID),
[Time] datetime2 NOT NULL,
Price decimal DEFAULT 0
);

INSERT INTO [Movies]
values
('Das boot'),
('Generation of war'),
('1917'),
('Schindlers list'),
('Pianist'),
('Downfall'),
('Stalingrad 1993'),
('Letters from Iwo Jima'),
('Grave of the fireflies')

INSERT INTO [Languages]
VALUES
('English'),
('German'),
('Russian'),
('Azerbaijani'),
('Japanies')

INSERT INTO [MovieLanguages]
VALUES
(1,5),
(2,5),
(3,1),
(4,1),
(5,1),
(6,5),
(7,5),
(8,4),
(9,4)

INSERT INTO [Branches]
VALUES
('28 Mall'),
('Sumqayit'),
('Deniz Mall'),
('Amburan Mall'),
('Ganjlik Mall')

INSERT INTO [Halls]
VALUES
('NAR',1),
('ZAL 3',1),
('ZAL Qalaxy',1),
('ZAL 1',2),
('ZAL 5',2),
('Star',2),
('ZAL BRAVO 1',3),
('ZAL BRAVO 2',3),
('ZAL BRAVO 3',3),
('NEOCARD',4),
('ATMOS',5)

INSERT INTO [Seanses]
VALUES
(1,1,4,'2021-10-5',5),
(2,2,1,'2021-10-5',6),
(3,3,1,'2021-10-6',6),
(4,4,2,'2021-10-6',4),
(5,5,2,'2021-10-7',4),
(5,6,4,'2021-10-7',2),
(6,7,4,'2021-10-8',2),
(7,8,1,'2021-10-8',7),
(8,9,2,'2021-10-8',7),
(9,10,2,'2021-10-9',7)

SELECT * FROM Seanses where DATEADD(month,-2,GETDATE()) = [Time]

SELECT M.ID , COUNT(M.ID) as SeanseCount , M.Name FROM Seanses as S join MovieLanguages as ML ON S.MovieLanguageID = ML.ID
Join Movies as M on ML.MovieID = M.ID GROUP BY M.ID , M.Name HAVING COUNT(M.ID) >= 2

SELECT * , H.Name as HallName ,B.Name as BranchName FROM Seanses as S Join Halls as H ON S.HallID = H.ID
Join Branches as B on H.BranchID = B.ID

SELECT  H.ID , COUNT(H.ID) as HallSeanseCount ,H.Name FROM Seanses as S 
join Halls as H on S.HallID = H.ID GROUP BY H.ID ,H.Name

SELECT  H.ID , COUNT(H.ID) as HallSeanseCount ,H.Name FROM Seanses as S 
join Halls as H on S.HallID = H.ID GROUP BY H.ID ,H.Name HAVING COUNT(H.ID) > 3




