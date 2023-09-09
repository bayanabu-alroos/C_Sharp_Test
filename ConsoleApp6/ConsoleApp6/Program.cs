//using System.Data;

//int[] number = { 1, 2, 3, 4, 5 };
//Console.WriteLine(number[10]);
//throw new Exception("Index out of range exception");
//static void GetValue(int[] array, int index)
//{
//    try
//    {
//        Console.WriteLine(array[index]);
//    }
//    catch(IndexOutOfRangeException ex)
//    {
//        throw new ArgumentOutOfRangeException(ex.Message);
//    }
//}


using ConsoleApp6;
using System.Reflection;

//Type typeInfo = typeof(Sample);

//Console.WriteLine($"Full Name: {typeInfo.FullName}");
//Console.WriteLine($"Base Type: {typeInfo.BaseType}");

//MethodInfo methodInfo = typeInfo.GetMethod("Display");
//Console.WriteLine($"Method Name: {methodInfo.Name}");

Sample sampleInstance = new Sample();
Type typeInf = sampleInstance.GetType();

Console.WriteLine($"Full Name: {typeInf.FullName}");
Console.WriteLine($"Base Type: {typeInf.BaseType}");

MethodInfo methodInf = typeInf.GetMethod("Display");
Console.WriteLine($"Method Name: {methodInf.Name}");
