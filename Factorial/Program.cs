Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
bool next;

do
{
    var n = RequestInt("n? ");
    var fact = Factorial(n);
    Console.WriteLine($"{n}! = {fact}");
    next = RequestBool("Do you want to calculate another factorial [y/n]? ");
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
    // Implement yor logic here
    return 0;
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