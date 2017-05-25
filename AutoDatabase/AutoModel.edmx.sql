
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2017 01:19:15
-- Generated from EDMX file: D:\My Stuff\Work\Mechanikas\auto-database\AutoDatabase\AutoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AutoShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Client_Id_Car]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Car] DROP CONSTRAINT [FK_Client_Id_Car];
GO
IF OBJECT_ID(N'[dbo].[FK_Job_Distribution_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Job_Distribution] DROP CONSTRAINT [FK_Job_Distribution_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_Job_Distribution_Service]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Job_Distribution] DROP CONSTRAINT [FK_Job_Distribution_Service];
GO
IF OBJECT_ID(N'[dbo].[FK_Job_ToCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Job] DROP CONSTRAINT [FK_Job_ToCar];
GO
IF OBJECT_ID(N'[dbo].[FK_Id_Company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK_Id_Company];
GO
IF OBJECT_ID(N'[dbo].[FK_Id_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [FK_Id_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Service_Id_Job]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Job] DROP CONSTRAINT [FK_Service_Id_Job];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Car]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Car];
GO
IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
GO
IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[Job]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Job];
GO
IF OBJECT_ID(N'[dbo].[Job_Distribution]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Job_Distribution];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[Service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [VIN] nvarchar(50)  NOT NULL,
    [Client_Id] int  NOT NULL,
    [NumberPlate] nvarchar(50)  NULL,
    [Make] nvarchar(50)  NOT NULL,
    [Model] nvarchar(50)  NOT NULL,
    [Run] int  NOT NULL,
    [Engine] nvarchar(50)  NOT NULL,
    [Year] int  NOT NULL,
    [Arrived] bit  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Adress] nvarchar(50)  NOT NULL,
    [Telephone] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Code] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Surname] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Jobs'
CREATE TABLE [dbo].[Jobs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Service_Id] int  NOT NULL,
    [Car_VIN] nvarchar(50)  NOT NULL,
    [Start] datetime  NOT NULL,
    [Hours] float  NULL,
    [Finished] bit  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Surname] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Services'
CREATE TABLE [dbo].[Services] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Price] float  NOT NULL,
    [Default_hours] float  NOT NULL
);
GO

-- Creating table 'Job_Distribution'
CREATE TABLE [dbo].[Job_Distribution] (
    [Employees_Id] int  NOT NULL,
    [Jobs_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [VIN] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([VIN] ASC);
GO

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [PK_Jobs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [PK_Services]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Employees_Id], [Jobs_Id] in table 'Job_Distribution'
ALTER TABLE [dbo].[Job_Distribution]
ADD CONSTRAINT [PK_Job_Distribution]
    PRIMARY KEY CLUSTERED ([Employees_Id], [Jobs_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Client_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_Client_Id_Car]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Client_Id_Car'
CREATE INDEX [IX_FK_Client_Id_Car]
ON [dbo].[Cars]
    ([Client_Id]);
GO

-- Creating foreign key on [Car_VIN] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [FK_Job_ToCar]
    FOREIGN KEY ([Car_VIN])
    REFERENCES [dbo].[Cars]
        ([VIN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Job_ToCar'
CREATE INDEX [IX_FK_Job_ToCar]
ON [dbo].[Jobs]
    ([Car_VIN]);
GO

-- Creating foreign key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [FK_Id_Company]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_Id_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Service_Id] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [FK_Service_Id_Job]
    FOREIGN KEY ([Service_Id])
    REFERENCES [dbo].[Services]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Service_Id_Job'
CREATE INDEX [IX_FK_Service_Id_Job]
ON [dbo].[Jobs]
    ([Service_Id]);
GO

-- Creating foreign key on [Employees_Id] in table 'Job_Distribution'
ALTER TABLE [dbo].[Job_Distribution]
ADD CONSTRAINT [FK_Job_Distribution_Employee]
    FOREIGN KEY ([Employees_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Jobs_Id] in table 'Job_Distribution'
ALTER TABLE [dbo].[Job_Distribution]
ADD CONSTRAINT [FK_Job_Distribution_Job]
    FOREIGN KEY ([Jobs_Id])
    REFERENCES [dbo].[Jobs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Job_Distribution_Job'
CREATE INDEX [IX_FK_Job_Distribution_Job]
ON [dbo].[Job_Distribution]
    ([Jobs_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------