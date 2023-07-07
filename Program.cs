// See https://aka.ms/new-console-template for more information

using System ;

namespace WiredBrainApp
{
    public static class Program {

        public static void Main (string[] args)
        {
            StackDoubles();
            StackStrings();
            System.Console.ReadLine();
        }

        private static void StackStrings()
        {
            SimpleStack stack = new SimpleStack();
            stack.Push("Michael Goboola");
            stack.Push("Nuwagaba Prudence Monica");
            stack.Push("Namugalu Nicole Maria");
            stack.Push("Nafula Moureen");
            stack.Push("Ayebare Nicole");
            stack.Push("Agaba Mbaaga Atuhaire");
            stack.Push("Rwothongeyo Trinity");
            stack.Push("Akampulira Sarah");
            stack.Push("Atuhaire Lynn");
            stack.Push("Kabasuga Persis Joseline");

            while (stack.count > 0)
            {
                var item = stack.Pop();
                System.Console.WriteLine($"The Name is {item}");
            }

            
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack();
            var sum = 0.0;
            stack.Push(1.20);
            stack.Push(2.34);
            stack.Push(4.5);

            while (stack.count > 0)
            {
                var item = (double)stack.Pop();
                System.Console.WriteLine($"The value at {stack.count} is {item}");
                sum += item;
            }

            System.Console.WriteLine($"The Sum of the Items is {sum} \n");
        }
    }
}

