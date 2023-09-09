//int mark, sum = 0;
//float avg = 0;
//int counter = 0;
//for (int i = 0; i< 100; i++)
//{
//    while (counter < 5)
//    {
//        Console.WriteLine("Please Enter Mark ");
//        if (int.TryParse(Console.ReadLine(),out mark)){
//            counter++;

//        }
//    }
//}

// array 


// data collection 
/*
 set of variable value object
one type
one name 
 */



//float array ;/// declartion 
//int [] num;
//int x = 10; /// intillization 
//int[] avg = { 1, 2, 3 };
//int[] avgs = new int[4] {1,2,3,4};
//int[] avgs1 = new int[4] ;
//int y = Convert.ToInt32(Console.ReadLine());// ask user for input 




//int[] num = new int[5];/// declartion 
//for (int i = 0; i < num.Length; i++)
//{
//    int.TryParse(Console.ReadLine(), out num[i]);
//}
//Console.WriteLine(num[9]);


//int[,] ints = new int[5, 5];///[row ,colum]
//int[,] ints1 ;
//int[,] ints2 = { { 1,2}, { 25,63 } } ;


//int size;
//int.TryParse(Console.ReadLine(), out size);
//int[] numbers = new int[size];
//Console.WriteLine(numbers.Length);

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
///System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
//int n;
//float sum = 0;
//Console.WriteLine("Please Enter The N Value :");
//int.TryParse(Console.ReadLine(), out n);
//if (n > 1)
//{
//    float[] numbers = new float[n];
//    for (int i = 1; i <= n; i++)
//    {
//        float y = i * 13 / 22;
//        sum += y;
//        numbers[i - 1] = sum;
//    }
//}
//Console.WriteLine(sum);






//int mark, sum = 0 ;
//float avg = 0;
//int counter = 0;
//for (int i = 0; i < 100; i++)
//{
//    while (counter < 5)
//    {
//        Console.WriteLine("Please Enter Mark :");
//        if (int.TryParse(Console.ReadLine(), out mark))
//        {
//            counter++;
//            sum += mark;
//        }
//        else
//        {
//            Console.WriteLine("Invalid Input Please Try Again :");
//        }
//    }
//    avg = sum / 5;
//    Console.WriteLine("Avg = {0}", avg);
//}



//double number , sum = 0;
//int counter = 0,n;
//Console.WriteLine("Please Enter number counter  :");
//int.TryParse(Console.ReadLine(), out n);

//while (counter < n)
//{
//    Console.WriteLine("Please Enter number  :");
//    if (double.TryParse(Console.ReadLine(), out number)){
//        counter++;
//        sum += number;
//    }
//    else
//    {
//        Console.WriteLine("Invalid Input Please Try Again :");
//    }

//}
//Console.WriteLine(sum);



int number, multiple = 1;
int counter = 0, n;
Console.WriteLine("Please Enter number counter  :");
int.TryParse(Console.ReadLine(), out n);

while (counter < n)
{
    Console.WriteLine("Please Enter number  :");
    if (int.TryParse(Console.ReadLine(), out number))
    {
        counter++;
        multiple *= number;
    }
    else
    {
        Console.WriteLine("Invalid Input Please Try Again :");
    }

}
Console.WriteLine(multiple);
