/*
 *   Write a C# Sharp program to print Hello and your name in a separate line.
Expected Output :
Hello: Alexandra Abramov
 */

//Console.WriteLine("Please Enter Your name ");
//string name = Console.ReadLine();
//Console.WriteLine("Hello {0}", name);


/*
 2. Write a C# Sharp program to print the sum of two numbers.
 */


//float x, y;

//Console.WriteLine("Please Enter First number ");
//float.TryParse(Console.ReadLine(), out x);
//Console.WriteLine("Please Enter Secound Number ");
//float.TryParse(Console.ReadLine(), out y);
//Console.WriteLine("Sum of two number  = {0}", x + y);

/*
 3. Write a C# Sharp program to print the result of dividing two numbers.
 */
//Console.WriteLine(" result of dividing two numbers = {0}",x / y);


/*
 4. Write a C# Sharp program to print the results of the specified operations.
Test data:

-1 + 4 * 6
( 35+ 5 ) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
Expected Output:
23
5
12
3
 */

//Console.WriteLine(" result of numbers -1 + 4 * 6 = {0}", -1 + 4 * 6);
//Console.WriteLine(" result of numbers ( 35+ 5 ) % 7 = {0}", (35 + 5) % 7);
//Console.WriteLine(" result of numbers 14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11);
//Console.WriteLine(" result of numbers 2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);


/*
 5. Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
 */


//int num1, num2, temp;
//Console.WriteLine("Please Enter First Number ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.WriteLine("Please Enter Secound Number ");
//int.TryParse(Console.ReadLine(), out num2);
//temp = num1;
//num1 = num2;
//num2 = temp;
//Console.WriteLine("After Swapping :\n First Number : {0} \n Second Number : {1}", num1 , num2);

/*
 6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
 */

//int num1, num2, num3, result;
//Console.WriteLine("Input the first number to multiply ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.WriteLine("Input the second number to multiply ");
//int.TryParse(Console.ReadLine(), out num2);
//Console.WriteLine("Input the third number to multiply ");
//int.TryParse(Console.ReadLine(), out num3);
//result = num1 * num2 * num3;

//Console.WriteLine(" the output of the multiplication of three numbers  = {0}", result);

/*
 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
 */

//int num1, num2, result;
//Console.Write("Input the first number : ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Input the second number : ");
//int.TryParse(Console.ReadLine(), out num2);

//Console.WriteLine(" {0} + {1} = {2}", num1, num2 ,num1 + num2);
//Console.WriteLine(" {0} - {1} = {2}", num1, num2, num1 - num2);
//Console.WriteLine(" {0} * {1} = {2}", num1, num2, num1 * num2);
//Console.WriteLine(" {0} / {1} = {2}", num1, num2, num1 / num2);
//Console.WriteLine(" {0} mod {1} = {2}", num1, num2, num1 % num2);


/*
 8. Write a C# Sharp program that prints the multiplication table of a number as input.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
 */

//int num1;
//Console.Write("Enter the number:");
//int.TryParse(Console.ReadLine(), out num1);
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine("{0} * {1} = {2}", num1, i, num1 * i);
//}

/*
 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
 */


//float[] num = new float[5];
//float sum = 0;
//for (float i = 1; i < num.Length; i++)
//{
//    Console.Write("Enter the {0} number:" , i);
//    float.TryParse(Console.ReadLine(), out num[num.Length - 1]);
//    sum += num[num.Length - 1];
//}
//Console.WriteLine("The average of Number input is :{0}", sum / (num.Length - 1));


//int num1 , num2 , num3 , num4 ;
//Console.Write("Enter the First number:");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Enter the Second number:");
//int.TryParse(Console.ReadLine(), out num2);
//Console.Write("Enter the third number:");
//int.TryParse(Console.ReadLine(), out num3);
//Console.Write("Enter the four number:");
//int.TryParse(Console.ReadLine(), out num4);
//sum = num1 + num2 + num3 + num4;

//Console.WriteLine("The average of {0} , {1} ,{2} ,{3} is :{4}", num1, num2, num3, num4, sum / 4);


