-- Using ROW_NUMBER()
SELECT *
FROM (
  SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
  FROM Products
) AS RowNumbered
WHERE RowNum <= 3;

-- Using RANK()
SELECT *
FROM (
  SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
  FROM Products
) AS Ranked
WHERE RankNum <= 3;

-- Using DENSE_RANK()
SELECT *
FROM (
  SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
  FROM Products
) AS DenseRanked
WHERE DenseRankNum <= 3;
