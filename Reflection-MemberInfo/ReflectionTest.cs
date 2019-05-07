using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_MemberInfo
{
    class ReflectionTest
    {
        public ReflectionTest() {
            Member1 = 1;
            Member2 = 2;
            Member3 = 3;
        }

        int member1, member2, member3;

        public int Member1 { get => member1; set => member1 = value; }
        public int Member2 { get => member2; set => member2 = value; }
        public int Member3 { get => member3; set => member3 = value; }


        public static int topla(int a, int b)
        {
            return a + b;
        }

        public static int cikar(int a, int b)
        {
            return a - b;
        }

        public static int karesi(int a)
        {
            return a * a;
        }

        

    }
}
