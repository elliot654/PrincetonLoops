using System;

namespace PrincetonLoops
{
    class Program
    {
        static void Main()
        {
            int[] test = new int[] { 10, 2, 30, 40 };
            Console.WriteLine(IsOrdered(test));
            Rgb testRgb= new Rgb(75,0,130);
            Cmyk testCmyk = new Cmyk(0.42,1,0,0.49);
            testCmyk.ConvertRgb(testRgb);
            Console.WriteLine(testCmyk.ToString());
            testRgb.ConvertCmyk(testCmyk);
            Console.WriteLine(testRgb.ToString());
            Checkerboard(5);
            DrunkardWalk(100);
        }
        public static bool IsOrdered(int[] input)
        {
            int[] reference = (int[])input.Clone();
            int length = input.Length;
            for(int i = 0; i < length-1; i++)
            {
                int min = i;
                for(int j = i+1; j < length; j++)
                {
                    if (input[j] < input[min])
                    {
                        min = j;
                    }
                    int temp = input[min];
                    input[min] = input[i];
                    input[i] = temp;
                }
            }
            if(reference==input)
            {
                return true;
            }
            return false;
        }

        public static void Checkerboard(int input)
        {
            int count = 0;
            int[,] board = new int[input, input];
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (count % 2 == 0)
                    {
                        board[i, j] = 1;
                        count++;
                    }
                    else
                    {
                        board[i, j] = 0;
                        count++;
                    }
                }
            }
            int rows = board.GetLength(0); 
            int cols = board.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("\t" + board[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void DrunkardWalk(int steps)
        {
            Random random = new Random();
            var location = new Tuple<int, int>(0,0);
            for(int i = 0; i <= steps; i++)
            {
                switch (random.Next(3))
                {
                    case 0:
                        location = new Tuple<int, int>(location.Item1 + 1, location.Item2);
                        break;
                    case 1:
                        location = new Tuple<int, int>(location.Item1 - 1, location.Item2);
                        break;
                    case 2:
                        location = new Tuple<int, int>(location.Item1, location.Item2 + 1);
                        break;  
                    case 3:
                        location = new Tuple<int, int>(location.Item1, location.Item2 - 1);
                        break;
                }
                Console.WriteLine($"{location.Item1}, {location.Item2}");
            }
            int distance = Math.Abs((location.Item1 * location.Item1) + (location.Item2 * location.Item2));
            Console.WriteLine(distance);
        }
    }
}