using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class Dortgen
    {
        private double X;
        private double Y;
        private double Yukseklik;
        private double Genislik;
        public Dortgen()
        {
            this.X = 0;
            this.Y = 0;
            this.Yukseklik = 0;
            this.Genislik = 0;
        }
        public Dortgen(Nokta nokta, double yukseklik, double genislik)
        {
            this.X = nokta.init_Nokta_X;
            this.Y = nokta.init_Nokta_Y;
            this.Yukseklik = yukseklik;
            this.Genislik = genislik;
        }
        public double init_Dortgen_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_Dortgen_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public double init_Dortgen_Yukseklik
        {
            get { return this.Yukseklik; }
            set { this.Yukseklik = value; }
        }
        public double init_Dortgen_Genislik
        {
            get { return this.Genislik; }
            set { this.Genislik = value; }
        }
    }
}
