/*
 *Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user
 */
//int num;
//int multip = 1;
//for (int i = 1; i <= 3; i++)
//{
//    Console.Write("Please Enter {0} Number  : ", i);
//    int.TryParse(Console.ReadLine(), out num );
//    multip *= num;
//}
//Console.WriteLine("the multiplication of three numbers : {0}",multip);

/*
 Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user
 */

//int num1, num2;


//Console.Write("Please Enter First Number  : ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Please Enter First Number  : ");
//int.TryParse(Console.ReadLine(), out num2);
//int add = num1 + num2;
//int subtract = num1 - num2;
//float divid= num1 / num2;
//float multiply = num1 * num2;

//Console.WriteLine("{0} + {1} = {2}", num1, num2, add);
//Console.WriteLine("{0} - {1} = {2}", num1, num2, subtract);
//Console.WriteLine("{0} / {1} = {2}", num1, num2, divid);
//Console.WriteLine("{0} * {1} = {2}", num1, num2, multiply);


/*
 Write a C# Sharp program that prints the multiplication table of a number as input.

 */
//int num;
//Console.Write("Please Enter  Number  : ");
//int.TryParse(Console.ReadLine(), out num);
//Console.WriteLine("The table is {0}: ",num);
//for (int i = 1; i <= 10; i++)
//{
//    int result = i * num;
//    Console.WriteLine("{0} x {1} = {2}",num ,i , result);
//}

/*
 Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20

 */

//int num1, num2;

//Console.Write("Please Enter First Number  : ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Please Enter First Number  : ");
//int.TryParse(Console.ReadLine(), out num2);
//Console.WriteLine(num1 == 20 || num2 == 20 || num1 + num2 == 20);

/*
 Write a C# program to print odd numbers from 1 to 99. Prints one number per line
 */

//Console.Write("Odd Numbers from 1 to 99 : ");
//for(int i = 1; i < 100; i++)
//{
//    if(i % 2 != 0)
//    {
//        Console.Write("{0},", i);
//    }
//}


/*
 Write a C# program to check if a given positive number is a multiple of 3 or 7.
 */

//int num;
//Console.Write("Please Enter Positive  Number  : ");
//int.TryParse(Console.ReadLine(), out num);
//if (num > 0)
//{
//    Console.WriteLine(num % 3 == 0 || num % 7 == 0);
//}


/*
 Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.
 */
//int num1, num2;
//Console.Write("Please Enter  Number  less than 100 : ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Please Enter  Number greater than 200 : ");
//int.TryParse(Console.ReadLine(), out num2);
//Console.WriteLine(num1 < 100 && num2 > 200);


/*
 Write a C# program to compute the sum of all the elements of an array of integers.
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
 */

//int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1}; 
//int sum = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    sum += array[i];
//}
//Console.WriteLine("the sum of all the elements of an array of integers : {0}",sum);


/*er
 * Write a C# Sharp program to get the index number of all lower case letters in a given string.
97-122 ascii code 
 */

//Console.Write("Please Enter Letters : ");
//string word  = Console.ReadLine();
//Console.Write("The index number of all lower case letters in a given string : ");
//for (int i = 0; i < word.Length; i++)
//{
//    char result = word[i];
//    int index = result;
//    if (index >= 97 && index <= 122)
//    {
//        Console.Write("{0} ,", i);
//    }
//}

/*
 Write a C# Sharp program to accept two integers and check whether they are equal or not.
 */

//int num1, num2;
//Console.Write("Please Enter First Number :");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Please Enter Second Number :");
//int.TryParse(Console.ReadLine(), out num2);

//if (num1 == num2)
//{
//    Console.WriteLine("{0} and {1} are equal", num1, num2);
//}
//else
//{
//    Console.WriteLine("{0} and {1} are not equal", num1, num2);
//}


/*
 Write a C# Sharp program to check whether a given number is positive or negative.
 */

//int num;
//Console.Write("Please Enter Number : ");
//int.TryParse(Console.ReadLine(), out num);
//if (num < 0)
//{
//    Console.WriteLine("This number is positive");
//}
//else
//{
//    Console.WriteLine("This number is negative");
//}

/*
 Write a C# Sharp program to find the largest of three numbers.
 */
