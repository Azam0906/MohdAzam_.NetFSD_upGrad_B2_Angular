-- 1. Identify items sold vs items in stock--
SELECT s.store_name, p.product_name, SUM(oi.quantity) AS total_sold
FROM stores s
JOIN orders o ON s.store_id = o.store_id
JOIN order_items oi ON o.order_id = oi.order_id
JOIN products p ON oi.product_id = p.product_id
WHERE p.product_id IN (
    -- Use EXCEPT to find products that were sold but are NOT in stock--
    SELECT product_id FROM order_items
    EXCEPT
    SELECT product_id FROM stocks WHERE quantity > 0
)
GROUP BY s.store_name, p.product_name;

-- 2. Update stock for discontinued items (simulation)--
UPDATE stocks
SET quantity = 0
WHERE product_id IN (
    SELECT product_id FROM products 
    WHERE model_year < 2018 -- Example criteria for "discontinued"
);