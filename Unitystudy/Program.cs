namespace Unitystudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1
            int num = 1;

            while (num <= 10)
            {
                Console.WriteLine("{0}", num);
                num++;
            }
            */

            for (int a = 2; a <= 9; a++)
            {
                Console.WriteLine("{0}단",a);

                for(int b = 1; b <= 9; b++)
                {
                    
                 Console.WriteLine("{0}*{1}={2}", a,b,a*b);
                    
                }
            }

        }
    }
}
