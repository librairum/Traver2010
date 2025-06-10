alter function dbo.FormateoNumeroDUA (@numeroDocRelacionado varchar(20))
 returns varchar(20)
 as
 Begin
 declare @numeroDuaFormateado varchar(20)
 declare @numeroDua as varchar(20)
 declare @numDocRelFormateado as varchar(20)
 --tomar el bloque de numero DUA

 select @numeroDua = substring(@numeroDocRelacionado, 13, len(@numeroDocRelacionado) - 12)
 
 --select replace(@numeroDua, '0','')
 select @numeroDuaFormateado = rtrim(ltrim(str(convert(int, @numeroDua))))
  --return @numeroDuaFormateado 
select @numDocRelFormateado = substring(@numeroDocRelacionado, 1, 12) +  @numeroDuaFormateado

 return @numDocRelFormateado
 
 End