USE [master]
GO

/****** Object:  Database [EshoppingDB]    Script Date: 22-07-2022 5.55.59 PM ******/
CREATE DATABASE [EshoppingDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EshoppingDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EshoppingDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EshoppingDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EshoppingDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EshoppingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EshoppingDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EshoppingDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EshoppingDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EshoppingDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EshoppingDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [EshoppingDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EshoppingDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EshoppingDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EshoppingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EshoppingDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EshoppingDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EshoppingDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EshoppingDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EshoppingDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EshoppingDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EshoppingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EshoppingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EshoppingDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EshoppingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EshoppingDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EshoppingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EshoppingDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EshoppingDB] SET RECOVERY FULL 
GO

ALTER DATABASE [EshoppingDB] SET  MULTI_USER 
GO

ALTER DATABASE [EshoppingDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EshoppingDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EshoppingDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EshoppingDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EshoppingDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EshoppingDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [EshoppingDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EshoppingDB] SET  READ_WRITE 
GO

