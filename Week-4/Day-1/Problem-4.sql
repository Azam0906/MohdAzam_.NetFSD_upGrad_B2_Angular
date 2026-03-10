-- 1. Create a temporary table to store the results--
CREATE TABLE #StoreRevenue (
    StoreID INT,
    TotalRevenue DECIMAL(18,2)
);

DECLARE @OrderID INT, @StoreID INT, @OrderTotal DECIMAL(18,2);

-- 2. Define the cursor to get all completed orders--
DECLARE order_cursor CURSOR FOR 
SELECT order_id, store_id FROM orders WHERE order_status = 4;

OPEN order_cursor;
FETCH NEXT FROM order_cursor INTO @OrderID, @StoreID;

WHILE @@FETCH_STATUS = 0
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Calculate total for this specific order--
        SELECT @OrderTotal = SUM(quantity * list_price * (1 - discount))
        FROM order_items WHERE order_id = @OrderID;

        -- Insert into temp table--
        INSERT INTO #StoreRevenue (StoreID, TotalRevenue) VALUES (@StoreID, ISNULL(@OrderTotal, 0));
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error processing Order ID: ' + CAST(@OrderID AS VARCHAR);
    END CATCH

    FETCH NEXT FROM order_cursor INTO @OrderID, @StoreID;
END;

CLOSE order_cursor;
DEALLOCATE order_cursor;

-- 3. Display the final summary---
SELECT StoreID, SUM(TotalRevenue) AS FinalStoreRevenue 
FROM #StoreRevenue 
GROUP BY StoreID;

-- Cleanup--
DROP TABLE #StoreRevenue;