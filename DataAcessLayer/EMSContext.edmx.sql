
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/13/2018 13:55:00
-- Generated from EDMX file: E:\My Projects\EmployerManagementSystem\EmployerManagementSystem\DataAcessLayer\EMSContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AssociationEmployer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_AssociationEmployer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Employers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EmployeeId] int IDENTITY(1,1) NOT NULL,
    [EmployeeCode] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [Designation] nvarchar(max)  NULL,
    [DepartmentCode] nvarchar(max)  NOT NULL,
    [EmployerId] int  NOT NULL
);
GO

-- Creating table 'Employers'
CREATE TABLE [dbo].[Employers] (
    [EmployerId] int IDENTITY(1,1) NOT NULL,
    [EmployerCode] nvarchar(max)  NOT NULL,
    [EmployerName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmployeeId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC);
GO

-- Creating primary key on [EmployerId] in table 'Employers'
ALTER TABLE [dbo].[Employers]
ADD CONSTRAINT [PK_Employers]
    PRIMARY KEY CLUSTERED ([EmployerId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployerId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_AssociationEmployer]
    FOREIGN KEY ([EmployerId])
    REFERENCES [dbo].[Employers]
        ([EmployerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AssociationEmployer'
CREATE INDEX [IX_FK_AssociationEmployer]
ON [dbo].[Employees]
    ([EmployerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------