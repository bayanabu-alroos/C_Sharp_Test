int x;
int.TryParse(Console.ReadLine(), out x);


try
{
    if (x == 0)
    {
        throw new Exception("Please Try Another Number");
    }
    double[] doubles = new double[x];
    double avarage;
    double sum = 0;
    for (int i = 0; i < doubles.Length; i++)
    {
        double.TryParse(Console.ReadLine(), out doubles[i]);
        if (Double.IsNormal(doubles[i]))
        {
            throw new Exception("Please Try Another double number");
        }
        sum += doubles[i];

    }
    avarage = sum / doubles.Length;
    if (Double.IsNaN(avarage))
    {
        throw new Exception("Please Try Another Number");
    }
    else
    {
        Console.WriteLine(avarage);
    }
}

catch (ArithmeticException error)
{
    Console.WriteLine(error.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
