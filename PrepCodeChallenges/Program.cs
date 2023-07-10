namespace PrepCodeChallenges
{
    internal class Program
    {
         static void Main()
        {
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
        }

        static void Challenge1()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}. Enter a number between 1 and 10: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your entries: [" + string.Join(", ", numbers) + "]");

            Console.Write("Select a number from your entries: ");
            int selectedNumber = Convert.ToInt32(Console.ReadLine());

            int score = CalculateScore(numbers, selectedNumber);
            Console.WriteLine("Score: " + score);
        }

        static int CalculateScore(int[] numbers, int selectedNumber)
        {
            int score = 0;
            foreach (int num in numbers)
            {
                if (num == selectedNumber)
                {
                    score += num;
                }
            }
            return score;
        }

        static void Challenge2()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool yearLept = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                yearLept = true;
            }

            Console.WriteLine($"Is {year} a Leap Year? {yearLept}");
        }

        static void Challenge3()
        {
            Console.Write("Enter an array of numbers separated by commas: ");
            string input = Console.ReadLine();

            string[] numbersStr = input.Split(',');
            int[] numbers = new int[numbersStr.Length];

            for (int i = 0; i < numbersStr.Length; i++)
            {
                if (!int.TryParse(numbersStr[i], out numbers[i]))
                {
                    throw new ArgumentException("Invalid input! Please enter a valid array of numbers separated by commas.");
                }
            }

            bool isPerfectSequence = true;
            int product = 1;
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    isPerfectSequence = false;
                    break;
                }

                product *= num;
                sum += num;
            }

            if (product != sum)
            {
                isPerfectSequence = false;
            }

            Console.WriteLine("Is this a perfect sequence? " + (isPerfectSequence ? "Yes" : "No"));
        }

        static void Challenge4()
        {
            Console.WriteLine();
        }
    }
}