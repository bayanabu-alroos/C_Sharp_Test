//Queue <string> students = new Queue<string> ();

//students.Enqueue("Bayan");
//students.Enqueue("Bayan 1");
//students.Enqueue("Bayan 2");
//students.Enqueue("Bayan 3");
//students.Enqueue("Bayan 4");


//for (int i = 0; i < 5; i++)
//{
//    Console.Write("please enter a name : ");
//    students.Enqueue(Console.ReadLine());
//}

//Console.WriteLine(students.Peek());
//Console.WriteLine(students.Dequeue());
//Console.WriteLine(students.Peek());

//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}
//Console.WriteLine(students.Peek());


//for (int i = 0;i < students.Count; i++)
//{
//    Console.WriteLine(students.ElementAt(i));
//}


using System.Collections;

//Stack<string> students = new Stack<string>();
//students.Push("First");
//students.Push("Second");
//students.Push("Four");
//students.Push("Five");
//students.Push("Six");

//Console.WriteLine(students.Peek());
//Console.WriteLine(students.Pop());
//Console.WriteLine(students.Peek());

Queue<string> queue = new Queue<string>();
Stack<string> stack = new Stack<string>();
queue.Enqueue("20");
queue.Enqueue("18");
queue.Enqueue("17");
queue.Enqueue("7");
queue.Enqueue("9");
queue.Enqueue("11");

foreach (string i in queue)
{
    Console.WriteLine(i);
}
int x = queue.Count;

for (int i = 0; i < x; i++)
{
    stack.Push(queue.Dequeue());
}

foreach (string i in stack)
{
    Console.WriteLine(i);
}


Queue<string> q = new Queue<string>();  
Stack<string> s = new Stack<string>();
for (int i = 0; i <= 20; i++)
{
    q.Enqueue(Console.ReadLine());
}
int v = q.Count;
for(int i = 0;i <= v; i++)
{
    s.Push(q.Dequeue());
}
foreach (string i in s)
{
    Console.WriteLine(i);
}

List<float> makrs = new List<float>();
Console.Write("Please enter number maker input ");
int g;
float sum =0;
int.TryParse(Console.ReadLine(), out g);
for (float i = 0;i <= g; i++)
{
    Console.Write("Please enter mark ");
    i = float.Parse(Console.ReadLine());
    makrs.Add(i);
    sum += i;
}
float avg = sum/ makrs.Count;
float min = makrs[0];
for (int i = 0; i <= g; i++)
{
    if (makrs[i] < min)
    {
        min = makrs[i];
    }
}
float max = makrs[0];
for (int i = 0; i <= g; i++)
{
    if (makrs[i] > max)
    {
        max = makrs[i];
    }
}
Console.WriteLine("the minmum mark is : {0} , maxmum mark is : {1} and avarage marks is {2}",min,max,avg);  



//block of code 
/*
 * return type 
 * 1- void -- Console.WriteLine ازا مابدي ارجع استخدمه print value ,print name ,close program
 * 2- Return type -->  wait for value to reuse it (sting , int ,bool,list<int>,queue<int>)
 * 
 * naming confingtion 
 * 
 * 1- camel case (variable): myName ,
 * 2- pascal case (Methods , classes ,property) : Dequeue, Count
 * 3- incase (Interface) : IStudent ,IClass 
 * 
 * 
 * list of parameter 
 * 
 * 1- dirction input ,output parameter for example tryparse 
 * 2- optional paramerter for example subString (int x => required , int ? y => optional ,int z = 16 => Default )
 * 3- 
 * 
 */


