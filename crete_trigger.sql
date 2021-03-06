USE [Storehouse]
GO
/****** Object:  Trigger [dbo].[CALC_AGE]    Script Date: 30/5/2017 8:31:45 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[CALC_AGE] ON [dbo].[CUSTOMERS]
AFTER INSERT, UPDATE
AS
BEGIN
     
     DECLARE @CustomerId INT
	 DECLARE @BirthDate smalldatetime

	 SELECT @CustomerId = INSERTED.CUSTOMER_ID      
     FROM INSERTED

	 SELECT @BirthDate = INSERTED.BIRTH_DATE      
     FROM INSERTED

	 UPDATE CUSTOMERS SET AGE = DATEDIFF(YEAR,@BirthDate,GETDATE()) 
	 WHERE CUSTOMER_ID = @CustomerId
	
END
