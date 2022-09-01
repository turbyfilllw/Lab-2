//problem 1 
Sum();
Clear();
static void Sum()
{
    int num1, num2;
    Console.Write("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
}
static void Clear()
{
    Console.WriteLine("Press a key to move on...");
    Console.ReadLine();
    Console.Clear();
}