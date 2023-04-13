using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практика_16_построение_графиков_функций
{
    abstract class Function
    {
        public double x = 0;
        public double y = 0;
        public Function(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        abstract public double Draw();
    }
    class Giperbola : Function
    {
        private double A { get; set; }
        public Giperbola( double x,double A) : base(x, y: 0)
        {
            this.A = A;
        }


        public override double Draw()
        {
            return y = A / x;
        }
    }
    class Parabola : Function
    {
        private double A { get; set; }
        private double B { get; set; }
        private double c { get; set; }
        public Parabola(double x, double A, double B, double c) : base(x, y: 0)
        {
            this.A = A;
            this.B = B;
            this.c = c;
        }
        public override double Draw()
        {
            return y = A * Math.Pow(x, 2) + B * x + c;
        }
    }
    class Round : Function
    {
        private double r { get; set; }
        public Round(double x, double r) : base(x, y: 0) {
            this.r = r;
        }
        public override double Draw() {
            return y = +(Math.Sqrt(r * r - Math.Pow(x, 2)));
        }
    }
}
