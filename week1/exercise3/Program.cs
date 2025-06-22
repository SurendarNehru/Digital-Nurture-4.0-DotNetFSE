using System;
class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;
    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }
    public override string ToString()
    {
        return $"{ProductId} - {ProductName} ({Category})";
    }
}
class ProductSearchApp
{
    public static Product FindByLinearSearch(Product[] productList, int searchId)
    {
        foreach (var product in productList)
        {
            if (product.ProductId == searchId)
                return product;
        }
        return null;
    }
    public static Product FindByBinarySearch(Product[] sortedProductList, int searchId)
    {
        int low = 0, high = sortedProductList.Length - 1;

        while (low <= high)
        {
            int middle = (low + high) / 2;
            if (sortedProductList[middle].ProductId == searchId)
                return sortedProductList[middle];
            else if (sortedProductList[middle].ProductId < searchId)
                low = middle + 1;
            else
                high = middle - 1;
        }

        return null;
    }
    static void Main(string[] args)
    {
        Product[] products = {
            new Product(5, "Speaker", "Electronics"),
            new Product(6, "Gaming PS5", "Playstation"),
            new Product(3, "Adidas Shoes", "Footwear"),
            new Product(4, "Book", "Education"),
            new Product(1, "Chain", "Accessories")
        };
        Array.Sort(products, (x, y) => x.ProductId.CompareTo(y.ProductId));
        Product linearResult = FindByLinearSearch(products, 4);
        Console.WriteLine("Linear Search Result: " + (linearResult != null ? linearResult.ToString() : "Not Found"));
        Product binaryResult = FindByBinarySearch(products, 4);
        Console.WriteLine("Binary Search Result: " + (binaryResult != null ? binaryResult.ToString() : "Not Found"));

    }
}