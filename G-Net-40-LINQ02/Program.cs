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

