CREATE TABLE [User]
(
ID int IDENTITY PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Surname nvarchar(50) NOT NULL,
NickName nvarchar(50) NOT NULL,
Email nvarchar(100) NOT NULL,
Age tinyint NOT NULL,
CONSTRAINT UN_User_NickName_Repeat UNIQUE(NickName),
CONSTRAINT CK_User_Age_Count CHECK (Age BETWEEN 1 AND 100),
CONSTRAINT UN_User_Email_Repeat UNIQUE(Email),
CONSTRAINT CK_User_Email_Lenght CHECK(LEN(Email) BETWEEN 4 and 100)
);

CREATE TABLE [Post]
(
ID int IDENTITY PRIMARY KEY,
UserID int NOT NULL FOREIGN KEY REFERENCES [User](ID),
LikeCount int DEFAULT 0,
[Description] nvarchar(250) NOT NULL DEFAULT 'Title here',
ContextFilePath nvarchar(250) NOT NULL,
CreatedAt datetime2 NOT NULL,
);

CREATE TABLE [Likes]
(
ID int IDENTITY PRIMARY KEY,
UserID int NOT NULL FOREIGN KEY REFERENCES [User](ID),
PostID int NOT NULL FOREIGN KEY REFERENCES [Post](ID),
);

CREATE TABLE [Comments]
(
ID int IDENTITY PRIMARY KEY,
UserID int NOT NULL FOREIGN KEY REFERENCES [User](ID),
PostID int NOT NULL FOREIGN KEY REFERENCES [Post](ID),
LikeCount int DEFAULT 0,
[Text] nvarchar(500),
CreatedAt datetime2 NOT NULL,
CONSTRAINT CK_Comment_Text_Lenght CHECK (LEN(Text)<=500)
);

INSERT INTO [User]
values
('Huseyn','Ahmedov','Bullet','gold.bullet.767@gmail.com',19),
('Mahir','Sadiqov','Masa','masa.1999@gmail.com',39),
('Resul','Qadirov','RakaRaka','Resul.ov200@gmail.com',21),
('Elsad','Mehemmedov','Elli50','Mehemmedov.el@gmail.com',24)

INSERT INTO [Post]
values
(3,23000,'How to play Assault class in battlefield 5 ','C\EditedVideo.mp4','2021-10-10'),
(2,45000,'Photoshop flame effect tutorial','C\EditedVideo.mov','2020-11-10'),
(2,123400,'BlackWater and it is downfall','C\EditedVideo.mp4','2019-2-2'),
(4,49343234,'This video has 49,343,234 views','C\EditedVideo.mp4','2016-3-2')

INSERT INTO [Comments]
values
(2,1,10,'Great video hope to see more ','2021-10-10'),
(3,1,2,'Nice','2021-10-10'),
(1,1,10,'Good video','2020-10-10'),
(3,2,10,'can you do more ?','2021-10-10'),
(4,2,10,'thanks helped me allot','2020-10-10'),
(1,2,10,'bad video','2021-10-10')

INSERT INTO [Likes]
values
(1,1),
(2,2),
(3,3),
(4,4),
(4,3),
(2,3),
(1,4),
(4,1),
(2,4),
(3,1),
(3,2),
(2,3)

SELECT Name + ' ' + Surname as Fullname FROM [User]
SELECT * FROM [Post] where LikeCount > 10
SELECT * FROM [Post] where LEN(Description) BETWEEN 20 and 100
SELECT * FROM [Post] where CreatedAt = GETDATE()
SELECT * FROM [Post] where LikeCount > ( SELECT AVG(LikeCount) FROM [Post])