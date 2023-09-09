// Casting 

//1 - implicit

//byte ---> short,int,long,float,double,decimal
byte test1 = 8;
short ttest1 = test1;
int ttesta = test1;
long ttestb = test1;
float ttestc = test1;
double ttestd = test1;
decimal tteste = test1;
//short --->int,long,float,double,decimal
short a = 8;
int b = a;
long c = a;
float d = a;
double e = a;
decimal f = a;  
//int --->long,float,double,decimal,char
int x = 10;
long y = x;
float z = x;
double n = x;
decimal v = x;
//long ---> float,double,decimal
long w = 8647;
float l = w;
double r = w;
decimal s = w;
//float ----> double,decimal
float t = 4578;
double j = t;

//explicit 
decimal u = (decimal)t;


//numberic , char ,boolean ---> sting

byte pp = 10;
string pt = pp + "";
bool f8 = true;
string fr = f8+"";
string fre = f8.ToString();

//double ----> decimal

double k = 338589.5566128;
decimal i = (decimal)k;

string hi = "150";
//using system 
byte by = Convert.ToByte(hi);
byte bh = byte.Parse(hi);
int llo = Convert.ToInt32(hi);


short nn;
Int16.TryParse(hi, out nn);
Console.WriteLine(nn);
int hh;
Int32.TryParse(hi, out hh);