namespace CIT_190_Lesson_8_Delegate_Work
{
    public class MathSolutions
    {
        public delegate double addMe(double x, double y);
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            // Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            // Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");

            Action<double, double> shrink = answer.GetSmaller;
            shrink(num1, num2);

            Func<double, double, double> times = answer.GetProduct;
            Console.WriteLine($"{num1} * {num2} = {(times(num1, num2))}");

            addMe total = new addMe(answer.GetSum);
            Console.WriteLine($"{num1} + {num2} = {total(num1, num2 )}");
        }
    }
}
