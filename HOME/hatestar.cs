namespace HOME
{
    internal class Program
    {
        static int Test (int a)
        {


            a++;
            Console.WriteLine(a);

            return a;
        }

        static void Main(string[] args)
        {
            /*
            for(int i =1; i<=5; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            */

            /*
            for (int i = 1; i <=5; i++)
            {
                

                for(int j = 5; j>=i; j--)
                {
                    Console.Write("*");
                }
            
            Console.WriteLine();
            }
            */

            /* 3
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
            */

            /* 4
            int a = 0;

            for(int i= 1; i <=10; i++ )
            {
                a += i;
            }
            Console.WriteLine(a);
            */

            string a = Console.ReadLine();
            int b = int.Parse(a);

            Test(b);

        }
    }
}
