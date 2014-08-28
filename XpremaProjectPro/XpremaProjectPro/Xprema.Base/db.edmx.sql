
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/28/2014 15:48:09
-- Generated from EDMX file: C:\Users\Heroo\Documents\GitHub\XpremaProject\XpremaProjectPro\XpremaProjectPro\Xprema.Base\db.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Xprema Prject];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AccountTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_AccountTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_Contracts_Accounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contracts] DROP CONSTRAINT [FK_Contracts_Accounts];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeContract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contracts] DROP CONSTRAINT [FK_EmployeeContract];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectActivities_Accounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectActivities] DROP CONSTRAINT [FK_ProjectActivities_Accounts];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectActivityProjectSubActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectSubActivities] DROP CONSTRAINT [FK_ProjectActivityProjectSubActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectExpenses_Accounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectExpenses_Accounts];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectOrderAttachment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attachments] DROP CONSTRAINT [FK_ProjectOrderAttachment];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileAttachment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attachments] DROP CONSTRAINT [FK_ProjectProfileAttachment];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileContract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contracts] DROP CONSTRAINT [FK_ProjectProfileContract];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileProjectActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectActivities] DROP CONSTRAINT [FK_ProjectProfileProjectActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileProjectOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectOrders] DROP CONSTRAINT [FK_ProjectProfileProjectOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfiles_Accounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectProfiles] DROP CONSTRAINT [FK_ProjectProfiles_Accounts];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectSubActivities_Accounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectSubActivities] DROP CONSTRAINT [FK_ProjectSubActivities_Accounts];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectSubActivityProjectExpens]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectSubActivityProjectExpens];
GO
IF OBJECT_ID(N'[dbo].[FK_SubTheFinancerAndProject_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubTheFinancerAndProject] DROP CONSTRAINT [FK_SubTheFinancerAndProject_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_SubTheFinancerAndProject_Thefinanciers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubTheFinancerAndProject] DROP CONSTRAINT [FK_SubTheFinancerAndProject_Thefinanciers];
GO
IF OBJECT_ID(N'[dbo].[FK_SupplierProjectExpens]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_SupplierProjectExpens];
GO
IF OBJECT_ID(N'[dbo].[FK_SystemPermessionGroupPermession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupPermessions] DROP CONSTRAINT [FK_SystemPermessionGroupPermession];
GO
IF OBJECT_ID(N'[dbo].[FK_Thefinanciers_Accounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Thefinanciers] DROP CONSTRAINT [FK_Thefinanciers_Accounts];
GO
IF OBJECT_ID(N'[dbo].[FK_UserGroupGroupPermession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupPermessions] DROP CONSTRAINT [FK_UserGroupGroupPermession];
GO
IF OBJECT_ID(N'[dbo].[FK_UserGroupUserSystem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSystems] DROP CONSTRAINT [FK_UserGroupUserSystem];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accounts];
GO
IF OBJECT_ID(N'[dbo].[Attachments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Attachments];
GO
IF OBJECT_ID(N'[dbo].[Contracts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contracts];
GO
IF OBJECT_ID(N'[dbo].[DailyMovemnts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DailyMovemnts];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[GroupPermessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupPermessions];
GO
IF OBJECT_ID(N'[dbo].[ProjectActivities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectActivities];
GO
IF OBJECT_ID(N'[dbo].[ProjectExpenses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectExpenses];
GO
IF OBJECT_ID(N'[dbo].[ProjectOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectOrders];
GO
IF OBJECT_ID(N'[dbo].[ProjectProfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[ProjectSubActivities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectSubActivities];
GO
IF OBJECT_ID(N'[dbo].[SubTheFinancerAndProject]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubTheFinancerAndProject];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[SystemPermessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SystemPermessions];
GO
IF OBJECT_ID(N'[dbo].[Thefinanciers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Thefinanciers];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[UserGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserGroups];
GO
IF OBJECT_ID(N'[dbo].[UserSystems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSystems];
GO
IF OBJECT_ID(N'[DataXStoreContainer].[View_Account_ByBalance]', 'U') IS NOT NULL
    DROP TABLE [DataXStoreContainer].[View_Account_ByBalance];
GO
IF OBJECT_ID(N'[DataXStoreContainer].[View_AccountDetails]', 'U') IS NOT NULL
    DROP TABLE [DataXStoreContainer].[View_AccountDetails];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AccountName] nvarchar(max)  NULL,
    [AccountDescription] nvarchar(max)  NULL,
    [Coin] nvarchar(max)  NULL,
    [AccountNatural] nvarchar(max)  NULL
);
GO

-- Creating table 'Attachments'
CREATE TABLE [dbo].[Attachments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AttachmentName] nvarchar(max)  NULL,
    [CreateDate] datetime  NOT NULL,
    [fileContent] varbinary(max)  NOT NULL,
    [ProjectProfile_ID] int  NULL,
    [ProjectOrder_ID] int  NULL
);
GO

-- Creating table 'Contracts'
CREATE TABLE [dbo].[Contracts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [SelaryAmount] float  NOT NULL,
    [Status] bit  NOT NULL,
    [EmplyeeAccount_ID] int  NULL,
    [Employee_ID] int  NOT NULL,
    [ProjectProfile_ID] int  NOT NULL,
    [UserID] int  NULL
);
GO

-- Creating table 'DailyMovemnts'
CREATE TABLE [dbo].[DailyMovemnts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FromAccout] int  NOT NULL,
    [ToAccount] int  NOT NULL,
    [Amount] float  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateOfProcess] datetime  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [EmployeeName] nvarchar(max)  NULL,
    [EmployeejobNumber] nvarchar(max)  NULL,
    [EmployeeGender] nvarchar(max)  NULL,
    [EmployeeNationalNumber] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Mobilenumber] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL
);
GO

-- Creating table 'GroupPermessions'
CREATE TABLE [dbo].[GroupPermessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [permessionValue] bit  NOT NULL,
    [SystemPermession_Id] int  NOT NULL,
    [UserGroup_Id] int  NOT NULL
);
GO

-- Creating table 'ProjectActivities'
CREATE TABLE [dbo].[ProjectActivities] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ActivityName] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Status] nvarchar(max)  NULL,
    [Progress] int  NOT NULL,
    [TotalCost] float  NOT NULL,
    [ProjectProfile_ID] int  NOT NULL,
    [Account_ID] int  NULL
);
GO

-- Creating table 'ProjectExpenses'
CREATE TABLE [dbo].[ProjectExpenses] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ExpensesName] nvarchar(max)  NULL,
    [DateofProcess] datetime  NOT NULL,
    [BillNumber] nvarchar(max)  NULL,
    [RequiarAmount] float  NOT NULL,
    [CashingNumber] nvarchar(max)  NULL,
    [ProjectSubActivity_ID] int  NOT NULL,
    [Account_ID] int  NULL,
    [Supplier_ID] int  NULL
);
GO

-- Creating table 'ProjectOrders'
CREATE TABLE [dbo].[ProjectOrders] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderTitle] nvarchar(max)  NULL,
    [OrderBody] nvarchar(max)  NULL,
    [OrderDate] datetime  NOT NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'ProjectProfiles'
CREATE TABLE [dbo].[ProjectProfiles] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProjectName] nvarchar(max)  NULL,
    [ProjectDescription] nvarchar(max)  NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Status] nvarchar(max)  NULL,
    [progress] int  NOT NULL,
    [TotalCost] float  NOT NULL,
    [AccountID] int  NULL
);
GO

-- Creating table 'ProjectSubActivities'
CREATE TABLE [dbo].[ProjectSubActivities] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SubActivityName] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [Startdate] datetime  NOT NULL,
    [enddate] datetime  NOT NULL,
    [Status] nvarchar(max)  NULL,
    [Persentage] int  NOT NULL,
    [TotalCost] float  NOT NULL,
    [ProjectActivity_ID] int  NOT NULL,
    [Account_ID] int  NULL
);
GO

