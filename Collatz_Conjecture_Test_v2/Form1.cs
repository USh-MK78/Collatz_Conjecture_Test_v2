using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Collatz_Conjecture_Test_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CollatzConjectureCalculate_Click(object sender, EventArgs e)
        {
            OutputTXT.Text = "";

            BigInteger X = BigInteger.Parse(Input_X_TXT.Text);
            int Y = int.Parse(EvenParam_TXT.Text); //3
            int Z = int.Parse(OddParam_TXT.Text); //1

            int M = int.Parse(textBox1.Text);

            int LoopCount = 0;
            while (X > 1)
            {
                if (X % M == 0)
                {
                    X = X / (Y * M);
                    OutputTXT.Text += "[" + LoopCount + "] " + Input_X_TXT.Text + " is " + X + ", This is Even Number.\r\n";
                }
                else
                {
                    //Collatz's idea is that you need to multiply by 3 and then add 1, but this code doesn't multiply 3.

                    X = X - Z;
                    //X = (X * Y) - Z;
                    OutputTXT.Text += "[" + LoopCount + "] " + Input_X_TXT.Text + " is " + X + ", This is Odd Number.\r\n";
                }

                LoopCount++;
            }

            //int LoopCount = 0;
            //while (X > 1)
            //{
            //    if (X % 2 == 0)
            //    {
            //        X = X / (Z * 2);
            //        OutputTXT.Text += "[" + LoopCount + "] " + Input_X_TXT.Text + " is " + X + ", This is Even Number.\r\n";
            //    }
            //    else
            //    {
            //        //Collatz's idea is that you need to multiply by 3 and then add 1, but this code doesn't multiply 3.

            //        X = (Y * X) + Z;
            //        OutputTXT.Text += "[" + LoopCount + "] " + Input_X_TXT.Text + " is " + X + ", This is Odd Number.\r\n";
            //    }

            //    LoopCount++;
            //}

            OutputTXT.Text += "[End]\r\n" + "Loop Count :" + LoopCount + "\r\n" + "Digit count :" + Input_X_TXT.Text.ToString().Length;
        }

        ///// <summary>
        ///// Method (CollatzConjectureHelper.cs)
        ///// </summary>
        //public void Calculate()
        //{
        //    OutputTXT.Text = "";

        //    BigInteger X = BigInteger.Parse(Input_X_TXT.Text);

        //    int LoopCount = 0;
        //    while (X > 1)
        //    {
        //        CollatzConjectureHelper.CollatzConjectureStruct collatzConjecture = new CollatzConjectureHelper.CollatzConjectureStruct(X);
        //        collatzConjecture.Calculate();
        //        OutputTXT.Text += Input_X_TXT.Text + " is " + collatzConjecture.X + ", This is" + collatzConjecture.OddEvenType + "Number.\r\n";
        //        LoopCount++;
        //    }

        //    OutputTXT.Text += "[End]\r\n" + "Loop Count :" + LoopCount + "\r\n" + "Digit count :" + Input_X_TXT.Text.ToString().Length;
        //}
    }
}
