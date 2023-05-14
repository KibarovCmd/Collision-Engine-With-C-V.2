using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    class Cember
    {
        private double X;
        private double Y;
        private double yariCap;
        public Cember()
        {
            this.X = 0;
            this.Y = 0;
            this.yariCap = 0;
        }
        public Cember(Nokta nokta, double yaricap)
        {
            this.X = nokta.init_Nokta_X;
            this.Y = nokta.init_Nokta_Y;
            this.yariCap = yaricap;
        }
        public double init_Cember_X
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double init_Cember_Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public double init_Cember_YariCap
        { 
            get { return this.yariCap; }
            set { this.yariCap = value; }
        }
    }
}
