using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExample15
{
    enum Level
    {
        High,
        Mid,
        Low
    }

    class Program
    {
        static void Main(string[] args)
        {
            UseSwitchCase();
        }

        static void UseSwitchEnum()
        {
            Level myLevel = Level.High;
            switch (myLevel)
            {
                case Level.High:
                    break;
                case Level.Mid:
                    break;
                case Level.Low:
                    break;
                default:
                    break;
            }
        }

        static void UseSwitchCase()
        {
            int score = 39;
            switch (score / 10)
            {
                case 10:
                    // 101 / 10 == 10, 逻辑错误。
                    if (score == 100)
                    {
                        goto case 8;
                    } else
                    {
                        goto default;
                    }
                case 8:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("C");
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        
    }

    class Caculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            bool hasError = false;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Your argument[s] are null.");
                hasError = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Your argument[s] are not number.");
                hasError = true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Out of range!");
                hasError = true;
            }
            finally
            {
                if (hasError)
                {
                    Console.WriteLine("Execution has error");
                } 
                else
                {
                    Console.WriteLine("Done");
                }
            }
            return a + b;
        }
    }
}
