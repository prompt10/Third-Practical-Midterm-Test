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
                Console.Write("Please input the amount of thing in 1st Box; ");
                _1stBox = int.Parse(Console.ReadLine());
            } while (_1stBox <= 0);
            do
            {
                Console.Write("Please input the amount of thing in 2nd Box; ");
                _2ndBox = int.Parse(Console.ReadLine());
            } while (_2ndBox <= 0);
            do
            {
                Console.Write("Please input the amount of thing in 1st Box; ");
                _3rdBox = int.Parse(Console.ReadLine());
            } while (_3rdBox <= 0);
        }
    }
}
