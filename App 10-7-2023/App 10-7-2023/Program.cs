//int num1, num2;
//Console.WriteLine("Please Enter a Number :");
//int.TryParse(Console.ReadLine(), out num1);
//Console.WriteLine("Please Enter a Number : ");
//int.TryParse(Console.ReadLine(), out num2);
//int num3 = num1 * num2;
//Console.WriteLine(num1 * num2);
//if (num3 > 100)
//{
//    Console.WriteLine("write User Name :");
//    string x = Console.ReadLine();
//    Console.WriteLine("Welcome\t" + x);
//}
//else
//{
//    Console.WriteLine("Good Luck!");
//}
//Console.WriteLine("End");

//if (num3 > 100)
//{
//    Console.WriteLine("write User Name :");
//    string x = Console.ReadLine();
//    Console.WriteLine("Welcome\t" + x);
//    if (num1 % 2 == 0 && num2 % 2 == 0)
//    {
//        Console.WriteLine("both is even number ");
//    }
//    else
//    {
//        if (num1 % 2 == 1 && num2 % 2 == 1)
//        {
//            Console.WriteLine("both is odd number ");
//        }
//        else
//        {
//            if (num1 % 2 == 0)
//            {
//                Console.WriteLine("first number is odd number and the second number is even");
//            }
//            else
//            {
//                Console.WriteLine("first number is even number and the second number is odd");
//            }
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Good Luck!");
//}

//float length, width;
//Console.WriteLine("Please Enter a Floor  length Meter :");
//float.TryParse(Console.ReadLine(), out length);
//Console.WriteLine("Please Enter a Floor width Meter: ");
//float.TryParse(Console.ReadLine(), out width);
//float area  = length * width /1000;

//if (area/1000 > 10)
//{
//    Console.WriteLine("Area = {0} Squared Master " , area);
//    Console.WriteLine("Meter price = 200 JOD");
//    Console.WriteLine("The Price for this area is = {0}" , area/200);
//}
//else
//{
//    Console.WriteLine("Area = {0} Squared Master ", area);
//    Console.WriteLine("Meter price = 225 JOD");
//    Console.WriteLine("The Price for this area is = {0}", area / 225);
//}

//float mark;
//Console.WriteLine("Please Enter a Mark :");
//float.TryParse(Console.ReadLine(), out mark);


//if (mark < 50)
//{
//    Console.WriteLine("F");
//}
//else if (mark > 50 && mark <= 55)
//{
//    Console.WriteLine("D-");
//}
//else if (mark > 55 && mark <= 60)
//{
//    Console.WriteLine("D");
//}
//else if (mark > 60 && mark <= 65)
//{
//    Console.WriteLine("D+");
//}
//else if (mark > 65 && mark <= 70)
//{
//    Console.WriteLine("C-");
//}
//else if (mark > 70 && mark <= 75)
//{
//    Console.WriteLine("C");
//}
//else if (mark > 75 && mark <= 80)
//{
//    Console.WriteLine("C+");
//}
//else if (mark > 80 && mark <= 85)
//{
//    Console.WriteLine("B-");
//}
//else if (mark > 85 && mark <= 90)
//{
//    Console.WriteLine("B");
//}
//else if (mark > 90 && mark <= 92)
//{
//    Console.WriteLine("B+");
//}
//else if (mark > 92 && mark <= 96)
//{
//    Console.WriteLine("A-");
//}
//else if (mark >  96)
//{
//    Console.WriteLine("A");
//}



//float totalPrice;
//float discountPresent;
//Console.WriteLine("Please Enter a TotalPrice:");
//float.TryParse(Console.ReadLine(), out totalPrice);
//Console.WriteLine("Please Enter a Number : ");
//float.TryParse(Console.ReadLine(), out discountPresent);

//if (discountPresent == 0)
//{
//    Console.WriteLine("Net Price  = {0}", (totalPrice));
//}
//else if (discountPresent == 10 || discountPresent == 20)
//{
//    Console.WriteLine("Net Price  = {0}", (totalPrice - (totalPrice * discountPresent / 100)));
//}
//else
//{
//    Console.WriteLine("Invalid Discount Present ");
//    Console.WriteLine("Net Price  = {0}", (totalPrice));
//}

