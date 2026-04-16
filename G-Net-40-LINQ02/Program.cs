using LINQ.Models;
using static LINQ.DataSources.Source;

#region Question 01

// 1. Get top 3 most expensive products 

//var Result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);


//foreach (var n in Result)
//{
//    Console.WriteLine(n);
//}

#endregion


#region Question 02

// 2. show page 2 of products, with page size = 5

//var Result = ProductList.Skip(5).Take(5);

//foreach (var n in Result)
//{
//    Console.WriteLine(n);
//}
#endregion


#region Question 03

// 3. Take products from the list as long as Their UnitPrice is less than $25 (list is ordered by price).

//var Result = ProductList.TakeWhile(p => p.UnitPrice < 25).OrderByDescending(p => p.UnitPrice);

//foreach (var n in Result)
//{
//    Console.WriteLine(n);
//}
#endregion

#region Question 04

// 4. Check if ALL products in the "Seafood" category are in stock

//var Result = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

//Console.WriteLine(Result);

#endregion


#region Question 05

// 5. Check if the ID list contains 9

//int[] ids = { 3, 9, 13, 18 };

//var Checked = ids.Contains(9);

//Console.WriteLine(Checked);

#endregion

#region Question 06

// 6. Group all products by Category and print each group  with its product count.

//var Result = ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, ProductCount = p.Count() });

//foreach (var group in Result)
//{
//    Console.WriteLine($"Category: {group.Category}, Product Count: {group.ProductCount}");
//}
#endregion

#region Question 07

//// 7. Group products by Category and project only product names per group

//var Result = ProductList.GroupBy(p => p.Category).Select(p => new 
//{ 
//    Category = p.Key, 
//    ProductName = p.Select(x => x.ProductName) 
//});

//foreach (var group in Result)
//{
//    Console.WriteLine($"Category: {group.Category}");
//    foreach (var name in group.ProductName)
//    {
//        Console.WriteLine($" - {name}");
//    }
//}

#endregion

#region Question 08

//// 8. Find all categories that have MORE THAN 3 products

//var Result = ProductList.GroupBy(p => p.Category).Select(x => new
//    {
//        Category = x.Key,
//        ProductCount = x.Count()

//    }).Where(x => x.ProductCount > 3);

//foreach (var group in Result)
//{
//    Console.WriteLine($"Category: {group.Category} - Product Count = {group.ProductCount}");

//}

#endregion


#region Question 09

//// 9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.

//var Result = from c in CustomerList
//             group c by c.Country
//             into grouped
//             select new
//                    {
//                      Country = grouped.Key,
//                        Count = grouped.Count(),
//                        TotalOrderValue = grouped.Sum(x => x.Orders.Sum(o => o.Total))
//                    };

//foreach (var group in Result)
//    {
//    Console.WriteLine($"Country: {group.Country} - Count = {group.Count} - Total Order Value = {group.TotalOrderValue}");
//}
#endregion

#region Question 10

//// 10. Calculate the total number of units in stock across all products

//var Result = ProductList.Sum(p => p.UnitsInStock);

//Console.WriteLine(Result);
#endregion

#region Question 11

//// 11. Find the CHEAPEST and MOST EXPENSIVE product prices

//var Cheapest = ProductList.Min(p => p.UnitPrice);
//var MostExpensive = ProductList.Max(p => p.UnitPrice);

//Console.WriteLine($"Cheapest: {Cheapest}, Most Expensive: {MostExpensive}");
#endregion

#region Question 12

// 12. Get a distinct list of all product categories

//var Result = ProductList.Select(p => p.Category).Distinct();

//foreach (var group in Result)
//{
//    Console.WriteLine($"Category: {group}");
//}
#endregion

#region Question 13

//   // 13. find product IDs that are in setA but NOT in setB 
//   int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
//   int[] setB = { 3, 6, 9, 12, 15, 13 };

//var Result = setA.Except(setB);

//foreach (var item in Result)
//    Console.WriteLine(item);
#endregion

#region Question 14

//// 14. Find countries that  appear in list1 but NOT in list2 (case -insensitive). 
//    string[] list1 = { "Germany", "France", "UK", "Spain" };
//    string[] list2 = { "france", "SPAIN", "Italy" };

//var Result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

//foreach (var item in Result)
//    Console.WriteLine(item);

#endregion

#region Question 15

//// 15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18. 

//var ProductDictionary = ProductList.ToDictionary(p => p.ProductID);

//var pruductWithID18 = ProductDictionary[18];

//Console.WriteLine(pruductWithID18);
#endregion

#region Question 16

//// 16. Get the first product whose price is greater than $50.

//var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 50);

//Console.WriteLine(Result);
#endregion

#region Question 17

//// 17. Try to get the first product with a price > $500.  it returns null instead of throwing.

//var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);

//Console.WriteLine(Result);
#endregion

#region Question 18

//// 18. Generate a multiplication table row for 7

//var multiplication = Enumerable.Range(1,12);

//foreach (var item in multiplication)
//{
//    Console.WriteLine($"7 * {item} = {7 * item}");
//}
#endregion

#region Question 19

//// 19. Generate even numbers between 1 and 30.

//var Result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

//foreach (var item in Result)
//    Console.WriteLine(item);
#endregion

