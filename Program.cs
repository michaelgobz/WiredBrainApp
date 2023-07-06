// See https://aka.ms/new-console-template for more information

using System ;

namespace WiredBrainApp
{
    public static class Program {

        public static void Main (string[] args) {
            var stack =  new SimpleStack();
            stack.Push(1.20);
            stack.Push(2.34);
            stack.Push(4.5);

            while(stack.count > 0) 
            {
                System.Console.WriteLine($"The value at {stack.count} is {stack.Pop()}");
            }
        }
    }
}

