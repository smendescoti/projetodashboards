IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [MovimentacaoFinanceira] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(150) NOT NULL,
    [Data] date NOT NULL,
    [Valor] decimal(18,2) NOT NULL,
    [TipoMovimentacao] int NOT NULL,
    CONSTRAINT [PK_MovimentacaoFinanceira] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201211233705_Initial', N'3.1.10');

GO

