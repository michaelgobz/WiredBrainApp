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
            SimpleStack<string> stack = new SimpleStack<String>();
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
            stack.Push("Ndikurungi Angela");
            stack.Push("Akaliza Keza Nina");
            stack.Push("Nandutu Sharon");
            stack.Push("Nanyanzi Sharon Makumbi");
            stack.Push("Akullu Viola");
            stack.Push("Akello winnifred");
            stack.Push("Akello winnie");
            stack.Push("Namuyomba Sabrina");
            stack.Push("Lindah Tracy");

            while (stack.Count > 0)
            {
                var item = stack.Pop();
                System.Console.WriteLine($"The Name is {item}");
            }

            
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            var sum = 0.0;
            stack.Push(1.20);
            stack.Push(2.34);
            stack.Push(4.5);

            while (stack.Count > 0)
            {
                var item = stack.Pop();
                System.Console.WriteLine($"The value at {stack.Count} is {item}");
                sum += item;
            }

            System.Console.WriteLine($"The Sum of the Items is {sum} \n");
        }
    }
}

