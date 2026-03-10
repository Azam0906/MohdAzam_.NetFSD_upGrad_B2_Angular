CREATE TRIGGER trg_UpdateStockAfterInsert
ON order_items
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Check if there is enough stock for the items inserted
        -- We compare the inserted quantity with the stock quantity
        IF EXISTS (
            SELECT 1 
            FROM inserted i
            JOIN orders o ON i.order_id = o.order_id
            JOIN stocks s ON i.product_id = s.product_id AND o.store_id = s.store_id
            WHERE s.quantity < i.quantity
        )
        BEGIN
            THROW 50001, 'Insufficient stock available to complete this order.', 1;
        END

        -- Perform the stock reduction
        UPDATE s
        SET s.quantity = s.quantity - i.quantity
        FROM stocks s
        JOIN inserted i ON s.product_id = i.product_id
        JOIN orders o ON i.order_id = o.order_id
        WHERE s.store_id = o.store_id;

    END TRY
    BEGIN CATCH
        -- Rollback the transaction if stock check fails or an error occurs
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Rethrow the custom error
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;