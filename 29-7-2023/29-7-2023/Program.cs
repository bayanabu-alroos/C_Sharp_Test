/*
 random
 */

//Random random = new Random();
//Console.WriteLine(random.Next(10));
//Console.WriteLine(random.Next(111111,9999990));
//Console.WriteLine(random.NextDouble());
//Console.WriteLine(random.NextSingle());
//Console.WriteLine(random.NextInt64(999999)); /// فوق ست خانات 
//Console.WriteLine(random.NextDouble());

/********************************************************************************/
//Console.WriteLine((char)random.Next(65,90));
//Console.WriteLine(Convert.ToChar(random.Next(65, 90)));
//Console.WriteLine();


int size = 0;
char[] pass;
Random random = new Random();
do
{
    Console.Write("Plese enter Length password :");
    int.TryParse(Console.ReadLine(), out size);
    pass = new char[size];
} while (size >= 4 || size <= 16);

for (int i = 0; i < pass.Length; i++)
{
    if (pass.Length >= 4 || pass.Length < 8)
    {
        if (random.Next() % 2 == 0)
        {
            pass[i] = (char)random.Next(97, 122);
        }
        else
        {
            pass[i] = (char)random.Next(47, 57);
        }
    }
    else if (pass.Length >= 8 || pass.Length < 12)
    {
        if (random.Next() % 2 == 0)
        {
            pass[i] = (char)random.Next(97, 122);
        }
        else
        {
            if (random.NextSingle() > 2)
            {
                pass[i] = (char)random.Next(47, 57);
            }
            else
            {
                pass[i] = (char)random.Next(65, 90);
            }
        }
    }
    else if (pass.Length >= 12 || pass.Length <= 16)
    {
        if (random.Next() % 2 == 0)
        {
            pass[i] = (char)random.Next(97, 122);
        }
        else
        {
            if (random.NextSingle() > 2)
            {
                pass[i] = (char)random.Next(47, 57);
            }
            else
            {

                pass[i] = (char)random.Next(65, 90);
            }
        }
    }
}

//Console.WriteLine(Math.PI);
//Console.WriteLine(Math.Min(7,10));
//Console.WriteLine(Math.Sqrt(7));
//Console.WriteLine(Math.Abs(-7));
//Console.WriteLine(Math.Round(8.55679256666));
//Console.WriteLine(Math.Floor(5.99999999999999999999999999));///رقم خانة 17  بعد الفاصلة اكبر  من خمسة يتم تقريب العدد الصحيح 
//Console.WriteLine(Math.Ceiling(8.0000000000000001));
//Console.WriteLine(Math.Pow(5,2));



List<string> names = new List<string>();//قابلة للتعديل وبدون تحديد حجم  لها 
names.Add("Bayan");
names.Insert(0, "Hi");
names.Add("0");
names.Add("1"); 








