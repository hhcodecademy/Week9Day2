using System.Xml.Schema;

namespace DelegateApp
{
    public delegate string MyDelegate2(string msj);
    public delegate void MyDelegate(string msj);
    internal class Program
    {

        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            list.Add("Nihat");
            list.Add("Yusif");
            list.Add("Nicat");
            list.Add("Fuzuli");
            list.Add("Ekber");

           var filteredList= list.Where(x=>x.StartsWith('N'));
           foreach (var x in filteredList)
            {
                Console.WriteLine(x);
            }
          


            ////Console.WriteLine("Hello, World!");
            //MyDelegate2 myDelegate2 = sayByeBye;
            //myDelegate2 += sendMessage;
            ////myDelegate2 = sayByeBye;
            ////MyDelegate myDelegate = sayHello;
            //string msj= myDelegate2.Invoke("Fuzuli sendMessage");
            //Console.WriteLine(msj); 

        }

        public static void sayHello(string msj)
        {

            Console.WriteLine(msj);

        }
        public static void sayBye(string msj)
        {

            Console.WriteLine(msj);

        }

        public static string sayByeBye(string msj)
        {
            string newMessgage = msj + "  ByeBye";
            Console.WriteLine(newMessgage);

            return msj;
        }
        public static string sendMessage(string msj)
        {
            string newMessage=msj+DateTime.Now.ToString();
            Console.WriteLine(msj);
        
            return newMessage;
        }


    }
}
