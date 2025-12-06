CREATE TABLE Parties (
    PartyID INT IDENTITY PRIMARY KEY,
    Role VARCHAR(10) NOT NULL, -- 'Issuer' or 'Receiver'
    Type CHAR(1) NOT NULL,     -- B, P, F
    RegID VARCHAR(50) NOT NULL, -- id
    Name NVARCHAR(200) NOT NULL,

    -- Address
    Country CHAR(2) NOT NULL,
    Governate NVARCHAR(100) NOT NULL,
    RegionCity NVARCHAR(100) NOT NULL,
    Street NVARCHAR(200) NOT NULL,
    BuildingNumber NVARCHAR(50) NOT NULL
);

CREATE TABLE Invoices (
    InvoiceID INT IDENTITY PRIMARY KEY,

    IssuerID INT NOT NULL FOREIGN KEY REFERENCES Parties(PartyID),
    ReceiverID INT NOT NULL FOREIGN KEY REFERENCES Parties(PartyID),

    DocumentType CHAR(1) NOT NULL DEFAULT 'i', -- must be 'i'
    DocumentTypeVersion VARCHAR(10) NOT NULL DEFAULT '1.0',

    DateTimeIssued DATETIME2 NOT NULL, -- must not be future
    TaxpayerActivityCode VARCHAR(10) NOT NULL,
    InternalId VARCHAR(100) NOT NULL,

    BranchID VARCHAR(10) NOT NULL, -- issuer branchId (mandatory for type B issuer)

    -- Totals (stored, but must match computed totals)
    TotalSalesAmount DECIMAL(18,5) NOT NULL,
    TotalDiscountAmount DECIMAL(18,5) NOT NULL,
    NetAmount DECIMAL(18,5) NOT NULL,
    ExtraDiscountAmount DECIMAL(18,5) NOT NULL DEFAULT 0,
    TotalItemsDiscountAmount DECIMAL(18,5) NOT NULL,
    TotalAmount DECIMAL(18,5) NOT NULL
);

CREATE TABLE InvoiceLines (
    LineID INT IDENTITY PRIMARY KEY,
    InvoiceID INT NOT NULL FOREIGN KEY REFERENCES Invoices(InvoiceID),

    Description NVARCHAR(500) NOT NULL,
    ItemType VARCHAR(10) NOT NULL,       -- GS1 or EGS
    ItemCode VARCHAR(50) NOT NULL,
    UnitType VARCHAR(20) NOT NULL,
    Quantity DECIMAL(18,5) NOT NULL,     -- > 0

    -- VALUE STRUCTURE (mandatory part only)
    CurrencySold CHAR(3) NOT NULL,       -- always EGP in minimal version
    AmountEGP DECIMAL(18,5) NOT NULL,

    SalesTotal DECIMAL(18,5) NOT NULL,
    ItemsDiscount DECIMAL(18,5) NOT NULL DEFAULT 0,
    DiscountAmount DECIMAL(18,5) NOT NULL DEFAULT 0, -- Discount amount per line

    NetTotal DECIMAL(18,5) NOT NULL,
    TotalTaxableFees DECIMAL(18,5) NOT NULL DEFAULT 0,
    ValueDifference DECIMAL(18,5) NOT NULL DEFAULT 0,

    Total DECIMAL(18,5) NOT NULL         -- final line total after taxes
);

CREATE TABLE InvoiceLineTaxes (
    TaxID INT IDENTITY PRIMARY KEY,
    LineID INT NOT NULL FOREIGN KEY REFERENCES InvoiceLines(LineID),

    TaxType VARCHAR(20) NOT NULL,
    TaxRate DECIMAL(18,5) NOT NULL,
    TaxAmount DECIMAL(18,5) NOT NULL,
    SubType VARCHAR(20) NULL
);

CREATE TABLE InvoiceTaxTotals (
    TaxTotalID INT IDENTITY PRIMARY KEY,
    InvoiceID INT NOT NULL FOREIGN KEY REFERENCES Invoices(InvoiceID),

    TaxType VARCHAR(20) NOT NULL,
    Amount DECIMAL(18,5) NOT NULL
);


ALTER TABLE Parties
ADD BranchId VARCHAR(50) NULL;

ALTER TABLE Invoices
DROP COLUMN BranchID;

ALTER TABLE Parties ADD CONSTRAINT CK_Party_Branch_Not_For_Receiver
CHECK (
    NOT (Role = 'Receiver' AND BranchId IS NOT NULL)
);

ALTER TABLE Invoices
ADD CONSTRAINT UQ_Invoices_InternalId UNIQUE (InternalId);

ALTER TABLE Parties
ADD CONSTRAINT CHK_PartyType CHECK (Type IN ('B','P','F'));
