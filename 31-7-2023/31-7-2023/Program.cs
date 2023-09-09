using System.Security.Principal;

//List<string> name = new List<string>();

//name.Add("B");
//name.Add("C");
//name.Add("D");
//Console.WriteLine(name[1]);
////name.Clear();
//name.ElementAt(0);// for example = name[1]
//name.Contains("B");// search 
//name.AddRange(new List<string> () {"n","h","k"});
//name.InsertRange(0, new List<string>() { "n", "h", "k" });
//name.Sort();
//name.Remove("B");
//name.RemoveAt(0);
//name.RemoveRange(0, 1);
//name.RemoveAll(name.Contains);
//name.RemoveAll(x => x.Contains("A"));
//name.Count();


//List<int> phone = new List<int>();
//phone.Add(0786459321);
//phone.Add(0786549321);
//phone.Add(0775641236);
//phone.Add(0796201569);
//phone.Add(0775641236);
//phone.Add(0775641236);
//phone.Add(0795648325);
//phone.Add(0799642516);
//phone.Add(0775641236);
//phone.Add(0778645321);
//Console.WriteLine(phone.FindAll);


//Dictionary<string ,string> properties = new Dictionary<string ,string>();
//Dictionary <string,List<string>> Customerlines = new Dictionary <string,List<string>>();
//Customerlines.Add("Bay",new List<string> { "07964251686" ,"078963456563" ,"99599526666" });
//Customerlines.Add("Bayan", new List<string>() { "07964251686" });
//Customerlines.Remove("Bay");
//Customerlines.Clear();
//Customerlines.ContainsKey("Bay");
//Console.WriteLine(Customerlines["Bay"]);
//Console.WriteLine(Customerlines.ElementAt(1).Key);


//ادخل اسماء خمسة طلاب و array علامات الطلاب ونطلع الافرج 

Dictionary<string, float[]> Marks = new Dictionary<string,float[]>();
for (int j = 0;  j <= 5; j++) { 
    Console.Write("please enter name : ");
    string name = Console.ReadLine();
    float sum = 0;
    float[] marks = new float[5];
    for (int i = 0; i < marks.Length; i++)
    {
        Console.Write("Input {0} mark:", i);
        float.TryParse(Console.ReadLine(), out marks[i]);
        sum += marks[i];
    }
    float avarage = sum / marks.Length;
    Marks.Add(name , marks);
    Console.WriteLine("{0} :the sum marks is {1} the avarage marks is  {2} ", Marks.ElementAt(j).Key, sum,avarage);
}
















