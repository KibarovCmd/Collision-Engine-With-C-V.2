using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class Yuzey
    {
        private double X;
        private double Y;
        private double Z;
        private double genislik;
        private double yukseklik;

        public Yuzey()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
            this.genislik = 0;
            this.yukseklik = 0;
        }

        public Yuzey(Nokta3d nokta3d, double genislik, double yukseklik)
        {
            this.X = nokta3d.init_Nokta3d_X;
            this.Y = nokta3d.init_Nokta3d_Y;
            this.Z = nokta3d.init_Nokta3d_Z;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
        public double init_Yuzey_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_Yuzey_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public double init_Yuzey_Z
        {
            get { return this.Z; }
            set { this.Z = value; }
        }
        public double init_Yuzey_Genislik
        {
            get { return this.genislik; }
            set { this.genislik = value; }
        }
        public double init_Yuzey_Yukseklik
        {
            get { return this.yukseklik; }
            set { this.yukseklik = value; }
        }
    }
}
