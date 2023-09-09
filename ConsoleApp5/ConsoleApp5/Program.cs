//int a, b, c, d,result ;
//a = 5;b = 3;
//result = AddNumbers(a, b);

//c = 15;
//d = 100;
//result = AddNumbers(a, b);


//Console.WriteLine($"{a} + {b} = {result}");
//static int AddNumbers(int x ,int y)
//{
//    int result = x + y;
//    return result;
//}

//string firstEmployee, SecondEmployee;
//firstEmployee = "Ali";
//SecondEmployee = "Ayman";

//// pass by value 

//Console.WriteLine($"Inside Main Method {firstEmployee} ,{SecondEmployee}");
//ChangeNames(firstEmployee, SecondEmployee);
//Console.WriteLine($"Inside Main Method After Calling {firstEmployee} ,{SecondEmployee}");

//Console.WriteLine("***********************");
//static void ChangeNames(string first, string second)
//{
//    first = "Esraa";
//    second = "Nariman";
//    Console.WriteLine($"Inside ChangeName Method {first} ,{second}");
//}

////Pass by Reference

//Console.WriteLine($"Inside Main Method {firstEmployee} ,{SecondEmployee}");
//ChangeName( ref firstEmployee,ref SecondEmployee);
//Console.WriteLine($"Inside Main Method After Calling  {firstEmployee} ,{SecondEmployee}");

//static void ChangeName( ref string first, ref string second)
//{
//    first = "Esraa";
//    second = "Nariman";
//    Console.WriteLine($"Inside ChangeName Method {first} ,{second}");
//}


//Console.WriteLine("***********************************");

////Pass by Reference
//int total = 0;
//total = 75;
//Console.WriteLine(total);
//Calculate(ref total);
//Console.WriteLine(total);

//static int Calculate (ref int total)
//{
//    total += 25;
//    Console.WriteLine(total);
//    return total;
//}

//DisplayPlyerStats(7, "Cras", 100, "Barazil", "ll");
//DisplayPlyerStats(8, "misii", 10);

//DisplayPlyerStats(country:"Jorddan" ,no:10 ,name:"Hi",goal:9,club:"hi");

//static void DisplayPlyerStats(int no ,string name ,int goal ,string country = "" ,string club = "")
//{
//    Console.WriteLine(no+"\n"+name+"\n"+goal+"\n"+country+"\n"+club);
//}


//Console.WriteLine("Defualt Constructor");

//Enemy zombie = new Enemy();
//Console.WriteLine(zombie.Health);

//class Enemy
//{
//    public int Id { get; set; }
//    public string EnemyName { get; set; }
//    public double Health { get; set; }
//    public Enemy()
//    {
//        Console.WriteLine("New enemy is created");
//        Health = 90;
//    }
//}

//Console.WriteLine("Parameterized Constructor");

//Enemy zombie = new Enemy("Gaint" ,105);
//Console.WriteLine(zombie.EnemyName);
//Console.WriteLine(zombie.Health);
//Console.WriteLine(zombie.Id);



//class Enemy
//{
//    public int Id { get; set; }
//    public string EnemyName { get; set; }
//    public double Health { get; set; }

//    public Enemy(string enemyName, double health)
//    {
//        Console.WriteLine("new Enemy is created from parameterized constructor");
//        EnemyName = enemyName;
//        Health = health;
//    }
//}


//Console.WriteLine("Copy Constructor");

//Enemy zombie = new Enemy("Gaint Zombie", 100);
//Enemy enemy = new Enemy(zombie);

//Console.WriteLine(enemy.EnemyName);
//Console.WriteLine(enemy.Health);



//class Enemy
//{
//    public int Id { get; set; }
//    public string EnemyName { get; set; }
//    public double Health { get; set; }

//    public Enemy(string enemyName, double health)
//    {
//        Console.WriteLine("new Enemy is created from parameterized constructor");
//        EnemyName = enemyName;
//        Health = health;
//    }
//    //Copy Constructor
//    public Enemy(Enemy enemy)
//    {
//        Console.WriteLine("new Enemy is created from copy constructor");

