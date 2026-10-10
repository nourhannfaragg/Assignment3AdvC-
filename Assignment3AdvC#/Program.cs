using Day_01_G03;
using System;
using System.IO;
using System.Linq;
namespace Assignment3AdvC_

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

            //Q2
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //Q3
            //string[] arr0 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = arr0.Where((n, i) => n.Length < i);

            //Q4
            //var result = ListGenerator.ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);

            //Q5
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);

            //Q6
            int[] arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr1.Where(p => p > 5)
            //                  .Skip(1)
            //                  .FirstOrDefault();
            //Console.WriteLine(result);

            //Q7
            //var result = arr1.Count(p => p % 2 != 0);
            //Console.WriteLine(result);

            //Q8
            //var result = ListGenerator.CustomersList.Select(p => new
            //{
            //    CustomerName = p.CustomerName,
            //    OrderCustomer = p.Orders.Count()
            //});


            //Q9
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        productCount = g.Count()
            //    });

            //Q10
            //var result = arr1.Sum();
            //Console.WriteLine(result);


            //Q11
            string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(p => p.Length);
            //Console.WriteLine(result);

            //Q12
            //var result = words.Min(p => p.Length);
            //Console.WriteLine(result);


            //Q13
            //var result = words.Max(p => p.Length);
            //Console.WriteLine(result);


            //Q14
            //var result = words.Average(p=> p.Length);
            //Console.WriteLine(result);

            //Q15
            //var result = ListGenerator.ProductsList.OrderBy(p => p.ProductName);


            //Q16
            string[] arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            
            //var result = arr3.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            
            //Q17
            //var result = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock > 0);

            var result01 = from p in ListGenerator.ProductsList
                           where p.UnitsInStock>0
                           orderby p.UnitsInStock descending
                           select p;
            //Q18
            string[] arr4 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = arr4.OrderBy(x => x.Length)
            //                   .ThenBy(x => x);


            //Q19
            //var result = arr3.OrderBy(x => x.Length)
            //                    .ThenBy(x=> x , StringComparer.OrdinalIgnoreCase);


            //Q20
            //var result = ListGenerator.ProductsList.OrderBy(p => p.Category)
            //                                        .ThenByDescending(p => p.UnitPrice);


            //Q21
            //var result = arr3.OrderBy(x => x.Length)
            //                   .ThenByDescending(x=> x, StringComparer.OrdinalIgnoreCase);


            //Q22
            //var result = arr4.Where(x => x[1]=='i')
            //                   .Reverse();

            //Q23
            //var result = ListGenerator.ProductsList.Select(p => new
            //{
            //    Name = p.ProductName
            //});


            //Q23
            string[] wordds = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result0 = wordds.Select(p => new
            //{
            //    UpperCase = p.ToUpper(),
            //    LowerCase = p.ToLower()
            //});

            //foreach (var item in result0)
            //{
            //    Console.WriteLine($"{item.UpperCase}-{item.LowerCase}");
            //}

            //Q24
            //var result = ListGenerator.ProductsList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    Price = p.UnitPrice
            //});

            var result02 = from p in ListGenerator.ProductsList
                         select new
                         {
                             p.ProductID,
                             p.ProductName,
                             Price = p.UnitPrice
                         }; 

            //Q25
            //var result = arr1.Select((num, index) => new
            //{
            //    Number = num,
            //    MatchesPosition = num== index
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.MatchesPosition}");
            //}

            //Q26
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = numbersA.SelectMany(a => numbersB,
            //    (a, b) => new { A = a, B = b })
            //    .Where(x => x.A < x.B);

            //Console.WriteLine("Pairs Where a < b:");
            //foreach (var x in result)
            //{
            //    Console.WriteLine($" {x.A} , {x.B}");
            //}

            //Q27
            //var result = ListGenerator.CustomersList.SelectMany(p => p.Orders)
            //                          .Where(o => o.Total < 500.00m);
            //foreach( var order in result )
            //{
            //    Console.WriteLine(order);
            //}

            //Q28
            var result = ListGenerator.CustomersList.SelectMany(p => p.Orders)
                                                    .Where(o => o.OrderDate.Year >= 1998);
            foreach( var o in result )
            {
                Console.WriteLine(o);
            }

        }
    }
}