/*
 10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
 */


//int x, y, z;
//Console.Write("Enter first number -");
//int.TryParse(Console.ReadLine(), out x); 
//Console.Write("Enter second number -");
//int.TryParse(Console.ReadLine(), out y);
//Console.Write("Enter third number -");
//int.TryParse(Console.ReadLine(), out z);
//int result1 = (x + y) * z;
//int result2 = (x * y) + (y * z);
//Console.WriteLine("Result of specified numbers {2}, {3} and {4}, (x+y).z is {0} and .y + y.z is {1}",result1,result2,x,y,z);


/*
 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
Test Data:
Enter your age - 25
Expected Output:
You look older than 25
 */


//int age;
//Console.Write("Enter your age - ");
//int.TryParse(Console.ReadLine(), out age);
//Console.WriteLine("You look older than {0}", age);

/*
 12. Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
Test Data:
Enter a digit: 25
Expected Output:
25 25 25 25
25252525
25 25 25 25
25252525
 */

//int num;
//Console.Write("Enter a digit: ");
//int.TryParse(Console.ReadLine(), out num);
//for (int i = 0; i < 2; i++)
//{
//    Console.WriteLine("{0} {0} {0} {0}", num);
//    Console.WriteLine("{0}{0}{0}{0}", num);
//}

/*
 13. Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5
Expected Output:
555
5 5
5 5
5 5
555
 */

//int num;
//Console.Write("Enter a number: ");
//int.TryParse(Console.ReadLine(), out num);
//Console.WriteLine("{0}{0}{0}", num);
//for (int i = 0; i < 2; i++)
//{
//    Console.WriteLine("{0} {0}", num);
//}
//Console.WriteLine("{0}{0}{0}", num);

/*
 14. Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86

Celsius = (5 (F-32))/9
Fahrenheit = (9C+(32*5))/5
Kelvin = c + 273
 */

//float C, F, K;
//Console.Write("Enter the amount of celsius: ");
//float.TryParse(Console.ReadLine(), out C);
//K = C + 273;
//F = (9 * C + (32 * 5)) / 5;
//Console.WriteLine("Kelvin = {0}", K);
//Console.WriteLine("Fahrenheit = {0}", F);

/*
 16. Write a C# program to create a new string from a given string where the first and last characters change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP
 */

//public class Exercise16
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(first_last("w3resource"));
//        Console.WriteLine(first_last("Python"));
//        Console.WriteLine(first_last("x"));
//    }
//    public static string first_last(string ustr)
//    {
//        return ustr.Length > 1
//            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
//    }
//}

////Console.Write("Enter your Word :");
////string str1 = Console.ReadLine();

////Console.Write(str1.Substring(str1.Length - 1) + str1.Substring(1, str1.Length - 2) + str1.Substring(0, 1));

/*
 17. Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
TThe quick brown fox jumps over the lazy dog.T
 */
//public class Exercise17
//{
//    static void Main(string[] args)
//    {
//        string str;
//        Console.Write("Input a string : ");
//        str = Console.ReadLine();
//        if (str.Length >= 1)
//        {
//            var s = str.Substring(0, 1);
//            Console.WriteLine(s + str + s);
//        }
//    }
//}

//Console.Write("Input a string : ");
//string str2 = Console.ReadLine();

//if (str2.Length >= 1)
//{
//    string firstCha = str2.Substring(0, 1);
//    Console.WriteLine(firstCha + str2 + firstCha);
//}

/*
 18. Write a C# program to check a pair of integers and return true if one is negative and one is positive.
Sample Output:
Input first integer:
-5
Input second integer:
25
Check if one is negative and one is positive:
True
 */

//int num1, num2;
//Console.Write("Input first integer: ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Input second integer: ");
//int.TryParse(Console.ReadLine(), out num2);

//Console.WriteLine("Check if one is negative and one is positive: ");
//Console.WriteLine((num1 < 0 && num2 > 0 || num1 > 0 && num2 < 0));

/*
 19. Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
 */

