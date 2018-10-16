SELECT * FROM Customers
WHERE Customers.CompanyName Like 'B%'

--INSERT INTO Products
--([ProductName], [UnitPrice])
--VALUES ('myNewProduct', '200')

SELECT * FROM Products
WHERE ProductName = 'myNewProduct'


SELECT ordr.OrderID, ordr.ShipName, ordr.ShipAddress, ordr.ShipCity, ordrdet.UnitPrice, ordrdet.Quantity, ordrdet.Discount FROM Orders ordr
LEFT JOIN [Order Details] ordrdet ON ordr.OrderID=ordrdet.OrderID