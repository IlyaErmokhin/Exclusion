using Exceptions;

namespace MyException
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Division by zero");
            Console.WriteLine("2. Server error");
            Console.WriteLine("3. Array boundary");
            int choice = int.Parse(Console.ReadLine());
            try
            {
                switch (choice)
                {
                    case 1:
                        int zero = 0;
                        int result = 1 / zero;
                        break;

                    case 2:
                        throw new MException("Not found", 404);

                    case 3:
                        var array = Array.Empty<string>();
                        var element = array[1];
                        break;
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
        }
    }
}