//int num1, num2;
//Console.Write("Input first integer: ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Input second integer: ");
//int.TryParse(Console.ReadLine(), out num2);
//if (num1 == num2)
//{
//    Console.WriteLine(" the triple of their sum = {0}", (num1 + num2) * 3);
//}
//else
//{
//    Console.WriteLine("sum two number is different input  = {0}", num1 + num2);
//}


/*
 20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.
 */
//int num1, num2;
//Console.Write("Input first integer: ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Input second integer: ");
//int.TryParse(Console.ReadLine(), out num2);
//if (num1 > num2)
//{
//    Console.WriteLine((num1 - num2) * 2);
//}
//else
//{
//    Console.WriteLine(num2 - num1);
//}


/*
 21. Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.
 */
//int num1, num2 , sum;
//Console.Write("Input first integer: ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Input second integer: ");
//int.TryParse(Console.ReadLine(), out num2);
//sum = num1 + num2;
//Console.WriteLine(num1 == 20 ||  num2 == 20 || sum == 20);

/*
 22. Write a C# program to check if the given integer is within 20 of 100 or 200.
Sample Output:
Input an integer:
25
False
 */

//int num;
//Console.Write("Input first integer: ");
//int.TryParse(Console.ReadLine(), out num);
//Console.Write(Math.Abs(num - 100) <= 20 || Math.Abs(num - 100) <= 20);

/*
 23. Write a C# program to convert a given string into lowercase.
Sample Output:
write a c# sharp program to display the following pattern using the alphabet.
 */
//Console.Write("Enter text : ");
//string str1 = Console.ReadLine();
//Console.WriteLine(str1.ToLower());

/*
 24. Write a C# program to find the longest word in a string.
Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
following
 */


//Console.Write("Enter your word : ");
//string str1  = Console.ReadLine();
//string[] words = str1.Split(new [] {" "}, StringSplitOptions.None);
//string word = "";
//int ctr  = 0;
//foreach (String i in words)
//{
//    if (i.Length > ctr)
//    {
//        word = i;
//        ctr = i.Length;
//    }
//}
//Console.WriteLine(word);

/*
 25. Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
Sample Output:
Odd numbers from 1 to 99. Prints one number per line.
1
3
5
7
9
...
95
97
99
 */

//for(int i = 1 ; i < 100; i++)
//{   if(i % 2 == 1)
//    {
//        Console.WriteLine(i);
//    }
//}

/*
 26. Write a C# program to compute the sum of the first 500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
824693
 */


//public class Exercise26
//{
//    public static void Main()
//    {
//        Console.WriteLine("\nSum of the first 500 prime numbers: ");
//        int sum = 0;
//        int ctr = 0;
//        int prime = 2;
//        while (ctr <= 500)
//        {
//            if (isPrime(prime))
//            {
//                sum += prime;
//                ctr++;
//            }
//            prime++;
//        }
//        Console.WriteLine(sum);
//    }
//    public static bool isPrime(int n)
//    {
//        int x = (int)Math.Floor(Math.Sqrt(n));
//        if (n == 1) return false;
//        if (n == 2) return true;

//        for (int i = 2; i <= x; ++i)
//        {
//            if (n % i == 0) return false;
//        }

//        return true;
//    }
//}


/*
 27. Write a C# program and compute the sum of an integer's digits.
Sample Output:
Input a number(integer): 12
Sum of the digits of the said integer: 3
 */

//int n;
//Console.Write("Input a number(integer): ");
//int.TryParse(Console.ReadLine(), out n);
//int sum = 0;
//while (n != 0)
//{
//    sum += n % 10;
//    n /= 10;
//}
//Console.WriteLine(sum);


/*
 28. Write a C# program to reverse the words of a sentence.
Sample Output:
Original String: Display the pattern like pyramid using the alphabet.
Reverse String: alphabet. the using pyramid like pattern the Display
 */

//Console.Write("Please enter words : ");
//string str = Console.ReadLine();
//List<string> list = new List<string>();
//string result = " ";
//string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
//for (int i = words.Length - 1; i >= 0; i--)
//{
//    result += words[i]+" " ;
//}
//list.Add(result);
//foreach (String x in list)
//{
//    Console.WriteLine("Reverse String: {0} ", x);
//}

