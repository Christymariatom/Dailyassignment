CREATE OR ALTER PROCEDURE SHOWClientNo(@Client_no int )
AS
begin

select * from CLIENT_MASTER WHERE client_no = @Client_No;
END;


/*EXEC SHOWClientNo 1*/ 



create or alter procedure SHOWProductNo(@product_no int)
AS
BEGIN
SELECT *FROM PRODUCT_MASTER WHERE product_no =@product_No
END;