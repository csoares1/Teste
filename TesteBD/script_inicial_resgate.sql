USE [teste]
GO

INSERT INTO [dbo].[Resgate]
           ([Tipo]
           ,[Id_Fundo]
           ,[cpf_cliente]
           ,[valor_movimentacao]
           ,[Data_movimentacao])
     VALUES
           (1
           ,(select top 1 Id from fundos)
           ,'65000290038'
           ,100
           ,getdate())
GO


