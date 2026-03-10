-- 1. Archive rejected orders older than 1 year--
INSERT INTO archived_orders (order_id, customer_id, order_status, order_date)
SELECT order_id, customer_id, order_status, order_date
FROM orders
WHERE order_status = 3 AND order_date < DATEADD(year, -1, GETDATE());

-- 2. Delete the archived records from the source---
DELETE FROM orders 
WHERE order_id IN (SELECT order_id FROM archived_orders);

-- 3. Display delay and status--
SELECT 
    order_id,
    DATEDIFF(day, order_date, shipped_date) AS days_to_ship,
    CASE 
        WHEN shipped_date > required_date THEN 'Delayed'
        ELSE 'On Time'
    END AS shipping_status
FROM orders;