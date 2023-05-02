/*select*from EMP_DETAILS;*/

create or alter procedure sp_GetSalary
@empno int,@sal MONEY output
as
begin
select @sal = salary FROM EMP_DETAILS where empno =@emp_no
end;