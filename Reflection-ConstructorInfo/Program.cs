using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_ConstructorInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(String);
            ConstructorInfo[] cInfo = t.GetConstructors();

            Console.WriteLine(t.Name + " in 'Constructor'ları");

            foreach (ConstructorInfo item in cInfo)
            {
                Console.Write(t.Name + " ");

                ParameterInfo[] pInfo = item.GetParameters();
                foreach (var parameters in pInfo)
                {
                    Console.Write(parameters.ParameterType +" "+ parameters.Name +"  " );
                }
                
                Console.WriteLine();

            }

        }
    }
}
