using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            List<string> list = new List<string>();

            using (LargeDataCollection data = new LargeDataCollection(list))
            {
                Console.WriteLine(" Enter Total numbers Count");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter numbers to Add");
               for(int i=0;i<num;i++)

                {
                    
                    string add = Console.ReadLine();
                    data.Push(add);                    
                }
                               
                Console.WriteLine("updated list is :");
                data.Read();
                Console.Write("\n");
                Console.WriteLine("Enter number to Remove");
                string Remove = Console.ReadLine();
                data.Remove(Remove);
              
                Console.WriteLine("updated list is :");
                data.Read();
                Console.Write("\n");
               // Console.WriteLine("After removing number updated list is"+ data);

            };
            //Console.WriteLine($"After removing number updated list is :{list}");
           
            Console.ReadKey();
        }
    }
}
