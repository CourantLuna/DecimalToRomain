/*
 This Program convert Decimal Number to Romain Numbers

Autor: Heydi Garcia Sanchez
ID: 1107303
 */

Console.WriteLine("Enter a decimal number to convert to Roman numeral: ");
string input= Console.ReadLine();

//validacion numerica (rechazar entrada no numerica)
if(!int.TryParse(input, out int number)) 
{
    Console.WriteLine("Invalid input. Please enter a valid decimal number. "); 
    return;
}

if(number < 1 || number > 3999) 
{
    Console.WriteLine("Please enter a number between 1 and 3990.");
    return;
}

string result = DecimalToRomain(number);
Console.WriteLine($"Roman numeral: {result}");

static string DecimalToRomain(int number) 
{
    string[] thousands = { "", "M", "MM", "MMM" };
    string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    return thousands[number / 1000] +
           hundreds[(number % 1000) / 100] +
           tens[(number % 100) / 10] +
           units[number % 10];
}