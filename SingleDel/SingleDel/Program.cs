using System;
namespace SingleDel

{

    class Program{

        public delegate void dMethod();

        public class P
        {
            public static void display() {
                Console.WriteLine("Hello");
            }
            public static void show() { 
                Console.WriteLine("Show");
            }

            //public static void print() { 
            //    Console.WriteLine("Print");
            //}

        }   //end class

        static void Main(string[] args) {
            //assign method show to delegate dMethod()

            dMethod d1 = P.show;

            dMethod d2 = new dMethod(P.display);

            //P obj = new P();

            //dMethod d3 = obj.print;

            //call method via delegates
            d1();
            d2();
            //d3();

        }

    }   //end program
}   //end namespace