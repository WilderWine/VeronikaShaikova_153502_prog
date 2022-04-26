using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_lab_7
{

   /* class IndEquat
    {
        Equation[] eqs;
        public IndEquat(Equation[] p) => eqs = p;
        // индексатор
        public Equation this[int index]
        {
            get => eqs[index];
            set => eqs[index] = value;
        }
    }*/

    public class Equation
    {
        private int _a, _b, _c;
        public int A { get { return _a; } set { _a = value; } }
        public int B { get { return _b; } set { _b = value; } }
        public int C { get { return _c; } set { _c = value; } }
        public Equation()
        {
        }
        public Equation(int _v1)
        {
            _a = _v1;
            _b = _c = 0;
        }
        public Equation(int _v1, int _v2)
        {
            _a = _v1;
            _b = _v2;
            _c = 0;
        }
        public Equation(int _v1, int _v2, int _v3)
        {
            _a = _v1;
            _b = _v2;
            _c = _v3;
        }
        public static Equation operator +(Equation ec, int value)
        {
            ec.C += value;
            return ec;
        }
        public static Equation operator +(Equation ec1, Equation ec2)
        {
            ec1.A += ec2.A;
            ec1.B += ec2.B;
            ec1.C += ec2.C;
            return ec1;
        }
        public static Equation operator -(Equation ec, int value)
        {
            ec.C -= value;
            return ec;
        }
        public static Equation operator -(Equation ec1, Equation ec2)
        {
            ec1.A -= ec2.A;
            ec1.B -= ec2.B;
            ec1.C -= ec2.C;
            return ec1;
        }
        public static Equation operator ++(Equation ec)
        {
            ec.C++;
            return ec;
        }
        public static Equation operator --(Equation ec1)
        {
            ec1.C--;
            return ec1;
        }
        public static Equation operator *(Equation ec, int value)
        {
            ec.A *= value;
            ec.B *= value;
            ec.C *= value;
            return ec;
        }
        public static Equation operator /(Equation ec, int value)
        {
            ec.A /= value;
            ec.B /= value;
            ec.C /= value;
            return ec;
        }

        public static explicit operator double(Equation ec)
        {
            return ec.A;
        }

        public static explicit operator Equation(int a)
        {
            return new Equation(a, a, a);
        }

        public static bool operator true(Equation ec)
          
        => ec.B*ec.B - 4 * ec.A * ec.C >= 0;
        
        

        public static bool operator false(Equation ec)
            => ec.B - 4 * ec.A * ec.C < 0;
        

        public static bool operator ==(Equation ec1, Equation ec2)
        {
            return (ec1.A == ec1.A && ec1.B == ec2.B && ec2.C == ec1.C);
        }

        public static bool operator !=(Equation ec1, Equation ec2)
        {
            return (ec1.A != ec1.A || ec1.B != ec2.B || ec2.C != ec1.C);
        }


        public new string ToString()
        {
            string str = "";
            if (_a != 0) str += _a.ToString() + "x^2 ";
            else str = "0 ";
            if (_b != 0 && _b > 0) str += "+ " + _b.ToString() + "x ";
            else if (_b != 0 && _b < 0) str += "- " + (-_b).ToString() + "x ";
            if (_c != 0 && _c > 0) str += "+ " + _c.ToString();
            else if (_c != 0 && _c < 0) str += "- " + (-_c).ToString();
            if (str == "") str = "0X^2 + 0x + 0";

            str += " = 0";

            return str;
        }

        public string Solve()
        {
            string str = "";

            if (_a == 0 && _b == 0 && _c == 0) str = "Equation: " + this.ToString() + " \nhas infinity of roots";
            if (_a != 0 && _b != 0 && _c == 0) str = "Equation: " + this.ToString() + "\nroot 1: 0\nroot 2: " + (-_b*1.0 / _a).ToString();
            if (_a != 0 && _c != 0 && _b == 0)
            {
                if (-_c*1.0 / _a > 0) str = "Equation: " + this.ToString() + "\nroot 1: " + Math.Sqrt(-_c*1.0 / _a).ToString() + "\nroot 2: -" + Math.Sqrt(-_c*1.0 / _a).ToString();
                else str = "Equation: " + this.ToString() + " \nhas no roots";
            }
            if (_a == 0 && _b != 0 && _c != 0) str = "Equation: " + this.ToString() + "\nroot: " + (-_c *1.0 / _b).ToString();
            if ((_a != 0 && _b == 0 && _c == 0) || (_a == 0 && _b != 0 && _c == 0)) str = "Equation: " + this.ToString() + "\nroot: 0";
            if (_a == 0 && _b == 0 && _c != 0) str = "Equation: " + this.ToString() + " \nhas no roots";
            if (_a != 0 && _b != 0 && _c != 0)
            {
                double D = _b * _b - 4 * _a * _c;
                if (D < 0) str = "Equation: " + this.ToString() + " \nhas no roots";
                else if (D == 0) str = "Equation: " + this.ToString() + "\nroot: " + (-_b *1.0 / (2 * _a)).ToString();
                else if (D>0) str = str = "Equation: " + this.ToString() + "\nroot 1: " + ((-_b + Math.Sqrt(D))/(2*_a)).ToString() + "\nroot 2: " + ((-_b - Math.Sqrt(D))/(2*_a)).ToString();
            }


            return str;
        }

    }
}
