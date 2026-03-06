--Week 3 day 3
--Level 2 Problem 2

SELECT p.product_name, st.store_name, s.quantity AS available_stock, SUM(ISNULL(oi.quantity, 0)) AS total_quantity_sold
FROM products p
INNER JOIN stocks s ON p.product_id = s.product_id
INNER JOIN stores st ON s.store_id = st.store_id
LEFT JOIN order_items oi ON p.product_id = oi.product_id
GROUP BY p.product_name, st.store_name, s.quantity
ORDER BY p.product_name;