USE [master]
GO
/****** Object:  Database [skladista]    Script Date: 20.3.2019. 16:53:39 ******/
CREATE DATABASE [skladista]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'skladista', FILENAME = N'C:\Users\pmrvic\Code\AlgebraCSharp2019\ConsoleApp1\baza\skladista.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'skladista_log', FILENAME = N'C:\Users\pmrvic\Code\AlgebraCSharp2019\ConsoleApp1\baza\skladista_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [skladista] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [skladista].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [skladista] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [skladista] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [skladista] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [skladista] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [skladista] SET ARITHABORT OFF 
GO
ALTER DATABASE [skladista] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [skladista] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [skladista] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [skladista] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [skladista] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [skladista] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [skladista] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [skladista] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [skladista] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [skladista] SET  DISABLE_BROKER 
GO
ALTER DATABASE [skladista] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [skladista] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [skladista] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [skladista] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [skladista] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [skladista] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [skladista] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [skladista] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [skladista] SET  MULTI_USER 
GO
ALTER DATABASE [skladista] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [skladista] SET DB_CHAINING OFF 
GO
ALTER DATABASE [skladista] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [skladista] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [skladista] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [skladista] SET QUERY_STORE = OFF
GO
USE [skladista]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [skladista]
GO
/****** Object:  Table [dbo].[proizvodi]    Script Date: 20.3.2019. 16:53:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proizvodi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[skladiste_id] [int] NULL,
 CONSTRAINT [PK_proizvodi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[radnici]    Script Date: 20.3.2019. 16:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[radnici](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
	[skladisno_mjesto] [int] NULL,
 CONSTRAINT [PK_radnici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[skladisna_mjesta]    Script Date: 20.3.2019. 16:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[skladisna_mjesta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[mjesto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_skladisna_mjesta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[voditelji]    Script Date: 20.3.2019. 16:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voditelji](
	[radnik_id] [int] NOT NULL,
	[skladisno_mjesto_id] [int] NOT NULL,
 CONSTRAINT [PK_voditelji] PRIMARY KEY CLUSTERED 
(
	[radnik_id] ASC,
	[skladisno_mjesto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_radnici]    Script Date: 20.3.2019. 16:53:40 ******/
CREATE NONCLUSTERED INDEX [IX_radnici] ON [dbo].[radnici]
(
	[prezime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[proizvodi]  WITH CHECK ADD  CONSTRAINT [FK_proizvodi_skladisna_mjesta] FOREIGN KEY([skladiste_id])
REFERENCES [dbo].[skladisna_mjesta] ([id])
GO
ALTER TABLE [dbo].[proizvodi] CHECK CONSTRAINT [FK_proizvodi_skladisna_mjesta]
GO
ALTER TABLE [dbo].[radnici]  WITH CHECK ADD  CONSTRAINT [FK_radnici_skladisna_mjesta] FOREIGN KEY([skladisno_mjesto])
REFERENCES [dbo].[skladisna_mjesta] ([id])
GO
ALTER TABLE [dbo].[radnici] CHECK CONSTRAINT [FK_radnici_skladisna_mjesta]
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD  CONSTRAINT [FK_voditelji_radnici] FOREIGN KEY([radnik_id])
REFERENCES [dbo].[radnici] ([id])
GO
ALTER TABLE [dbo].[voditelji] CHECK CONSTRAINT [FK_voditelji_radnici]
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD  CONSTRAINT [FK_voditelji_skladisna_mjesta] FOREIGN KEY([skladisno_mjesto_id])
REFERENCES [dbo].[skladisna_mjesta] ([id])
GO
ALTER TABLE [dbo].[voditelji] CHECK CONSTRAINT [FK_voditelji_skladisna_mjesta]
GO
ALTER TABLE [dbo].[skladisna_mjesta]  WITH CHECK ADD  CONSTRAINT [ck_provjera] CHECK  (([mjesto]='Sisak' OR [mjesto]='Rijeka' OR [mjesto]='Zagreb'))
GO
ALTER TABLE [dbo].[skladisna_mjesta] CHECK CONSTRAINT [ck_provjera]
GO
USE [master]
GO
ALTER DATABASE [skladista] SET  READ_WRITE 
GO
