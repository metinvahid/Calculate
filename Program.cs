using System.ComponentModel.Design.Serialization;

namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cavab1 = Topla(3, 4);
            Console.WriteLine(cavab1);
            Topla1(6, 4);




        l1:
            Console.Write("a:");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                goto l1;
            }

        l2:
            Console.Write("b:");
            if(!double.TryParse(Console.ReadLine(),out double b))
            {
                goto l2;
            }

        l3:
            Console.Write("operation as [+,-,*,/] ");
            char operation = Console.ReadLine()[0];
            double cavab = Calculate(a,b,operation);
            Console.WriteLine($"{a} {b} {operation} = {cavab}");

            Console.ReadKey();

        }

        static int Topla(int a , int b)
        {
            int c = a + b;
            return c;
        }

        static void Topla1 (int a , int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }


        static double Calculate(double a , double b , char op)
        {
            double c = 0;

            switch (op)
            {
                case '+':
                    c = a + b; break;

                case '-':
                    c = a - b; break;

                case '*': c = a * b; break;

                    case '/': c = a / b; break;



                    default:
                    break;
            }


            return c;
        }

    }
}
