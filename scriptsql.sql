CREATE PROCEDURE spGetSalesBy_DateRange
    @STARTDATE DATE,
    @ENDDATE DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ProductCode,
        ProductName,
        Quantity,
        UnitPrice,
        (Quantity * UnitPrice) AS Total,
        SaleDate
    FROM PRODUCTSALES
    WHERE SaleDate BETWEEN @STARTDATE AND @ENDDATE
END

CREATE TABLE PRODUCTSALES ( 
    SALEID INT PRIMARY KEY, 
    PRODUCTCODE NVARCHAR(20), 
    PRODUCTNAME NVARCHAR(100), 
    QUANTITY INT, 
    UNITPRICE DECIMAL(18,2), 
    SALEDATE DATE 
); 
 -- Sample Data 
INSERT INTO PRODUCTSALES (SALEID, PRODUCTCODE, PRODUCTNAME, QUANTITY, 
UNITPRICE, SALEDATE) 
VALUES 
(1, 'P001', 'Pen', 10, 1.50, '2025-06-20'), 
(2, 'P001', 'Pen', 5, 1.50, '2025-06-25'), 
(3, 'P002', 'Notebook', 3, 3.20, '2025-06-21'), 
(4, 'P003', 'Eraser', 15, 0.80, '2025-06-22'); 
