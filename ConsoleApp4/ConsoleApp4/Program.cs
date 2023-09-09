
//using System.Text;

//var fileName = @"C:\Users\bayan\OneDrive\Documents\first.txt";
////using FileStream fs = File.OpenRead(fileName);

////byte[] buffer = new byte[1024];

////int x;
////while ((x = fs.Read(buffer, 0, buffer.Length)) > 0)
////{
////    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, x));
////}



////using FileStream fs2 = File.OpenRead(fileName);
//string [] fs = File.ReadAllLines(fileName);
////using var sr = new StreamReader(fs2);
//List<int> count = new List<int>();
//int x;


//for (int i = 0; i < fs.Length; i++)
//{
//    int.TryParse(fs[i], out x);

//    Console.WriteLine(x);

//    count.Add(x);
//}
//Console.WriteLine("the sum is : {0} and the avarege number is : {1}", count.Sum(), count.Sum() / count.Count);

//while (sr.Peek() > 6)
//{
//    Console.WriteLine(sr.ReadLine());

//}





//using ConsoleApp4;

//Person p1 = new Person();

//p1.FirstName = Console.ReadLine();
//p1.LastName = Console.ReadLine();
//p1.Age = Convert.ToInt32(Console.ReadLine());



//Console.WriteLine(p1.FullName);

using System.Collections.Generic;

string path_text_file = @"C:\Users\bayan\OneDrive\Documents\C#\Courses.txt";
string path_folder = @"C:\Users\bayan\OneDrive\Documents\C#";

if (!Directory.Exists(path_folder))
{
    try
    {
        CreateFolder(path_text_file);
    }
    catch (DirectoryNotFoundException error)
    {
        Directory.CreateDirectory(path_folder);
        CreateFolder(path_text_file);
    }
    catch (Exception error) { }
}

static void CreateFolder(string path)
{
    if (!File.Exists(path))
    {
        using FileStream fs = File.Create(path);
        if (fs.CanWrite)
        {

            using var sr = new StreamWriter(fs);

            sr.WriteLine("C#\nJava\nPython\nQA");

            Console.WriteLine("done");
        }
        else
        {
            Console.WriteLine("File Is not Editable");
        }
    }
}


static List<string> ReadFromFile(string path)
{
    if (!File.Exists(path))
    {
        using var sr = new StreamReader(path);



    }
}



