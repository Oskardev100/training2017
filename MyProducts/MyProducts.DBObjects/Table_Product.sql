USE [TrainingPOC]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 8/10/2017 10:56:41 PM ******/
DROP TABLE [dbo].[Product]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 8/10/2017 10:56:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Model] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[KeyWords] [nchar](10) NULL,
	[Active] [bit] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


