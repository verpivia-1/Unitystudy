namespace HOME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1
            for(int i =1; i<=5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            */

            /* 2
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine();

                for(int j = 5; j>=i; j--)
                {
                    Console.Write("*");
                }
            
            }
            */

            for (int i = 1; i <= 10; i++)
            {
                int a = i;
                int b = a % 2;
               
                if (b == 1)
                {
                    Console.WriteLine("{0}는 홀수 입니다.", a);
                }
                else
                {
                    Console.WriteLine("{0}는 짝수 입니다.", a);
                }

            }

         }
    }
}
