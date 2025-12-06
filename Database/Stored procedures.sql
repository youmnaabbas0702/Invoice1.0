--Add an Issuer/Receiver
CREATE PROCEDURE SP_AddParty
    @Role VARCHAR(10),
    @Type CHAR(1),
    @RegID VARCHAR(50),
    @Name NVARCHAR(200),
    @Country CHAR(2),
    @Governate NVARCHAR(100),
    @RegionCity NVARCHAR(100),
    @Street NVARCHAR(200),
    @BuildingNumber NVARCHAR(50),
    @NewPartyID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Parties
    (Role, Type, RegID, Name, Country, Governate, RegionCity, Street, BuildingNumber)
    VALUES
    (@Role, @Type, @RegID, @Name, @Country, @Governate, @RegionCity, @Street, @BuildingNumber);

    -- Return the new PartyID
    SET @NewPartyID = SCOPE_IDENTITY();
END

--add invoice
CREATE PROCEDURE SP_AddInvoice
    @IssuerID INT,
    @ReceiverID INT,

    @DateTimeIssued DATETIME2,
    @TaxpayerActivityCode VARCHAR(10),
    @InternalId VARCHAR(100),
    @BranchID VARCHAR(10),

    @TotalSalesAmount DECIMAL(18,5),
    @TotalDiscountAmount DECIMAL(18,5),
    @NetAmount DECIMAL(18,5),
    @ExtraDiscountAmount DECIMAL(18,5),
    @TotalItemsDiscountAmount DECIMAL(18,5),
    @TotalAmount DECIMAL(18,5),

    @NewInvoiceID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Invoices
    (IssuerID, ReceiverID, DocumentType, DocumentTypeVersion,
     DateTimeIssued, TaxpayerActivityCode, InternalId, BranchID,
     TotalSalesAmount, TotalDiscountAmount, NetAmount,
     ExtraDiscountAmount, TotalItemsDiscountAmount, TotalAmount)
    VALUES
    (@IssuerID, @ReceiverID, 'i', '1.0',
     @DateTimeIssued, @TaxpayerActivityCode, @InternalId, @BranchID,
     @TotalSalesAmount, @TotalDiscountAmount, @NetAmount,
     @ExtraDiscountAmount, @TotalItemsDiscountAmount, @TotalAmount);

    SET @NewInvoiceID = SCOPE_IDENTITY();
END

--add invoice line
CREATE PROCEDURE SP_AddInvoiceLine
    @InvoiceID INT,

    @Description NVARCHAR(500),
    @ItemType VARCHAR(10),
    @ItemCode VARCHAR(50),
    @UnitType VARCHAR(20),
    @Quantity DECIMAL(18,5),

    @CurrencySold CHAR(3),
    @AmountEGP DECIMAL(18,5),

    @SalesTotal DECIMAL(18,5),
    @ItemsDiscount DECIMAL(18,5),
    @DiscountAmount DECIMAL(18,5),

    @NetTotal DECIMAL(18,5),
    @TotalTaxableFees DECIMAL(18,5),
    @ValueDifference DECIMAL(18,5),

    @Total DECIMAL(18,5),

    @NewLineID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO InvoiceLines
    (InvoiceID, Description, ItemType, ItemCode, UnitType, Quantity,
     CurrencySold, AmountEGP, SalesTotal, ItemsDiscount, DiscountAmount,
     NetTotal, TotalTaxableFees, ValueDifference, Total)
    VALUES
    (@InvoiceID, @Description, @ItemType, @ItemCode, @UnitType, @Quantity,
     @CurrencySold, @AmountEGP, @SalesTotal, @ItemsDiscount, @DiscountAmount,
     @NetTotal, @TotalTaxableFees, @ValueDifference, @Total);

    SET @NewLineID = SCOPE_IDENTITY();
END

--add invoice line tax
CREATE PROCEDURE SP_AddInvoiceLineTax
    @LineID INT,
    @TaxType VARCHAR(20),
    @TaxRate DECIMAL(18,5),
    @TaxAmount DECIMAL(18,5),
    @SubType VARCHAR(20) = NULL,
    @NewTaxID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO InvoiceLineTaxes
    (LineID, TaxType, TaxRate, TaxAmount, SubType)
    VALUES
    (@LineID, @TaxType, @TaxRate, @TaxAmount, @SubType);

    SET @NewTaxID = SCOPE_IDENTITY();
END

--add invoice tax total
CREATE PROCEDURE SP_AddInvoiceTaxTotal
    @InvoiceID INT,
    @TaxType VARCHAR(20),
    @Amount DECIMAL(18,5),
    @NewTaxTotalID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO InvoiceTaxTotals
    (InvoiceID, TaxType, Amount)
    VALUES
    (@InvoiceID, @TaxType, @Amount);

    SET @NewTaxTotalID = SCOPE_IDENTITY();
END