//        Health = enemy.Health;
//        EnemyName = enemy.EnemyName;
//    }
//}


//Console.WriteLine("Private Constructor");

////Counter ctr = new Counter();
////Math math =new Math();
//Counter.currentCount = 70;
//Counter.IncrementCount();
//Console.WriteLine($"New Count : {Counter.currentCount}");


//public class Counter
//{
//    public static int currentCount;

//    private Counter()
//    {

//    }
//    public static int IncrementCount()
//    {

//        return ++currentCount;
//    }

//}


//using System.Drawing;

//Console.WriteLine("Static Constructor");

//Enemy rebot = new Enemy();

//Enemy enemy = new Enemy();

//Enemy zobie = new Enemy();


//class Enemy
//{
//    public int Id { get; set; }
//    public string EnemyName { get; set; }
//    public double Health { get; set; }
//    static int staticCounter = 0;
//    static int instanceCounter = 0;

//    static Enemy()
//    {
//        staticCounter++;
//        Console.WriteLine($"Static Constructor is called {staticCounter}");
//    }
//    public Enemy()
//    {
//        instanceCounter++;
//        Console.WriteLine($"Instance Constructor is called {instanceCounter}");
//    }

//}


//Bank.CreateNewAccount();

//Bank bank = new Bank();
//bank.CreateNewAccountNotStatic();


//class Bank
//{
//    // static method
//    public static void CreateNewAccount()
//    {
//        Console.WriteLine("New account has been created using static method");
//    }
//    //instance method
//    public  void CreateNewAccountNotStatic()
//    {
//        Console.WriteLine("New account has been created using NON static method");
//    }
//}


//string txt = "200";
//string welcome = "Hello and weelcome to my OOP";
//int x = 5;
//Console.WriteLine(x.IsGreaterByNumber(3));
//Console.WriteLine(txt.IsNumber());
//Console.WriteLine(welcome.CountWords());

//static  class ExtensionMethods
//{
//    public static bool IsGreaterByNumber(this int num1 ,int num2)
//    {
//        return num1 > num2;
//    }
//    public static bool IsNumber (this string strings)
//    {
//        return int.TryParse(strings ,out int num);
//    }
//    public static int CountWords(this string strings)
//    {
//        if (!string.IsNullOrEmpty(strings))
//        {
//            string[] words = strings.Split(' ');
//            return words.Length;
//        }else { return 0; }
//    }
//}

//Factorial  5! =1*2*3*4*5

//int num = 5;
//Console.WriteLine("Non recursive way");
//Console.WriteLine(FactoriaNonRecursive(num));
//Console.WriteLine("Recursive way");
//Console.WriteLine(FactorialRecursive(num));
//string path = string.Empty;
//path = @"C:\Users\bayan\OneDrive\Desktop\bayan";
//Console.WriteLine(path);
//DisplayFolder(path, 0);

// Non recursive way 
//static int FactoriaNonRecursive(int number)
//{
//    if (number == 0)
//    {
//        return 1;
//    }

//    int value = 1;
//    for (int i = number ; i > 0; i--)
//    {
//        value *= i;
//        Console.WriteLine(i);
//    }
//    return value;
//}

// Recursive way 

//static int FactorialRecursive(int number)
//{
//    if (number == 0)
//    {
//        return 1;
//    }
//    return number * FactorialRecursive(number - 1);
//}


//static void DisplayFolder (string path ,int indent)
//{
//    foreach(var folder in Directory.GetDirectories(path))
//    {
//        Console.WriteLine($"{new string(' ',indent)} {Path.GetFileName(folder)}");
//        DisplayFolder(folder, indent + 2);
//    }
//}

//Animal animal = new Animal();
//animal.FeedAnimal();

//Bird bird = new Bird();
//Dog dog = new Dog();
//dog.WalkDog();
//dog.FeedAnimal();

