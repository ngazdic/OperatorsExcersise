
using OperatorExcersise;




Console.WriteLine(Calculations.Subtract(2, 5));
Console.WriteLine(Calculations.Multiply(2, 5));
Console.WriteLine(Calculations.Divide(2, 2));
Console.WriteLine(Calculations.Add(2, 5));
Console.WriteLine(Calculations.Modulus(2, 2));







int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int quotient = a / b;
int remainder = a % b;

if (a % b == 0)
{

    Console.WriteLine(a + "/" + b + " is " + quotient);
}
else
{
    Console.WriteLine($"{a} / {b} result is {quotient} reminder is {remainder}");
}



Console.WriteLine(" What is the radius of your circle ?");
var radius = double.Parse(Console.ReadLine());
Console.WriteLine($"The area of a circle with radius of {radius} is {Calculations.AreaOfCircle(radius)}");

