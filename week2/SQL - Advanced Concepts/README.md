## Exercise 2: Retrieving Top-N Products per Category Using Ranking Functions

# Scenario:
You are tasked with retrieving the top 3 most expensive products in each category from a Products table. The challenge involves handling possible price ties and ensuring the most accurate ranking per category.

# Steps Taken:
1. Understanding the Dataset:
The Products table contains columns such as ProductID, ProductName, Category, and Price. The goal is to group data by Category and rank products by Price in descending order.

2. Using ROW_NUMBER() for Unique Ranking:
A subquery was written using the ROW_NUMBER() window function partitioned by Category and ordered by Price DESC. This assigns a unique row number to each product in a category.

3. Using RANK() for Tied Ranking:
The RANK() function was similarly applied to handle ties. If two or more products share the same price, they get the same rank, and subsequent ranks are skipped.

4. Using DENSE_RANK() for Consecutive Ranking with Ties:
To assign consecutive ranks even when there are ties, the DENSE_RANK() function was used. It behaves like RANK(), but does not skip rank numbers.

# Output:
![ex1 1](https://github.com/user-attachments/assets/b34a0164-c778-4d0c-a501-3e3b9303d7fc)
![ex1 2](https://github.com/user-attachments/assets/e86c5327-7151-4890-a480-64d463ad94ed)
![ex1 3](https://github.com/user-attachments/assets/6a430004-f8c9-44fe-9a67-d8db94b785ce)

# Conclusion:
The implementation demonstrated how different SQL ranking functions handle ordering and ties. 
These approaches offer flexible solutions to common "Top-N per group" problems in analytics and reporting.
