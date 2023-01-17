using Exclusions;

try
{
    while (true)
    {
        Console.WriteLine("1. Server error");
        Console.WriteLine("2. Division by zero");
        Console.WriteLine("3. Array boundary");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 0:
                int zero = 0;
                int result = 1 / zero;
                break;

            case 1:
                throw new MException("Not found", 404);

            case 2:
                var array = Array.Empty<string>();
                var element = array[1];
                break;
        }
    }
}
catch (MException e)
{
    Console.WriteLine($"{e.Message} {e.ErrorCode}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Division by zero");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Going beyond the boundaries of the array");
}