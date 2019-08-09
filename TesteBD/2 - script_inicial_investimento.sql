USE [teste]
GO

INSERT INTO [dbo].[Investimento]
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


INSERT INTO [dbo].[Investimento]
           ([Tipo]
           ,[Id_Fundo]
           ,[cpf_cliente]
           ,[valor_movimentacao]
           ,[Data_movimentacao])
     VALUES
           (1
           ,(select top 1 Id from fundos)
           ,'37376679006'
           ,100
           ,getdate())
GO


INSERT INTO [dbo].[Investimento]
           ([Tipo]
           ,[Id_Fundo]
           ,[cpf_cliente]
           ,[valor_movimentacao]
           ,[Data_movimentacao])
     VALUES
           (1
           ,(select top 1 Id from fundos)
           ,'24165976040'
           ,100
           ,getdate())
GO


INSERT INTO [dbo].[Investimento]
           ([Tipo]
           ,[Id_Fundo]
           ,[cpf_cliente]
           ,[valor_movimentacao]
           ,[Data_movimentacao])
     VALUES
           (2
           ,(select top 1 Id from fundos)
           ,'75147544070'
           ,100
           ,getdate())
GO


INSERT INTO [dbo].[Investimento]
           ([Tipo]
           ,[Id_Fundo]
           ,[cpf_cliente]
           ,[valor_movimentacao]
           ,[Data_movimentacao])
     VALUES
           (2
            ,(select top 1 Id from fundos)
           ,'31935513095'
           ,100
           ,getdate())
GO

INSERT INTO [dbo].[Investimento]
           ([Tipo]
           ,[Id_Fundo]
           ,[cpf_cliente]
           ,[valor_movimentacao]
           ,[Data_movimentacao])
     VALUES
           (2
          ,(select top 1 Id from fundos)
           ,'47469022082'
           ,100
           ,getdate())
GO




