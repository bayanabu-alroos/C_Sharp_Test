/*
 type classes
1. 
 */

//string[] strings = new string[3];
//for (int i = 0; i < strings.Length; i++)
//{
//    Console.Write("Please enter word");
//    strings[i] = Console.ReadLine();
//    Console.WriteLine("value array :", strings[i]);
//}


//string name;
//name = "Bayan Abu Alroos";
//Console.WriteLine("ToLower : {0}", name.ToLower());
//Console.WriteLine("ToUpper : {0}", name.ToUpper());
//Console.WriteLine("Trim : {0}", name.Trim());
//Console.WriteLine("TrimStart : {0}", name.TrimStart());
//Console.WriteLine("TrimEnd : {0}", name.TrimEnd());
//Console.WriteLine("Length : {0}", name.Length);
//Console.WriteLine(name[0]);
//Console.WriteLine("ToCharArray : {0}", name.ToCharArray());
//Console.WriteLine("ToCharArray : {0}", name[5]);
//Console.WriteLine("Contains : {0}", name.Contains("Abu"));
//Console.WriteLine("StartsWith : {0}", name.StartsWith("Abu"));
//Console.WriteLine("StartsWith : {0}", name.EndsWith("oos"));
//Console.WriteLine("Equals : {0}", name.Equals("Bayan", StringComparison.OrdinalIgnoreCase));
//Console.WriteLine("Replace : {0}", name.Replace(' ', '_'));
//Console.WriteLine("IndexOf : {0}", name.IndexOf("A"));
//Console.WriteLine("LastIndexOf : {0}", name.LastIndexOf("A"));
//Console.WriteLine("Substring : {0}", name.Substring(2));
//Console.WriteLine("Substring : {0}", name.Substring(2,2));//اقتطاع 







/*اخراج احرف العلة a,i,e,u,o*/

//Console.Write("Enter a Sentence : ");
//string sentence = Console.ReadLine().ToLower();
//int[] arr = new int[sentence.Length];

//for (int i = 0; i < sentence.Length; i++)
//{
//    char ch = sentence[i];
//    Console.Write(ch);
//    // Check if ith character is a vowel
//    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//    {
//        Console.WriteLine("{0} in index :{1}",ch, i);
//    }
//}


string[] name = new string[5];
int sum = 0;
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine("Enter a Name : ");
    name[i] = Console.ReadLine().ToLower();
    for (int j = 0; j < name[i].Length; j++)
    {
        char chars = name[i][j];
        if (chars ==  'a' || chars == 'e' || chars == 'i' || chars == 'o' || chars == 'u')
        {
            sum++;
            Console.WriteLine("{0} in index :{1}",chars ,j);
        }
    }
}
Console.WriteLine("Total vowels in array : {0}", sum);

//string[] Name = new string[5];

//for (int i = 0; i <= Name.Length - 1; i++)
//{
//    Console.WriteLine($"Enter pleas Name ({i})");
//    Name[i] = Console.ReadLine();
//}
//Console.WriteLine();
//foreach (var item in Name)
//{

//    Console.Write($"{item},");

//}
//Console.WriteLine();


//int counter = 0;

//foreach (string item in Name)
//{
//    string text = item.ToLower();
//    for (int i = 0; i < text.Length; i++)
//    {

//        switch (text[i])
//        {
//            case 'a':
//            case 'o':
//            case 'u':
//            case 'i':
//            case 'e':
//                ++counter;
//                break;
//        }

//    }



//}
//Console.WriteLine();
//Console.WriteLine($"Counter letters Vowels : {counter}");
//Console.WriteLine();



