namespace Determine_Color_of_a_Chessboard_Square
{
    internal class Program
    {
        public static int decodeChar(char c)
        {
            switch (c)
            {
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3;
                case 'd':
                    return 4;
                case 'e':
                    return 5;
                case 'f':
                    return 6;
                case 'g':
                    return 7;
                default:
                    return 8;
            }
        }

        public static int decodeDigit(char c)
        {
            return int.Parse(c.ToString());
        }
        public static bool SquareIsWhite(string coordinates)
        {
            if ((decodeChar(coordinates[0]) + decodeDigit(coordinates[1])) % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            for(char i = 'h'; i >= 'a'; i--)
            {
                for(char j = '1'; j <= '8'; j++)
                {
                    bool b = SquareIsWhite(i.ToString() + j.ToString());

                    if(b)
                    {
                        Console.Write("w" + " "); // w for white
                    }
                    else
                    {
                        Console.Write("b" + " "); // b for black
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
