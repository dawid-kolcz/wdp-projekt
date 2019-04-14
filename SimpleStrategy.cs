using System;
namespace Projekt
{
    public class SimpleStrategy : Strategy
    {
        public SimpleStrategy()
        {
        }

        public void WriteStrategy()
        {
            Console.WriteLine("Simple strategy -> Lose!");
        }
    }
}