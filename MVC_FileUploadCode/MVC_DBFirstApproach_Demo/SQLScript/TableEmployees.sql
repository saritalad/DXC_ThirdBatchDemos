USE [AnjaleeDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 09/10/2024 07:08:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(10,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Salary] [decimal](12, 0) NULL,
	[Doj] [datetime] NULL,
	[DeptId] [int] NULL,
	[gender] [varchar](50) NULL,
	[photopath] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


