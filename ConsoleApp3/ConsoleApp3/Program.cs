//Write a program in C# Sharp to display the first 10 natural numbers.
//2. Write a C# Sharp program to find the sum of the first 10 natural numbers.

//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    Console.Write(i + ",");
//    sum += i;
//}
//Console.WriteLine("The Sum is : {0}",sum);


//4. Write a C# Sharp program to read 10 numbers and find their average and sum.
//Console.WriteLine("Input the 10 numbers :");
//int num;
//float sum = 0;

//for(int i = 1; i <= 10; i++)
//{
//    Console.Write("Number-{0} :",i );
//    int.TryParse( Console.ReadLine(), out num );
//    sum += num; 
//}
//float avarage = sum / 10;
//Console.WriteLine("The sum of 10 no is : {0}",sum);
//Console.WriteLine("The Average is : {0}", avarage);


/*7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
*/

//int n;
//Console.Write("Input upto the table number starting from 1 : ");
//int.TryParse(Console.ReadLine(), out n);
//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= n; j++)
//    {
//        if (i <= n - 1)
//        {
//            Console.Write("{0} * {1} = {2}  ",j ,i ,j*i);
//        }
//        else
//        {
//            Console.Write("{0} * {1} = {2} ,", j, i, j * i);
//        }
//    }
//    Console.WriteLine("\n");
//}



//
using ConsoleApp3;
using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;

//int rows;
//Console.Write("Input number of rows :");
//int.TryParse(Console.ReadLine(), out rows);
//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("{0}",j);
//    }
//    Console.Write("\n");
//}

//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("{0}", i);
//    }
//    Console.Write("\n");
//}

//int num = 1;
//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("{0}", num++);
//    }
//    Console.Write("\n");
//}

//int spac ,col= 1 ;
//spac = rows + 4 - 1;
//for(int i = 1; i <= rows; i++)
//{
//    for(int j = spac;j>=1; j--)
//    {
//        Console.Write(" ");
//    }
//    for(int l = 1; l <= i; l++)
//    {
//        Console.Write("*");
//    }
//    Console.Write("\n");
//    spac--;
//}

//int spac = rows + 4 - 1;
//for (int i = 1; i <= rows; i++)
//{
//    for (int k = spac; k >= 1; k--)
//    {
//        Console.Write(" ");
//    }
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("{0}", i);
//    }
//    Console.Write("\n");
//    spac--;
//}

//int spc = rows + 4 - 1;
//for (int i = 1; i <= rows; i++)
//{
//    for (int k = spc; k >= 1; k--)
//    {
//        Console.Write(" ");
//    }

//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("{0} ", i);
//    }
//    Console.Write("\n");
//    spc--;
//}


//Console.Write("Input number of rows : ");
//int p, q;
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    if (i % 2 == 0)
//    { p = 1; q = 0; }
//    else
//    { p = 0; q = 1; }
//    for (int j = 1; j <= i; j++)
//        if (j % 2 == 0)
//            Console.Write("{0}", p);
//        else
//            Console.Write("{0}", q);
//    Console.Write("\n");
//}

//for (int i = 0; i <= rows; i++)
//{
//    for (int j = 1; j <= rows-i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.Write("\n");
//}
//for (int i = rows-1 ; i >= 1; i--)
//{
//    for (int j = 1; j <= rows - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.Write("\n");
//}
//int num ,start,end,ctr;
//Console.Write("Input starting number of range: ");
//int.TryParse((string)Console.ReadLine(), out start);
//Console.Write("Input ending number of range: ");
//int.TryParse((string)Console.ReadLine(), out end);


//for (num = start; num <= end; num++)
//{
//    ctr = 0;

//    for (int i = 2; i <= num / 2; i++)
//    {
//        if (num % i == 0)
//        {
//            ctr++;
//            break;
//        }
//    }
//    if (ctr == 0 && num != 1)
//        Console.Write("{0} ", num);
//}
//Console.Write("\n");
//char ch = 'J';
//Console.WriteLine(ch+1);




//List<float> marks = new List<float>();
//Console.Write("Please enter number maker input ");
//int g;
//float sum = 0;
//int.TryParse(Console.ReadLine(), out g);
//for (int i = 0; i < g; i++)
//{
//    Console.Write("Please enter mark ");
//    float mark = float.Parse(Console.ReadLine());
//    marks.Add(mark);
//    sum += mark;
//}
//float avg = sum / marks.Count;
//float min = marks[0];
//Console.WriteLine("min {0}", min);
//for (int i = 0; i < marks.Count; i++)
//{
//    if (marks[i] < min)
//    {
//        min = marks[i];
//        continue;
//    }
//}
//float max = marks[0];
//for (int i = 0; i < marks.Count; i++)
//{
//    if (marks[i] > max)
//    {
//        max = marks[i];
//        continue;
//    }
//}
//Console.WriteLine("the minmum mark is : {0} , maxmum mark is : {1} and avarage marks is {2}", min, max, avg);





//int a = 5;
//int b = 2;
//Console.WriteLine(a/b);








//const int c = 3;

//int x = 5, y = 8, z = 4;
//Console.WriteLine(x * y + z * 2);


//int[] intArray = new int[];
//int[] array = new int[5];
//int array = new int[5];

//int x = 8;
//do
//{
//    Console.Write(x);
//    x++;
//} while (x <= 8);

//int i;
//Console.WriteLine(i);


//int k = 2;
//display(k);

//void display(int val = 3)
//{
//    Console.Write(val);
//}



//int i = 0;
//for (; ; )
//{
//    if (i < 5)
//        Console.Write(i);
//    else
//        break;
//    i++;
//}

//int i = 5;
//int x = i;
//x = 7;
//Console.WriteLine(i);

//Class1 class1 = new Class1();
//Console.WriteLine(class1.Id);


//Person person = new Person();
//Console.WriteLine(person.Id);

//Person person = new Person();
//Console.WriteLine(person.Id);


//int[] arr = { 1, 2, 3, 4, 5 };
//Console.Write(arr[5]);
//int m;


//Stack<int> stack = new Stack<int>();
//Queue<int> queue = new Queue<int>();

//LinkedList<int> list = new LinkedList<int>();



//static void PrintNumbers(int x,int y)
//{
//    int z = (x < y) ? x : y;
//    int n = (x > y) ? x : y;
//    for (int i = z+1; i < n; i++)
//    {
//        Console.WriteLine(i);
//    }
//}

//PrintNumbers(16,6);

//AplusExam aplus = new AplusExam();
//aplus.Mark = 88.56;



//static void PrintNumbers(int x, int y)
//{
//    int z = (x < y) ? x : y;
//    int n = (x > y) ? x : y;
//    for (int i = z + 1; i < n; i++)
//    {
//        Console.WriteLine(i);
//    }
//}



//static void PrintNumbers()
//{
//    int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//    foreach (int i in numbers)
//    {
//        Console.WriteLine(i);
//    }
//}

//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

int[] array = { 1, 2, 3, 5, 6, 8, 9, 10 };
for(int i = 1; i <= array.Length; )
{
   if(i != array[i-1]  )
    {
        Console.WriteLine(i);
        break;
    }
    else
    {
        i++;
    }
}




















