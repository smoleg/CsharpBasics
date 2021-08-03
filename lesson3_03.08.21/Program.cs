using System;

namespace lesson3_03._08._21
{
    // Повторить стэк и куча
    // Повторить ref, in, out

    struct Complex
    {
        public int a, b;

        public Complex(int re, int im)
        {
            a = re;
            b = im;
        }

        public override string ToString()
        {
            return b < 0 ? $"{a} - {-b}i" : $"{a} + {b}i";
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(re: x.a + y.a, im: x.b + y.b);
        }

        public static Complex operator -(Complex x)
        {
            return new Complex(re: -x.a, im: -x.b);
        }

    }
    class Program
    {

        static void M (Complex z)
        {
            z.a = 2020;
        }
        static void Main(string[] args)
        {
            Complex z1 = new Complex(re: 1, im: 33);
            Console.WriteLine(z1);
            M(z1);
            Console.WriteLine(z1);

            //z1.a = 10;
            //z1.b = 33;
            //Complex z2 = new Complex();
            //z2.a = 42;
            //z2.b = 11;
            //Console.WriteLine(z1 + z2);
            //Complex z3 = -z2;
            //Console.WriteLine(z3);
        }

        static int A(in int a)
        {
            return a;
        }

        
    }
}
