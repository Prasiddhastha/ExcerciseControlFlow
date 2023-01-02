using System;
namespace ExcerciseControlFlow

{   class Excercise
    {


    }
    class Program
    {   
        static void Main(string[] args)
        {
        A: Console.Clear();
            
            Console.WriteLine("Enter ur choice:");
            Console.WriteLine("1.ValidityCheck\t\t2.Max Number\n3.AspectRatio\t\t4.CarSpeed\n");
            var choice = Convert.ToInt32(Console.ReadLine());
        
            switch (choice)
            {   
                case 1:
                    Question.GetValidity();
                    Console.WriteLine("Press Any Key to clear screen");
                    Console.ReadKey();
                    goto A;
                    
                    
                case 2:
                        Question.GetMax();
                    Console.WriteLine("Press Any Key to clear screen");
                    Console.ReadKey();
                    goto A;
                case 3:
                        Question.GetAspectRatio();
                    Console.WriteLine("Press Any Key to clear screen");
                    Console.ReadKey();
                    goto A;
                case 4:
                    Question.SpeedCamera();
                    Console.WriteLine("Press Any Key to clear screen");
                    Console.ReadKey();
                    goto A;
                default:
                    Console.WriteLine("Wrong Input");
                    Console.WriteLine("Press Any Key to clear screen");
                    goto A;
            }
        }
    }
}
