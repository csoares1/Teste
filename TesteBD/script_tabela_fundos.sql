USE [teste]
GO

CREATE TABLE [dbo].[fundos](
	[Id] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[Nome] [nvarchar](100) NULL,
	[Cnpj] [nvarchar](50) NULL,
	[Investimento] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


