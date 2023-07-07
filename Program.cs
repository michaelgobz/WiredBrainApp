// See https://aka.ms/new-console-template for more information

using System ;

namespace WiredBrainApp
{
    public static class Program {

        public static void Main (string[] args) {
            var stack =  new SimpleStack();
            var sum = 0.0;
            stack.Push(1.20);
            stack.Push(2.34);
            stack.Push(4.5);
            
            while(stack.count > 0)
            {
                double item =  stack.Pop();
                System.Console.WriteLine($"The value at {stack.count} is {item}");
                sum =+ item;
            }

            System.Console.WriteLine($"The Sum of the Items is {sum}");
            System.Console.ReadLine();
        }
    }
}

