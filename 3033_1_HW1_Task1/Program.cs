// Fenix Strickland 113437176
// MIS 3033 HW1 Task 1

const double cogs = 79.99;
const double wholesaleprice = 250.00;
const double markup = 0.15;
const double combomarkup = 0.125;
const double salestax = 0.089;



Console.WriteLine("How many cogs are being purchased?");
double cogamt = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How many gears are being purchased?");
double gearamt = Convert.ToDouble(Console.ReadLine());

double combototal = (cogs * cogamt) + (wholesaleprice * gearamt);
double totalcount = cogs + wholesaleprice;
double taxcombo = combototal * salestax;
double calccombomark = combototal * combomarkup;
double grandtotal = combototal + taxcombo + calccombomark;

if (cogamt > 10 || gearamt > 10 || totalcount == 16)
{
  
    Console.WriteLine("Here is your receipt:");
    Console.WriteLine($"You purchased {cogamt} cogs.");
    Console.WriteLine($"You purchased {gearamt} gears.");
    Console.WriteLine($"Your subtotal is: {combototal:c2}");
    Console.WriteLine($"Sales Tax: {taxcombo:c2}");
    Console.WriteLine($"Discount: {calccombomark:c2}");
    Console.WriteLine($"Grand Total: {grandtotal:c2}");
}
else
{
    double regtotal = (cogs * cogamt) + (wholesaleprice * gearamt);
    double calcregmark = regtotal * markup;
    double taxreg = regtotal * salestax;
    double reggrandtotal = regtotal + calcregmark + taxreg;
    Console.WriteLine("Here is your receipt:");
    Console.WriteLine($"You purchased {cogamt} cogs.");
    Console.WriteLine($"You purchased {gearamt} gears.");
    Console.WriteLine($"Your subtotal is: {regtotal:c2}");
    Console.WriteLine($"Sales Tax: {taxreg:c2}");
    Console.WriteLine($"Discount: 0.00");
    Console.WriteLine($"Grand Total: {reggrandtotal:c2}");
}
