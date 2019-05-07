using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection_MemberInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(ReflectionTest);

            MemberInfo[] mInfo = t.GetMembers();

            Console.Write("Elemanlar : ");
            foreach (MemberInfo item in mInfo)
            {
                //if (item.MemberType == MemberTypes.Field)
                //{
                //    Console.WriteLine(item.Name + " - " + item.MemberType + " ");
                //}
                Console.WriteLine(item.Name + " - " + item.MemberType + " ");
            }

        }
    }
}
