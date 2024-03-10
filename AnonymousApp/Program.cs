namespace AnonymousApp
{
    public delegate void PrintDelegete(int value);
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDelegete printDelegete1 = printMessage;
            //printDelegete1(45);

            PrintDelegete printDelegete2 = printMessage2;
            //printDelegete2(85);

            PrintDelegete printDelegete3 = delegate (int param)
            {

                Console.WriteLine($"{param} will  print");
            };

            PrintDelegete printDelegete4 = (int param)=>
            {

                Console.WriteLine($"{param}  will have print");
            };

            PrintDelegete delegete = printDelegete1;
            delegete += printDelegete2;
            delegete += printDelegete3;
            delegete += printDelegete4;

            printData(delegete,10);

        }

        public static void printMessage(int value) {

            Console.WriteLine($"{value} has printed");
        }

        public static void printMessage2(int value)
        {

            Console.WriteLine($"{value} is printing");
        }

        public static void printData(PrintDelegete delegete, int value)
        {
            value = value * 10;
            delegete(value);
        }
    }
}
