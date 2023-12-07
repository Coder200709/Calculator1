using Calculator.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to calculator!");
        Console.Write("Your name: ");
        string name = Console.ReadLine()!;

        Console.Write("First number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("Function [+ | - | / | * | prc | avg]: ");
        string function = Console.ReadLine()!;
        Console.Write("Second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine()!);
        if(function == "prc")
        {
            AdvancedCalculate advancedCalculate = 
                new AdvancedCalculate(name, firstNumber, function, secondNumber);
                advancedCalculate.CalcuateAllFunctions();
        }
        else if (function == "avg"){
            AdvancedCalculate advancedCalculate1 = new AdvancedCalculate(name, firstNumber, function, secondNumber);
            advancedCalculate1.MultiplicationTable(10,10);
        }
        else
        {
            ICalculate calculate = new Calculate(name, firstNumber, function, secondNumber);
            calculate.CalcuateAllFunctions();
        }
    }
}