using System;

namespace Lecture2HomeWork
{
    class Program
    {
        class Lecture2
        {

            static int IfStatementTask(int a, int b)
            {
                
                int result = 0;
                if (a > b)
                {
                    result = a + b;
                }


                if (a == b)
                {
                    result = a * b;
                }


                if (a < b)
                {
                    result = a - b;
                }

                Console.Write("Result is: ");
                return result;

            }

            static int QuarterIdentifier(int x, int y)
            {

                int quarter = 0;

                if( y == 0 && x == 0)
                {
                    Console.Write("Zero Coordinates: ");
                    return quarter;
                }

                if(y > 0)
                {
                    if (x > 0)
                        quarter = 1;
                    else
                        quarter = 2;
                }
                else
                {
                    if (x < 0)
                        quarter = 3;
                    else
                        quarter = 4;
                }


                Console.Write("Quarter: ");
                return quarter;
            }

            static (int, int, int) AscendingOrder(int a, int b, int c)
            {
                int smallestNumber = 0;
                int middleNumber = 0;
                int highestNumber = 0;

                if (a == b && a == c && b == c)
                {
                    return (a, b, c);
                }

                if (a == b || a == c || b == c)
                {
                    if(a == b && a > c)
                    {
                        smallestNumber = c;
                        middleNumber = a;
                        highestNumber = b;
                    }
                    if (a == b && a < c)
                    {
                        smallestNumber = b;
                        middleNumber = a;
                        highestNumber = c;
                    }

                    if(a == c && a > b)
                    {
                        smallestNumber = b;
                        middleNumber = a;
                        highestNumber = c;
                    }
                    if (a == c && a < b)
                    {
                        smallestNumber = c;
                        middleNumber = a;
                        highestNumber = b;
                    }
                }

                if (a < b && a < c)
                { 
                    smallestNumber = a;
                    if(b < c)
                    {
                        middleNumber = b;
                        highestNumber = c;
                    }
                    else
                    {
                        middleNumber = c;
                        highestNumber = b;
                    }
                }

                if (a < b && a > c)
                {
                    middleNumber = a;
                    if (b < c)
                    {
                        smallestNumber = b;
                        highestNumber = c;
                    }
                    else
                    {
                        smallestNumber = c;
                        highestNumber = b;
                    }

                }

                if (a > b && a > c)
                {
                    highestNumber = a;
                    if (b < c)
                    {
                        smallestNumber = b;
                        middleNumber = c;
                    }
                    else
                    {
                        smallestNumber = c;
                        middleNumber = b;
                    }
                }

                if (a > b && a < c)
                {
                    middleNumber = a;
                    if (b < c)
                    {
                        smallestNumber = b;
                        highestNumber = c;
                    }
                    else
                    {
                        smallestNumber = c;
                        highestNumber = b;
                    }
                }



                return (smallestNumber, middleNumber, highestNumber);

                
            }

            static (int,int) QuadraticEquation(int a, int b, int c)
            {
                int d = 0;
                int x1 = 0;
                int x2 = 0;
                int root = 1;
                int i = 0;


                d = b*2 - 4 * a * c;
                
                while(true)
                {
                    i++;
                    root = (d / root + root) / 2;
                    if(i == d + 1)
                    {
                        break;
                    }
                }

                if (d > 0 || d == 0)
                {
                    x1 = (-b + root) / (2 * a);
                    x2 = (-b - root) / (2 * a);
                }
                else
                {
                    
                    return (-1, -1);
                }
                return (x1,x2);
            }

            static string NumberToWords(int number)
            {
                string words = "";
                // Unfortunately, I can not find a solution easier that to add all the words to the array.
                string[] simpleNumberMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tensNumberMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number == 0)
                    return "zero";

                if (number > 0)
                {
                    if (number < 20)
                    {
                        words += simpleNumberMap[number];
                    }
                    else
                    {
                        words += tensNumberMap[number / 10];
                        if ((number % 10) > 0)
                            words += "-" + simpleNumberMap[number % 10];
                    }
                }
                return words;


            }

            static void Main(string[] args)
            {

                Console.WriteLine("Please select task number: 1,2,3,4,5");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                switch (taskNumber)
                    {
                    case 1:
                        {
                            Console.WriteLine("Course Task #1");
                            Console.WriteLine("The user enters 2 numbers (A and B). If A > B, result is A+B, if A=B, result is A * B, if A < B, result is A-B");
                            Console.Write("a = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("b = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(IfStatementTask(a, b));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Course Task #2");
                            Console.WriteLine("The user enters 2 numbers (X and Y). Determine which quarter the point with coordinates (X, Y) belongs to.");
                            Console.Write("x = ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("y = ");
                            int y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(QuarterIdentifier(x, y));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Course Task #3");
                            Console.WriteLine("The user enters 3 numbers (A, B and C). Print them to the console in ascending order.");
                            Console.Write("a = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("b = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.Write("c = ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            (a,b,c) = AscendingOrder(a, b, c);
                            if (a == 0 && b == 0 && c == 0)
                            {
                                Console.WriteLine($"Ascending order is not completed. Zero numbers provided: {a} , {b} , {c}");
                            }
                            else
                            {
                                Console.WriteLine($"Ascending order: {a} , {b} , {c}");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Course Task #4");
                            Console.WriteLine("The user enters 3 numbers (A, B and C). Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.");
                            Console.Write("a = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("b = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.Write("c = ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            int x1 = 0;
                            int x2 = 0;
                            (x1,x2) = QuadraticEquation(a, b, c);
                            if(x1 == -1 && x2 == -1)
                            {
                                Console.WriteLine("Действительных корней нет");
                            }
                            else
                            {
                                Console.Write($"X values = {x1};{x2}");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Course Task #5");
                            Console.WriteLine("The user enters a two-digit number. Print the capitalization of this number to the console. For example, typing '25' will print 'twenty - five' to the console.");
                            Console.Write("two-digit number = ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            string numberToWords = NumberToWords(number);
                            Console.WriteLine($"your number in words is: {numberToWords}");
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong number. Return to the start");
                        Main(null);
                        break;
                    }

                bool repeat = false;
                Console.WriteLine("Do you want to repeat the code again? Type 1 for 'yes'  0 for 'no'");
                int option = Convert.ToInt32(Console.ReadLine());
                if(option == 1)
                {
                    repeat = true;
                }    

                if(repeat)
                {
                    Main(null);
                }



            }
        }
    }
}