/*
31. Write a C# program to multiply the corresponding elements of two integer arrays.
Sample Output:
Array1: [1, 3, -5, 4]
Array2: [1, 4, -5, -2]
Multiply corresponding elements of two arrays:
1 12 25 -8
 */

//int[] arr1 = { 1, 3, -5, 4 };
//int[] arr2 = { 1, 4, -5, -2 };
//for  (int i = 0; i <arr1.Length ; i++)
//{
//    Console.Write(arr1[i] * arr2[i] + " ");
//}

/*
 32. Write a C# program to create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
dog.dog.dog.dog.
 */
//Console.Write("Enter your word : ");
//string str1  = Console.ReadLine();

//if(str1.Length > 4)
//{
//    Console.WriteLine(str1.Length < 4 ? str1 + str1 + str1 + str1 : str1.Substring(str1.Length - 4) + str1.Substring(str1.Length - 4) + str1.Substring(str1.Length - 4) + str1.Substring(str1.Length - 4));
//}


/*
 33. Write a C# program to check if a given positive number is a multiple of 3 or 7.
Sample Output:
Input first integer:
15
True
 */

//int num;
//Console.Write("Input first integer: ");
//int.TryParse(Console.ReadLine(), out num);
//if (num % 3 == 0 || num % 7 == 0)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

/*
 34. Write a C# program to check if a string starts with a specified word.
Note: Suppose the sentence starts with "Hello"
Sample Data: string1 = "Hello how are you?"
Result: Hello.
Sample Output:
Input a string : Hello how are you?
True
 */

//string str;
//Console.Write("Input a string : ");
//str = Console.ReadLine();
//Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' ' ));


/*
 35. Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.
Sample Output:
Input a first number(<100): 75
Input a second number(>100): 250
True
 */

//int num1 ,num2;
//Console.Write("Input a first number(<100) : ");
//int.TryParse(Console.ReadLine(),out num1);
//Console.Write("Input a second number(>200): ");
//int.TryParse(Console.ReadLine(), out num2);
//Console.WriteLine(num1 < 100 && num2 > 200);


/*
 36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
Sample Output:
Input a first number: -5
Input a second number: 8
True
 */

//int num1, num2;
//Console.Write("Input a first number: ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Input a first number: ");
//int.TryParse(Console.ReadLine(), out num2);
//Console.WriteLine((num1 >= -10 && num1 <= 10) || (num2 >= -10 && num2 <= 10));

/*
 37. Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".
Test Data: PHP Tutorial
Sample Output:
P Tutorial
 */

//string str = "PHP Tutorial";
//Console.WriteLine("Originl String : ",str);
//Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));


/*
 38. Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
Test Data: PHP
Sample Output:
PH
 */
//string str = "PHP Tutorial";
//string result = "";
//Console.WriteLine("Originl String : {0}", str);
//if (str.Length >= 1 && str[0] == 'P')
//{
//    result += str[0];
//}
//if (str.Length >= 2 && str[1] == 'H')
//{
//    result += str[1];
//}
//Console.WriteLine(result);


/*
 39. Write a C# program to find the largest and lowest values from three integer values.
Test Data:
Input first integer:
15
Input second integer:
25
Input third integer:
30
Sample Output
Largest of three: 30
Lowest of three: 15
 */

//int[] nums = new int[3];
//for (int i = 1; i <= nums.Length; i++)
//{
//    Console.Write("Input {0} integer:",i);
//    int.TryParse(Console.ReadLine(), out nums[i]);
//}
//Console.WriteLine("Largest of three: {0}", nums.Max());
//Console.WriteLine("Lowest of three: {0}", nums.Min());


/*
 40. Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
Test Data:
Input first integer:
15
Input second integer:
12
Sample Output
15
 */


float[] nums = new float[5];
for (int i = 1; i <= nums.Length; i++)
{
    Console.Write("Input {0} integer:", i);
    float.TryParse(Console.ReadLine(), out nums[i]);
}

