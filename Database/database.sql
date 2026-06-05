/* =====================================================================
   LKS SMK Jabar 2026 - IT Software Solution for Business
   Smart Meal Distribution System - SPPG
   Database script: create database + 7 tables + seed data
   Target: SQL Server / LocalDB (MSSQLLocalDB)
   ===================================================================== */

IF DB_ID('SPPGDb') IS NOT NULL
BEGIN
    ALTER DATABASE SPPGDb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SPPGDb;
END
GO

CREATE DATABASE SPPGDb;
GO

USE SPPGDb;
GO

/* ---------- 1. Users ---------- */
CREATE TABLE Users (
    UserId      INT IDENTITY(1,1) PRIMARY KEY,
    Username    VARCHAR(50)  NOT NULL UNIQUE,
    Password    VARCHAR(50)  NOT NULL,
    FullName    VARCHAR(100) NOT NULL,
    Role        VARCHAR(30)  NOT NULL,   -- PetugasSPPG | SupervisorSPPG
    Position    VARCHAR(50)  NULL
);

/* ---------- 2. Employees ---------- */
CREATE TABLE Employees (
    EmployeeId   INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(100) NOT NULL,
    Position     VARCHAR(50)  NULL,
    Phone        VARCHAR(30)  NULL,
    Address      VARCHAR(200) NULL
);

/* ---------- 3. RawMaterials ---------- */
CREATE TABLE RawMaterials (
    MaterialId     INT IDENTITY(1,1) PRIMARY KEY,
    MaterialName   VARCHAR(100)   NOT NULL,
    Category       VARCHAR(50)    NULL,
    Unit           VARCHAR(20)    NULL,
    Stock          DECIMAL(18,2)  NOT NULL DEFAULT 0,
    EstimatedPrice DECIMAL(18,2)  NOT NULL DEFAULT 0
);

/* ---------- 4. Schools ---------- */
CREATE TABLE Schools (
    SchoolId     INT IDENTITY(1,1) PRIMARY KEY,
    SchoolName   VARCHAR(100) NOT NULL,
    Address      VARCHAR(200) NULL,
    PICName      VARCHAR(100) NULL,
    PICPhone     VARCHAR(30)  NULL,
    StudentCount INT          NOT NULL DEFAULT 0
);

/* ---------- 5. KitchenNeeds ---------- */
CREATE TABLE KitchenNeeds (
    NeedId     INT IDENTITY(1,1) PRIMARY KEY,
    NeedDate   DATE           NOT NULL,
    MaterialId INT            NOT NULL,
    Quantity   DECIMAL(18,2)  NOT NULL,
    Unit       VARCHAR(20)    NULL,
    Notes      VARCHAR(200)   NULL,
    CONSTRAINT FK_KitchenNeeds_RawMaterials FOREIGN KEY (MaterialId)
        REFERENCES RawMaterials(MaterialId)
);

/* ---------- 6. SupplierOrders ---------- */
CREATE TABLE SupplierOrders (
    OrderId       INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate     DATE           NOT NULL,
    SupplierName  VARCHAR(100)   NOT NULL,
    MaterialId    INT            NOT NULL,
    OrderQuantity DECIMAL(18,2)  NOT NULL,
    Unit          VARCHAR(20)    NULL,
    Status        VARCHAR(30)    NOT NULL DEFAULT 'Pending', -- Pending | Diproses | Selesai
    Notes         VARCHAR(200)   NULL,
    CONSTRAINT FK_SupplierOrders_RawMaterials FOREIGN KEY (MaterialId)
        REFERENCES RawMaterials(MaterialId)
);

/* ---------- 7. ProductionDistribution ---------- */
CREATE TABLE ProductionDistribution (
    ProcessId          INT IDENTITY(1,1) PRIMARY KEY,
    ProcessDate        DATE         NOT NULL,
    SchoolId           INT          NOT NULL,
    PortionCount       INT          NOT NULL DEFAULT 0,
    ProductionStatus   VARCHAR(30)  NOT NULL DEFAULT 'Belum Diproses', -- Belum Diproses | Diproses | Selesai
    DistributionStatus VARCHAR(30)  NOT NULL DEFAULT 'Belum Dikirim',  -- Belum Dikirim | Dikirim | Selesai
    Notes              VARCHAR(200) NULL,
    CONSTRAINT FK_ProductionDistribution_Schools FOREIGN KEY (SchoolId)
        REFERENCES Schools(SchoolId)
);
GO

/* =====================================================================
   SEED DATA
   ===================================================================== */

