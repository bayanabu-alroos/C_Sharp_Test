//List<int> num = new List<int> { 10, 20, 3, 5, 6, 7, 5, 15, 10, 15 };
//Console.WriteLine(num.Count);
//num = num.Distinct().ToList();
//Console.WriteLine(num.Count);
//foreach (var item in num)
//{
//    Console.WriteLine(item);
//}

List<int> list = new List<int> { 10, 10, 13, 7, 9, 8, 5, 7, 6, 8, 6, 9, 11, 14, 28, 13, 15, 19 };
//for (int i = 0; i < list.Count; i++)
//{
//    if (list[i] > 10)
//    {
//        Console.WriteLine(list[i]);
//    }
//}
list.Where(x=>x > 10).Distinct().Order().ToList().ForEach(y=>Console.Write($"{y}\t"));