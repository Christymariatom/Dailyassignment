create or ALTER PROCEDURE sp_PrintData AS
BEGIN
SELECT getdate();
END;

exec sp_PrintData