using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угрюмова_практика_16_построение_графиков_функций
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Name = "Синус";
            chart1.Series[1].Name = "Косинус";
            double y = 0;
            for(int x = -360; x <= 360; x++)
            {

                y = Math.Sin(Math.PI / 180 * x*20);
                chart1.Series["Синус"].Points.AddXY(x, y);

                y = Math.Cos(Math.PI / 180 * x*20);
                chart1.Series["Косинус"].Points.AddXY(x, y);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            try 
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                switch (comboBox1.SelectedIndex) 
                {
                    case 0:
                        for (double x = 0; x <= 50; x++) 
                        {
                            if (x != 0) 
                            {
                                chart1.Series[0].Name = "гипербола 1";
                                Giperbola g = new Giperbola(x, double.Parse(textBox1.Text));
                                chart1.Series["гипербола 1"].Points.AddXY((float)x, (float)g.Draw());
                            }
                        }
                        for (double x = -50; x <= 0; x++) 
                        {
                            if (x != 0) 
                            {
                                chart1.Series[1].Name = "гипербола 2";
                                Giperbola g1 = new Giperbola(x, double.Parse(textBox1.Text));
                                chart1.Series["гипербола 2"].Points.AddXY((float)x, (float)g1.Draw());
                            }
                        }
                        break;
                    case 1:

                        

                        for (double x = 0; x <= 50; x++) 
                        {
                            chart1.Series[0].Name = "парабола 1";
                            Parabola p = new Parabola(x, double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                                chart1.Series["парабола 1"].Points.AddXY((float)x, (float)p.Draw());
                            
                        }
                        for (double x = -50; x <= 0; x++) 
                        {
                            chart1.Series[1].Name = "парабола 2";
                            Parabola p = new Parabola(x, double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                                chart1.Series["парабола 2"].Points.AddXY((float)x, (float)p.Draw());
                        }
                        break;
                    case 2:
                        
                        for (double x = -50; x <= 50; x+=0.5) 
                        {
                            chart1.Series[0].Name = "радиус 1";
                            chart1.Series[1].Name = "радиус 2";
                            Round r = new Round(x, double.Parse(textBox1.Text));
                            chart1.Series["радиус 1"].Points.AddXY((float)x, (float)r.Draw());
                            chart1.Series["радиус 2"].Points.AddXY((float)x, -(float)r.Draw());
                        }
                        break;
                }
            } 
            catch 
            {
                MessageBox.Show("данные введены не все или неправильно");
            }
        }
    }
}
