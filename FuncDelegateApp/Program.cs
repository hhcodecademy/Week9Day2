namespace FuncDelegateApp
{
    public delegate bool NihadDelegate(string msg);
    public delegate void NDelegate(int msg);

    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int> myFunc = random;
            myFunc(4);
            NDelegate nDelegate = random;
            nDelegate(5);

            //Func<string, bool> nihad = NihadMethod;
            //bool result3 = nihad("no");
            //Console.WriteLine(result3);
            //Predicate<string> nihad2 = NihadMethod;
            //bool result4 = nihad("yes");
            //Console.WriteLine(result4);
            //NihadDelegate nihad3 = NihadMethod;
            //bool result5 = nihad("no");
            //Console.WriteLine(result5);
            //Func<int> delegate1= Result;
            //int result1 = delegate1.Invoke();
            //Console.WriteLine(result1);
            //Func<int, int> delegate2 = Result2;
            //int result2 = delegate2.Invoke(3);
            //Console.WriteLine(result2);

            //Func<int, int, int> delegateMath = sum;
            //delegateMath += multiply;
            //delegateMath += sub;
            //int result = delegateMath.Invoke(10, 8);
            //Console.WriteLine(result);

            //Func<int, int, string> delegatResult = sumResult;
            //string msj = delegatResult.Invoke(10, 8);
            //Console.WriteLine(msj);

        }

        public static int sum(int value1, int value2)
        {
            return value1 + value2;
        }
        public static int multiply(int value1, int value2)
        {
            return value1 * value2;
        }
        public static int sub(int value1, int value2)
        {
            return value1 - value2;
        }

        public static string sumResult(int value1, int value2)
        {
            return (value1 + value2).ToString();
        }

        public static int Result()
        {
            return 5;
        }
        public static int Result2(int value1)
        {
            return value1 * 5;
        }
        public static void random(int value)
        {
            Console.WriteLine("SALAM   " + value) ;
        }
        public static bool NihadMethod(string str)
        {
            if (str == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
