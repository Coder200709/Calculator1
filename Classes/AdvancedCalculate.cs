namespace Calculator.Classes
{
    public class AdvancedCalculate : Calculate, IAdvancedCalculate
    {
        public AdvancedCalculate(string name, double firstNumber, string function, double secondNumber)
            :base(name, firstNumber, function, secondNumber)
            { }

        public double Percentage(double firstNumber, double secondNumber)
        {
            double result = (firstNumber / 100) * secondNumber;

            return result;
        }
        public void MultiplicationTable(double rows, double columns){
            for (int i = 1; i <= rows; i++){
                for (int j = 1; j <= columns; j++){
                    int result = i * j;
                    Console.Write($"{i} * {j} = {result}\t");
                }
            Console.WriteLine();
            }
        }
        public override void CalcuateAllFunctions()
        {
            double result = Percentage(this.FirstNumber, this.SecondNumber);

            Console.WriteLine($"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");
        }

        

        void IAdvancedCalculate.MultiplicationTable(double firstNumber, double secondNumber)
        {
           MultiplicationTable(10,10);
        }
    }
}