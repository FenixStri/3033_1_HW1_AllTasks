//Fenix Strickland 113437176
//MIS 3033 HW1 Task 4

//First Method

 double LineValueForY(double m, double x, double b)
{
    return m * x + b;
}

Console.WriteLine("Input values m, x, and b to calculate Y.");
Console.WriteLine("M: ");
double slope = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("X: ");
double xinput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("B: ");
double yintercept = Convert.ToDouble(Console.ReadLine());

double y = LineValueForY(slope, xinput, yintercept);

Console.WriteLine($"Y = {y}");

//Second Method

int Factorial(int number)
{
    int fact = 1;
    for(int i = 2; i <= number; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int factsolution;
Console.WriteLine("Input number to acquire it's factorial: ");
int number = Convert.ToInt32(Console.ReadLine());
factsolution = Factorial(number);
Console.WriteLine($"The factorial of your number is: {factsolution}");