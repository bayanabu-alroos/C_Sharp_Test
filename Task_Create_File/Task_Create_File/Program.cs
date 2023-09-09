using System.Collections.Generic;
using System.IO;

string fileNamesPath = @"C:\Users\bayan\OneDrive\Desktop\Marks\Names.txt";
string fileMarkPath = @"C:\Users\bayan\OneDrive\Desktop\Marks\Marks.txt";

string folderPath = @"C:\Users\bayan\OneDrive\Desktop\Marks";

if (!File.Exists(folderPath))
{
    if (!Directory.Exists(folderPath))
    {
        try
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Create Folder Markes in desktop");
            CreateNamesFile(fileNamesPath);
            CreateMarkesFile(fileMarkPath);

            Console.WriteLine(ReadFileToDictionary(fileNamesPath,fileMarkPath));

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}




static void CreateNamesFile (string path)
{
    if (!File.Exists(path))
    {
        using FileStream fileStream = File.Create(path);
        if (fileStream.CanWrite)
        {
            using var stream = new StreamWriter(fileStream);
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter Name :");
                string name =Console.ReadLine();
                stream.WriteLine($"{name}");
            }
            Console.WriteLine("File is done Create All name");
        }
        else
        {
            Console.WriteLine("File is not Editable");
        }
    }
    else
    {
        Console.WriteLine("The File Name already exists.");
    }
}

static void CreateMarkesFile(string path)
{
    if (!File.Exists(path))
    {
        using FileStream fileStream = File.Create(path);
        if (fileStream.CanWrite)
        {
            using var stream = new StreamWriter(fileStream);
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter Marks :");
                int mark = int.Parse(Console.ReadLine());
                stream.WriteLine($"{mark}");
            }
            Console.WriteLine("File is done Create All Mark");
        }
        else
        {
            Console.WriteLine("File is not Editable");
        }
    }
    else
    {
        Console.WriteLine("The File Marks already exists.");
    }
}


static Dictionary<string, string> ReadFileToDictionary(string pathnName ,string pathMark)
{
    Dictionary<string, string> result = new Dictionary<string, string>();
    if (File.Exists(pathnName) && File.Exists(pathMark))
    {
        try
        {
            using FileStream fileStreamName = File.OpenRead(pathnName);
            using FileStream fileStramMark = File.OpenRead(pathMark);
            using var streamName = new StreamReader(fileStreamName);
            using var streamMark = new StreamReader(fileStramMark);

            while (streamName.Peek() > 0 && streamMark.Peek() > 0)
            {
                result.Add(streamName.ReadLine(), streamMark.ReadLine());
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        Console.WriteLine("File Dose not Exist");
    }
    return result;
}

