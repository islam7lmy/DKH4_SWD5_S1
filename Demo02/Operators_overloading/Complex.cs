using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operators_overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)

                // a != null ? a.real : 0
            };
        }

        public static Complex operator ++(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + 1,
                Imag = (a?.Imag ?? 0) + 1

                // a != null ? a.real : 0
            };
        }

        public static Complex operator --(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - 1,
                Imag = (a?.Imag ?? 0) - 1

                // a != null ? a.real : 0
            };
        }

        public static bool operator >(Complex a, Complex b)
        {
            if (a.Real == b.Real)
                return a.Imag > b.Imag;
            else
                return a.Real > b.Real;
        }
        public static bool operator <(Complex a, Complex b)
        {
            if (a.Real == b.Real)
                return a.Imag < b.Imag;
            else
                return a.Real < b.Real;
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.Real == b.Real && a.Imag == b.Imag;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }



        ///casting
        public static /*int*/ explicit operator int(Complex a)
        {
            return a?.Real ?? 0;
        }

        //public static /*int*/ implicit operator int(Complex a)
        //{
        //    return a?.Real ?? 0;
        //}

        //public static /*int*/ implicit operator string(Complex a)
        //{
        //    return a?.ToString() ?? string.Empty;
        //}
    }

    static class ComplexExtinsions
    {
        public static Complex Add(this Complex A , Complex B)
        {
            return A + B;
        }
    }
}
