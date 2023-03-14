SELECT 
	p.Name as ProductName, 
	c.Name as CategoryName
FROM Products p WITH (NOLOCK)
LEFT JOIN Products_And_Categories pc WITH (NOLOCK) ON pc.ProductID = p.ID
LEFT JOIN Categories c WITH (NOLOCK) ON c.ID = pc.CategoryID
