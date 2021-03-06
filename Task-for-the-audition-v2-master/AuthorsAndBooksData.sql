USE [AuthorsAndBooks]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

GO
INSERT [dbo].[Authors] ([Id], [Name]) VALUES (1, N'John R. R. Tolkien')
GO
INSERT [dbo].[Authors] ([Id], [Name]) VALUES (2, N'George R. R. Martin')
GO
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[Years] ON 

GO
INSERT [dbo].[Years] ([Id], [Name], [authorId]) VALUES (1, N'1954', 1)
GO
INSERT [dbo].[Years] ([Id], [Name], [authorId]) VALUES (2, N'1955', 1)
GO
INSERT [dbo].[Years] ([Id], [Name], [authorId]) VALUES (3, N'1996', 2)
GO
INSERT [dbo].[Years] ([Id], [Name], [authorId]) VALUES (5, N'1998', 2)
GO
INSERT [dbo].[Years] ([Id], [Name], [authorId]) VALUES (7, N'2000', 2)
GO
INSERT [dbo].[Years] ([Id], [Name], [authorId]) VALUES (8, N'2005', 2)
GO
INSERT [dbo].[Years] ([Id], [Name], [authorId]) VALUES (9, N'2011', 2)
GO
SET IDENTITY_INSERT [dbo].[Years] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (1, N'The Fellowship of The Ring', 1)
GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (2, N'The Two Towers', 1)
GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (4, N'The Return of the King', 2)
GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (5, N'A Game of Thrones', 3)
GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (8, N'A Clash of Kings', 5)
GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (10, N'A Storm of Swords', 7)
GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (11, N'A Feast for Crows', 8)
GO
INSERT [dbo].[Books] ([Id], [Name], [yearId]) VALUES (12, N'A Dance with Dragons', 9)
GO
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