-- Creating table 'SubTheFinancerAndProjects'
CREATE TABLE [dbo].[SubTheFinancerAndProjects] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProjectID] int  NULL,
    [FinacerID] int  NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [SuppliersNatural] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Adderss] nvarchar(max)  NULL
);
GO

-- Creating table 'SystemPermessions'
CREATE TABLE [dbo].[SystemPermessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PermessionName] nvarchar(max)  NOT NULL,
    [PropertyName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Thefinanciers'
CREATE TABLE [dbo].[Thefinanciers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [financiername] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [agentName] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Adderss] nvarchar(max)  NULL,
    [AccountID] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DateOfTransaction] datetime  NOT NULL,
    [TotalIn] float  NOT NULL,
    [TotalOut] float  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [CommandNames] nvarchar(max)  NULL,
    [Account_ID] int  NOT NULL
);
GO

-- Creating table 'UserGroups'
CREATE TABLE [dbo].[UserGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GroupName] nvarchar(max)  NOT NULL,
    [GroupDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSystems'
CREATE TABLE [dbo].[UserSystems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [UserGroup_Id] int  NULL
);
GO

-- Creating table 'View_Account_ByBalance'
CREATE TABLE [dbo].[View_Account_ByBalance] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AccountName] nvarchar(max)  NULL,
    [AccountDescription] nvarchar(max)  NULL,
    [Coin] nvarchar(max)  NULL,
    [balance] float  NULL,
    [FormatedBalance] nvarchar(max)  NULL
);
GO