//class Bird : Animal
//{
//    public string BirdColor { get; set; }
//    public double Altitude { get; set; } 
//    public void Fly() { }
//}
//class Dog : Animal
//{
//    public string DogBread { get; set; }
//    public string DogIntelligence { get; set; }
//    public int EasyToTrainLevel { get; set; }
//    public void WalkDog() { }

//    public void TrainDog() { }
//}

//class Animal
//{

//    public string AnimalName { get; set; }
//    public DateOnly AnimalBirthDate { get; set; }

//    public void FeedAnimal()
//    {

//    }
//}


//bass class


//Dog dog = new Dog();


//class Animal
//{
//    private string privateVarable;
//    public string publicVariable;
//    protected string protectedVariable;
//    internal string internalVarable;

//    private void TrainAnimalPrivate() { }
//    public void TrainAnimalPublic() { }

//    protected void TrainAnimalProtected() { }

//    internal void TrainAnimalInternal() { }


//}


//class Dog:Animal
//{


//    void FeedDog() { }
//}

//class Cat : Animal
//{
//    void FeedCat() { }
//}


//Shape shape = new Shape();
//shape.Draw();
//Shape shape1 = new Circle();
//shape1.Draw();
//Console.WriteLine("******************************");

//Shape[] shape2 = new Shape[4];
//shape2[0] = new Shape();
//shape2[1] = new Circle();
//shape2[2] = new Tringle();
//shape2[3] = new Line();

//foreach(Shape shap in shape2)
//{
//    shap.Draw();
//}
//class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Base Shape is Created");
//    }
//}

//class Circle : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Circle is created");
//    }
//}

//class Tringle : Shape
//{

//    // new implemention inhertened mehtod
//    public override void Draw()
//    {
//        Console.WriteLine("Tringle is created");
//    }
//}

//class Line : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Line is created");
//    }
//}





//BankAccount account = new BankAccount("Arabic", "Saving", "Amman", "12453", "JOD", 200);

//account.Balance = 600;


//account.Withdraw(100);


//class BankAccount
//{
//    public string BankName { get; set; }

//    public string BranchName { get; set; }
//    public string BranchAddress { get; set; }
//    public string AccountNumber { get; set; }

//    public string AccountCurrency { get; set; }
//    public decimal Balance { get; set; }

//    public BankAccount()
//    {
//        Console.WriteLine("Constructor is called automaticlly");
//    }
//    public BankAccount(string bankname, string branchname, string branchaddress, string accountnumber, string accountcurrency, decimal balance)
//    {
//        BankName = bankname;
//        BranchName = branchname;
//        BranchAddress = branchaddress;
//        AccountNumber = accountnumber;
//        AccountCurrency = accountcurrency;
//        Balance = balance;
//    }
//    public void Withdraw(decimal Amount)
//    {
//        decimal newBalance = Balance - Amount;
//        if (newBalance < 0)
//        {
//            Console.WriteLine("Invalid Transaction");
//        }
//        else
//        {
//            Console.WriteLine($"Withdraw amount is : {Amount}");
//            Console.WriteLine($"Your new balance for {AccountNumber} is {newBalance}");
//        }
//        Console.WriteLine($"Transaction Date {DateTime.Now}");
//    }
//    public void Deposit(decimal Amount) 
//    {
//        decimal newBalance = Balance + Amount;
//        Console.WriteLine($"Deposit amount is : {Amount}");
//        Console.WriteLine($"Your new balance for {AccountNumber} is {newBalance}");
//        Console.WriteLine($"Transaction Date {DateTime.Now}");
//    }

//    public void Transfer() { }
//    public void ChangePassword() { } 

//    public void CreateSubAccount() { }

//    public void PrintStatment() { }

//}


//Person person = new Person();
//person.Firstname = "Test";
//person.LastName = "Test";
//person.Country = "Country";

//class Person
//{
//    // variable 
//    string firstname;
//    string lastname;
//    DateOnly birthDate;
//    string country;


//    public string Firstname
//    {
//        get { return firstname; }
//        set { firstname = value; }
//    }

//    public string LastName
//    {
//        get { return lastname; }
//        set { lastname = value; }
//    }

