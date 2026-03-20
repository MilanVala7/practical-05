namespace ExceptionHandling;
class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        for (int i = 0; i <= 5; i++)
        {
            try
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
        }
    }
}