--edit branchId column dropped from Invoices and added to Parties
ALTER PROCEDURE SP_AddInvoice
    @IssuerID INT,
    @ReceiverID INT,

    @DateTimeIssued DATETIME2,
    @TaxpayerActivityCode VARCHAR(10),
    @InternalId VARCHAR(100),

    @TotalSalesAmount DECIMAL(18,5),
    @TotalDiscountAmount DECIMAL(18,5),
    @NetAmount DECIMAL(18,5),
    @ExtraDiscountAmount DECIMAL(18,5),
    @TotalItemsDiscountAmount DECIMAL(18,5),
    @TotalAmount DECIMAL(18,5),

    @NewInvoiceID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Invoices
    (IssuerID, ReceiverID, DocumentType, DocumentTypeVersion,
     DateTimeIssued, TaxpayerActivityCode, InternalId,
     TotalSalesAmount, TotalDiscountAmount, NetAmount,
     ExtraDiscountAmount, TotalItemsDiscountAmount, TotalAmount)
    VALUES
    (@IssuerID, @ReceiverID, 'i', '1.0',
     @DateTimeIssued, @TaxpayerActivityCode, @InternalId,
     @TotalSalesAmount, @TotalDiscountAmount, @NetAmount,
     @ExtraDiscountAmount, @TotalItemsDiscountAmount, @TotalAmount);

    SET @NewInvoiceID = SCOPE_IDENTITY();
END

ALTER PROCEDURE SP_AddParty
    @Role VARCHAR(10),
    @Type CHAR(1),
    @RegID VARCHAR(50),
    @Name NVARCHAR(200),
    @Country CHAR(2),
    @Governate NVARCHAR(100),
    @RegionCity NVARCHAR(100),
    @Street NVARCHAR(200),
    @BuildingNumber NVARCHAR(50),
    @BranchId VARCHAR(50) = NULL,
    @NewPartyID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Parties
    (Role, Type, RegID, Name, Country, Governate, RegionCity, Street, BuildingNumber, BranchId)
    VALUES
    (@Role, @Type, @RegID, @Name, @Country, @Governate, @RegionCity, @Street, @BuildingNumber, @BranchId);

    SET @NewPartyID = SCOPE_IDENTITY();
END

CREATE PROCEDURE SP_GenerateInternalId
    @NewInternalId VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Candidate VARCHAR(100);
    DECLARE @Exists INT = 1;

    WHILE @Exists = 1
    BEGIN
        -- Example: random 8-digit number with prefix INV
        SET @Candidate = 'INV' + RIGHT('00000000' + CAST(ABS(CHECKSUM(NEWID())) % 100000000 AS VARCHAR(8)), 8);

        -- Check if it already exists in Invoices table
        SELECT @Exists = COUNT(*) FROM Invoices WHERE InternalId = @Candidate;
    END

    SET @NewInternalId = @Candidate;
END

--check internal id exists
CREATE PROCEDURE SP_CheckInternalIdExists
    @InternalId NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM Invoices WHERE InternalId = @InternalId)
        SELECT 1 AS ExistsResult;
    ELSE
        SELECT 0 AS ExistsResult;
END
GO

--Update functionality..
CREATE PROCEDURE SP_UpdateParty
(
    @PartyID INT,
    @Role VARCHAR(10),
    @Type CHAR(1),
    @RegID VARCHAR(50),
    @Name NVARCHAR(200),
    @Country CHAR(2),
    @Governate NVARCHAR(100),
    @RegionCity NVARCHAR(100),
    @Street NVARCHAR(200),
    @BuildingNumber NVARCHAR(50),
    @BranchId VARCHAR(50) = NULL
)
AS
BEGIN
    UPDATE Parties
    SET Role = @Role,
        Type = @Type,
        RegID = @RegID,
        Name = @Name,
        Country = @Country,
        Governate = @Governate,
        RegionCity = @RegionCity,
        Street = @Street,
        BuildingNumber = @BuildingNumber,
        BranchId = @BranchId
    WHERE PartyID = @PartyID;
END

CREATE PROCEDURE SP_UpdateInvoiceHeader
(
    @InvoiceID INT,
    @IssuerID INT,
    @ReceiverID INT,
    @DateTimeIssued DATETIME2,
    @TaxpayerActivityCode VARCHAR(10),
    @InternalId VARCHAR(100),

    @TotalSalesAmount DECIMAL(18,5),
    @TotalDiscountAmount DECIMAL(18,5),
    @NetAmount DECIMAL(18,5),
    @ExtraDiscountAmount DECIMAL(18,5),
    @TotalItemsDiscountAmount DECIMAL(18,5),
    @TotalAmount DECIMAL(18,5)
)
AS
BEGIN
    UPDATE Invoices
    SET IssuerID = @IssuerID,
        ReceiverID = @ReceiverID,
        DateTimeIssued = @DateTimeIssued,
        TaxpayerActivityCode = @TaxpayerActivityCode,
        InternalId = @InternalId,

        TotalSalesAmount = @TotalSalesAmount,
        TotalDiscountAmount = @TotalDiscountAmount,
        NetAmount = @NetAmount,
        ExtraDiscountAmount = @ExtraDiscountAmount,
        TotalItemsDiscountAmount = @TotalItemsDiscountAmount,
        TotalAmount = @TotalAmount
    WHERE InvoiceID = @InvoiceID;
