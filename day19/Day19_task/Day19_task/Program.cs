using System;
using System.Collections;
using System.Collections.Generic;
using day10_G01;
using System.Linq;
using static day10_G01.ListGenerators;
using System.Reflection.Metadata.Ecma335;
using System.Net.WebSockets;
using System.Threading;
using System.Security.Cryptography;
using System.IO;

namespace Day19_task
{
    internal class Program
    {
        static void Main()
        {
            /*--------------------------------- Restriction Operators ---------------------------------*/
            #region Restriction Operators
            #region P1
            //var outOfStockProducts = ProductList.Where(p => p.UnitsInStock == 0)
            //                                    .Select(p => new { Name = p.ProductName, Stock = p.UnitsInStock });
            //foreach (var item in outOfStockProducts)
            //{
            //    Console.WriteLine(item);
            //    //Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            //}
            #endregion

            #region P2
            //var inStockExpensiveProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M)
            //                                          .Select(p => new { Name = p.ProductName, Price = p.UnitPrice, Stock = p.UnitsInStock });
            //foreach (var item in inStockExpensiveProducts)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region P3
            //string[] Arr = { "zero", "one", "two", "three", "four","five", "six", "seven", "eight", "nine" };
            //var digitsWithShorterName = Arr.Where((name, index) => name.Length < index)
            //                               .Select((name, index) => new{ Digit = index , Name = name });
            //foreach (var item in digitsWithShorterName)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            /*--------------------------------- Element Operators ---------------------------------*/
            #region Element Operators
            #region P1
            //var firstOutOfStock = ProductList.Where(p => p.UnitsInStock == 0)
            //                                 .Select(p => new { Name = p.ProductName, Stock = p.UnitsInStock })
            //                                 .FirstOrDefault();
            //Console.WriteLine(firstOutOfStock?.Name ?? "No found");
            #endregion

            #region P2
            //var expensiveProduct = ProductList.Where(p => p.UnitPrice > 1000)
            //                                  .Select(p => new { Name = p.ProductName, Price = p.UnitPrice })
            //                                  .FirstOrDefault();
            //Console.WriteLine(expensiveProduct?.Name ?? "No product found with price > 1000"); 
            #endregion

            #region P3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondGreaterThan5 = Arr.Where(n => n > 5)
            //                            .Select(p => new { Value = p })
            //                            .Skip(1)
            //                            .FirstOrDefault();
            //Console.WriteLine(secondGreaterThan5 == null ? "No found" : secondGreaterThan5);
            #endregion
            #endregion

            /*--------------------------------- Aggregate Operators ---------------------------------*/
            #region Aggregate Operators
            #region P1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var oddCount = Arr.Count(n => n % 2 == 1);

            //Console.WriteLine($"Odd Count = {oddCount}"); 
            #endregion

            #region P2
            //var customerOrders = CustomerList.Select(c => new { Customer = c.Name, OrdersCount = c.Orders.Count() });

            //foreach (var item in customerOrders)
            //    Console.WriteLine($"{item.Customer} - Orders: {item.OrdersCount}");
            #endregion

            #region P3
            //var categoryProducts = ProductList.GroupBy(p => p.Category)
            //                                  .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var item in categoryProducts)
            //    Console.WriteLine($"{item.Category} - {item.Count}"); 
            #endregion

            #region P4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var total = Arr.Sum();

            //Console.WriteLine($"Total = {total}"); 
            #endregion

            #region P5
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var totalChars = words.Sum(w => w.Length);

            //Console.WriteLine($"Total Characters = {totalChars}");
            #endregion

            #region P6
            //var stockPerCategory = ProductList.GroupBy(p => p.Category)
            //                                  .Select(g => new { Category = g.Key, Stock = g.Sum(p => p.UnitsInStock) });

            //foreach (var item in stockPerCategory)
            //    Console.WriteLine($"{item.Category} - Units: {item.Stock}");
            #endregion

            #region P7
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var minLength = words.Min(w => w.Length);

            //Console.WriteLine($"Shortest Word Length = {minLength}"); 
            #endregion

            #region P8
            //var cheapestPerCategory = ProductList.GroupBy(p => p.Category)
            //                                     .Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) });

            //foreach (var item in cheapestPerCategory)
            //    Console.WriteLine($"{item.Category} - Min Price: {item.MinPrice}"); 
            #endregion

            #region P9
            //var cheapestProducts = ProductList.GroupBy(p => p.Category)
            //                          .Select(g => new
            //                          {
            //                              Category = g.Key,
            //                              MinPrice = g.Min(p => p.UnitPrice),
            //                              Products = g.Where(p => p.UnitPrice == g.Min(x => x.UnitPrice))
            //                          });

            //foreach (var item in cheapestProducts)
            //{
            //    Console.WriteLine($"{item.Category} - Min Price: {item.MinPrice}");
            //    foreach (var p in item.Products)
            //        Console.WriteLine($"   {p.ProductName}");
            //} 
            #endregion

            #region P10
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var maxLength = words.Max(w => w.Length);

            //Console.WriteLine($"Longest Word Length = {maxLength}"); 
            #endregion

            #region P11
            //var maxPricePerCategory = ProductList.GroupBy(p => p.Category)
            //                                     .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });

            //foreach (var item in maxPricePerCategory)
            //    Console.WriteLine($"{item.Category} - Max Price: {item.MaxPrice}"); 
            #endregion

            #region P12
            //var mostExpensiveProducts = ProductList.GroupBy(p => p.Category)
            //                                       .Select(g => new
            //                                       {
            //                                            Category = g.Key,
            //                                            MaxPrice = g.Max(p => p.UnitPrice),
            //                                            Products = g.Where(p => p.UnitPrice == g.Max(x => x.UnitPrice))
            //                                       });

            //foreach (var item in mostExpensiveProducts)
            //{
            //    Console.WriteLine($"{item.Category} - Max Price: {item.MaxPrice}");
            //    foreach (var p in item.Products)
            //        Console.WriteLine($"   {p.ProductName}");
            //} 
            #endregion

            #region P13
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var avgLength = words.Average(w => w.Length);

            //Console.WriteLine($"Average Word Length = {avgLength}"); 
            #endregion

            #region P14
            //var avgPricePerCategory = ProductList.GroupBy(p => p.Category)
            //                                     .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });

            //foreach (var item in avgPricePerCategory)
            //    Console.WriteLine($"{item.Category} - Avg Price: {item.AvgPrice:F2}"); 
            #endregion
            #endregion

            /*--------------------------------- Ordering Operators ---------------------------------*/
            #region Ordering Operators
            #region P1
            //var productsByName = ProductList.OrderBy(p => p.ProductName);

            //foreach (var product in productsByName)
            //    Console.WriteLine(product.ProductName); 
            #endregion

            #region P2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //    Console.WriteLine(word); 
            #endregion

            #region P3
            //var productsByStock = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var product in productsByStock)
            //    Console.WriteLine($"{product.ProductName} - {product.UnitsInStock}"); 
            #endregion

            #region P4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digitsSorted = Arr.OrderBy(d => d.Length)
            //                      .ThenBy(d => d);

            //foreach (var digit in digitsSorted)
            //    Console.WriteLine(digit); 
            #endregion

            #region P5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var wordsSorted = words.OrderBy(w => w.Length)
            //                       .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in wordsSorted)
            //    Console.WriteLine(word); 
            #endregion

            #region P6
            //var productsByCategoryAndPrice = ProductList.OrderBy(p => p.Category)
            //                                            .ThenByDescending(p => p.UnitPrice);

            //foreach (var product in productsByCategoryAndPrice)
            //    Console.WriteLine($"{product.Category} - {product.ProductName} - {product.UnitPrice}"); 
            #endregion

            #region P7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var wordsSortedDesc = Arr.OrderBy(w => w.Length)
            //                         .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in wordsSortedDesc)
            //    Console.WriteLine(word); 
            #endregion

            #region P8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digitsReversed = Arr.Where(d => d.Length > 1 && d[1] == 'i')
            //                        .Reverse();

            //foreach (var digit in digitsReversed)
            //    Console.WriteLine(digit); 
            #endregion
            #endregion

            /*--------------------------------- Transformation Operators ---------------------------------*/
            #region Transformation Operators
            #region P1
            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //    Console.WriteLine(name); 
            #endregion

            #region P2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordVersions = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var word in wordVersions)
            //    Console.WriteLine(word);
            #endregion

            #region P3
            //var productInfo = ProductList.Select(p => new
            //                              {
            //                                  p.ProductName,
            //                                  Price = p.UnitPrice,
            //                                  p.Category
            //                              });

            //foreach (var product in productInfo)
            //    Console.WriteLine(product); 
            #endregion

            #region P4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var valueCheck = Arr.Select((num, index) => new
            //                    {
            //                        Number = num,
            //                        InPlace = (num == index)
            //                    });

            //foreach (var item in valueCheck)
            //    Console.WriteLine(item); 
            #endregion

            #region P5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA.SelectMany(a => numbersB
            //                    .Where(b => a < b)
            //                    .Select(b => new { A = a, B = b }));

            //foreach (var pair in pairs)
            //    Console.WriteLine($"{pair.A} is less than {pair.B}"); 
            #endregion

            #region P6
            //var cheapOrders = CustomerList.SelectMany(c => c.Orders)
            //                              .Where(o => o.Total < 500);


            //foreach (var order in cheapOrders)
            //    Console.WriteLine(order); 
            #endregion

            #region P7
            //var recentOrders = CustomerList.SelectMany(c => c.Orders)
            //                               .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in recentOrders)
            //    Console.WriteLine($"OrderID: {order.Id}, Date: {order.OrderDate}"); 
            #endregion
            #endregion

            /*--------------------------------- Partitioning Operators ---------------------------------*/
            #region Partitioning Operators
            #region P3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var sequence = numbers.TakeWhile((num, index) => num >= index);

            //foreach (var n in sequence)
            //    Console.WriteLine(n); 
            #endregion

            #region P4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var divisibleBy3 = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var n in divisibleBy3)
            //    Console.WriteLine(n); 
            #endregion

            #region P5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var lessThanIndex = numbers.SkipWhile((num, index) => num >= index);

            //foreach (var n in lessThanIndex)
            //    Console.WriteLine(n); 
            #endregion
            #endregion

            /*--------------------------------- Quantifiers Operators ---------------------------------*/
            #region Quantifiers Operators
            #region P1
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var hasEi = words.Any(w => w.Contains("ei"));

            //Console.WriteLine($"Any word contains 'ei'? {hasEi}"); 
            #endregion

            #region P2
            //var categoriesWithOutOfStock = ProductList.GroupBy(p => p.Category)
            //                                          .Where(g => g.Any(p => p.UnitsInStock == 0));

            //foreach (var category in categoriesWithOutOfStock)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //        Console.WriteLine($"   {product.ProductName} - {product.UnitsInStock}");
            //} 
            #endregion

            #region P3
            //var categoriesAllInStock = ProductList.GroupBy(p => p.Category)
            //                                      .Where(g => g.All(p => p.UnitsInStock > 0));

            //foreach (var category in categoriesAllInStock)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //        Console.WriteLine($"   {product.ProductName} - {product.UnitsInStock}");
            //} 
            #endregion 
            #endregion
        }
    }
}
