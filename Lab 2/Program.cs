Sum();
Clear();
Multiply();
Clear();
Values();
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

// part 3 - prints size of data types in bytes, min value, and max value
static void Values()
{
    Console.WriteLine("size of int(bytes): " + sizeof(int) + " min value of int: " + int.MinValue + " max value of int: " + int.MaxValue);
    Console.WriteLine("size of sbyte(bytes): " + sizeof(sbyte) + " min value of sbyte: " + sbyte.MinValue + " max value of sbyte: " + sbyte.MaxValue);
    Console.WriteLine("size of byte(bytes): " + sizeof(byte) + " min value of byte: " + byte.MinValue + " max value of byte: " + byte.MaxValue);
    Console.WriteLine("size of short(bytes): " + sizeof(short) + " min value of short: " + short.MinValue + " max value of short: " + short.MaxValue);
    Console.WriteLine("size of ushort(bytes): " + sizeof(ushort) + " min value of ushort: " + ushort.MinValue + " max value of ushort: " + ushort.MaxValue);
    Console.WriteLine("size of uint(bytes): " + sizeof(uint) + " min value of uint: " + uint.MinValue + " max value of uint: " + uint.MaxValue);
    Console.WriteLine("size of long(bytes): " + sizeof(long) + " min value of long: " + long.MinValue + " max value of long: " + long.MaxValue);
    Console.WriteLine("size of ulong(bytes): " + sizeof(ulong) + " min value of ulong: " + ulong.MinValue + " max value of ulong: " + int.MaxValue);
    Console.WriteLine("size of float(bytes): " + sizeof(float) + " min value of float: " + float.MinValue + " max value of float: " + float.MaxValue);
    Console.WriteLine("size of double(bytes): " + sizeof(double) + " min value of double: " + double.MinValue + " max value of double: " + double.MaxValue);
    Console.WriteLine("size of decimal(bytes): " + sizeof(decimal) + " min value of decimal: " + decimal.MinValue + " max value of decimal: " + decimal.MaxValue);
}

static void Clear()
{
    Console.WriteLine("Press a key to move on...");
    Console.ReadLine();
    Console.Clear();
}