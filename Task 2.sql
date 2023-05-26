CREATE TABLE Products(
  Id int PRIMARY KEY,
  Name TEXT);

CREATE TABLE Categories(
  Id int PRIMARY KEY,
  Name TEXT);

CREATE TABLE ProductCategories(
  ProductId int FOREIGN KEY REFERENCES Products(Id),
  CategoryId int FOREIGN KEY REFERENCES Categories(Id),
  PRIMARY KEY (ProductId, CategoryId));
 
INSERT INTO Products
VALUES 
  (1, 'p1'),
  (2, 'p2'),
  (3, 'p3'),
  (4, 'p4'),
  (5, 'p5') 


INSERT INTO Categories
VALUES 
  (1, 'cat1'),
  (2, 'cat2'),
  (3, 'cat3'),
  (4, 'cat4'),
  (5, 'cat5')



INSERT INTO ProductCategories
VALUES 
  (1,1),
  (1,2),
  (1,3),
  (2,4),
  (2,1),
  (3,5)


SELECT p.Name, c.Name FROM Products p 
LEFT JOIN ProductCategories pc 
ON p.Id = pc.ProductId
LEFT JOIN Categories c 
ON pc.CategoryId = c.Id