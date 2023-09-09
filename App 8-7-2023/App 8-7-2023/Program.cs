//Convert

//string ---> numeric 
//string test = "150";
//byte a = Convert.ToByte(test);
//short b = Convert.ToInt16(test);
//int c = Convert.ToInt32(test);
//long d = Convert.ToInt64(test);
//float f = Convert.ToSingle(test);
//double g = Convert.ToDouble(test);
//decimal h = Convert.ToDecimal(test);
//Console.WriteLine(c + 20);
//==================================================
//string ---> boolean
//string test2 = "TRue";
//bool b1 = Convert.ToBoolean(test2);
//Console.WriteLine(b1);
//==================================================
//string ---> char
//string test3 = "H";
//char c3 = Convert.ToChar(test3);
//Console.WriteLine((int)c3);

//data-string

//numberic , char , boolean -----> String 
//byte a = 10 + 1;
//short b = 10 + 2;
//int c = 10 + 3;
//long d = 10 + 4;
//float f = 10 + 5;
//double g = 10 + 6;
//decimal hc = 10 + 7;
//char c1 = 'd';
//bool b1 = true;
//string z = b1 + "";
//string z2 = b1.ToString();
//Console.WriteLine(a);
//Console.WriteLine(z);
//Console.WriteLine(z2);

//implicit
//byte ---> short,int,long,float,double,decimal,string
//byte a = 8;
//short b = a;
//int c = a;
//long d = a;
//float e = a;
//double f = a;
//decimal g = a;
////short --->int,long,float,double,decimal
//short b1 = 75;
//int c1 = b1;
//long d1 = b1;
//float e1 = b1;
//double f1 = b1;
//decimal g1 = b1;

////int --->long,float,double,decimal
//int c2 = 180;
//long d2 = c2;
//float e2 = c2;
//double f2 = c2;
//decimal g2 = c2;
////long ---> float,double,decimal
//long d3 = 96592959626959652;
//float e3 = d3;
//double f3 = d3;
//decimal g3 = d3;
////float ----> double,decimal
//float e4 = 85.95266952632f;
//double f4 = e4;
////double ----> decimal
//double d5 = 85950.553544851;
////char --> int . long .float .double .decimal 
//char v = 'D';
//int z = v;
//long zzzz = v;
//double zzz2 = v;


//Parse
//string ---> numeric 
//string test = "150";
//byte a = Byte.Parse(test);
//short b = Int16.Parse(test);
//int c = Int32.Parse(test);
//long d = Int64.Parse(test);
//float f = float.Parse(test);
//double g = Double.Parse(test);
//decimal h = Decimal.Parse(test);
//Console.WriteLine(c + 20);
////==================================================
////string ---> boolean
//string test2 = "TRue";
//bool b1 = Boolean.Parse(test2);
//Console.WriteLine(b1);
////==================================================
////string ---> char
//string test3 = "H";
//char c3 = Char.Parse(test3);
//Console.WriteLine((int)c3);


//Plus

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num1 + num2);
//***************************************************
//int num11 = Int32.Parse(Console.ReadLine());
//int num22 = Int32.Parse(Console.ReadLine());
//Console.WriteLine(num11 + num22);
//****************************************************
//int num111, num222;
//Int32.TryParse(Console.ReadLine(), out num111);
//Int32.TryParse(Console.ReadLine(), out num222);
//Console.WriteLine(num111 + num222);


//staticCasting

//double ---> decimal , long,int ,short,byte
double doc = 158523.544658415;
decimal a = (decimal)doc;
long b = (long)doc;
int c = (int)doc;
short d = (short)doc;
byte e = (byte)doc;

//char --> 
byte tb1 = 97;
byte tb2 = 98;
byte tb3 = 99;
byte tb4 = 100;

short tb25 = 8535;
double uy = 97.966264;
char testChar = (char)uy;
Console.Write("" + (char)tb1 + (char)tb2 + (char)tb3 + (char)tb4);