class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите первое число ");
            double Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак операции ");
            string Operation = Console.ReadLine();
            Console.WriteLine("Введите второе число ");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            double Result = double.NaN;

            if (Operation == "+")
                Result = Num1 + Num2;
            else if (Operation == "-")
                Result = Num1 - Num2;
            else if (Operation == "*")
                Result = Num1 * Num2;
            else if (Operation == "/")
                if (Num2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    continue;
                }
                else
                {
                    Result = Num1 / Num2;
                }
            else
            {
                Console.WriteLine("Поддерживаются только операции + - * /");
                continue;
            }
            Result = Num1 / Num2;
            Console.WriteLine(Result);
        }
    }
}
    
