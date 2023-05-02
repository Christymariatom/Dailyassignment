create trigger empinstrg on EMP_DETAILS
AFTER INSERT
AS
SELECT 'Row Created'