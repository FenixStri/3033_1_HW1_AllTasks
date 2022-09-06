//Fenix Strickland 113437176
//MIS 3033 HW1 Task 3


Console.WriteLine("Do you have an exam grade? (yes/no):");
string userinput = Console.ReadLine();

double sum = 0;
int count = 0;

if (userinput == "Yes" || userinput == "yes")
{
    do
    {
        Console.WriteLine("Please input one exam grade: ");
        double examscore = Convert.ToDouble(Console.ReadLine());
        sum = sum + examscore;
        count++;

        Console.WriteLine("Do you have another exam grade? (yes/no)");
        userinput = Console.ReadLine();

    } while (userinput == "Yes" || userinput == "yes");
}

else if (userinput == "No" || userinput == "no")
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine("ERROR 404 NOT FOUND");
}
double avg = sum / count;
Console.WriteLine($"The number of exams is {count}");
Console.WriteLine($"The average grade percentage is {avg / 100:p2}");
