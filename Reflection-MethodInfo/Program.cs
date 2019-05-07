using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_MethodInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Array);

            MethodInfo[] mInfo = t.GetMethods();

            int counter = 0;

            foreach ( MethodInfo item in mInfo)
            {
                Console.WriteLine("Metodun adı : "+ item.Name);
                Console.WriteLine("Return type : "+ item.ReturnType);

                if (item.IsStatic)
                {
                    Console.WriteLine("Bu metot statik");
                }
                else
                {
                    Console.WriteLine("Bu metot statik değil");
                }

                Console.WriteLine();
                counter++;
            }
            Console.WriteLine("Toplam " +counter + " adet metodu var..");

        }
    }
}
