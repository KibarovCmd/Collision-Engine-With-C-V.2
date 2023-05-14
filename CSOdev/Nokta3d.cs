using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class Nokta3d
    {
        private double X;
        private double Y;
        private double Z;
        public Nokta3d()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public Nokta3d(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double init_Nokta3d_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_Nokta3d_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public double init_Nokta3d_Z
        {
            get { return this.Z; }
            set { this.Z = value; }
        }
    }
}
