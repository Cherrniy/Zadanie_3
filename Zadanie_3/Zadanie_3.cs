using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadanie_3
{
    public partial class Zadanie_3 : Form
    {
        public Zadanie_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fo = double.MaxValue;
            int Sum = 0;
            double Min = double.MaxValue;
            double Size = 0;
            Random rnd = new Random();
            double[] myArray;
            myArray = new double[5];
            for (int i = 0; i < 5; i++)
            {
                myArray[i] = rnd.Next() % 10;
            }           
            for (int i = 0; i < 5; i++)
            {
                if (myArray[i] == 0)
                    Sum++;
                if (Min < myArray[i])
                {
                    Min = myArray[i];
                    Size = 0;
                }
                else
                    Size += myArray[i];
            }
            label3.Text= Sum.ToString();
            label4.Text= Size.ToString();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (Math.Abs(myArray[i]) > Math.Abs(myArray[j]))
                    {
                        fo = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = fo;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                this.chart1.Series[0].Points.AddXY(i, myArray[i]);
            }
        }
    }
}
