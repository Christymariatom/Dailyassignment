SELECT ACCOUNTNo as ACNO,
Name as[Account Holder Name],
Balance,
RefAcno as [Ref Acno],
r.Name[Name of Referer]
FROM BankTB a join BankTB r
on a.RefAcno = r.AccountNo;