//int[] numbers = new int[3];
//for (int i = 1; i <= numbers.Length; i++)
//{
//    Console.Write("Please Enter {0} Number :", i);
//    int.TryParse(Console.ReadLine(), out numbers[i-1]);
//}
//if (numbers[0] > numbers[1])
//{
//    if (numbers[0] > numbers[2])
//    {
//        Console.WriteLine("The Number {0} is largest", numbers[0]);
//    }else {
//        Console.WriteLine("The Number {0} is largest", numbers[2]);
//    }
//}
//else if (numbers[1] > numbers[2])
//{
//    Console.WriteLine("The Number {0} is largest", numbers[1]);
//}
//else
//{
//    Console.WriteLine("The Number {0} is largest", numbers[2]);
//}

/*
 Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number such as 
666666
66666
6666
666
66
6 
 */
//int row;
//Console.Write("Please Enter  Number :");
//int.TryParse(Console.ReadLine(), out row);
//for (int i = row; i > 0; i--)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write(row);
//    }
//    Console.WriteLine("\n");
//}

/*
 Create a function that takes the age in years and returns the age in days.

Notes : Use 365 days as the length of a year for this challenge.

 */

//static void AgeInYears(int y)
//{
//    int age_in_days;
//    age_in_days = y * 365;

//    Console.WriteLine("The age in days = {0}", age_in_days);
//}

//Console.Write("Please Enter your age : ");
//int age;
//int.TryParse(Console.ReadLine(), out age);
//AgeInYears(age);

/*
 Write a function that converts hours into seconds.
60 seconds in a minute, 60 minutes in an hour.Don't forget to return your answer

 */

//static void ConvertHours(int h)
//{
//    int minutes, seconds;

//    minutes = h * 60;
//    seconds = h * 60 * 60;

//    Console.WriteLine("Minutes = " + minutes +
//                      ", Seconds = " + seconds);
//}
//int hour;
//Console.Write("Please Enter Hours : ");
//int.TryParse(Console.ReadLine(), out hour);
//ConvertHours(hour);


/*
 Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.
 */

//static void Circle(float x)
//{
//    double perimeter, area;

//    perimeter = 2 * x * Math.PI;
//    area =  Math.PI * Math.Pow(x,2);

//    Console.WriteLine("The perimeter of the circle : {0} and the  area of the circle : {1}",perimeter,area);
//}

//float  radius;
//Console.Write("Please enter the radius of a circle as input : ");
//float.TryParse(Console.ReadLine(),out radius);

//Circle(radius);


/*
 Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.

 */

//static void CheckNumbers (int x , int y)
//{
//    bool bothEven = ((x % 2 == 0) && (y % 2 == 0)) ? true : false;
//    Console.WriteLine(bothEven ? "there're numbers bothEven" : "there's number Odd");
//}
//int num1, num2;
//Console.Write("Please Enter First Number : ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Please Enter Second Number : ");
//int.TryParse(Console.ReadLine(), out num2);

//CheckNumbers(num1, num2);

/*
 Write a C# Sharp program to calculate true mean value, mean with rounding away from zero and mean with rounding to the nearest of some specified decimal values.
Expected Output:
True Mean: 16.36
Away From Zero: 16.37
Rounding to Nearest: 16.35
*
 */

//static void MeanValue(List<decimal> numbers)
//{
//    decimal sum = 0;
//    decimal mean;
//    foreach (var item in numbers)
//    {
//        sum += item;
//    }

//    Console.WriteLine("True Mean: {0}", sum / numbers.Count);
//    Console.WriteLine("Away From Zero: {0}",(Math.Round(sum, 1, MidpointRounding.AwayFromZero)) / numbers.Count);
//    Console.WriteLine("Rounding to Nearest:  {0}", (Math.Round(sum, 1, MidpointRounding.ToEven)) / numbers.Count);
//}
//List<decimal> list = new List<decimal>();
//decimal x;
//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Please Enter Number decimal : ");
//    decimal.TryParse(Console.ReadLine(), out x);
//    list.Add(x);
//}
//MeanValue(list);

/*
 Write a C# Sharp program to find the sum of the first 10 natural numbers.
 */

//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    sum += i;
//}
//Console.WriteLine("the sum of the first 10 natural numbers : {0}",sum);

/*
 Write a C# Sharp program to read 10 numbers and find their average and sum.

 */

//int sum = 0;
//float average;
//int [] numbers = new int[10];
//for (int i = 1; i <= numbers.Length; i++)
//{
//    Console.Write("Please Enter {0} Number : ",i);
//    int.TryParse(Console.ReadLine(), out numbers[i-1]);
//    sum += numbers[i-1];
//}

//average = sum / ((float) (numbers.Length));
//Console.WriteLine("The Sum Numbers is : {0} ,Average Numbers is : {1}",sum,average);


