
/*
    *
   ***
  *****
 *******
*********
 
 
 */

int rows =0;

Console.Write("Please Enter Number Grater than 3 ");


while (rows < 3)
{
    int.TryParse(Console.ReadLine(), out rows);
}
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= rows - i; j++)
        Console.Write(" ");
    for (int k = i * 2 - 1; k > 0; k--)
        Console.Write("*");
    //for (int j = 0; j < i; j++)
    //    Console.Write("*");
    Console.WriteLine();
}

/*
 
*
**
***
****
*****


 */



while (rows < 3)
{
    int.TryParse(Console.ReadLine(), out rows);
}
for (int i = 1; i <= rows; i++)
{
    for (int j = i; j > 0; j--)
        Console.Write("*");
    //for (int j = 0; j < i; j++)
    //    Console.Write("*");
    Console.WriteLine();
}

/*
    *
   **
  ***
 ****
*****
 
 */

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



while (rows < 3)
{
    int.TryParse(Console.ReadLine(), out rows);
}
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= (rows+1) - i; j++)
        Console.Write("*");
    Console.WriteLine();
}