//    public DateOnly BirthDate
//    {
//        get { return birthDate; }
//        set { birthDate = value; }
//    }

//    public string Country
//    {
//        get { return country; }
//        set { country = value; }
//    }
//}

//Line line = new Line();
//line.SayHallo();
//line.Draw();

////Shape Shape = new Shape();

//abstract class Shape
//{
//    abstract public void Draw();
//    public void SayHallo()
//    {
//        Console.WriteLine("Hello from the abstract class");
//    }
//}

//class Line : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Hello from the abstract class");
//    }
//}


//sealed class Animal
//{
//    public string Name { get; set; }
//}

//class Dog : Animal
//{
//    public string DogBread { get; set; }
//}

//Console.WriteLine(Company.CompanyName);

/*
 *1- only static members allowed
 *2- cannot be instantiated 
 *3- is sealed by defult
 *4- cannot contain instance constructor
 */


//class Employee : Company { }
//static class Company
//{
//    //public Company(string companyName)
//    //{

//    //}
//    static public string CompanyName = "Code Company";
//    static public string CompanyLocation = "Amman";

//    static public int GetTotalEmplooyees()
//    {
//        return 20;
//    } 
//}


//Console.WriteLine(TemeratureConverter.CelsiusToFerhrenheit(20));
//Console.WriteLine(TemeratureConverter.FerhrenheitToCelsius(86));



//public static class TemeratureConverter
//{
//    public static double CelsiusToFerhrenheit(double TemeratureCelsius)
//    {
//        return (TemeratureCelsius * 9 / 5) + 32;
//    }
//    public static double FerhrenheitToCelsius (double TemeratureFerhrenheit)
//    {
//        return (TemeratureFerhrenheit - 32) * 5 / 9;
//    }
//}


//using ConsoleApp5;

//Employee employee = new Employee();

//employee.EmployeeNumber = 1;
//employee.EmployeeName = "Bayan";
//Console.WriteLine($"{employee.EmployeeNumber} -{employee.EmployeeName} -{employee.CalculateSalary()}");

/*
 * 1 . The source file name can be different , but each partial classes name must be the same
 * 
 * 2. All the partial class defintions must be in the same namespace and assembly.
 * 
 * 3. If any part is declared abstract ,sealed or base type then the whole class is declared of the same type
 * 
 * 4. Must have the same access modifiers like public or private
 * 
 * 5. Different parts can have different base types so the final class will inherit all the base types
 * 
 * 6. Must contain the partial keyword 
 * 
 * 7. The Partial Modifier can only appear immediatly before the keyword class,struct , or interface.
 */
//Animal animal = new Animal();
//Animal.Dog dog = new Animal.Dog();
//Animal.Cat cat = new Animal.Cat();

////outer class
//class Animal
//{
//    public Animal()
//    {
//        Dog.DataDog();
//    }

//    public string AnimalName { get; set; }
//    public string LifeSpan { get; set; }
//    //inner class 
//    public class Dog
//    {
//        public string DogBread { get; set; }
//        public string Intelligence { get; set; }

//        public  static void DataDog() { }
//    }

//    public class Cat
//    {
//        public string Coat { get; set; }

//        public string[] Colors { get; set; }
//    }
//

//using bank;
//using parentnamespace;
//using parentnamespace.nestednamespace;
//using pn = parentnamespace;

//bankaccount bankaccount = new bankaccount();
//client.person person = new client.person();

//person.createbankaccont();

//parentnamespececlass parent = new parentnamespececlass();
//nestednamespececlass nested = new nestednamespececlass();

//pn.parentnamespececlass parentnamespececlass = new pn.parentnamespececlass();

//employee employee = new employee();
//employee emp;


//public struct employee
//{
//    public string employeename { get; set; }
//    public string employeejob { get; set; }

//    public decimal salary { get; set; }

//    public employee() { }

//    //parameterized constructor 
//    public employee(string employeename, decimal salary)
//    {
//        employeename = employeename;
//        salary = salary;
//    }

//    public void displaytimesheet()
//    {
//        Console.WriteLine("timesheet method in struct");
//    }

//}





