/*
 
Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
Test Data
Input number of terms : 10
Expected Output :
The odd numbers are :1 3 5 7 9 11 13 15 17 19
The Sum of odd Natural Number upto 10 terms : 100
*
 */

//int num;
//int sum = 0;
//Console.Write("Input number of terms : ");
//int.TryParse(Console.ReadLine(), out num);
//Console.Write("The odd numbers are :");
//for (int i = 1; i <= num; i++)
//{
//    int odd = i *2 - 1;
//    Console.Write("{0} ",odd);
//    sum += odd;
//}
//Console.WriteLine("\n The Sum of odd Natural Number upto {0} terms : {1}" ,num ,sum);

/*
 Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

   *
  ***
******
 */




//int row, spc;
//int sum = 0;
//Console.Write("Please Enter Number of row :");
//int.TryParse(Console.ReadLine(), out row);
//spc = row + 4 - 1;

//for (int i = 1; i <= row; i++)
//{
//    sum += i;

//    for (int j = spc; j >= 1; j--)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= sum; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//    spc--;
//}


/*
 Write a program using a switch statement that takes one value from the user and asks about the type of conversion and then performs a conversion depending on the type of conversion. If user enters:

I -> convert from inches to centimeters.
G -> convert from gallons to liters.
M -> convert from mile to kilometer.
P -> convert from pound to kilogram.

 */

int value;
char choice;
double centimeters, liters, kilometer, kilogram;
Console.Write("Please Enter number a digit value : ");
int.TryParse(Console.ReadLine(), out value);
Console.WriteLine("Please Choice Letter of the given choices : \n " +
    "I -> convert from inches to centimeters.\n" +
    "G -> convert from gallons to liters.\n " +
    "M -> convert from mile to kilometer.\n " +
    "P -> convert from pound to kilogram.\n");
Console.Write("The Choice letter is : ");
char.TryParse(Console.ReadLine(), out choice);
switch (choice)
{
    case 'I':
        centimeters = value / 0.3937;//1 cm is equal is 0.3937 inch
        Console.WriteLine("\n In Centimeters : {0}",centimeters);
        break;
    case 'i':
        centimeters = value / 0.3937;//1 cm is equal is 0.3937 inch
        Console.WriteLine("\n In Centimeters : {0}", centimeters);
        break;
    case 'G':
        liters = value * 3.7854; // 1 gallon=3.7854 litters
        Console.WriteLine("\n In Liters : {0}", liters);
        break;
    case 'g':
        liters = value * 3.7854; // 1 gallon=3.7854 litters
        Console.WriteLine("\n In Liters : {0}", liters);
        break;
    case 'M':
        kilometer = value * 1.6093;//1 mile = 1.6093 kilometer
        Console.WriteLine("\n In Kilometer : {0}", kilometer);
        break;
    case 'm':
        kilometer = value * 1.6093;//1 mile = 1.6093 kilometer
        Console.WriteLine("\n In Kilometer : {0}", kilometer);
        break;
    case 'P':
        kilogram = value * 0.45359;//1 pound = 0.45359 kilogram
        Console.WriteLine("\n In Kilometer : {0}", kilogram);
        break;
    case 'p:
        kilogram = value * 0.45359;//1 pound = 0.45359 kilogram
        Console.WriteLine("\n In Kilometer : {0}", kilogram);
        break;
    default:
        Console.WriteLine("You Enter A Invalid Choice");
        break;
}

/*
 Write a C# Sharp program that takes three letters and displays them in reverse order.
 */

//char [] letter = new char[3];
//for (int i = 0; i < letter.Length; i++)
//{
//    Console.Write("Input letter: ");
//    char.TryParse(Console.ReadLine(), out letter[i]);
//}

//letter.Reverse();
//Console.Write("letter them reverse order : ");

//for (int i = letter.Length - 1;i >= 0; i--)
//{
//    Console.Write("{0} ", letter[i]);
//}

/*
 Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.

 */
//char chars;
//Console.Write("Input letter: ");
//char.TryParse(Console.ReadLine(), out chars);

//if ((chars == 'a') || (chars == 'e') || (chars == 'i') || (chars == 'o') || (chars == 'u') ||
//    (chars == 'A') || (chars == 'E') || (chars == 'I') || (chars == 'O') || (chars == 'U'))
//{
//    Console.WriteLine("It's a  vowel.");
//}
//else if(chars >=0 || chars <= 9)
//{
//    Console.WriteLine("It's a  digit.");

//}
//else
//{
//    Console.WriteLine("It's a  any other symbol.");
//}



