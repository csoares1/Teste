USE [teste]
GO



CREATE TABLE [dbo].[Resgate](
	[Id] [uniqueidentifier] NOT NULL DEFAULT (newsequentialid()),
	[Tipo] [int] NULL,
	[Id_Fundo] [uniqueidentifier] NULL,
	[cpf_cliente] [nvarchar](11) NULL,
	[valor_movimentacao] [decimal](18, 0) NULL,
	[Data_movimentacao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Resgate]  WITH CHECK ADD FOREIGN KEY([Id_Fundo])
REFERENCES [dbo].[fundos] ([Id])
GO


