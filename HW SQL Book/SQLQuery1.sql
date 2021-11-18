CREATE DATABASE [Library]

USE Library

CREATE TABLE [Authors]
(
ID int IDENTITY PRIMARY KEY,
[Name] nvarchar(100),
Surname nvarchar(100)
);

CREATE TABLE [Books]
(
ID int IDENTITY PRIMARY KEY,
AuthorID int FOREIGN KEY (AuthorID) REFERENCES Authors(ID),
[Name] nvarchar(100),
PageCount int,
CONSTRAINT CK_Books_Name_Lenght CHECK (LEN(Name) BETWEEN 2 and 100),
CONSTRAINT CK_Books_PageCount_Size CHECK (PageCount > 10) 
);

INSERT INTO Authors
VALUES
('Leo','Tolstoy'),
('Gustav','Flaubert'),
('Vladimir','Nabokov'),
('Mark','Twain'),
('William','Shakespeare'),
('Scott','Fizgerald'),
('Marcel','Proust'),
('Anton','Checkhov'),
('George','Eliot')

INSERT INTO Books
values
(1,'Anna Karenina',300),
(1,'War and Peace',290),
(2,'Madame Bovary',400),
(3,'Lolita',200),
(4,'The Adventures of Huckleberry Finn',330),
(5,'Hamlet',340),
(6,'The Great Gatsby ',410),
(7,'In Search of Lost Time',210),
(8,'The Stories of Anton Chekhov',290),
(9,'Middlemarch',335)

CREATE VIEW VI_Authors_Books
AS
SELECT 
 B.ID , 
 B.Name ,
 B.PageCount , 
 A.Name + ' ' + A.Surname as AuthorFullName 
  FROM Authors as A join Books as B on A.ID = B.AuthorID

CREATE PROCEDURE Get_AnyName
@Name nvarchar(100)
AS
SELECT 
 * 
  FROM VI_Authors_Books where @Name = Name or @Name = AuthorFullName

CREATE PROC Insert_Author 
 @Name nvarchar(100),
 @Surname nvarchar(100)
 AS
 INSERT INTO Authors
 VALUES 
 (@Name,@Surname)

 EXEC Insert_Author 'Enid','Blyton'

CREATE PROC Update_Author 
 @Name nvarchar(100),
 @Surname nvarchar(100),
 @ID int
 AS
 UPDATE Authors SET Name=@Name , Surname = @Surname 
  where ID = @ID

EXEC Update_Author 'Joanne','Rowling',10

CREATE PROC Delete_Author
 @ID int
 AS
  DELETE Authors where ID=@ID

 EXEC Delete_Author 10

 CREATE VIEW VI_Author_Book_count
 AS
 SELECT 
 A.ID , 
 A.Name + ' ' + A.Surname AS FullName ,
 COUNT(A.ID) AS BooksCount , 
 MAX(B.PageCount) AS MaxPageCount
 FROM Authors AS A join Books as B on A.ID = B.AuthorID
 GROUP BY A.ID , A.Name + ' ' + A.Surname
 


