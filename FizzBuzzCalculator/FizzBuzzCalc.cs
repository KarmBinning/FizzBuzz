using System;

namespace FizzBuzzCalculator
{
    public class FizzBuzzCalc
    {
        public FizzBuzzCalc() { }

        public FizzBuzzCalc(int fizzNumber, int buzzNumber) { }

        //	TODO:
        //	if i is a multiple of "fizzNumber" print "fizz"
        //	multiple of "buzzNumber" => print "buzz"
        //	multiple of both => print "fizzbuzz"
        //	any other number => print the number
        public string ToString(int i)
        {
            if (i == 0)
                throw new ArgumentException();
            if (i % 15 == 0)
                return "Fizz Buzz";
            else if (i % 3 == 0)
                return "Fizz";
            else if (i % 5 == 0)
                return "Buzz";
            else
                return i.ToString();
        }
    }
}
