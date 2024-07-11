namespace ExcsptionalHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[5];

            Console.WriteLine("Enter the array elements");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("Entered list of Array is:");

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception Indexoutofrange)
            {
                Console.WriteLine("out of range");
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
