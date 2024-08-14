namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! Enter the height of the triangle: ");
            string userHeight = Console.ReadLine();
            int height = int.Parse(userHeight);
            for (int row = 0; row < height; row++)
            {

                for (int col = 0; col <= row; col++)
                {
                    Console.Write(row + 1);
                }
                Console.WriteLine();
            }

        }  
    }
 }
