CREATE TABLE Parfume(
ID int NOT NULL PRIMARY KEY,
Name nvarchar,
);

CREATE TABLE Brand (
ID int NOT NULL PRIMARY KEY,
Name nvarchar,
ParfumeID int NOT NULL FOREIGN KEY REFERENCES Parfume(ID)
);

CREATE TABLE Price (
ID int NOT NULL PRIMARY KEY,
Size decimal,
Price decimal,
BrandID int NOT NULL FOREIGN KEY REFERENCES Brand(ID)
);