//int x = 4, y = 2;

//Console.WriteLine(y * y-- - +y + x-- * y); ///7


//int t = 9;
//int r = 66;
//int o = 15;
//Console.WriteLine(++t * r-- - o % t / r--);//660

//int a = 7;
//int b = 2;
//int c = 6;
//int result = (++a * c - ++c + b-- * a++);//57
//Console.WriteLine(result);



string s = Console.ReadLine();
int b;
Int32.TryParse(s, out b);
float f;
float.TryParse(s, out f);
Console.WriteLine(s , b );

int num1 ,num2 ;
Int32.TryParse(Console.ReadLine(), out num1);
Int32.TryParse(Console.ReadLine(), out num2);

Console.WriteLine(s , num1 + num2);

