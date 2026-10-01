-- Лабораторная работа №8. Создание базы данных StudentDB вручную
-- (приложение создаёт базу и таблицу автоматически при первом запуске,
-- этот скрипт нужен только для ручной настройки на "боевом" SQL Server).

IF DB_ID('StudentDB') IS NULL
    CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

IF OBJECT_ID('dbo.Students', 'U') IS NULL
CREATE TABLE dbo.Students (
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    Surname    NVARCHAR(50) NOT NULL,
    Name       NVARCHAR(50) NOT NULL,
    GroupName  NVARCHAR(20) NOT NULL,
    Course     INT NOT NULL
);
GO
