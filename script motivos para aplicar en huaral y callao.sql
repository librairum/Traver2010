use traver
go
CREATE Procedure [dbo].[Spu_Fact_Help_FAC66_MOTIVODETRASLADO]  
@campo  Varchar(20),  
@filtro  Varchar(50)  
As  
If @filtro='*'  
 Begin  
  Select * from FAC66_MOTIVODETRASLADO  
  
 End  
Else  
 Begin  
  If @campo='FAC66CODMOTIVO'  
   Begin  
    Select * from FAC66_MOTIVODETRASLADO where  
    FAC66CODMOTIVO like @filtro   
   End  
  Else  
   Begin  
    Select * from FAC66_MOTIVODETRASLADO where  
    FAC66DESMOTIVO like @filtro    
   End  
 End  
 
 
 
 
 update FAC66_MOTIVODETRASLADO 
 set FAC66DESMOTIVO =  'Recojo de bienes transformados'
 where FAC66CODMOTIVO = '08'
 
 --delete from FAC66_MOTIVODETRASLADO  where FAC66CODMOTIVO = '10'
 --10
 select  * from FAC34_GUIAREMISION where FAC34MOTRASLCOD = '10'
