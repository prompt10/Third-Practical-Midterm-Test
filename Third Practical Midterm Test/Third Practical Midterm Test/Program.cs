using System;

namespace Third_Practical_Midterm_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int _1stBox, _2ndBox, _3rdBox, aTake, bTake;
            do
            {
                Console.Write("Please input the amount of thing is 1st Box; ");
                _1stBox = int.Parse(Console.ReadLine());
            } while (_1stBox <= 0);
        }
    }
}
