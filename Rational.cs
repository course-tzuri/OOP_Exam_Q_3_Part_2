using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace Exam_25_10_2020_dotnet_course_Q_2
{
    class Rational
    {
        public double _p;
        public double _q;
       // public int notRationalNum;
       // public bool rationalNum;

        public  Rational(double p, double q)
        {
            _p = p;
            _q = q;
            if (p%1!=0 & q <=0)
            {
                p = 0;
            }
            
            
        }

        public bool GraterThan(Rational r1, Rational r2)
        {
            return r1._p * r2._q > r1._q * r2._p;
        }
        public bool Equals(Rational r1, Rational r2)
        {
            return r1._p * r2._q == r1._q * r2._p;
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            Rational r3 = new Rational((r1._p * r2._q + r1._q * r2._p), (r1._q * r2._q));
            return r3;
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            Rational r4 = new Rational((r1._p * r2._q - r1._q * r2._p), (r1._q * r2._q));
            return r4;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            Rational r5 = new Rational((r1._p * r2._p), (r1._q * r2._q));
            return r5;
        }
        public static double GetNumerator(Rational r6)
        {
          
            return r6._p; 
        }

        public static double GetDenominator(Rational r5)
        {
            return r5._q;
        }
        public override string ToString()
        {
            return "3/4()";
        }


    }
}
