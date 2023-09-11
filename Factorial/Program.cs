Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
bool next;

do
{
    var n = RequestInt("n? ");
    var fact = Factorial(n);
    Console.WriteLine($"{n}! = {fact}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"------------------------");
    Console.ForegroundColor = ConsoleColor.White;
    next = RequestBool("Do you want to calculate another factorial [y/n]? ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"------------------------");
    Console.ForegroundColor = ConsoleColor.White;
} while(next);

bool RequestBool(string message)
{
    Console.Write(message);
    var response = Console.ReadLine();
    if (response!.ToLower() == "y")
    {
        return true;
    }
    return false;
}

double Factorial(int n)
{
    double factorial = n;
if (factorial > 0)
    {
        for (int x = n - 1; x > 0; x--)
        {
            factorial = factorial * x;
        }
        return factorial;
    }
    else
    {
        for (int x = n + 1; x < 0; x++)
        {
            factorial = factorial * x;
        }
        return factorial;
    }
    
}

int RequestInt(string message)
{
    Console.Write(message);
    var inputString = Console.ReadLine();
    try
    {
        return Convert.ToInt32(inputString);
    }
    catch (Exception)
    {
        throw new Exception("You must enter a valid integer number.");
    }
}