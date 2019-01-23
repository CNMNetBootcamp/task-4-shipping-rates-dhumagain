using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)

        {
            //Good
            //setup
            double itemWeight = 0.0;
            double cost = 0.0;

            //input

            Console.WriteLine(" Please enter the weight of the shipping item in lb.");

            itemWeight =double.Parse(Console.ReadLine());

            //output

            if (itemWeight<=2)
            {
               cost = 2;
                
            }
            else if (itemWeight >2 && itemWeight <=6)

            {
                cost = 4;
            }
            else if (itemWeight >6 && itemWeight <= 10)
            {
                cost = 6;
            }
            else
            {
                cost = 10;
            }

            Console.WriteLine("The cost of shipping " + itemWeight + "  lb is $" + cost);

            Console.ReadLine();
        }
    
    }
}

