
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/20/2020 17:10:36
-- Generated from EDMX file: C:\Users\ery_c\Desktop\Programacao\C#\SysFrantheskC-\Franthesk\Franthesk\Model\dbFranthesk.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [franthesk];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MERCADORIA_MERCADORIA_VENDA1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MERCADORIA_VENDA] DROP CONSTRAINT [FK_MERCADORIA_MERCADORIA_VENDA1];
GO
IF OBJECT_ID(N'[dbo].[FK_VENDA_MERCADORIA_VENDA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MERCADORIA_VENDA] DROP CONSTRAINT [FK_VENDA_MERCADORIA_VENDA];
GO
IF OBJECT_ID(N'[dbo].[FK_MOVIMENTO_CAIXA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MOVIMENTO] DROP CONSTRAINT [FK_MOVIMENTO_CAIXA];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CAIXA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CAIXA];
GO
IF OBJECT_ID(N'[dbo].[COMISSAO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[COMISSAO];
GO
IF OBJECT_ID(N'[dbo].[MERCADORIA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MERCADORIA];
GO
IF OBJECT_ID(N'[dbo].[MERCADORIA_VENDA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MERCADORIA_VENDA];
GO
IF OBJECT_ID(N'[dbo].[MOVIMENTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MOVIMENTO];
GO
IF OBJECT_ID(N'[dbo].[USUARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIO];
GO
IF OBJECT_ID(N'[dbo].[VENDA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENDA];
GO
IF OBJECT_ID(N'[dbo].[CATEGORIAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CATEGORIAS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CAIXA'
CREATE TABLE [dbo].[CAIXA] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [DT_Data] varchar(50)  NULL,
    [VL_ValorDinheiroAdmin] float  NULL,
    [VL_ValorCartaoAdmin] float  NULL,
    [VL_ValorDinheiroFunc] float  NULL,
    [VL_ValorCartaoFunc] float  NULL,
    [NM_Status] varchar(50)  NULL,
    [VL_ValorInicial] float  NULL
);
GO

-- Creating table 'COMISSAO'
CREATE TABLE [dbo].[COMISSAO] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [DT_Data] varchar(50)  NULL,
    [VL_Total] float  NULL,
    [VL_Comissao] float  NULL
);
GO

-- Creating table 'MERCADORIA'
CREATE TABLE [dbo].[MERCADORIA] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [CD_Referencia] int  NULL,
    [NM_Nome] varchar(50)  NULL,
    [TG_Categoria] varchar(50)  NULL,
    [DT_Data] varchar(50)  NULL,
    [VL_ValorCompra] float  NULL,
    [VL_ValorVenda] float  NULL,
    [VL_Estoque] int  NULL
);
GO

-- Creating table 'MERCADORIA_VENDA'
CREATE TABLE [dbo].[MERCADORIA_VENDA] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [CD_Mercadoria] int  NULL,
    [CD_Venda] int  NULL,
    [QT_Quantidade] int  NULL
);
GO

-- Creating table 'MOVIMENTO'
CREATE TABLE [dbo].[MOVIMENTO] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [DT_Hora] varchar(50)  NULL,
    [VL_Valor] float  NULL,
    [TX_Descricao] varchar(max)  NULL,
    [CD_Caixa] int  NULL
);
GO

-- Creating table 'USUARIO'
CREATE TABLE [dbo].[USUARIO] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [NM_Nome] varchar(100)  NULL,
    [TG_Login] varchar(50)  NULL,
    [NR_Senha] varchar(50)  NULL,
    [CD_Admin] int  NULL,
    [NR_Tel] varchar(50)  NULL,
    [TX_ENDE] varchar(max)  NOT NULL
);
GO

-- Creating table 'VENDA'
CREATE TABLE [dbo].[VENDA] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [NM_Vendedor] varchar(50)  NULL,
    [DT_Data] varchar(50)  NULL,
    [VL_ValorTotal] float  NULL,
    [CD_Cartao] int  NULL
);
GO

-- Creating table 'CATEGORIAS'
CREATE TABLE [dbo].[CATEGORIAS] (
    [CD_ID] int IDENTITY(1,1) NOT NULL,
    [CD_Nome] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CD_ID] in table 'CAIXA'
ALTER TABLE [dbo].[CAIXA]
ADD CONSTRAINT [PK_CAIXA]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- Creating primary key on [CD_ID] in table 'COMISSAO'
ALTER TABLE [dbo].[COMISSAO]
ADD CONSTRAINT [PK_COMISSAO]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- Creating primary key on [CD_ID] in table 'MERCADORIA'
ALTER TABLE [dbo].[MERCADORIA]
ADD CONSTRAINT [PK_MERCADORIA]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- Creating primary key on [CD_ID] in table 'MERCADORIA_VENDA'
ALTER TABLE [dbo].[MERCADORIA_VENDA]
ADD CONSTRAINT [PK_MERCADORIA_VENDA]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- Creating primary key on [CD_ID] in table 'MOVIMENTO'
ALTER TABLE [dbo].[MOVIMENTO]
ADD CONSTRAINT [PK_MOVIMENTO]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- Creating primary key on [CD_ID] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [PK_USUARIO]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- Creating primary key on [CD_ID] in table 'VENDA'
ALTER TABLE [dbo].[VENDA]
ADD CONSTRAINT [PK_VENDA]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- Creating primary key on [CD_ID] in table 'CATEGORIAS'
ALTER TABLE [dbo].[CATEGORIAS]
ADD CONSTRAINT [PK_CATEGORIAS]
    PRIMARY KEY CLUSTERED ([CD_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CD_Mercadoria] in table 'MERCADORIA_VENDA'
ALTER TABLE [dbo].[MERCADORIA_VENDA]
ADD CONSTRAINT [FK_MERCADORIA_MERCADORIA_VENDA1]
    FOREIGN KEY ([CD_Mercadoria])
    REFERENCES [dbo].[MERCADORIA]
        ([CD_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MERCADORIA_MERCADORIA_VENDA1'
CREATE INDEX [IX_FK_MERCADORIA_MERCADORIA_VENDA1]
ON [dbo].[MERCADORIA_VENDA]
    ([CD_Mercadoria]);
GO

-- Creating foreign key on [CD_Venda] in table 'MERCADORIA_VENDA'
ALTER TABLE [dbo].[MERCADORIA_VENDA]
ADD CONSTRAINT [FK_VENDA_MERCADORIA_VENDA]
    FOREIGN KEY ([CD_Venda])
    REFERENCES [dbo].[VENDA]
        ([CD_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENDA_MERCADORIA_VENDA'
CREATE INDEX [IX_FK_VENDA_MERCADORIA_VENDA]
ON [dbo].[MERCADORIA_VENDA]
    ([CD_Venda]);
GO

-- Creating foreign key on [CD_Caixa] in table 'MOVIMENTO'
ALTER TABLE [dbo].[MOVIMENTO]
ADD CONSTRAINT [FK_MOVIMENTO_CAIXA]
    FOREIGN KEY ([CD_Caixa])
    REFERENCES [dbo].[CAIXA]
        ([CD_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MOVIMENTO_CAIXA'
CREATE INDEX [IX_FK_MOVIMENTO_CAIXA]
ON [dbo].[MOVIMENTO]
    ([CD_Caixa]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------