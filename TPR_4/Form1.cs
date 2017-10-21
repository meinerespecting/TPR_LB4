using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            doId();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public double[] massK = new double[4] { 6, 8, 3, 4 };
        public double[] massF = new double[3] { 0, 0, 0};
        public double[] massS = new double[4] { 0, 0, 0, 0};
        public double[] massT = new double[4] { 0, 0, 0, 0 };
        public double[] massFour = new double[3] { 0, 0, 0 };
        public double[] massFiv = new double[4] { 0, 0, 0, 0};

        private void doId()
        {
            Control[] el;
            string tboxName = "";
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    tboxName = "textBox" + i.ToString() + "1";
                    el = this.Controls.Find(tboxName, true);
                    el[0].Text = massK[i - 1].ToString();
                }
            }
        }

        public Double xren1(double a, double f)
        {
            double g = f;
            return (f - (g - 1) * a); ;
        }
        public Double xren2(double b, double u)
        {
            return b * u;
        }

        private void first()
        {
            Control[] el;
            string tboxName = "";
            double a, b, c;
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "textBox" + i.ToString() + "2";
                el = this.Controls.Find(tboxName, true);
                a = Convert.ToDouble(dantextBox1.Text);
                b = Convert.ToDouble(dantextBox2.Text);
                c = Convert.ToDouble(dantextBox3.Text);
                massF[0] = a; massF[1] = b; massF[2] = c;

                plustextBox1.Text = xren1(a, c).ToString();
                plustextBox2.Text = xren2(b, c).ToString();
                              
            }
            
            }

        private void second()
        {
            Control[] el;
            string tboxName = "";
            double[] fi2 = { 0, 0, 0, 0 };
            for (int i = 1; i < 5; i++)
            {
                tboxName = "textBox" + i.ToString() + "2";
                el = this.Controls.Find(tboxName, true);
                fi2[i - 1] = (massF[2] - massK[i - 1]) * massF[0];
                massS[i - 1] = fi2[i- 1];
                el[0].Text = fi2[i - 1].ToString();

            }
        }

        private void third()
        {
            Control[] el;
            string tboxName = "";
            double []fi3 = {0, 0, 0, 0};
            for(int i = 1; i < 5; i++)
            {
                tboxName = "textBox" + i.ToString() + "3";
                el = this.Controls.Find(tboxName, true);

                fi3[i - 1] = massK[i - 1] * massS[1];
                massT[i - 1] = fi3[i - 1];
                el[0].Text = fi3[i - 1].ToString();
            }
        }

        private void four()
        {
            Control[] el;
            string tboxName = "";
            double[] fi4 = { 0, 0, 0, 0 };

                tboxName = "textBox14";
                el = this.Controls.Find(tboxName, true);
                fi4[0] = (massF[0] - massK[0]) * massK[0]/ massT[3];
                fi4[0] = massFour[0];
                el[0].Text = fi4[0].ToString();

                tboxName = "textBox24";
                el = this.Controls.Find(tboxName, true);
                fi4[1] = massS[1] * massT[2];
                fi4[1] = massFour[1];
                el[0].Text = fi4[1].ToString();

                tboxName = "textBox34";
                el = this.Controls.Find(tboxName, true);
                fi4[2] = massS[2] * massT[3];
                fi4[2] = massFour[2];
                el[0].Text = fi4[2].ToString();
        }
    
        private void five()
        {
            Control[] el;
            string tboxName = "";
            double[] fi5 = { 0, 0, 0, 0 };
            tboxName = "textBox15";
            el = this.Controls.Find(tboxName, true);
            fi5[0] = 1 - Math.Pow(massS[0] * massT[1] - (-1), 3);
            el[0].Text = fi5[0].ToString();

            tboxName = "textBox25";
            el = this.Controls.Find(tboxName, true);
            fi5[1] = 1 - Math.Pow(massS[1] * massT[2] - (-1), 3);
            el[0].Text = fi5[1].ToString();

            tboxName = "textBox35";
            el = this.Controls.Find(tboxName, true);
            fi5[2] = 1 - Math.Pow(massS[2] * massT[3] - (-1), 3);
            el[0].Text = fi5[2].ToString();
        }


        private void doSec()
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            first();
            second();
            third();
            four();
            five();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}