-- Creating table 'View_AccountDetails'
CREATE TABLE [dbo].[View_AccountDetails] (
    [ID] int  NOT NULL,
    [AccountName] nvarchar(max)  NULL,
    [AccountDescription] nvarchar(max)  NULL,
    [Coin] nvarchar(max)  NULL,
    [Balance] float  NULL,
    [AllDeposes] float  NULL,
    [AllWishdrowls] float  NULL,
    [ProcessID] int  NOT NULL,
    [DateOfTransaction] datetime  NOT NULL,
    [TotalIn] float  NOT NULL,
    [TotalOut] float  NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [PK_Attachments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [PK_Contracts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'DailyMovemnts'
ALTER TABLE [dbo].[DailyMovemnts]
ADD CONSTRAINT [PK_DailyMovemnts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'GroupPermessions'
ALTER TABLE [dbo].[GroupPermessions]
ADD CONSTRAINT [PK_GroupPermessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [PK_ProjectActivities]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [PK_ProjectExpenses]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectOrders'
ALTER TABLE [dbo].[ProjectOrders]
ADD CONSTRAINT [PK_ProjectOrders]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectProfiles'
ALTER TABLE [dbo].[ProjectProfiles]
ADD CONSTRAINT [PK_ProjectProfiles]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [PK_ProjectSubActivities]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SubTheFinancerAndProjects'
ALTER TABLE [dbo].[SubTheFinancerAndProjects]
ADD CONSTRAINT [PK_SubTheFinancerAndProjects]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'SystemPermessions'
ALTER TABLE [dbo].[SystemPermessions]
ADD CONSTRAINT [PK_SystemPermessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'Thefinanciers'
ALTER TABLE [dbo].[Thefinanciers]
ADD CONSTRAINT [PK_Thefinanciers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'UserGroups'
ALTER TABLE [dbo].[UserGroups]
ADD CONSTRAINT [PK_UserGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [PK_UserSystems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'View_Account_ByBalance'
ALTER TABLE [dbo].[View_Account_ByBalance]
ADD CONSTRAINT [PK_View_Account_ByBalance]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID], [ProcessID], [DateOfTransaction], [TotalIn], [TotalOut] in table 'View_AccountDetails'
ALTER TABLE [dbo].[View_AccountDetails]
ADD CONSTRAINT [PK_View_AccountDetails]
    PRIMARY KEY CLUSTERED ([ID], [ProcessID], [DateOfTransaction], [TotalIn], [TotalOut] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Account_ID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_AccountTransaction]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountTransaction'
CREATE INDEX [IX_FK_AccountTransaction]
ON [dbo].[Transactions]
    ([Account_ID]);
GO

-- Creating foreign key on [Account_ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [FK_ProjectActivities_Accounts]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectActivities_Accounts'
CREATE INDEX [IX_FK_ProjectActivities_Accounts]
ON [dbo].[ProjectActivities]
    ([Account_ID]);
GO

-- Creating foreign key on [Account_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_ProjectExpenses_Accounts]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectExpenses_Accounts'
CREATE INDEX [IX_FK_ProjectExpenses_Accounts]
ON [dbo].[ProjectExpenses]
    ([Account_ID]);
GO

-- Creating foreign key on [AccountID] in table 'ProjectProfiles'
ALTER TABLE [dbo].[ProjectProfiles]
ADD CONSTRAINT [FK_ProjectProfiles_Accounts]
    FOREIGN KEY ([AccountID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfiles_Accounts'
CREATE INDEX [IX_FK_ProjectProfiles_Accounts]
ON [dbo].[ProjectProfiles]
    ([AccountID]);
GO

-- Creating foreign key on [Account_ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [FK_ProjectSubActivities_Accounts]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectSubActivities_Accounts'
CREATE INDEX [IX_FK_ProjectSubActivities_Accounts]
ON [dbo].[ProjectSubActivities]
    ([Account_ID]);
GO

-- Creating foreign key on [AccountID] in table 'Thefinanciers'
ALTER TABLE [dbo].[Thefinanciers]
ADD CONSTRAINT [FK_Thefinanciers_Accounts]
    FOREIGN KEY ([AccountID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Thefinanciers_Accounts'
CREATE INDEX [IX_FK_Thefinanciers_Accounts]
ON [dbo].[Thefinanciers]
    ([AccountID]);
GO

-- Creating foreign key on [ProjectOrder_ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [FK_ProjectOrderAttachment]
    FOREIGN KEY ([ProjectOrder_ID])
    REFERENCES [dbo].[ProjectOrders]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectOrderAttachment'
CREATE INDEX [IX_FK_ProjectOrderAttachment]
ON [dbo].[Attachments]
    ([ProjectOrder_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [FK_ProjectProfileAttachment]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileAttachment'
CREATE INDEX [IX_FK_ProjectProfileAttachment]
ON [dbo].[Attachments]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [UserID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_Contracts_Accounts]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[UserSystems]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Contracts_Accounts'
CREATE INDEX [IX_FK_Contracts_Accounts]
ON [dbo].[Contracts]
    ([UserID]);
GO

-- Creating foreign key on [Employee_ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_EmployeeContract]
    FOREIGN KEY ([Employee_ID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeContract'
CREATE INDEX [IX_FK_EmployeeContract]
ON [dbo].[Contracts]
    ([Employee_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_ProjectProfileContract]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileContract'
CREATE INDEX [IX_FK_ProjectProfileContract]
ON [dbo].[Contracts]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [SystemPermession_Id] in table 'GroupPermessions'
ALTER TABLE [dbo].[GroupPermessions]
ADD CONSTRAINT [FK_SystemPermessionGroupPermession]
    FOREIGN KEY ([SystemPermession_Id])
    REFERENCES [dbo].[SystemPermessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SystemPermessionGroupPermession'
CREATE INDEX [IX_FK_SystemPermessionGroupPermession]
ON [dbo].[GroupPermessions]
    ([SystemPermession_Id]);
GO

-- Creating foreign key on [UserGroup_Id] in table 'GroupPermessions'
ALTER TABLE [dbo].[GroupPermessions]
ADD CONSTRAINT [FK_UserGroupGroupPermession]
    FOREIGN KEY ([UserGroup_Id])
    REFERENCES [dbo].[UserGroups]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserGroupGroupPermession'
CREATE INDEX [IX_FK_UserGroupGroupPermession]
ON [dbo].[GroupPermessions]
    ([UserGroup_Id]);
GO

-- Creating foreign key on [ProjectActivity_ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [FK_ProjectActivityProjectSubActivity]
    FOREIGN KEY ([ProjectActivity_ID])
    REFERENCES [dbo].[ProjectActivities]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectActivityProjectSubActivity'
CREATE INDEX [IX_FK_ProjectActivityProjectSubActivity]
ON [dbo].[ProjectSubActivities]
    ([ProjectActivity_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [FK_ProjectProfileProjectActivity]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileProjectActivity'
CREATE INDEX [IX_FK_ProjectProfileProjectActivity]
ON [dbo].[ProjectActivities]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ProjectSubActivity_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_ProjectSubActivityProjectExpens]
    FOREIGN KEY ([ProjectSubActivity_ID])
    REFERENCES [dbo].[ProjectSubActivities]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectSubActivityProjectExpens'
CREATE INDEX [IX_FK_ProjectSubActivityProjectExpens]
ON [dbo].[ProjectExpenses]
    ([ProjectSubActivity_ID]);
GO

-- Creating foreign key on [Supplier_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_SupplierProjectExpens]
    FOREIGN KEY ([Supplier_ID])
    REFERENCES [dbo].[Suppliers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierProjectExpens'
CREATE INDEX [IX_FK_SupplierProjectExpens]
ON [dbo].[ProjectExpenses]
    ([Supplier_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'ProjectOrders'
ALTER TABLE [dbo].[ProjectOrders]
ADD CONSTRAINT [FK_ProjectProfileProjectOrder]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileProjectOrder'
CREATE INDEX [IX_FK_ProjectProfileProjectOrder]
ON [dbo].[ProjectOrders]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ProjectID] in table 'SubTheFinancerAndProjects'
ALTER TABLE [dbo].[SubTheFinancerAndProjects]
ADD CONSTRAINT [FK_SubTheFinancerAndProject_ProjectProfiles]
    FOREIGN KEY ([ProjectID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SubTheFinancerAndProject_ProjectProfiles'
CREATE INDEX [IX_FK_SubTheFinancerAndProject_ProjectProfiles]
ON [dbo].[SubTheFinancerAndProjects]
    ([ProjectID]);
GO

-- Creating foreign key on [FinacerID] in table 'SubTheFinancerAndProjects'
ALTER TABLE [dbo].[SubTheFinancerAndProjects]
ADD CONSTRAINT [FK_SubTheFinancerAndProject_Thefinanciers]
    FOREIGN KEY ([FinacerID])
    REFERENCES [dbo].[Thefinanciers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SubTheFinancerAndProject_Thefinanciers'
CREATE INDEX [IX_FK_SubTheFinancerAndProject_Thefinanciers]
ON [dbo].[SubTheFinancerAndProjects]
    ([FinacerID]);
GO

-- Creating foreign key on [UserGroup_Id] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [FK_UserGroupUserSystem]
    FOREIGN KEY ([UserGroup_Id])
    REFERENCES [dbo].[UserGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserGroupUserSystem'
CREATE INDEX [IX_FK_UserGroupUserSystem]
ON [dbo].[UserSystems]
    ([UserGroup_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------