using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class Kure
    {
        private double X;
        private double Y;
        private double Z;
        private double yariCap;

        public Kure()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
            this.yariCap = 0;
        }

        public Kure(Nokta3d nokta3d, double yariCap)
        {
            this.X = nokta3d.init_Nokta3d_X;
            this.Y = nokta3d.init_Nokta3d_Y;
            this.Z = nokta3d.init_Nokta3d_Z;
            this.yariCap = yariCap;
        }
        public double init_Kure_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_Kure_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public double init_Kure_Z
        {
            get { return this.Z; }
            set { this.Z = value; }
        }
        public double init_Kure_YariCap
        {
            get { return this.yariCap; }
            set { this.yariCap = value; }
        }
    }
}
