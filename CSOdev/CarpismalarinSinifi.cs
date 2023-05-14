using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOdev
{
    static class CarpismalarinSinifi
    {
        static public bool noktaDikdortgenCarpismaDenetimi(Nokta nokta, Dortgen dortgen)
        {
            double noktaDortgenUzaklik = Math.Sqrt(Math.Pow((dortgen.init_Dortgen_Y - nokta.init_Nokta_Y),2)+Math.Pow((dortgen.init_Dortgen_X - nokta.init_Nokta_X),2));
            if (Math.Abs(nokta.init_Nokta_X-dortgen.init_Dortgen_X) < dortgen.init_Dortgen_Genislik / 2 && Math.Abs(nokta.init_Nokta_Y-dortgen.init_Dortgen_Y) < dortgen.init_Dortgen_Yukseklik / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool dortgenDortgenCarpismaDenetimi(Dortgen dortgen1, Dortgen dortgen2)
        {
            double dortgen1MerkezX = dortgen1.init_Dortgen_X;
            double dortgen1MerkezY = dortgen1.init_Dortgen_Y;
            double dortgen2MerkezX = dortgen2.init_Dortgen_X;
            double dortgen2MerkezY = dortgen2.init_Dortgen_Y;
            double dortgenDortgenUzaklik = Math.Sqrt(Math.Pow(dortgen2MerkezY - dortgen1MerkezY, 2) + Math.Pow(dortgen2MerkezX - dortgen1MerkezX, 2));
            if (Math.Abs(dortgen1MerkezX-dortgen2MerkezX) < dortgen1.init_Dortgen_Genislik / 2 + dortgen2.init_Dortgen_Genislik / 2 && Math.Abs(dortgen1MerkezY-dortgen2MerkezY) < dortgen1.init_Dortgen_Yukseklik / 2 + dortgen2.init_Dortgen_Yukseklik / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool dortgenCemberCarpismaDenetimi(Dortgen dortgen, Cember cember)
        {
            double dortgenMerkezX = dortgen.init_Dortgen_X;
            double dortgenMerkezY = dortgen.init_Dortgen_Y;
            double dortgenCemberUzaklik = Math.Sqrt(Math.Pow(cember.init_Cember_Y - dortgenMerkezY, 2) + Math.Pow(cember.init_Cember_X - dortgenMerkezX, 2));
            if (Math.Abs(dortgenMerkezX-cember.init_Cember_X) < cember.init_Cember_YariCap / 2 + dortgen.init_Dortgen_Genislik / 2 && Math.Abs(dortgenMerkezY-cember.init_Cember_Y) < cember.init_Cember_YariCap / 2 + dortgen.init_Dortgen_Yukseklik / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool noktaCemberCarpismaDenetimi(Nokta nokta, Cember cember)
        {
            double noktaCemberUzaklik = Math.Sqrt(Math.Pow(cember.init_Cember_Y-nokta.init_Nokta_Y, 2) + Math.Pow(cember.init_Cember_X - nokta.init_Nokta_X, 2));
            if (noktaCemberUzaklik < cember.init_Cember_YariCap / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool cemberCemberCarpismaDenetimi(Cember cember1, Cember cember2)
        {
            double cemberCemberUzaklik = Math.Sqrt(Math.Pow(cember1.init_Cember_Y-cember2.init_Cember_Y,2)+Math.Pow(cember1.init_Cember_X-cember2.init_Cember_X,2));
            if (cemberCemberUzaklik < cember1.init_Cember_YariCap / 2 + cember2.init_Cember_YariCap / 2)
            {
                return true;
            }
            else { return false; }
        }

        static public bool noktaKureCarpismaDenetimi(Nokta3d nokta3d, Kure kure)
        {
            double noktaKureUzaklik = Math.Sqrt(Math.Pow(kure.init_Kure_Y - nokta3d.init_Nokta3d_Y, 2) + Math.Pow(kure.init_Kure_X - nokta3d.init_Nokta3d_X, 2)+Math.Pow(kure.init_Kure_Z-nokta3d.init_Nokta3d_Z,2));
            if (noktaKureUzaklik < kure.init_Kure_YariCap / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool kureKureCarpismaDenetimi(Kure kure1, Kure kure2)
        {
            double kureKureUzaklik = Math.Sqrt(Math.Pow(kure1.init_Kure_Y - kure2.init_Kure_Y, 2) + Math.Pow(kure1.init_Kure_X - kure2.init_Kure_X, 2) + Math.Pow(kure1.init_Kure_Z - kure2.init_Kure_Z, 2));
            if (kureKureUzaklik < kure1.init_Kure_YariCap / 2 + kure2.init_Kure_YariCap / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool kureSilindirCarpismaDenetimi(Kure kure, Silindir silindir)
        {
            double silindirMerkezZ = silindir.init_Silindir_Z + silindir.init_Silindir_Yukseklik / 2;
            double kureSilindirUzaklik = Math.Sqrt(Math.Pow(kure.init_Kure_Z - silindirMerkezZ,2) + Math.Pow(kure.init_Kure_Y - silindir.init_Silindir_Y,2)+Math.Pow(kure.init_Kure_X - silindir.init_Silindir_X,2));
            if (kureSilindirUzaklik < kure.init_Kure_YariCap + silindir.init_Silindir_YariCap && kureSilindirUzaklik < kure.init_Kure_YariCap + silindir.init_Silindir_Yukseklik / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool noktaSilindirCarpismaDenetimi(Nokta3d nokta3d, Silindir silindir)
        {
            double silindirMerkezZ = silindir.init_Silindir_Z;
            double noktaSilindirUzaklik = Math.Sqrt(Math.Pow(nokta3d.init_Nokta3d_Z - silindirMerkezZ, 2) + Math.Pow(nokta3d.init_Nokta3d_Y - silindir.init_Silindir_Y, 2) + Math.Pow(nokta3d.init_Nokta3d_X - silindir.init_Silindir_X, 2));
            if (Math.Abs(nokta3d.init_Nokta3d_X-silindir.init_Silindir_X) < silindir.init_Silindir_YariCap / 2 && Math.Abs(nokta3d.init_Nokta3d_Y - silindir.init_Silindir_Y)  < silindir.init_Silindir_YariCap / 2 && Math.Abs(nokta3d.init_Nokta3d_Z - silindir.init_Silindir_Z) < silindir.init_Silindir_Yukseklik / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool silindirSilindirCarpismaDenetimi(Silindir silindir1, Silindir silindir2)
        {
            double silindir1MerkezZ = silindir1.init_Silindir_Z + silindir1.init_Silindir_Yukseklik / 2;
            double silindir2MerkezZ = silindir2.init_Silindir_Z + silindir2.init_Silindir_Yukseklik / 2;
            double noktaSilindirUzaklik = Math.Sqrt(Math.Pow(silindir2MerkezZ - silindir1MerkezZ, 2) + Math.Pow(silindir1.init_Silindir_Y - silindir1.init_Silindir_Y, 2) + Math.Pow(silindir2.init_Silindir_X - silindir1.init_Silindir_X, 2));
            if (Math.Abs(silindir1.init_Silindir_X - silindir2.init_Silindir_X) < silindir1.init_Silindir_YariCap / 2 + silindir2.init_Silindir_YariCap / 2 && Math.Abs(silindir1.init_Silindir_Y - silindir2.init_Silindir_Y) < silindir1.init_Silindir_YariCap / 2 + silindir2.init_Silindir_YariCap / 2 && Math.Abs(silindir1.init_Silindir_Z - silindir2.init_Silindir_Z) < silindir1.init_Silindir_Yukseklik / 2 + silindir2.init_Silindir_Yukseklik / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool yuzeyKureCarpismaDenetimi(Yuzey yuzey, Kure kure)
        {
            double yuzeyMerkezY = yuzey.init_Yuzey_Y + yuzey.init_Yuzey_Genislik / 2;
            double yuzeyMerkezZ = yuzey.init_Yuzey_Z - yuzey.init_Yuzey_Yukseklik / 2;
            double yuzeyKureUzaklik = Math.Sqrt(Math.Pow(yuzeyMerkezZ - kure.init_Kure_Z,2)+Math.Pow(yuzeyMerkezY - kure.init_Kure_Y,2)+Math.Pow(yuzey.init_Yuzey_X - kure.init_Kure_X,2));
            if (yuzeyKureUzaklik < kure.init_Kure_YariCap)
            {
                return true;
            }
            else { return false; }
        }
        static public bool yuzeyDikdortgenPrizmaCarpismaDenetimi(Yuzey yuzey, DikdortgenPrizma dikdortgenPrizma)
        {
            double yuzeyMerkezY = yuzey.init_Yuzey_Y + yuzey.init_Yuzey_Genislik / 2;
            double yuzeyMerkezZ = yuzey.init_Yuzey_Z - yuzey.init_Yuzey_Yukseklik / 2;
            double dikdortgenPrizmaMerkezX = dikdortgenPrizma.init_DikdortgenPrizma_X + dikdortgenPrizma.init_DikdortgenPrizma_En / 2;
            double dikdortgenPrizmaMerkezY = dikdortgenPrizma.init_DikdortgenPrizma_Y - dikdortgenPrizma.init_DikdortgenPrizma_Genislik / 2;
            double dikdortgenPrizmaMerkezZ = dikdortgenPrizma.init_DikdortgenPrizma_Z - dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik / 2;
            double yuzeyDikdortgenPrizmaUzaklik = Math.Sqrt(Math.Pow(dikdortgenPrizmaMerkezZ-yuzeyMerkezZ,2)+Math.Pow(dikdortgenPrizmaMerkezY-yuzeyMerkezY,2)+Math.Pow(dikdortgenPrizmaMerkezX-yuzey.init_Yuzey_X,2));
            if (yuzeyDikdortgenPrizmaUzaklik < yuzey.init_Yuzey_Genislik / 2 + dikdortgenPrizma.init_DikdortgenPrizma_Genislik / 2 && yuzeyDikdortgenPrizmaUzaklik < yuzey.init_Yuzey_Yukseklik / 2 + dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik / 2 && yuzeyDikdortgenPrizmaUzaklik < dikdortgenPrizma.init_DikdortgenPrizma_En / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool yuzeySilindirCarpismaDenetimi(Yuzey yuzey, Silindir silindir)
        {
            double yuzeyMerkezY = yuzey.init_Yuzey_Y + yuzey.init_Yuzey_Genislik / 2;
            double yuzeyMerkezZ = yuzey.init_Yuzey_Z - yuzey.init_Yuzey_Yukseklik / 2;
            double silindir1MerkezZ = silindir.init_Silindir_Z + silindir.init_Silindir_Yukseklik / 2;
            double yuzeySilindirUzaklik = Math.Sqrt(Math.Pow(silindir1MerkezZ - yuzeyMerkezZ,2)+Math.Pow(silindir.init_Silindir_Y - yuzeyMerkezY,2)+Math.Pow(silindir.init_Silindir_X - yuzey.init_Yuzey_X,2));
            if (yuzeySilindirUzaklik < yuzey.init_Yuzey_Yukseklik / 2 + silindir.init_Silindir_Yukseklik / 2 && yuzeySilindirUzaklik < yuzey.init_Yuzey_Genislik / 2 + silindir.init_Silindir_YariCap)
            {
                return true;
            }
            else { return false; }
        }
        static public bool kureDikdortgenPrizmaCarpismaDenetimi(Kure kure, DikdortgenPrizma dikdortgenPrizma)
        {
            double dikdortgenPrizmaMerkezX = dikdortgenPrizma.init_DikdortgenPrizma_X + dikdortgenPrizma.init_DikdortgenPrizma_En / 2;
            double dikdortgenPrizmaMerkezY = dikdortgenPrizma.init_DikdortgenPrizma_Y - dikdortgenPrizma.init_DikdortgenPrizma_Genislik / 2;
            double dikdortgenPrizmaMerkezZ = dikdortgenPrizma.init_DikdortgenPrizma_Z - dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik / 2;
            double kureDikdortgenPrizmaUzaklik = Math.Sqrt(Math.Pow(dikdortgenPrizmaMerkezZ-kure.init_Kure_Z,2)+Math.Pow(dikdortgenPrizmaMerkezY-kure.init_Kure_Y,2)+Math.Pow(dikdortgenPrizmaMerkezX-kure.init_Kure_X,2));
            if (kureDikdortgenPrizmaUzaklik < kure.init_Kure_YariCap + dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik / 2 && kureDikdortgenPrizmaUzaklik < kure.init_Kure_YariCap + dikdortgenPrizma.init_DikdortgenPrizma_Genislik / 2 && kureDikdortgenPrizmaUzaklik < kure.init_Kure_YariCap + dikdortgenPrizma.init_DikdortgenPrizma_En / 2)
            {
                return true;
            }
            else { return false; }
        }
        static public bool dikdortgenPrizmaDikdortgenPrizmaCarpismaDenetimi(DikdortgenPrizma dikdortgenPrizma1, DikdortgenPrizma dikdortgenPrizma2)
        {
            double dikdortgenPrizma1MerkezX = dikdortgenPrizma1.init_DikdortgenPrizma_X + dikdortgenPrizma1.init_DikdortgenPrizma_En / 2;
            double dikdortgenPrizma1MerkezY = dikdortgenPrizma1.init_DikdortgenPrizma_Y - dikdortgenPrizma1.init_DikdortgenPrizma_Genislik / 2;
            double dikdortgenPrizma1MerkezZ = dikdortgenPrizma1.init_DikdortgenPrizma_Z - dikdortgenPrizma1.init_DikdortgenPrizma_Yukseklik / 2;
            double dikdortgenPrizma2MerkezX = dikdortgenPrizma2.init_DikdortgenPrizma_X + dikdortgenPrizma2.init_DikdortgenPrizma_En / 2;
            double dikdortgenPrizma2MerkezY = dikdortgenPrizma2.init_DikdortgenPrizma_Y - dikdortgenPrizma2.init_DikdortgenPrizma_Genislik / 2;
            double dikdortgenPrizma2MerkezZ = dikdortgenPrizma2.init_DikdortgenPrizma_Z - dikdortgenPrizma2.init_DikdortgenPrizma_Yukseklik / 2;
            double dikdortgenPrizmaDikdortgenPrizmaUzaklik = Math.Sqrt(Math.Pow(dikdortgenPrizma2MerkezZ-dikdortgenPrizma1MerkezZ,2)+Math.Pow(dikdortgenPrizma2MerkezY-dikdortgenPrizma1MerkezY,2)+Math.Pow(dikdortgenPrizma2MerkezX-dikdortgenPrizma1MerkezX,2));
            if (dikdortgenPrizmaDikdortgenPrizmaUzaklik < dikdortgenPrizma1.init_DikdortgenPrizma_Yukseklik / 2 + dikdortgenPrizma2.init_DikdortgenPrizma_Yukseklik / 2 && dikdortgenPrizmaDikdortgenPrizmaUzaklik < dikdortgenPrizma1.init_DikdortgenPrizma_Genislik / 2 + dikdortgenPrizma2.init_DikdortgenPrizma_Genislik / 2 && dikdortgenPrizmaDikdortgenPrizmaUzaklik < dikdortgenPrizma1.init_DikdortgenPrizma_En / 2 + dikdortgenPrizma2.init_DikdortgenPrizma_En / 2)
            {
                return true;
            }
            else { return false; }
        }
    }
}
