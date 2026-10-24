using System.Collections;
using System.Text;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Collec = new ArrayList();
            int Position = Collec.Add("Laptop"); //So this Method adds an index and return the number of index  
            int position2 = Collec.Add("Mouse");
            Collec.Add(500);
            string keyboard = (Collec.Contains("keyboard")) ? "1" : "Keyboard";
            if (keyboard == "Keyboard")
                Collec.Insert(0, "keyboard");
            else
                Console.WriteLine("It is already Exist");
            foreach (object var in Collec)
                Console.Write(var + " ");
        }
    }
}
