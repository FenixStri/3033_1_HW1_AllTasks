//Fenix Strickland 113437176
//MIS 3033 HW1 Task 2

double sum = 0;
double examgrade;
double count = 0;

for (int i=1; i<=3; i++) 
{

    Console.WriteLine($"Input exam grade {i}");
    examgrade = Convert.ToDouble(Console.ReadLine());
    sum = sum + examgrade; 
    count++; 

}
double avg = sum / count;

Console.WriteLine($"{avg / 100:P2}");