//switch (discountPresent)
//{
//    case 0:
//        Console.WriteLine("Net Price  = {0}", (totalPrice));
//        break;
//    case 10:
//    case 20:
//        Console.WriteLine("Net Price  = {0}", (totalPrice - (totalPrice * discountPresent / 100)));
//        break;
//    default:
//        Console.WriteLine("Invalid Discount Present ");
//        goto case 0;
//        break;

//}

//float num1, num2;
/*Console.WriteLine("Please Enter the num1:");
float.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("Please Enter the num2 :");
float.TryParse(Console.ReadLine(), out num2);

double price = (num1 + num2);
if (price > 100)
{
    Console.WriteLine("total price");
    Console.WriteLine(price);
    Console.WriteLine("your discount");
    Console.WriteLine(price * .10);
    Console.WriteLine("total price");
    Console.WriteLine(price - (price * .10));
}
else
{
    if (price < 100)
        Console.WriteLine("total price");
    Console.WriteLine(price);
    Console.WriteLine("your discount");
    Console.WriteLine(price * .5);
    Console.WriteLine("total price");
    Console.WriteLine(price - (price * .5));
}*/


float bill;
Console.WriteLine("Please Enter the  value bill ");
if (float.TryParse(Console.ReadLine(), out bill))
{
    if (bill > 20)
    {
        Console.WriteLine("{0} Coupon 10 JD", bill);
    }
    else if (bill > 50)
    {
        Console.WriteLine("{0} Coupon 20 JD", bill);
    }
    else if (bill > 100)
    {
        Console.WriteLine("Discount bill 25% on total price :", bill - (bill * 0.25));
    }
    else
    {
        Console.WriteLine("No Discount or Coupon in the billing ",bill);
    }
}
else
{
    Console.WriteLine("invalid input ");
}






char char1;  // --> [#$&!@]
int num3;   // 50 > 70
double num4;  // between 0 and 1 floating number 
bool boolean; //  true - false 

Console.WriteLine("Please enter Character: ");

if (char.TryParse(Console.ReadLine(), out char1))
{
    int num8 = char1;

    if (num8 == 33 || num8 ==  36 || num8 ==  35 || num8 == 33  || num8 == 32)
    {
        Console.WriteLine("This is valid Character {0}: ", char1);
    }
    else
    {
        Console.WriteLine("This is invalid Character ");
    }
}
else
{
    Console.WriteLine("This is invalid Character ");
}

Console.WriteLine("Please enter your name : ");

string text ; //---> Name 
if ((text = Console.ReadLine()) == "Bayan")
{
    Console.WriteLine("Correct String Input");
}
else
{
    Console.WriteLine("Invalid String Input");
}

if ((text = Console.ReadLine()) == "Bayan")
{
    Console.WriteLine("Correct String Input");
}
else
{
    if ((text = Console.ReadLine()) == "Bayan")
    {
        Console.WriteLine("Correct String Input");
    }
    else
    {
        if ((text = Console.ReadLine()) == "Bayan")
        {
            Console.WriteLine("Correct String Input");
        }
        else
        {
            Console.WriteLine("Invalid String Input");
        }
    }
}




Console.WriteLine("Please enter  Number : ");

if (Int32.TryParse(Console.ReadLine(), out num3))
{
    if (num3 > 50 && num3 < 70)
    {
        Console.WriteLine("This is valid Number  {0}: ", num3);
    }
    else
    {
        Console.WriteLine("This is invalid Number  ");
     }
}

Console.WriteLine("Please enter Number float between 1 - 0 : ");

if (double.TryParse(Console.ReadLine(), out num4))
{
    if (num4 > 0 && num4 < 1)
        Console.WriteLine("Correct Double Number");
    else
        Console.WriteLine("Invalid Double Number");
}
else
{
    Console.WriteLine("Invalid Input");
}


int num5;
Console.WriteLine("Please enter Number : ");

if (Int32.TryParse(Console.ReadLine(), out num5))
{
    if(num5 == 100 )
    {
        Console.WriteLine("This Number Valid Number");
    }
    else
    {
        Console.WriteLine("Please enter Number : ");
        Int32.TryParse(Console.ReadLine(), out num5);
        if (num5  == 100)
        {
            Console.WriteLine("This Number Valid Number");
        }
        else
        {
            Console.WriteLine("Please enter Number : ");
            Int32.TryParse(Console.ReadLine(), out num5);
        }
    }
}
else
{
    Console.WriteLine("Just enter integer numbers ");
}


