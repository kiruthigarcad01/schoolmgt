USE [linds]
GO
/****** Object:  Index [PK_registration]    Script Date: 4/19/2024 6:51:05 PM ******/
ALTER TABLE [dbo].[registration] DROP CONSTRAINT [PK_registration] WITH ( ONLINE = OFF )
GO

ALTER TABLE Registration
DROP CONSTRAINT PK_Registration;
