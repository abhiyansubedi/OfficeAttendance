USE [Attendance]
GO

/****** Object:  Table [dbo].[tbllicense]    Script Date: 10/7/2024 9:39:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbllicense](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LicenseKey] [varchar](255) NOT NULL,
	[UserId] [int] NULL,
	[Remarks] [int] NULL
) ON [PRIMARY]
GO


