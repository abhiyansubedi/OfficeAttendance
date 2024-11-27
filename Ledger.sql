USE [Attendance]
GO

/****** Object:  Table [dbo].[Ledger]    Script Date: 10/17/2024 2:22:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ledger](
	[UserID] [varchar](255) NOT NULL,
	[UserName] [varchar](255) NOT NULL,
	[VerifyDate] [varchar](255) NOT NULL,
	[VerifyType] [int] NOT NULL,
	[VerifyState] [int] NOT NULL,
	[WorkCode] [int] NOT NULL,
	[TimeIn] [varchar](255) NOT NULL,
	[TimeOut] [varchar](255) NOT NULL,
	[Status] [varchar](255) NOT NULL
) ON [PRIMARY]
GO