-- Users (akun login default)
INSERT INTO Users (Username, Password, FullName, Role, Position) VALUES
('petugas',    'petugas123',    'Regina Wilian',     'PetugasSPPG',    'Petugas Operasional'),
('supervisor', 'supervisor123', 'Victoria Kimberly',  'SupervisorSPPG', 'Supervisor SPPG');

-- Employees
INSERT INTO Employees (EmployeeName, Position, Phone, Address) VALUES
('Catherina Vallencia',     'Petugas Operasional', '081234567890', 'Jl. Lurus No. 12, Depok'),
('Hillary Abigail',  'Supervisor',          '081234567891', 'Jl. Rusak No. 5, Jakarta Timur'),
('Oline Manuel',    'Juru Masak',          '081234567892', 'Jl. Jalan No. 8, Jakarta Barat'),
('Adeline Wijaya',      'Asisten Dapur',       '081234567893', 'Jl. Menuju Roma No. 3, Jakarta Pusat');

-- RawMaterials
INSERT INTO RawMaterials (MaterialName, Category, Unit, Stock, EstimatedPrice) VALUES
('Beras',           'Karbohidrat', 'kg',    50.00, 13000.00),
('Telur Ayam',      'Protein',     'butir', 300.00,  2500.00),
('Daging Ayam',     'Protein',     'kg',    20.00, 35000.00),
('Bayam',           'Sayuran',     'ikat',  30.00,  3500.00),
('Wortel',          'Sayuran',     'kg',    15.00, 12000.00),
('Minyak Goreng',   'Bumbu',       'liter', 25.00, 18000.00),
('Bumbu Dasar',     'Bumbu',       'kg',    10.00, 25000.00),
('Tempe',           'Protein',     'papan', 40.00,  5000.00);

-- Schools
INSERT INTO Schools (SchoolName, Address, PICName, PICPhone, StudentCount) VALUES
('SDN 1 Menteng', 'Jl. Veteran No. 1, Jakarta Pusat',     'Bu Miranda',    '082111222001', 240),
('SMPN 2 Jakarta', 'Jl. Sudirman No. 12, Jakarta Barat',   'Pak Bagas',  '082111222002', 180),
('SMAN 3 Jakarta', 'Jl. Diponegoro No. 7, Jakarta Utara',  'Pak Nadhif',    '082111222003', 200),
('SMKN 4 Jakarta', 'Jl. Cendrawasih No. 4, Jakarta Selatan', 'Pak Brian',  '082111222004', 150);

-- KitchenNeeds (contoh tanggal kemarin & hari ini)
INSERT INTO KitchenNeeds (NeedDate, MaterialId, Quantity, Unit, Notes) VALUES
(CAST(GETDATE() AS DATE), 1, 25.00, 'kg',    'Kebutuhan harian'),
(CAST(GETDATE() AS DATE), 2, 200.00,'butir', 'Untuk lauk telur'),
(CAST(GETDATE() AS DATE), 4, 15.00, 'ikat',  'Sayur bening');

-- SupplierOrders (contoh dengan beragam status)
INSERT INTO SupplierOrders (OrderDate, SupplierName, MaterialId, OrderQuantity, Unit, Status, Notes) VALUES
(CAST(GETDATE() AS DATE), 'CV Bagas 31', 1, 100.00, 'kg',    'Pending',  'Pesanan beras mingguan'),
(CAST(GETDATE() AS DATE), 'UD Ayam Busuk',       3, 30.00,  'kg',    'Diproses', 'Pesanan ayam segar'),
(CAST(GETDATE() AS DATE), 'Toko Sayur Koh Acong 555',    4, 20.00,  'ikat',  'Selesai',  'Bayam sudah diterima');

-- ProductionDistribution (contoh)
INSERT INTO ProductionDistribution (ProcessDate, SchoolId, PortionCount, ProductionStatus, DistributionStatus, Notes) VALUES
(CAST(GETDATE() AS DATE), 1, 240, 'Selesai',  'Dikirim',       'Distribusi pagi'),
(CAST(GETDATE() AS DATE), 2, 180, 'Diproses', 'Belum Dikirim', 'Sedang dimasak'),
(CAST(GETDATE() AS DATE), 3, 200, 'Belum Diproses', 'Belum Dikirim', 'Antrian sore');

GO

PRINT 'Database SPPGDb berhasil dibuat dengan seed data.';
PRINT 'Login awal:';
PRINT '  Petugas    : username=petugas    password=petugas123';
PRINT '  Supervisor : username=supervisor password=supervisor123';
