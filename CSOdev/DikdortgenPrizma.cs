using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class DikdortgenPrizma
    {
        private double X;
        private double Y;
        private double Z;
        private double genislik;
        private double yukseklik;
        private double en;

        public DikdortgenPrizma()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
            this.genislik = 0;
            this.yukseklik = 0;
            this.en = 0;
        }

        public DikdortgenPrizma(Nokta3d nokta3d, double genislik, double yukseklik, double en)
        {
            this.X = nokta3d.init_Nokta3d_X;
            this.Y = nokta3d.init_Nokta3d_Y;
            this.Z = nokta3d.init_Nokta3d_Z;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.en = en;
        }

        public double init_DikdortgenPrizma_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_DikdortgenPrizma_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public double init_DikdortgenPrizma_Z
        {
            get { return this.Z; }
            set { this.Z = value; }
        }
        public double init_DikdortgenPrizma_Genislik
        {
            get { return this.genislik; }
            set { this.genislik = value; }
        }
        public double init_DikdortgenPrizma_Yukseklik
        {
            get { return this.yukseklik; }
            set { this.yukseklik = value; }
        }
        public double init_DikdortgenPrizma_En
        {
            get { return this.en; }
            set { this.en = value; }
        }
    }
}
