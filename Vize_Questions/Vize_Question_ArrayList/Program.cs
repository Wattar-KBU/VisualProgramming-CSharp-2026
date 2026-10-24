using System.Collections;
namespace Vize_Question_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("Ayse");
            array.Add("Ahmet");
            array.Add("9");

            bool name = (array.Contains("Ali") ? true : false);
            if (name == false)
                array.Insert(0, "Ali");
            else
                Console.WriteLine("Alread contain ali ");
            
           
            array.Sort();
            foreach (object  var in array){
                Console.WriteLine(var);
            }
            
        }
    }
}
