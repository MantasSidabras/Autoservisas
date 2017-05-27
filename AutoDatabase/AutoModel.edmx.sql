
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2017 21:25:41
-- Generated from EDMX file: C:\Users\Matas\Desktop\Autoservisas\AutoDatabase\AutoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
--GO
--USE [AutoShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Client_Id_Car]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_Client_Id_Car];
GO
IF OBJECT_ID(N'[dbo].[FK_Job_ToCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jobs] DROP CONSTRAINT [FK_Job_ToCar];
GO
IF OBJECT_ID(N'[dbo].[FK_Id_Company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Companies] DROP CONSTRAINT [FK_Id_Company];
GO
IF OBJECT_ID(N'[dbo].[FK_Id_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_Id_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Service_Id_Job]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jobs] DROP CONSTRAINT [FK_Service_Id_Job];
GO
IF OBJECT_ID(N'[dbo].[FK_Job_Distribution_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Job_Distribution] DROP CONSTRAINT [FK_Job_Distribution_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_Job_Distribution_Job]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Job_Distribution] DROP CONSTRAINT [FK_Job_Distribution_Job];
GO
IF OBJECT_ID(N'[dbo].[FK_GarageClient_Garage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GarageClient] DROP CONSTRAINT [FK_GarageClient_Garage];
GO
IF OBJECT_ID(N'[dbo].[FK_GarageClient_Client]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GarageClient] DROP CONSTRAINT [FK_GarageClient_Client];
GO
IF OBJECT_ID(N'[dbo].[FK_GarageEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_GarageEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_GarageReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reviews] DROP CONSTRAINT [FK_GarageReview];
GO
IF OBJECT_ID(N'[dbo].[FK_GarageService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Services] DROP CONSTRAINT [FK_GarageService];
GO
IF OBJECT_ID(N'[dbo].[FK_DiscountService_Discount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DiscountService] DROP CONSTRAINT [FK_DiscountService_Discount];
GO
IF OBJECT_ID(N'[dbo].[FK_DiscountService_Service]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DiscountService] DROP CONSTRAINT [FK_DiscountService_Service];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cars];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companies];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Jobs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jobs];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Services];
GO
IF OBJECT_ID(N'[dbo].[Garages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Garages];
GO
IF OBJECT_ID(N'[dbo].[Reviews]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reviews];
GO
IF OBJECT_ID(N'[dbo].[Discounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discounts];
GO
IF OBJECT_ID(N'[dbo].[Job_Distribution]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Job_Distribution];
GO
IF OBJECT_ID(N'[dbo].[GarageClient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GarageClient];
GO
IF OBJECT_ID(N'[dbo].[DiscountService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiscountService];
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
    [Telephone] nvarchar(30)  NOT NULL,
    [User_Id] int  NULL
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
    [Surname] nvarchar(50)  NOT NULL,
    [GarageId] int  NOT NULL
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
    [Default_hours] float  NOT NULL,
    [GarageId] int  NOT NULL
);
GO

-- Creating table 'Garages'
CREATE TABLE [dbo].[Garages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [BankAccount] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Owner] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Reviews'
CREATE TABLE [dbo].[Reviews] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Rating] smallint  NOT NULL,
    [GarageId] int  NOT NULL
);
GO

-- Creating table 'Discounts'
CREATE TABLE [dbo].[Discounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Percentage] smallint  NOT NULL,
    [UsesLeft] bigint  NOT NULL,
    [LimitedUse] bit  NOT NULL,
    [ExpirationDate] datetime  NOT NULL,
    [PictureName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [PasswordHash] nvarchar(max)  NOT NULL,
    [IsAdmin] bit  NOT NULL
);
GO

-- Creating table 'Job_Distribution'
CREATE TABLE [dbo].[Job_Distribution] (
    [Employees_Id] int  NOT NULL,
    [Jobs_Id] int  NOT NULL
);
GO

-- Creating table 'GarageClient'
CREATE TABLE [dbo].[GarageClient] (
    [Garages_Id] int  NOT NULL,
    [Clients_Id] int  NOT NULL
);
GO

-- Creating table 'DiscountService'
CREATE TABLE [dbo].[DiscountService] (
    [Discounts_Id] int  NOT NULL,
    [Services_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'Garages'
ALTER TABLE [dbo].[Garages]
ADD CONSTRAINT [PK_Garages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [PK_Reviews]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Discounts'
ALTER TABLE [dbo].[Discounts]
ADD CONSTRAINT [PK_Discounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Employees_Id], [Jobs_Id] in table 'Job_Distribution'
ALTER TABLE [dbo].[Job_Distribution]
ADD CONSTRAINT [PK_Job_Distribution]
    PRIMARY KEY CLUSTERED ([Employees_Id], [Jobs_Id] ASC);
GO

-- Creating primary key on [Garages_Id], [Clients_Id] in table 'GarageClient'
ALTER TABLE [dbo].[GarageClient]
ADD CONSTRAINT [PK_GarageClient]
    PRIMARY KEY CLUSTERED ([Garages_Id], [Clients_Id] ASC);
GO

-- Creating primary key on [Discounts_Id], [Services_Id] in table 'DiscountService'
ALTER TABLE [dbo].[DiscountService]
ADD CONSTRAINT [PK_DiscountService]
    PRIMARY KEY CLUSTERED ([Discounts_Id], [Services_Id] ASC);
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

-- Creating foreign key on [Garages_Id] in table 'GarageClient'
ALTER TABLE [dbo].[GarageClient]
ADD CONSTRAINT [FK_GarageClient_Garage]
    FOREIGN KEY ([Garages_Id])
    REFERENCES [dbo].[Garages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Clients_Id] in table 'GarageClient'
ALTER TABLE [dbo].[GarageClient]
ADD CONSTRAINT [FK_GarageClient_Client]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GarageClient_Client'
CREATE INDEX [IX_FK_GarageClient_Client]
ON [dbo].[GarageClient]
    ([Clients_Id]);
GO

-- Creating foreign key on [GarageId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_GarageEmployee]
    FOREIGN KEY ([GarageId])
    REFERENCES [dbo].[Garages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GarageEmployee'
CREATE INDEX [IX_FK_GarageEmployee]
ON [dbo].[Employees]
    ([GarageId]);
GO

-- Creating foreign key on [GarageId] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [FK_GarageReview]
    FOREIGN KEY ([GarageId])
    REFERENCES [dbo].[Garages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GarageReview'
CREATE INDEX [IX_FK_GarageReview]
ON [dbo].[Reviews]
    ([GarageId]);
GO

-- Creating foreign key on [GarageId] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [FK_GarageService]
    FOREIGN KEY ([GarageId])
    REFERENCES [dbo].[Garages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GarageService'
CREATE INDEX [IX_FK_GarageService]
ON [dbo].[Services]
    ([GarageId]);
GO

-- Creating foreign key on [Discounts_Id] in table 'DiscountService'
ALTER TABLE [dbo].[DiscountService]
ADD CONSTRAINT [FK_DiscountService_Discount]
    FOREIGN KEY ([Discounts_Id])
    REFERENCES [dbo].[Discounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Services_Id] in table 'DiscountService'
ALTER TABLE [dbo].[DiscountService]
ADD CONSTRAINT [FK_DiscountService_Service]
    FOREIGN KEY ([Services_Id])
    REFERENCES [dbo].[Services]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiscountService_Service'
CREATE INDEX [IX_FK_DiscountService_Service]
ON [dbo].[DiscountService]
    ([Services_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [FK_UserClient]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserClient'
CREATE INDEX [IX_FK_UserClient]
ON [dbo].[Clients]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------