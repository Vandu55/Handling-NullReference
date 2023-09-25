using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_NullReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = null;
                Console.WriteLine(name.Length);
                Console.ReadLine();
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("String is Null.........");   
            }
        }
    }
}
