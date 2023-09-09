/*
 These tasks, when awaited or when the Result property is accessed (after ensuring they are completed),
  provide the return value of the asynchronous operation.
 */

using System.Threading;

Task<int> task = ReturnIntAsync();
task.Wait();  // Wait for the task to complete
Console.WriteLine($"Returned int: {task.Result}");

Task<string> stringTask = ReturnStringAsync();
stringTask.Wait();  // Wait for the task to complete
Console.WriteLine($"Returned string: {stringTask.Result}");

static async Task<int> ReturnIntAsync()
{
    await Task.Delay(1000);  // Simulate some async operation
    return 42;
}

static async Task<string> ReturnStringAsync()
{
    await Task.Delay(1000);  // Simulate some async operation
    return "Hello, World!";
}

//Thread thread = new Thread(DoWork);
//DoWork();
//static void DoWork()
//{
//    string result = "Hello from the thread!";
//    Console.WriteLine(result);
//}