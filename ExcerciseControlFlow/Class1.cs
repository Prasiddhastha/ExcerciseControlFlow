using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseControlFlow
{
    public class Question
    {   
        //Qno1
        public static void GetValidity()
        {
            Console.WriteLine("Enter a Number between 1 to 10");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        //Qno2
        public static void  GetMax()
        {
            Console.Write("Enter a number:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:");
            var num2 = Convert.ToInt32(Console.ReadLine());


            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine($"{max} is max");
        }
        //Qno3
        public static void GetAspectRatio()
        {
            Console.WriteLine("Enter Width of Image:");
            var width = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Height of Image:");
            var height = Convert.ToSingle(Console.ReadLine());
            var aspectRatio = (width / height > 1) ? "Landscape" : "Potrait";
            Console.WriteLine("Picture is {0}", aspectRatio);
        }
        //Qno4
        public static void SpeedCamera()
        {
            Console.WriteLine("Enter Speed Limit:");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Speed of a car");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            if(carSpeed<=speedLimit)
            {
                Console.WriteLine("OK");
            }
            else 
            {
                var kmperDemeritPoint = 5;
                var demeritpoint =(carSpeed-speedLimit)/kmperDemeritPoint;
                if(demeritpoint>12)
                {
                    Console.WriteLine("Licence Suspended");

                }
                else
                {
                    Console.WriteLine(demeritpoint);
                }
            }
        }
    }
}
