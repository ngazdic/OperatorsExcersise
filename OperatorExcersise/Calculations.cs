using System;
namespace OperatorExcersise
{
    public class Calculations
    {


        public static int Subtract(int num1, int num2)
        {
           int sum = 0;
            sum = num1 - num2;

            return sum;
        }


        public static int Add(int num1, int num2)
        {

            return  num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {

            return num1 * num2;


        }

        public static int Divide(int num1, int num2)
        {


            return num1 / num2;


        }

        public static int Modulus(int num1, int num2)
        {

            return num1 % num2;


        }

        public static double AreaOfCircle(double r)
        {


            double radius = Math.PI* Math.Pow(r, 2);

            return radius;


        }

    }
}



    

