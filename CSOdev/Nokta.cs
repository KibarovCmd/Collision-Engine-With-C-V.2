using CSOdev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class Nokta
    {
        private double X;
        private double Y;
        public Nokta()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Nokta(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double init_Nokta_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_Nokta_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
    }
}

