using System;

namespace Workshop
{
    class Program
    {
        public const int stack = 100;
        public const int bet = 1;


        static void Main(string[] args)
        {
            ToCheckWinOrLoss();
           int check = ToWinOrLoss();
            Console.WriteLine("FINAL AMOUNT AFTER DAY " +check);


        }
        public static int ToCheckWinOrLoss()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            return result;
        }
        public static int ToWinOrLoss()
        {
            int STACK = stack;
            int result = ToCheckWinOrLoss();
            while (STACK < 150 && STACK > 50)
            {
                if (result == 0)
                    STACK = STACK - bet;
                else if (result == 1)
                    STACK = STACK + bet;
            }
            return STACK;
        }
    }
}
      
