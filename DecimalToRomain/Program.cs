/*
 This Program convert Decimal Number to Romain Numbers

Autor: Heydi Garcia Sanchez
ID: 1107303
 */

bool continueConversion = true;
while (continueConversion) 
{  
    int number;
    string input;

    do
    {
        Console.Write("Enter a decimal number to convert to Roman numeral: ");
        input = Console.ReadLine();
        //validacion numerica (rechazar entrada no numerica)
        if(!int.TryParse(input, out number) || number < 1 || number > 3999) 
        {
            Console.WriteLine("Invalid input. Please enter a valid decimal number");
        }

    } while (!int.TryParse(input, out number) || number < 1 || number > 3999);

    string result = DecimalToRomain(number);
    Console.WriteLine($"Roman numeral: {result}");

    Console.WriteLine("Continue or Try again? write down Y/N");
    string choice = Console.ReadLine().Trim().ToUpper();
    if (choice != "Y")
    {
        continueConversion = false;
    }
} 

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