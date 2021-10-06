using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o', ja 'l' tähte on lauses "Hello, World!"

            string helloW = "Hello World!".ToLower();

            int counter1 = 0;
            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < helloW.Length; i++)

            {
                if (helloW[i] == 'h')
                {
                    counterH++;
                }
                else if (helloW[i] == 'o')
                {
                    counterL++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Hello Worldis on {counter} 'h' {counter} 'o' ja {counter} 'l' tähte");
        }
    }
}
