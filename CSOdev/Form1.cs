using System;
using System.Collections;
using System.Drawing;
namespace CSOdev
{
    public partial class Form1 : Form
    {
        string text1, text2, text3, text4, text5, text6, text7, text8, text9, text10, text11, text12, text13, text14;
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Paint += panel1_PaintTemizleme;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            button1.Click += Button_ClickEvent;
        }
        private void one(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 100);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(nokta10);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (Nokta nokta in arrayList)
            {
                g2.DrawRectangle(pen, Convert.ToInt32(nokta.init_Nokta_X), Convert.ToInt32(nokta.init_Nokta_Y), 1, 1);
            }
        }
        private void two(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 100);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(dortgen30);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (Dortgen dortgen in arrayList)
            {
                g2.DrawRectangle(pen, Convert.ToInt32(dortgen.init_Dortgen_X - dortgen.init_Dortgen_Genislik / 2) , Convert.ToInt32(dortgen.init_Dortgen_Y - dortgen.init_Dortgen_Yukseklik / 2) , Convert.ToInt32(dortgen.init_Dortgen_Genislik),Convert.ToInt32(dortgen.init_Dortgen_Yukseklik));
            }
        }
        private void three(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 100);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(cember30);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (Cember cember in arrayList)
            {
                g2.DrawEllipse(pen, Convert.ToInt32(cember.init_Cember_X) - Convert.ToInt32(cember.init_Cember_YariCap) / 2, Convert.ToInt32(cember.init_Cember_Y) - Convert.ToInt32(cember.init_Cember_YariCap) / 2, Convert.ToInt32(cember.init_Cember_YariCap), Convert.ToInt32(cember.init_Cember_YariCap));
            }
        }
        private void four(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 100);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(kure30);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (Kure kure in arrayList)
            {
                g2.DrawEllipse(pen, Convert.ToInt32(kure.init_Kure_X) - Convert.ToInt32(kure.init_Kure_YariCap) / 2, Convert.ToInt32(kure.init_Kure_Y) - Convert.ToInt32(kure.init_Kure_YariCap) / 2, Convert.ToInt32(kure.init_Kure_YariCap), Convert.ToInt32(kure.init_Kure_YariCap));
                g3.DrawArc(pen, Convert.ToInt32(kure.init_Kure_X) - Convert.ToInt32(kure.init_Kure_YariCap) / 2, Convert.ToInt32(kure.init_Kure_Y) - Convert.ToInt32(kure.init_Kure_YariCap) / 12, Convert.ToInt32(kure.init_Kure_YariCap), Convert.ToInt32(kure.init_Kure_YariCap) / 6, 180, 360);
            }
        }
        private void five(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 100);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(silindir10);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (Silindir silindir in arrayList)
            {
                g2.DrawEllipse(pen, Convert.ToInt32(silindir.init_Silindir_X) - Convert.ToInt32(silindir.init_Silindir_YariCap) / 2, Convert.ToInt32(silindir.init_Silindir_Y) - Convert.ToInt32(silindir.init_Silindir_YariCap) / 2, Convert.ToInt32(silindir.init_Silindir_YariCap), Convert.ToInt32(silindir.init_Silindir_YariCap));
                g3.DrawEllipse(pen, Convert.ToInt32(silindir.init_Silindir_X) - Convert.ToInt32(silindir.init_Silindir_YariCap) / 4, Convert.ToInt32(silindir.init_Silindir_Y) - Convert.ToInt32(silindir.init_Silindir_YariCap) / 4, Convert.ToInt32(silindir.init_Silindir_YariCap) / 2, Convert.ToInt32(silindir.init_Silindir_YariCap) / 2);
            }
        }
        private void six(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 100);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(dikdortgenPrizma30);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            var g6 = e.Graphics;
            var g7 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (DikdortgenPrizma dikdortgenPrizma in arrayList)
            {
                g2.DrawRectangle(pen, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik), Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik));
                g3.DrawRectangle(pen, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2 + 10, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2 + 10, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) - 20, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) - 20);
                g4.DrawLine(pen, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2 + 10, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2 + 10);
                g5.DrawLine(pen, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik), Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) - 10, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2 + 10);
                g6.DrawLine(pen, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik), Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2 + 10, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) - 10);
                g7.DrawLine(pen, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik), Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik), Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_X) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Genislik) - 10, Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Y) - Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) / 2 + Convert.ToInt32(dikdortgenPrizma.init_DikdortgenPrizma_Yukseklik) - 10);
            }
        }
        private void seven(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 100);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(yuzey10);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (Yuzey yuzey in arrayList)
            {
                g2.DrawLine(pen, Convert.ToInt32(yuzey.init_Yuzey_X), Convert.ToInt32(yuzey.init_Yuzey_Y) - 50, Convert.ToInt32(yuzey.init_Yuzey_X), Convert.ToInt32(yuzey.init_Yuzey_Y + 50));
            }
        }
        private void eight(object sender, PaintEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            Nokta nokta10 = new Nokta(100, 387);
            Nokta3d nokta20 = new Nokta3d(100, 387, 0);
            Dortgen dortgen30 = new Dortgen(nokta10, 100, 140);
            Cember cember30 = new Cember(nokta10, 100);
            DikdortgenPrizma dikdortgenPrizma30 = new DikdortgenPrizma(nokta20, 100, 100, 100);
            Kure kure30 = new Kure(nokta20, 100);
            Silindir silindir10 = new Silindir(nokta20, 100, 100);
            Yuzey yuzey10 = new Yuzey(nokta20, 100, 100);
            arrayList.Add(dortgen30);
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 200, 300, 400);
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            foreach (Dortgen dortgen in arrayList)
            {
                g2.DrawRectangle(pen, Convert.ToInt32(dortgen.init_Dortgen_X - dortgen.init_Dortgen_Genislik / 2), Convert.ToInt32(dortgen.init_Dortgen_Y - dortgen.init_Dortgen_Yukseklik / 2), Convert.ToInt32(dortgen.init_Dortgen_Genislik), Convert.ToInt32(dortgen.init_Dortgen_Yukseklik));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Paint += one;
            this.Invalidate();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Paint += three;
            this.Invalidate();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Paint += two;
            this.Invalidate();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Paint += four;
            this.Invalidate();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Paint += five;
            this.Invalidate();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Paint += six;
            this.Invalidate();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Paint += seven;
            this.Invalidate();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Paint += eight;
            this.Invalidate();
        }
        private void panel1_DrawRadioButton1Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            Pen pen = new Pen(Color.White,1);
            int yeniYEkseni1 = 487 - Convert.ToInt32(textBox2.Text);
            int yeniYEkseni2Veri = 487 - Convert.ToInt32(textBox5.Text);
            int yeniXEkseni1 = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox12.Text) / 2;
            int yeniYEkseni2 = yeniYEkseni2Veri - Convert.ToInt32(textBox11.Text) / 2;
            g.DrawRectangle(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni1, 1, 1);
            g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text));
            g3.DrawRectangle(pen, Convert.ToInt32(textBox4.Text), yeniYEkseni2Veri, 1, 1);
        }
        private void panel1_DrawRadioButton2Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            g.DrawRectangle(pen, Convert.ToInt32(textBox1.Text), 487 - Convert.ToInt32(textBox2.Text), 1, 1);
            g2.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox14.Text) / 2, (487 - Convert.ToInt32(textBox5.Text)) - Convert.ToInt32(textBox14.Text) / 2, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox14.Text));
        }
        private void panel1_DrawRadioButton3Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            int yeniYEkseni1Veri = 487 - Convert.ToInt32(textBox2.Text);
            int yeniXEkseni1 = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox8.Text) / 2;
            int yeniYEkseni1 = yeniYEkseni1Veri - Convert.ToInt32(textBox7.Text) / 2;
            int yeniYEkseni2Veri = 487 - Convert.ToInt32(textBox5.Text);
            int yeniXEkseni2 = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox12.Text) / 2;
            int yeniYEkseni2 = yeniYEkseni2Veri - Convert.ToInt32(textBox11.Text) / 2;
            g.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni1, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text));
            g2.DrawRectangle(pen, yeniXEkseni2, yeniYEkseni2, Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text));
        }
        private void panel1_DrawRadioButton4Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            int yeniYEkseniVeri = 487 - Convert.ToInt32(textBox2.Text);
            int yeniXEkseni = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox8.Text)/2;
            int yeniYEkseni = yeniYEkseniVeri - Convert.ToInt32(textBox7.Text) / 2;
            g.DrawRectangle(pen, yeniXEkseni, yeniYEkseni, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text));
            g2.DrawEllipse(pen, Convert.ToInt32(textBox4.Text)-Convert.ToInt32(textBox14.Text)/2, (487-Convert.ToInt32(textBox5.Text))-Convert.ToInt32(textBox14.Text)/2, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox14.Text));
        }
        private void panel1_DrawRadioButton5Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            g.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox10.Text) / 2, (487 - Convert.ToInt32(textBox2.Text)) - Convert.ToInt32(textBox10.Text) / 2, Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox10.Text));
            g2.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox14.Text) / 2, (487 - Convert.ToInt32(textBox5.Text)) - Convert.ToInt32(textBox14.Text) / 2, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox14.Text));
        }
        private void panel1_DrawRadioButton6Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int yeniYEkseni1 = 487 - Convert.ToInt32(textBox2.Text);
            g2.DrawRectangle(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni1, 1, 1);
            int zEkseniVeri = Convert.ToInt32(textBox6.Text)+1;
            int yariCapVeri = Convert.ToInt32(textBox14.Text)/zEkseniVeri;
            if (yariCapVeri / 6 == 0)
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
            }
            else
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g4.DrawArc(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 12, yariCapVeri, yariCapVeri / 6, 180, 360);
            }
        }
        private void panel1_DrawRadioButton7Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            int yeniYEkseni1 = 487 - Convert.ToInt32(textBox2.Text);
            int yeniYEkseni2Veri = 487 - Convert.ToInt32(textBox5.Text);
            int yeniXEkseni1 = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox12.Text) / 2;
            int yeniYEkseni2 = yeniYEkseni2Veri - Convert.ToInt32(textBox11.Text) / 2;
            g.DrawRectangle(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni1, 1, 1);
            g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text));
            g3.DrawRectangle(pen, Convert.ToInt32(textBox4.Text), yeniYEkseni2Veri, 1, 1);
        }
        private void panel1_DrawRadioButton8Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int yeniYEkseni1 = 487 - Convert.ToInt32(textBox2.Text);
            g2.DrawRectangle(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni1, 1, 1);
            int zEkseniVeri = Convert.ToInt32(textBox6.Text) + 1;
            int yariCapVeri = (Convert.ToInt32(textBox14.Text) / zEkseniVeri);
            int yeniYariCapVeri = yariCapVeri / 2;
            int merkezX = Convert.ToInt32(textBox4.Text) - yariCapVeri / 2;
            int merkezY = (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2;
            if (!(yeniYariCapVeri == 0))
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g4.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yeniYariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yeniYariCapVeri / 2, yeniYariCapVeri, yeniYariCapVeri);
            }
            else
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
            }
        }
        private void panel1_DrawRadioButton9Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            var g6 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int zEkseniVeri = Convert.ToInt32(textBox6.Text) + 1;
            int yariCapVeri = (Convert.ToInt32(textBox14.Text) / zEkseniVeri);
            int yeniYariCapVeri = yariCapVeri / 2;
            int zEkseniVeri2 = Convert.ToInt32(textBox3.Text) + 1;
            int yariCapVeri2 = (Convert.ToInt32(textBox10.Text) / zEkseniVeri2);
            int yeniYariCapVeri2 = yariCapVeri2 / 2;
            if (!(yeniYariCapVeri == 0) && !(yeniYariCapVeri2 == 0))
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g4.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yeniYariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yeniYariCapVeri / 2, yeniYariCapVeri, yeniYariCapVeri);
                g5.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);
                g6.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yeniYariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yeniYariCapVeri2 / 2, yeniYariCapVeri2, yeniYariCapVeri2);
            }
            else
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g5.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);
            }
        }
        private void panel1_DrawRadioButton10Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int zEkseniVeri2 = Convert.ToInt32(textBox3.Text)+1;
            int yariCapVeri2 = Convert.ToInt32(textBox10.Text) / zEkseniVeri2;
            int zEkseniVeri = Convert.ToInt32(textBox6.Text) + 1;
            int yariCapVeri = Convert.ToInt32(textBox14.Text) / zEkseniVeri;
            if (yariCapVeri / 6 == 0 && yariCapVeri2 == 0)
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g2.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);
            }
            else
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g4.DrawArc(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 12, yariCapVeri, yariCapVeri / 6, 180, 360);
                g2.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);
                g5.DrawArc(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 12, yariCapVeri2, yariCapVeri2 / 6, 180, 360);
            }
        }
        private void panel1_DrawRadioButton11Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            var g6 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int zEkseniVeri = Convert.ToInt32(textBox6.Text) + 1;
            int yariCapVeri = Convert.ToInt32(textBox14.Text) / zEkseniVeri;
            int zEkseniVeri2 = Convert.ToInt32(textBox3.Text) + 1;
            int yariCapVeri2 = (Convert.ToInt32(textBox10.Text) / zEkseniVeri2);
            int yeniYariCapVeri2 = yariCapVeri2 / 2;
            if (!(yeniYariCapVeri2 == 0))
            {
                g5.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);
                g6.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yeniYariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yeniYariCapVeri2 / 2, yeniYariCapVeri2, yeniYariCapVeri2);
            }
            else
            {
                g5.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);
            }
            if (yariCapVeri / 6 == 0)
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
            }
            else
            {
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g4.DrawArc(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 12, yariCapVeri, yariCapVeri / 6, 180, 360);
            }
        }
        private void panel1_DrawRadioButton12Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int zEkseniVeri = Convert.ToInt32(textBox6.Text) + 1;
            int yariCapVeri = Convert.ToInt32(textBox14.Text) / zEkseniVeri;
            int yeniYEkseni = 487 - Convert.ToInt32(textBox2.Text);
            int kucultmeBuyutmeDegeri = Convert.ToInt32(textBox8.Text) / 2 - Convert.ToInt32(textBox3.Text) / 4;
            if (yariCapVeri / 6 == 0 )
            {
                g2.DrawLine(pen,Convert.ToInt32(textBox1.Text),yeniYEkseni - kucultmeBuyutmeDegeri, Convert.ToInt32(textBox1.Text),yeniYEkseni + kucultmeBuyutmeDegeri);
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
            }
            else
            {
                g2.DrawLine(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni - kucultmeBuyutmeDegeri, Convert.ToInt32(textBox1.Text), yeniYEkseni + kucultmeBuyutmeDegeri);
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g4.DrawArc(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 12, yariCapVeri, yariCapVeri / 6, 180, 360);
            }
        }
        private void panel1_DrawRadioButton13Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g1 = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            var g6 = e.Graphics;
            var g7 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int yeniYEkseni1 = 487 - Convert.ToInt32(textBox2.Text);
            int yeniYEkseni2Veri = 487 - Convert.ToInt32(textBox5.Text);
            int yeniXEkseni1 = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox12.Text) / 2;
            int yeniYEkseni2 = yeniYEkseni2Veri - Convert.ToInt32(textBox11.Text) / 2;
            int yeniYEkseni = 487 - Convert.ToInt32(textBox2.Text);
            int azaltmaDegeri = Convert.ToInt32(textBox6.Text) / 4;
            yeniXEkseni1 += azaltmaDegeri;
            yeniYEkseni2 += azaltmaDegeri;
            string textbox11 = Convert.ToString(Convert.ToInt32(textBox11.Text) - 2 * azaltmaDegeri);
            string textbox12 = Convert.ToString(Convert.ToInt32(textBox12.Text) - 2 * azaltmaDegeri);
            int kucultmeBuyutmeDegeri = Convert.ToInt32(textBox8.Text) / 2 - Convert.ToInt32(textBox3.Text) / 4;
            if (Convert.ToInt32(textbox11) >= 20)
            {
                g1.DrawLine(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni1 - kucultmeBuyutmeDegeri, Convert.ToInt32(textBox1.Text), yeniYEkseni1 + kucultmeBuyutmeDegeri);
                g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textbox12), Convert.ToInt32(textbox11));
                g3.DrawRectangle(pen, yeniXEkseni1 + 10, yeniYEkseni2 + 10, Convert.ToInt32(textbox12) - 20, Convert.ToInt32(textbox11) - 20);
                g4.DrawLine(pen, yeniXEkseni1, yeniYEkseni2, yeniXEkseni1+10,yeniYEkseni2+10);
                g5.DrawLine(pen,yeniXEkseni1+ Convert.ToInt32(textbox12), yeniYEkseni2, yeniXEkseni1 + Convert.ToInt32(textbox12) - 10,yeniYEkseni2+10);
                g6.DrawLine(pen,yeniXEkseni1,yeniYEkseni2 + Convert.ToInt32(textbox11), yeniXEkseni1+10, yeniYEkseni2 + Convert.ToInt32(textbox11) - 10);
                g7.DrawLine(pen, yeniXEkseni1 + Convert.ToInt32(textbox12), yeniYEkseni2 + Convert.ToInt32(textbox11), yeniXEkseni1 + Convert.ToInt32(textbox12) - 10, yeniYEkseni2 + Convert.ToInt32(textbox11) - 10);
            }
            else
            {
                g1.DrawLine(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni1 - kucultmeBuyutmeDegeri, Convert.ToInt32(textBox1.Text), yeniYEkseni1 + kucultmeBuyutmeDegeri);
                g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textbox12), Convert.ToInt32(textbox11));
            }
        }
        private void panel1_DrawRadioButton14Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int yeniYEkseni = 487 - Convert.ToInt32(textBox2.Text);
            int zEkseniVeri = Convert.ToInt32(textBox6.Text) + 1;
            int yariCapVeri = (Convert.ToInt32(textBox14.Text) / zEkseniVeri);
            int yeniYariCapVeri = yariCapVeri / 2;
            int kucultmeBuyutmeDegeri = Convert.ToInt32(textBox8.Text) / 2 - Convert.ToInt32(textBox3.Text) / 4;
            if (!(yeniYariCapVeri == 0))
            {
                g2.DrawLine(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni - kucultmeBuyutmeDegeri, Convert.ToInt32(textBox1.Text), yeniYEkseni + kucultmeBuyutmeDegeri);
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
                g4.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yeniYariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yeniYariCapVeri / 2, yeniYariCapVeri, yeniYariCapVeri);
            }
            else
            {
                g2.DrawLine(pen, Convert.ToInt32(textBox1.Text), yeniYEkseni - kucultmeBuyutmeDegeri, Convert.ToInt32(textBox1.Text), yeniYEkseni + kucultmeBuyutmeDegeri);
                g3.DrawEllipse(pen, Convert.ToInt32(textBox4.Text) - yariCapVeri / 2, (487 - Convert.ToInt32(textBox5.Text)) - yariCapVeri / 2, yariCapVeri, yariCapVeri);
            }
        }
        private void panel1_DrawRadioButton15Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g1 = e.Graphics;
            var gyes = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            var g6 = e.Graphics;
            var g7 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int zEkseniVeri2 = Convert.ToInt32(textBox3.Text) + 1;
            int yariCapVeri2 = Convert.ToInt32(textBox10.Text) / zEkseniVeri2;
            int yeniYEkseni1 = 487 - Convert.ToInt32(textBox2.Text);
            int yeniYEkseni2Veri = 487 - Convert.ToInt32(textBox5.Text);
            int yeniXEkseni1 = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox12.Text) / 2;
            int yeniYEkseni2 = yeniYEkseni2Veri - Convert.ToInt32(textBox11.Text) / 2;
            int yeniYEkseni = 487 - Convert.ToInt32(textBox2.Text);
            int azaltmaDegeri = Convert.ToInt32(textBox6.Text) / 4;
            yeniXEkseni1 += azaltmaDegeri;
            yeniYEkseni2 += azaltmaDegeri;
            string textbox11 = Convert.ToString(Convert.ToInt32(textBox11.Text) - 2 * azaltmaDegeri);
            string textbox12 = Convert.ToString(Convert.ToInt32(textBox12.Text) - 2 * azaltmaDegeri);
            if (yariCapVeri2 == 0)
            {
                g1.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);            }
            else
            {
                g1.DrawEllipse(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 2, yariCapVeri2, yariCapVeri2);
                gyes.DrawArc(pen, Convert.ToInt32(textBox1.Text) - yariCapVeri2 / 2, (487 - Convert.ToInt32(textBox2.Text)) - yariCapVeri2 / 12, yariCapVeri2, yariCapVeri2 / 6, 180, 360);
            }
            if (!(Convert.ToInt32(textbox11) >= 20))
            {
                g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textbox12), Convert.ToInt32(textbox11));
            }
            else
            {
                g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textbox12), Convert.ToInt32(textbox11));
                g3.DrawRectangle(pen, yeniXEkseni1 + 10, yeniYEkseni2 + 10, Convert.ToInt32(textbox12) - 20, Convert.ToInt32(textbox11) - 20);
                g4.DrawLine(pen, yeniXEkseni1, yeniYEkseni2, yeniXEkseni1 + 10, yeniYEkseni2 + 10);
                g5.DrawLine(pen, yeniXEkseni1 + Convert.ToInt32(textbox12), yeniYEkseni2, yeniXEkseni1 + Convert.ToInt32(textbox12) - 10, yeniYEkseni2 + 10);
                g6.DrawLine(pen, yeniXEkseni1, yeniYEkseni2 + Convert.ToInt32(textbox11), yeniXEkseni1 + 10, yeniYEkseni2 + Convert.ToInt32(textbox11) - 10);
                g7.DrawLine(pen, yeniXEkseni1 + Convert.ToInt32(textbox12), yeniYEkseni2 + Convert.ToInt32(textbox11), yeniXEkseni1 + Convert.ToInt32(textbox12) - 10, yeniYEkseni2 + Convert.ToInt32(textbox11) - 10);
            }
        }
        private void panel1_DrawRadioButton16Checked(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var g2 = e.Graphics;
            var g3 = e.Graphics;
            var g4 = e.Graphics;
            var g5 = e.Graphics;
            var g6 = e.Graphics;
            var g7 = e.Graphics;
            var g8 = e.Graphics;
            var g9 = e.Graphics;
            var g10 = e.Graphics;
            var g11 = e.Graphics;
            var g12 = e.Graphics;
            var g13 = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            Font font = new Font("Niagara Solid", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("Z Ekseni Ekrandan Ýceri Dogrudur Yani Maksimum 0 Olabilir", font, brush, 320, 455, drawFormat);
            int yeniYEkseni2Veri = 487 - Convert.ToInt32(textBox5.Text);
            int yeniXEkseni1 = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox12.Text) / 2;
            int yeniYEkseni2 = yeniYEkseni2Veri - Convert.ToInt32(textBox11.Text) / 2;
            int azaltmaDegeri = Convert.ToInt32(textBox6.Text) / 4;
            yeniXEkseni1 += azaltmaDegeri;
            yeniYEkseni2 += azaltmaDegeri;
            string textbox11 = Convert.ToString(Convert.ToInt32(textBox11.Text) - 2 * azaltmaDegeri);
            string textbox12 = Convert.ToString(Convert.ToInt32(textBox12.Text) - 2 * azaltmaDegeri);

            int yeniYEkseni2Veri2 = 487 - Convert.ToInt32(textBox2.Text);
            int yeniXEkseni2 = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox8.Text) / 2;
            int yeniYEkseni22 = yeniYEkseni2Veri2 - Convert.ToInt32(textBox7.Text) / 2;
            int azaltmaDegeri2 = Convert.ToInt32(textBox3.Text) / 4;
            yeniXEkseni2 += azaltmaDegeri2;
            yeniYEkseni22 += azaltmaDegeri2;
            string textbox7 = Convert.ToString(Convert.ToInt32(textBox7.Text) - 2 * azaltmaDegeri2);
            string textbox8 = Convert.ToString(Convert.ToInt32(textBox8.Text) - 2 * azaltmaDegeri2);
            if (!(Convert.ToInt32(textbox11) >= 20))
            {
                g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textbox12), Convert.ToInt32(textbox11));

            }
            else
            {
                g2.DrawRectangle(pen, yeniXEkseni1, yeniYEkseni2, Convert.ToInt32(textbox12), Convert.ToInt32(textbox11));
                g3.DrawRectangle(pen, yeniXEkseni1 + 10, yeniYEkseni2 + 10, Convert.ToInt32(textbox12) - 20, Convert.ToInt32(textbox11) - 20);
                g4.DrawLine(pen, yeniXEkseni1, yeniYEkseni2, yeniXEkseni1 + 10, yeniYEkseni2 + 10);
                g5.DrawLine(pen, yeniXEkseni1 + Convert.ToInt32(textbox12), yeniYEkseni2, yeniXEkseni1 + Convert.ToInt32(textbox12) - 10, yeniYEkseni2 + 10);
                g6.DrawLine(pen, yeniXEkseni1, yeniYEkseni2 + Convert.ToInt32(textbox11), yeniXEkseni1 + 10, yeniYEkseni2 + Convert.ToInt32(textbox11) - 10);
                g7.DrawLine(pen, yeniXEkseni1 + Convert.ToInt32(textbox12), yeniYEkseni2 + Convert.ToInt32(textbox11), yeniXEkseni1 + Convert.ToInt32(textbox12) - 10, yeniYEkseni2 + Convert.ToInt32(textbox11) - 10);
            }
            if (!(Convert.ToInt32(textbox7) >= 20))
            {
                g8.DrawRectangle(pen, yeniXEkseni2, yeniYEkseni22, Convert.ToInt32(textbox8), Convert.ToInt32(textbox7));
            }
            else
            {
                g8.DrawRectangle(pen, yeniXEkseni2, yeniYEkseni22, Convert.ToInt32(textbox8), Convert.ToInt32(textbox7));
                g9.DrawRectangle(pen, yeniXEkseni2 + 10, yeniYEkseni22 + 10, Convert.ToInt32(textbox8) - 20, Convert.ToInt32(textbox7) - 20);
                g10.DrawLine(pen, yeniXEkseni2, yeniYEkseni22, yeniXEkseni2 + 10, yeniYEkseni22 + 10);
                g11.DrawLine(pen, yeniXEkseni2 + Convert.ToInt32(textbox8), yeniYEkseni22, yeniXEkseni2 + Convert.ToInt32(textbox8) - 10, yeniYEkseni22 + 10);
                g12.DrawLine(pen, yeniXEkseni2, yeniYEkseni22 + Convert.ToInt32(textbox7), yeniXEkseni2 + 10, yeniYEkseni22 + Convert.ToInt32(textbox7) - 10);
                g13.DrawLine(pen, yeniXEkseni2 + Convert.ToInt32(textbox8), yeniYEkseni22 + Convert.ToInt32(textbox7), yeniXEkseni2 + Convert.ToInt32(textbox8) - 10, yeniYEkseni22 + Convert.ToInt32(textbox7) - 10);
            }
        }
        private void panel1_PaintTemizleme(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            Brush fill = new SolidBrush(Color.Black);
            g.FillRectangle(fill, 0, 0, 1000, 1000);
        }
        private void Button_ClickEvent(object sender, EventArgs e)
        {
            text1 = textBox1.Text; text2 = textBox2.Text; text3 = textBox3.Text;
            text4 = textBox4.Text; text5 = textBox5.Text;
            text6 = textBox6.Text; text7 = textBox7.Text;
            text8 = textBox8.Text; text9 = textBox9.Text;
            text10 = textBox10.Text; text11 = textBox11.Text;
            text12 = textBox12.Text; text13 = textBox13.Text; text14 = textBox14.Text;
            if (radioButton1.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text4)
                    && Char_SpaceControl(text5) && Char_SpaceControl(text11) && Char_SpaceControl(text12))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton1Checked;
                    Nokta nokta = new Nokta(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
                    Nokta noktaDortgen = new Nokta(Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text));
                    Dortgen dortgen = new Dortgen(noktaDortgen, Convert.ToInt32(textBox11.Text),Convert.ToInt32(textBox12.Text));
                    if (CarpismalarinSinifi.noktaDikdortgenCarpismaDenetimi(nokta, dortgen))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton2.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text4)
                   && Char_SpaceControl(text5) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton2Checked;
                    Nokta nokta = new Nokta(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    Nokta noktaCember = new Nokta(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                    Cember cember = new Cember(noktaCember,Convert.ToInt32(textBox14.Text));
                    if (CarpismalarinSinifi.noktaCemberCarpismaDenetimi(nokta, cember))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else 
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton3.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text4)
                   && Char_SpaceControl(text5) && Char_SpaceControl(text7) && Char_SpaceControl(text8) &&
                   Char_SpaceControl(text11) && Char_SpaceControl(text12))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton3Checked;
                    Nokta noktaDortgen1 = new Nokta(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
                    Nokta noktaDortgen2 = new Nokta(Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text));
                    Dortgen dortgen1 = new Dortgen(noktaDortgen1, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
                    Dortgen dortgen2 = new Dortgen(noktaDortgen2, Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text));
                    if (CarpismalarinSinifi.dortgenDortgenCarpismaDenetimi(dortgen1, dortgen2))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else 
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton4.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text4)
                   && Char_SpaceControl(text5) && Char_SpaceControl(text7) && Char_SpaceControl(text8) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton4Checked;
                    Nokta noktaDortgen = new Nokta(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    Nokta noktaCember = new Nokta(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                    Dortgen dortgen = new Dortgen(noktaDortgen, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
                    Cember cember = new Cember(noktaCember, Convert.ToInt32(textBox14.Text));
                    if (CarpismalarinSinifi.dortgenCemberCarpismaDenetimi(dortgen, cember))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else 
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton5.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text4)
                   && Char_SpaceControl(text5) && Char_SpaceControl(text10) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton5Checked;
                    Nokta noktaCember1 = new Nokta(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
                    Nokta noktaCember2 = new Nokta(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                    Cember cember1 = new Cember(noktaCember1,Convert.ToInt32(textBox10.Text));
                    Cember cember2 = new Cember(noktaCember2, Convert.ToInt32(textBox14.Text));
                    if (CarpismalarinSinifi.cemberCemberCarpismaDenetimi(cember1, cember2))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton6.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton6Checked;
                    Nokta3d nokta3D = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d nokta3DKure = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Kure kure = new Kure(nokta3DKure, Convert.ToInt32(textBox14.Text)) ;
                    if (CarpismalarinSinifi.noktaKureCarpismaDenetimi(nokta3D, kure))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton7.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text4)
                    && Char_SpaceControl(text5) && Char_SpaceControl(text11) && Char_SpaceControl(text12))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton7Checked;
                    Nokta nokta = new Nokta(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    Nokta noktaDortgen = new Nokta(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                    Dortgen dortgen = new Dortgen(noktaDortgen, Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text));
                    if (CarpismalarinSinifi.noktaDikdortgenCarpismaDenetimi(nokta, dortgen))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton8.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6)
                   && Char_SpaceControl(text11) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton8Checked;
                    Nokta3d nokta3D = new Nokta3d(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text));
                    Nokta3d nokta3DSilindir = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Silindir silindir = new Silindir(nokta3DSilindir, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox11.Text));
                    if (CarpismalarinSinifi.noktaSilindirCarpismaDenetimi(nokta3D, silindir))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton9.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6)
                   && Char_SpaceControl(text7) && Char_SpaceControl(text10) && Char_SpaceControl(text11) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton9Checked;
                    Nokta3d nokta3Dsilindir2 = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d nokta3DSilindir = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Silindir silindir2 = new Silindir(nokta3Dsilindir2, Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox7.Text));
                    Silindir silindir = new Silindir(nokta3DSilindir, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox11.Text));
                    if (CarpismalarinSinifi.silindirSilindirCarpismaDenetimi(silindir2, silindir))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton10.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6)
                   && Char_SpaceControl(text10) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton10Checked;
                    Nokta3d kureNokta1 = new Nokta3d(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text));
                    Nokta3d kureNokta2 = new Nokta3d(Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text),Convert.ToInt32(textBox6.Text));
                    Kure kure1 = new Kure(kureNokta1,Convert.ToInt32(textBox10.Text));
                    Kure kure2 = new Kure(kureNokta2,Convert.ToInt32(textBox14.Text));
                    if (CarpismalarinSinifi.kureKureCarpismaDenetimi(kure1, kure2))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else 
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton11.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6) 
                   && Char_SpaceControl(text10) && Char_SpaceControl(text11) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton11Checked;
                    Nokta3d kureNokta = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d silindirNokta = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Kure kure = new Kure(kureNokta,Convert.ToInt32(textBox10.Text));
                    Silindir silindir = new Silindir(silindirNokta,Convert.ToInt32(textBox14.Text),Convert.ToInt32(textBox11.Text));
                    if (CarpismalarinSinifi.kureSilindirCarpismaDenetimi(kure, silindir))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton12.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6)
                   && Char_SpaceControl(text7) && Char_SpaceControl(text8) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton12Checked;
                    Nokta3d yuzeyNokta = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d kureNokta = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Yuzey yuzey = new Yuzey(yuzeyNokta,Convert.ToInt32(textBox8.Text),Convert.ToInt32(textBox7.Text));
                    Kure kure = new Kure(kureNokta, Convert.ToInt32(textBox14.Text));
                    if (CarpismalarinSinifi.yuzeyKureCarpismaDenetimi(yuzey, kure))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton13.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6) && Char_SpaceControl(text7)
                   && Char_SpaceControl(text8) && Char_SpaceControl(text11) && Char_SpaceControl(text12)
                   && Char_SpaceControl(text13))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton13Checked;
                    Nokta3d yuzeyNokta = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d dikdortgen3dNokta = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Yuzey yuzey = new Yuzey(yuzeyNokta, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text));
                    DikdortgenPrizma dikdortgenPrizma = new DikdortgenPrizma(dikdortgen3dNokta,Convert.ToInt32(textBox12.Text),Convert.ToInt32(textBox11.Text),Convert.ToInt32(textBox13.Text));
                    if (CarpismalarinSinifi.yuzeyDikdortgenPrizmaCarpismaDenetimi(yuzey, dikdortgenPrizma))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton14.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6) && Char_SpaceControl(text7)
                   && Char_SpaceControl(text8) && Char_SpaceControl(text11) && Char_SpaceControl(text14))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton14Checked;
                    Nokta3d yuzeyNokta = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d silindirNokta = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Yuzey yuzey = new Yuzey(yuzeyNokta, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text));
                    Silindir silindir = new Silindir(silindirNokta, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox11.Text));
                    if (CarpismalarinSinifi.yuzeySilindirCarpismaDenetimi(yuzey, silindir))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton15.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6) && Char_SpaceControl(text10)
                   && Char_SpaceControl(text11) && Char_SpaceControl(text12) && Char_SpaceControl(text13))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton15Checked;
                    Nokta3d kureNokta = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d dikdortgen3dNokta = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Kure kure = new Kure(kureNokta, Convert.ToInt32(textBox10.Text));
                    DikdortgenPrizma dikdortgenPrizma = new DikdortgenPrizma(dikdortgen3dNokta,Convert.ToInt32(textBox12.Text),Convert.ToInt32(textBox11.Text),Convert.ToInt32(textBox13.Text));
                    if (CarpismalarinSinifi.kureDikdortgenPrizmaCarpismaDenetimi(kure, dikdortgenPrizma))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (radioButton16.Checked == true)
            {
                if (Char_SpaceControl(text1) && Char_SpaceControl(text2) && Char_SpaceControl(text3)
                   && Char_SpaceControl(text4) && Char_SpaceControl(text5) && Char_SpaceControl(text6) && Char_SpaceControl(text7)
                   && Char_SpaceControl(text8) && Char_SpaceControl(text9) && Char_SpaceControl(text11) && Char_SpaceControl(text12)
                   && Char_SpaceControl(text13))
                {
                    panel1.Visible = true;
                    panel1.Paint += panel1_DrawRadioButton16Checked;
                    Nokta3d dikdortgen3dNokta1 = new Nokta3d(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Nokta3d dikdortgen3dNokta2 = new Nokta3d(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    DikdortgenPrizma dikdortgenPrizma1 = new DikdortgenPrizma(dikdortgen3dNokta1, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text));
                    DikdortgenPrizma dikdortgenPrizma2 = new DikdortgenPrizma(dikdortgen3dNokta2, Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox13.Text));
                    if (CarpismalarinSinifi.dikdortgenPrizmaDikdortgenPrizmaCarpismaDenetimi(dikdortgenPrizma1, dikdortgenPrizma2))
                    {
                        panellabel2.Text = "Çarptý";
                    }
                    else
                    {
                        panellabel2.Text = "Çarpmadý";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doðru Tipte Veriler Giriniz", "Veri Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool Char_SpaceControl(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }
            else 
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!(char.IsNumber(text[i])))
                    {
                        return false;
                    }
                    else 
                    {
                        continue;
                    }
                }
            }
            return true;
        }
    }
}