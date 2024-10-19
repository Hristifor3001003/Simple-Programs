namespace Count_Total_Number_Of_Colored_Cells
{
    internal class Program
    {

        public static long ColoredCells(int n)
        {

            return (2 * (long)n * (n - 1) + 1);
        }
        static void Main(string[] args)
        {
            for(int n = 1; n <= 50; n++)
            {
                Console.WriteLine("For n = " + n + ", we have: " + ColoredCells(n) + " colored cells.");
            }
        }
    }
}
