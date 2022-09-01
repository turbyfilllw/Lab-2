Sum();
Clear();
Multiply();
Clear();

// part 1 - adds 2 numbers
static void Sum()
{
    int num1, num2;
    Console.Write("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
}
// part 2 - multiplies a number by its multiplication table
static void Multiply()
{
    Console.Write("Enter a number to multiply: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.Write("How many times do you want to multiply?: ");
    int maxNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < maxNumber + 1; i++)
    {
        Console.WriteLine($"{num} * {i} = {num * i}");
    }
}

static void Clear()
{
    Console.WriteLine("Press a key to move on...");
    Console.ReadLine();
    Console.Clear();
}