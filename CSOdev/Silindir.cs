using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class Silindir
    {
        private double X;
        private double Y;
        private double Z;
        private double yariCap;
        private double yukseklik;

        public Silindir()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
            this.yariCap = 0;
            this.yukseklik = 0;
        }

        public Silindir(Nokta3d nokta3d, double yariCap, double yukseklik)
        {
            this.X = nokta3d.init_Nokta3d_X;
            this.Y = nokta3d.init_Nokta3d_Y;
            this.Z = nokta3d.init_Nokta3d_Z;
            this.yariCap = yariCap;
            this.yukseklik = yukseklik;
        }

        public double init_Silindir_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_Silindir_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public double init_Silindir_Z
        {
            get { return this.Z; }
            set { this.Z = value; }
        }
        public double init_Silindir_YariCap
        {
            get { return this.yariCap; }
            set { this.yariCap = value; }
        }
        public double init_Silindir_Yukseklik
        {
            get { return this.yukseklik; }
            set { this.yukseklik = value; }
        }
    }
}
