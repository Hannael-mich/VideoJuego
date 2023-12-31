USE [Generacion23]
GO
/****** Object:  Table [dbo].[VideoJuegos]    Script Date: 24/12/2023 11:43:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoJuegos](
	[idVideoJuego] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precio] [decimal](18, 2) NULL,
	[FechaLanzamiento] [date] NULL,
	[imagen] [varchar](max) NULL,
 CONSTRAINT [PK_VideoJuegos] PRIMARY KEY CLUSTERED 
(
	[idVideoJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VideoJuegos] ON 

INSERT [dbo].[VideoJuegos] ([idVideoJuego], [nombre], [precio], [FechaLanzamiento], [imagen]) VALUES (2, N'Mario', CAST(121.51 AS Decimal(18, 2)), CAST(N'2004-04-10' AS Date), N'mario.jpg')
INSERT [dbo].[VideoJuegos] ([idVideoJuego], [nombre], [precio], [FechaLanzamiento], [imagen]) VALUES (3, N'Halo', CAST(1321.21 AS Decimal(18, 2)), CAST(N'2001-05-12' AS Date), N'halo.jpg')
INSERT [dbo].[VideoJuegos] ([idVideoJuego], [nombre], [precio], [FechaLanzamiento], [imagen]) VALUES (4, N'CallofDuty', CAST(1503.10 AS Decimal(18, 2)), CAST(N'2010-10-05' AS Date), N'CallofDuty')
INSERT [dbo].[VideoJuegos] ([idVideoJuego], [nombre], [precio], [FechaLanzamiento], [imagen]) VALUES (1004, N'Zelda', CAST(1230.12 AS Decimal(18, 2)), CAST(N'2003-05-15' AS Date), N'Zelda.jpg')
INSERT [dbo].[VideoJuegos] ([idVideoJuego], [nombre], [precio], [FechaLanzamiento], [imagen]) VALUES (1005, N'Mario Bros', CAST(1523.75 AS Decimal(18, 2)), CAST(N'2013-02-15' AS Date), N'MarioBros.jpg')
INSERT [dbo].[VideoJuegos] ([idVideoJuego], [nombre], [precio], [FechaLanzamiento], [imagen]) VALUES (1006, N'Zelda', CAST(1230.12 AS Decimal(18, 2)), CAST(N'1998-08-15' AS Date), N'Zelda.jpg')
SET IDENTITY_INSERT [dbo].[VideoJuegos] OFF
GO
