namespace WiredBrainApp
{
    public class Utils
    {

        public void StackStrings()
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

        public void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            var sum = 0.0;
            stack.Push(1.20);
            stack.Push(2.34);
            stack.Push(34.5);
            stack.Push(2.52);
            stack.Push(4.490);
            stack.Push(56.5);
            stack.Push(90.5);
            stack.Push(12.5);
            stack.Push(91.5);

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
