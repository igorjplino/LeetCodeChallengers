// See https://aka.ms/new-console-template for more information

using LeetCodeChallengers.Challengers.Easy;
using LeetCodeChallengers.Challengers.Medium;
using System.Diagnostics;

Console.WriteLine("LeetCode challengers!");
Console.WriteLine();

var sw = Stopwatch.StartNew();

//TwoSum.Execute();
//BestTimeToBuyAndSellStock.Execute();
ProductOfArrayExceptSelf.Execute();

sw.Stop();
Console.WriteLine();
Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds}");