END

CREATE PROCEDURE SP_DeleteInvoiceLinesAndTaxes
(
    @InvoiceID INT
)
AS
BEGIN
    -- Delete line taxes
    DELETE FROM InvoiceLineTaxes
    WHERE LineID IN (SELECT LineID FROM InvoiceLines WHERE InvoiceID = @InvoiceID);

    -- Delete lines
    DELETE FROM InvoiceLines WHERE InvoiceID = @InvoiceID;

    -- Delete tax totals
    DELETE FROM InvoiceTaxTotals WHERE InvoiceID = @InvoiceID;
END


--Get info:
--get invoice header
CREATE PROCEDURE GetInvoiceHeaderById
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        i.InvoiceID,
        i.DocumentType,
        i.DocumentTypeVersion,
        i.DateTimeIssued,
        i.TaxpayerActivityCode,
        i.InternalId,
        i.TotalSalesAmount,
        i.TotalDiscountAmount,
        i.NetAmount,
        i.ExtraDiscountAmount,
        i.TotalItemsDiscountAmount,
        i.TotalAmount,
        
        -- Issuer info
        pi.PartyID AS IssuerID,
        pi.Role AS IssuerRole,
        pi.Type AS IssuerType,
        pi.RegID AS IssuerRegID,
        pi.Name AS IssuerName,
        pi.Country AS IssuerCountry,
        pi.Governate AS IssuerGovernate,
        pi.RegionCity AS IssuerRegionCity,
        pi.Street AS IssuerStreet,
        pi.BuildingNumber AS IssuerBuildingNumber,
        pi.BranchId AS IssuerBranchId,
        
        -- Receiver info
        pr.PartyID AS ReceiverID,
        pr.Role AS ReceiverRole,
        pr.Type AS ReceiverType,
        pr.RegID AS ReceiverRegID,
        pr.Name AS ReceiverName,
        pr.Country AS ReceiverCountry,
        pr.Governate AS ReceiverGovernate,
        pr.RegionCity AS ReceiverRegionCity,
        pr.Street AS ReceiverStreet,
        pr.BuildingNumber AS ReceiverBuildingNumber,
        pr.BranchId AS ReceiverBranchId

    FROM Invoices i
    INNER JOIN Parties pi ON i.IssuerID = pi.PartyID
    INNER JOIN Parties pr ON i.ReceiverID = pr.PartyID
    WHERE i.InvoiceID = @InvoiceID;
END

--get invoice lines
CREATE PROCEDURE GetInvoiceLinesByInvoiceId
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        l.LineID,
        l.InvoiceID,
        l.Description,
        l.ItemType,
        l.ItemCode,
        l.UnitType,
        l.Quantity,
        l.CurrencySold,
        l.AmountEGP,
        l.SalesTotal,
        l.ItemsDiscount,
        l.DiscountAmount,
        l.NetTotal,
        l.TotalTaxableFees,
        l.ValueDifference,
        l.Total
    FROM InvoiceLines l
    WHERE l.InvoiceID = @InvoiceID
    ORDER BY l.LineID;
END

--Get invoice taxes
CREATE PROCEDURE GetInvoiceLineTaxesByInvoiceLineId
    @LineID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        t.TaxID,
        t.LineID,
        t.TaxType,
        t.TaxRate,
        t.TaxAmount,
        t.SubType
    FROM InvoiceLineTaxes t
    WHERE t.LineID = @LineID
    ORDER BY t.TaxID;
END

--get invoice tax totals
CREATE PROCEDURE GetInvoiceTaxTotalsByInvoiceId
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        TaxTotalID,
        InvoiceID,
        TaxType,
        Amount
    FROM InvoiceTaxTotals
    WHERE InvoiceID = @InvoiceID
    ORDER BY TaxTotalID;
END

CREATE PROCEDURE sp_GetInvoiceReport
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        h.InvoiceID,
        h.DateTimeIssued,
        h.TaxpayerActivityCode,
        h.InternalId,
        l.LineID,
        l.Description AS LineDescription,
        l.ItemCode,
        l.ItemType,
        l.Quantity,
        l.UnitType,
        l.SalesTotal,
        l.DiscountAmount,
        l.NetTotal,
        t.TaxType,
        t.TaxRate,
        t.TaxAmount,
        tt.TaxType AS TaxTotalType,
        tt.Amount AS TaxTotalAmount
    FROM Invoices h
    LEFT JOIN InvoiceLines l ON h.InvoiceID = l.InvoiceID
    LEFT JOIN InvoiceLineTaxes t ON l.LineID = t.LineID
    LEFT JOIN InvoiceTaxTotals tt ON h.InvoiceID = tt.InvoiceID
    WHERE h.InvoiceID = 1
END


--get invoice id by internalId
create PROCEDURE GetInvoiceID_ByInternalID
    @InternalID varchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT InvoiceID
    FROM Invoices
    WHERE InternalId = @InternalID;
END;
GO
