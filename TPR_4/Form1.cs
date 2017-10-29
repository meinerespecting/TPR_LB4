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
        public double[] massK = new double[] { 0.0, 1.0, 2.0, 3.0, 4.0};
      //  public double[] massF = new double[] { 0, 0, 0}; //не исп
        public double[] massS = new double[] { 0, 0, 0, 0, 0};
        public double[] massT = new double[] { 0, 0, 0, 0, 0 };
        public double[] massFour = new double[] { 0, 0, 0, 0 };
        public double[] massFiv = new double[] { 0, 0, 0, 0 };
        public double a, b, c;

        private void doId()
        {
            Control[] el;
            string tboxName = "";
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
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
            return ((f - (g - 1) )* a);
        }
        public Double xren2(double b, double u)
        {
            return b * u;
        }

        private void first()
        {
            Control[] el;
            string tboxName = "";
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "textBox" + i.ToString() + "2";
                el = this.Controls.Find(tboxName, true);
                a = Convert.ToDouble(dantextBox1.Text); //System.FormatException ????
                b = Convert.ToDouble(dantextBox2.Text);
                c = Convert.ToDouble(dantextBox3.Text);
               // massF[0] = a; massF[1] = b; massF[2] = c;

                plustextBox1.Text = xren1(a, c).ToString();
                plustextBox2.Text = xren2(b, c).ToString();

                              
            }
            
            }

        private void third()
        {
            Control[] el;
            string tboxName = "";
            double[] fi3 = { 0, 0, 0, 0, 0 };
            for (int i = 1; i <= 5; i++)
            {
                tboxName = "textBox" + i.ToString() + "3";
                el = this.Controls.Find(tboxName, true);
                fi3[i - 1] = massK[i - 1] * b;
                massT[i - 1] = fi3[i- 1];
                el[0].Text = fi3[i - 1].ToString();

            }
        }

        private void second()
        {
            Control[] el;
            string tboxName = "";
            double []fi2 = {0, 0, 0, 0, 0};
            for(int i = 1; i <= 5; i++)
            {
                tboxName = "textBox" + i.ToString() + "2";
                el = this.Controls.Find(tboxName, true);
                //TextBox.AppendText("123");
                //count2(ref el, i);
                fi2[i - 1] = (c - massK[i - 1]) * a;
                massS[i - 1] = fi2[i - 1];
                el[0].Text = fi2[i - 1].ToString();

            }
        }
 /*       private void count2(ref Control[] el, int j)
        {
            //TextBox.AppendText("2-");
            double []fi2 = {0, 0, 0, 0, 0 };
            int k = (6 - j);//костыльььььььь
            for (int i = 1; i <=k; i++)
            {
                fi2[i - 1] = (c - massK[i - 1]) * a;
                massS[i - 1] = fi2[i - 1];
                el[0].Text = fi2[i - 1].ToString();
                //TextBox.AppendText((i + 1).ToString());
            }
        }*/

        private void four()
        {
            Control[] el;
            string tboxName = "";
            double[] fi4 = { 0, 0, 0, 0, 0 };
            
                tboxName = "textBox14";
                el = this.Controls.Find(tboxName, true);
                fi4[0] = massS[0]/ massT[1];
                massFour[0] = fi4[0];
                el[0].Text = fi4[0].ToString("0.000");

                tboxName = "textBox24";
                el = this.Controls.Find(tboxName, true);
                fi4[1] = (massS[0] * massS[1]) / (massT[1] * massT[2]);
                massFour[1] = fi4[1];
                el[0].Text = fi4[1].ToString("0.000");

                tboxName = "textBox34";
                el = this.Controls.Find(tboxName, true);
                fi4[2] = (massS[0] * massS[1] * massS[2]) / (massT[1] * massT[2] * massT[3]);
                massFour[2] = fi4[2];
                el[0].Text = fi4[2].ToString("0.000");

                tboxName = "textBox44";
                el = this.Controls.Find(tboxName, true);
                fi4[3] = (massS[0] * massS[1] * massS[2] * massS[3]) / (massT[1] * massT[2] * massT[3] * massT[4]);
                massFour[3] = fi4[3];
                el[0].Text = fi4[3].ToString("0.000");

        }
    
        private void five()
        {
            Control[] el;
            string tboxName = "";
            double[] fi5 = { 0, 0, 0, 0 };
            tboxName = "textBox15";
            el = this.Controls.Find(tboxName, true);
            fi5[0] =  1 - Math.Pow (2.71828, massS[0] * massT[1] * (-1));
            massFiv[0] = fi5[0];
            el[0].Text = fi5[0].ToString("0.000");

            tboxName = "textBox25";
            el = this.Controls.Find(tboxName, true);
            fi5[1] = 1 - Math.Pow(2.71828, massS[1] * massT[2] * (-1));
            massFiv[1] = fi5[1];
            el[0].Text = fi5[1].ToString("0.000");

            tboxName = "textBox35";
            el = this.Controls.Find(tboxName, true);
            fi5[2] = 1 - Math.Pow(2.71828, massS[2] * massT[3] * (-1));
            massFiv[2] = fi5[2];
            el[0].Text = fi5[2].ToString("0.000");

            tboxName = "textBox45";
            el = this.Controls.Find(tboxName, true);
            fi5[3] = 1 - Math.Pow(2.71828, massS[3] * massT[4] * (-1));
            massFiv[3] = fi5[3];
            el[0].Text = fi5[3].ToString("0.000");
        }


        private void doFo()
        {
            Control[] el;
            string tboxName = "";
            double sumf = 0.0;
            tboxName = "sumtextBox4";
            el = this.Controls.Find(tboxName, true);

            for (int i = 0; i < 4; i++)
            {
                sumf += massFour[i];
            }
            
            el[0].Text = sumf.ToString("0.000");
        }

        private void doFi()
        {
            Control[] el;
            string tboxName = "";
            double sumfi = 0.0;
            tboxName = "sumtextBox5";
            el = this.Controls.Find(tboxName, true);

            for (int i = 0; i < 4; i++)
            {
                sumfi += massFiv[i];
            }

            el[0].Text = sumfi.ToString("0.000");
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            first();
            second();
            third();
            four();
            five();
            doFo();
            doFi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <=4; i++)
                TextBox.AppendText("\n3[" + i + "]:" + massT[i].ToString());
        }

    }
}