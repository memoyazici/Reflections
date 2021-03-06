﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection_MethodInvokeAtRuntime
{
    class ReflectionTest
    {
        public ReflectionTest()
        {
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

        class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,22,3,44,5,66,7};
            int sonuc;

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}




            Type t = typeof(ReflectionTest);
            MethodInfo m = t.GetMethod("topla");

            object[] parameters = { 15, 25 };

                if (m.IsStatic)
                {
                    sonuc = (int) m.Invoke(null,parameters);
                }
                else
                {
                    object o = Activator.CreateInstance(t);
                    sonuc = (int) m.Invoke(o,parameters);
                }

           Console.WriteLine(sonuc.ToString());
            



            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
