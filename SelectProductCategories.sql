SELECT p.[Name], c.[Name] FROM Products p
LEFT OUTER JOIN ProductCategory pc
ON p.Id = pc.ProductId
LEFT OUTER JOIN Categories c
ON pc.CategoryId = c.Id