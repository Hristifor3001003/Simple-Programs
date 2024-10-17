using System.Numerics;
using System.Text;

namespace String_To_Integer__atoi_
{
    internal class Program
    {
        const int min = -2_147_483_648;
        const int max = 2_147_483_647;

        public static int decodeChar(char c)
        {
            switch(c)
            {
                case '0':
                    return 0;
                    break;
                case '1':
                    return 1;
                    break;
                case '2':
                    return 2;
                    break;
                case '3':
                    return 3;
                    break;
                case '4':
                    return 4;
                    break;
                case '5':
                    return 5;
                    break;
                case '6':
                    return 6;
                    break;
                case '7':
                    return 7;
                    break;
                case '8':
                    return 8;
                    break;
                case '9':
                    return 9;
                    break;
                default: return -1;
            }
        }

        public static int convertAndRound(StringBuilder str, bool isNegative)
        {

            if(!isNegative)
            {
                if(str.Length > 10) 
                {
                    return max;
                }
                else if(str.Length < 10)
                {
                    int dec = 1;
                    int result = 0;
                    for(int i = str.Length - 1; i >= 0; i--)
                    {
                        result += dec * decodeChar(str[i]);
                        dec *= 10;
                    }

                    return result;
                }
                else
                {
                    BigInteger bi = BigInteger.Parse(str.ToString());
                    BigInteger maxInt = new BigInteger(max);

                    if(bi.CompareTo(maxInt) > 0)
                    {
                        return max;
                    }
                    else
                    {
                        int dec = 1;
                        int result = 0;
                        for (int i = str.Length - 1; i >= 0; i--)
                        {
                            result += dec * decodeChar(str[i]);
                            dec *= 10;
                        }

                        return result;
                    }
                }
            }
            else
            {
                if(str.Length > 10)
                {
                    return min;
                }
                else if(str.Length < 10)
                {
                    int dec = 1;
                    int result = 0;
                    for (int i = str.Length - 1; i >= 0; i--)
                    {
                        result += dec * decodeChar(str[i]);
                        dec *= 10;
                    }

                    return -result;
                }
                else
                {
                    BigInteger bi = BigInteger.Parse("-" + str.ToString());
                    BigInteger minInt = new BigInteger(min);

                    if(bi.CompareTo(minInt) < 0)
                    {
                        return min;
                    }
                    else
                    {
                        int dec = 1;
                        int result = 0;
                        for (int i = str.Length - 1; i >= 0; i--)
                        {
                            result += dec * decodeChar(str[i]);
                            dec *= 10;
                        }

                        return -result;
                    }
                }
            }
        }

        public static int myAtoi(string s)
        {
            if(s.Length == 0)
            {
                return 0;
            }

            int i = 0;
            while(i < s.Length && s[i] == ' ')
            {
                i++;
            }

            if(i == s.Length)
            {
                return 0;
            }

            if (s[i] == '-')
            {
                i++;
                
                StringBuilder resultString = new StringBuilder("");

                if(i == s.Length)
                {
                    return 0;
                }

                while(i < s.Length && char.IsDigit(s[i]) && s[i] == '0')
                {
                    i++;
                }

                if( i == s.Length)
                {
                    return 0;
                }

                while(i < s.Length && char.IsDigit(s[i]))
                {
                    resultString.Append(s[i]);
                    i++;
                }

                return convertAndRound(resultString, true);
            }
            else if (s[i] == '+')
            {
                i++;

                StringBuilder resultString = new StringBuilder("");

                if (i == s.Length)
                {
                    return 0;
                }

                while (i < s.Length && char.IsDigit(s[i]) && s[i] == '0')
                {
                    i++;
                }

                if (i == s.Length)
                {
                    return 0;
                }

                while (i < s.Length && char.IsDigit(s[i]))
                {
                    resultString.Append(s[i]);
                    i++;
                }

                return convertAndRound(resultString, false);
            }
            else
            {
                StringBuilder resultString = new StringBuilder("");

                if (i == s.Length)
                {
                    return 0;
                }

                while (i < s.Length && char.IsDigit(s[i]) && s[i] == '0')
                {
                    i++;
                }

                if (i == s.Length)
                {
                    return 0;
                }

                while (i < s.Length && char.IsDigit(s[i]))
                {
                    resultString.Append(s[i]);
                    i++;
                }

                return convertAndRound(resultString, false);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("42 -> " + myAtoi("42"));
            Console.WriteLine("-42 -> " + myAtoi("-042"));
            Console.WriteLine("1337 -> " + myAtoi("1337c0d3"));
            Console.WriteLine("0 -> " + myAtoi("0-1"));
            Console.WriteLine("1 -> " + myAtoi("1"));
            Console.WriteLine("1 -> " + myAtoi("+1"));
            Console.WriteLine("-2147483647 -> " + myAtoi("-2147483647"));
            Console.WriteLine("-2147483648 -> " + myAtoi("-2147483648"));
            Console.WriteLine("-2147483648 -> " + myAtoi("-2147483649"));
            Console.WriteLine("2147483647 -> " + myAtoi("2147483647"));
            Console.WriteLine("2147483647 -> " + myAtoi("2147483648"));
        }
    }
}
