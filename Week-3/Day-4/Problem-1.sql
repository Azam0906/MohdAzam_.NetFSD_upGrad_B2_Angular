SELECT CONCAT(p1.product_name, ' (', p1.model_year, ')') AS [Product (Year)], p1.list_price,
    (SELECT AVG(p2.list_price) 
     FROM products p2 
     WHERE p2.category_id = p1.category_id) AS Category_Avg_Price,
    p1.list_price - (SELECT AVG(p2.list_price) 
                     FROM products p2 
                     WHERE p2.category_id = p1.category_id) AS Price_Difference
FROM products p1
WHERE p1.list_price > (
    SELECT AVG(p2.list_price) 
    FROM products p2 
    WHERE p2.category_id = p1.category_id
);