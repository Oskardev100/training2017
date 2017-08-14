USE [TrainingPOC]
GO

/****** Object:  Table [dbo].[ProductImage]    Script Date: 8/10/2017 10:53:02 PM ******/
DROP TABLE [dbo].[ProductImage]
GO

/****** Object:  Table [dbo].[ProductImage]    Script Date: 8/10/2017 10:53:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[ImageSource] [nvarchar](250) NULL,
	[ProductId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[UpdatedDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_ProductImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


