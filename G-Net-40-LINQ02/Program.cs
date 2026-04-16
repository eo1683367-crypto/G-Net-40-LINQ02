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

