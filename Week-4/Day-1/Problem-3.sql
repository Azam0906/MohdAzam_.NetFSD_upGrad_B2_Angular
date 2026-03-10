CREATE TRIGGER trg_ValidateOrderStatus
ON orders
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if we are trying to set status to 4 (Completed)
    -- but shipped_date is still NULL
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        WHERE i.order_status = 4 AND i.shipped_date IS NULL
    )
    BEGIN
        -- Rollback prevents the update from saving
        RAISERROR('Validation Error: Cannot set order to Completed if shipped_date is missing.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;