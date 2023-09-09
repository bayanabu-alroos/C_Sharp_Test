////*****************************************For Loop

//for(int i = 0; i < 4; i++)
//{
//    int a;
//    if (int.TryParse(Console.ReadLine(),out a))
//    {
//        Console.WriteLine("Very Good");
//    }
//    else
//    {
//        Console.WriteLine("Invalid Input Please Try Agin ");
//    }

//}

//***While

//int a ,counter = 0;

//int.TryParse(Console.ReadLine(), out a);
//while (a != 100 && counter < 3)
//{
//    counter++;
//    Console.WriteLine("Invalid Input Please Try Agin ");
//    int.TryParse(Console.ReadLine(), out a);
//}
//Console.WriteLine("Very Good");


//int a, counter = 0;

//int.TryParse(Console.ReadLine(), out a);
//while ( counter < 4)
//{
//    counter++;
//    if (a == 100)
//    {
//        Console.WriteLine("Very Good");
//        break;
//    }  
//    Console.WriteLine("Invalid Input Please Try Again ");
//    int.TryParse(Console.ReadLine(), out a);
//}


//int.TryParse(Console.ReadLine(), out a);
//while (true)
//{
//    if (a == 100)
//    {
//        Console.WriteLine("Very Good");
//        break;
//    }
//    else
//    {
//        if (counter < 3)
//        {
//            counter++;
//            Console.WriteLine("Invalid Input Please Try Again ");
//            continue;
//        }
//        break;

//    }

//}

//int a,counter = 0 ;
//do
//{
//    int.TryParse(Console.ReadLine(), out a);
//    if (a  == 100)
//    {
//        Console.WriteLine("Very Good");
//        break;
//    }
//    counter++;
//}while (a != 100 && counter < 4);



using System.Data;
///
/// Do while
/// 
string name = "Bayan";
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine(name);
//}
int counter = 0;
//while (counter < 4)
//{
//    counter++;
//    Console.WriteLine(name);
//}

//do
//{
//    Console.WriteLine(name);
//    counter++;
//} while (counter < 4);

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//int i, result = 0;
//for (i = 1; i <= 20; i++)
//{
//    //result = result + (i + 10);
//    result +=  (i + 10);
//}
//Console.WriteLine("Result Sum from 1 to 20 plus 10 = {0}", result);


//int sum = 0;
//for (i = 1; i <= 10; i++)
//{
//    //result = result + (i + 10);
//    sum += i;
//}
//Console.WriteLine("Result Sum from 1 to 10  = {0}", sum);

//int a = 0, count = 0;
//while (count <= 10)
//{
//    a += count;

//    count++;
//}
//Console.WriteLine("Result Sum from 1 to 10  = {0}", a);


//int test = 0;
//for (i = 1; i <= 10; i+=2)
//{
//    //result = result + (i + 10);
//    test += i;
//}
//Console.WriteLine("Result Sum from 1 to 10  = {0}", test);




////number factorial
//int fact = 1;
//for(i = 1; i <= 5; i++)
//{
//    fact *= i;
//}Console.WriteLine("Result Sum 1*2*3*4*5  = {0}", fact);

////Multiplation 
//int mult = 1;
//for (i = 1; i <= 50; i+=2)
//{
//    mult *= i;
//}
//Console.WriteLine("Result Sum 2*4*.....*50  = {0}", mult);

//Console.WriteLine("Please Enter Number Greater than 3");
//int row = 0;

//while (row < 3)
//{
//    int.TryParse(Console.ReadLine(), out row);
//}
//for (int i = 0; i < row; i++)
//{
//    for (int j = i; j > 0; j--)
//        Console.WriteLine("*");
//    Console.WriteLine();

//}

//int row = 0;

//while (row < 3)
//{
//    int.TryParse(Console.ReadLine(), out row);
//}
//for (int i = 1; i <= row; i++)
//{
//    for (int j = row - i; j > 0; j--)
//        Console.WriteLine(" ");
//    for (int j = i; j > 0; j--)
//        Console.WriteLine("*");

//    Console.WriteLine();

//}

int rows = 0;

while (rows < 3)
{
    int.TryParse(Console.ReadLine(), out rows);
}
for (int i = 1; i <= rows; i++)
{
    for (int j = rows - i; j > 0; j--)
        Console.Write(" ");
    for (int j = i; j > 0; j--)
        Console.Write("*");
    Console.WriteLine();
}


//int rows = 0;

//while (rows < 3)
//{
//    int.TryParse(Console.ReadLine(), out rows);
//}
//for (int i = 1; i <= rows; i++)
//{
//    for (int j = i; j > 0; j--)
//        Console.Write("*");
//    //for (int j = 0; j < i; j++)
//    //    Console.Write("*");
//    Console.WriteLine();
//}



