using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Matlab.Functions;
namespace DXApplication3
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string oper; double numa, numb, numr;
        public int deactive;
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gaugeControl1_Click(object sender, EventArgs e)
        {

        }
        int sing = 0;
        private void EnterNumBer(object sender, EventArgs e)
        {
            if (sing == 1) { label1.Text = "";sing = 0;}
            DevExpress.XtraEditors.SimpleButton numbers = (DevExpress.XtraEditors.SimpleButton)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
                label1.Text += numbers.Text;

            }

            else
            {
                label1.Text += numbers.Text;          
            }
            double.TryParse(label1.Text, out numb);
            co = 1;

        }
        int c = 0; string oper0; int co = 1;
        private void enterOpertion(object sender, EventArgs e)
        {
            
            sing = 1;
            string t=label1.Text;
            DevExpress.XtraEditors.SimpleButton operation = (DevExpress.XtraEditors.SimpleButton)sender;
            oper0 = oper;
            oper = operation.Text;
            if (co == 1)
            {
                if (c == 0&& cf==0)
                {
                    numa = numb;

                    c++;
                }
                else if (c == 1 && ce == 0)
                {

                    try
                    {

                        switch (oper0)
                        {
                            case "+": { numr = numa + numb; break; }
                            case "-": { numr = numa - numb; break; }
                            case "x": { numr = numa * numb; break; }
                            case "/": { numr = numa / numb; break; }
                            case "x^y": { numr = Math.Pow(numa, numb); break; }
                            case "x^(1/y)": { numr = Math.Pow(numa, 1.0 / numb); break; }
                            case "nCr": { double n = Maths.fact(numa); double p = Maths.fact(numb); numr = n / (p * (Maths.fact(numa - numb))); break; }
                            case "npr": { double n = Maths.fact(numa); numr = n / ((Maths.fact(numa - numb))); break; }
                            default: break;
                        }
                        numa = numr;
                        label1.Text = numr.ToString();

                    }
                    catch { }

                }
                else
                {
                    ce =0;
                    c = 1;

                }

                co = 0;

            }
         }
                
           


       

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            string t = label1.Text;
            if (t != "0")
            {
                if (t[0] != '-')
                {
                    label1.Text = "-" + t;
                }
                else
                {
                    label1.Text = t.Remove(0, 1);
                }
                co = 1;
                double.TryParse(label1.Text, out numb);
            }

           
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            string t=label1.Text;int l=t.Length;
            if (l> 1)
            {
                if (t[0] == '-' && l == 2) t = "0"; 
                else t = t.Remove(l-1, 1);
                label1.Text = t;
               
            }
            else
            {
                label1.Text = "0";
            }
            double.TryParse(label1.Text, out numb);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            string t=label1.Text;
            if (!t.Contains('.'))
            {
                label1.Text+= ".";
            }
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
        int ce = 0;
        private void simpleButton14_Click(object sender, EventArgs e)
        {
            ce = 1;
            co = 1;
            string t=label1.Text;
           
          
            
            try
            {
              
                switch(oper)
                {
                    case "+": { numr = numa + numb; break;}
                    case "-": { numr = numa - numb; break; }
                    case "x": { numr = numa * numb; break; }
                    case "/": { numr = numa / numb; break; }
                    case "x^y": { numr = Math.Pow(numa,numb); break; }
                    case "x^(1/y)": { numr = Math.Pow(numa,1.0/ numb); break; }
                    case "nCr": { double n = Maths.fact(numa); double p = Maths.fact(numb); numr =n/(p*(Maths.fact(numa-numb))); break; }
                    case "npr": { double n = Maths.fact(numa); numr = n / ( (Maths.fact(numa - numb))); break; }
                    default: break;
                }
                numa = numr;
                label1.Text = numr.ToString();
              
                
            }
            catch { }
            c = 3;

        }
        int cf=0;
        private void FunctionMaths(object sender, EventArgs e)
        {
            cf = 1;
            co = 1;
            DevExpress.XtraEditors.SimpleButton Functions = (DevExpress.XtraEditors.SimpleButton)sender;
            string t = label1.Text;
            string f=Functions.Text;
            try
            {
                double num = double.Parse(t);
                switch (f)
                {
                    case "cos": { numr = Math.Cos(num); break; }
                    case "sin": { numr = Math.Sin(num); break; }
                    case "tan": { numr = Math.Tan(num); break; }
                    case "acos": { numr = Math.Acos(num); break; }
                    case "asin": { numr = Math.Asin(num); break; }
                    case "atan": { numr = Math.Atan(num); break; }
                    case "ln": { numr = Math.Log(num); break; }
                    case "sqrt": { numr = Math.Sqrt(num); break; }
                    case "exp": { numr = Math.Exp(num); break; }
                    case "x²": { numr =num*num; break; }
                    case "n!": { if (num < 190) numr = Maths.fact(num); break; }
                    case "%": { numr = num/100; break; }
                    case "x^3": { numr =Math.Pow(num,3); break; }
                    case "x^(1/3)": { numr = Math.Pow(num, 1.0/3); break; }
                    case "10^n": { numr = Math.Pow(10, num); break;}
                    case "floor": { numr = Math.Floor(num); break; }
                    case "ceil": { numr = Math.Ceiling(num); break; }
                    case "sign": { numr = Math.Sign(num); break; }
                    default: break;
                }
               label1.Text = numr.ToString();
               numa = numr;
              

            }
            catch { }

        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton Cte = (DevExpress.XtraEditors.SimpleButton)sender;
            cf = 1;
            string cte = Cte.Text;
            switch (cte)
            {
                case "pi": numr = Math.PI; break;
                case "e": numr = Math.E; break;
                case "ln2": numr = Math.Log(2); break;
                default: break;
            }
            label1.Text = numr.ToString();
            numa = numr;
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled == true)
            {
                panel1.Enabled = false;
                label1.Text = "";

            }
            else
            {
                panel1.Enabled = true;
                label1.Text="0";
            
            }
        }

        private void rfrf(object sender, EventArgs e)
        {
            label1.Text = "0";
            c = 0;
            ce = 0;
            co = 1;
            cf = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void dr(object sender, EventArgs e)
        {
          
        }

        private void jkl(object sender, EventArgs e)
        {
            float a;
            lb1.Text = label1.Text;
          if(bs==0) { float.TryParse(label1.Text,out a);label1.Text=a.ToString(); }
        }
        int bs = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (bs == 0)
            {
                this.Size = new Size(606, 449);
                gt1.Visible = false;
                gaugeControl1.Visible = true;
                bs = 1;
            }
            else 
            {
                this.Size = new Size(340, 449);
                gaugeControl1.Visible = false;
                gt1.Visible = true;
               
                label1.DigitCount = 10;
                bs =0;
            
            }
        }

        private void bgrtg(object sender, EventArgs e)
        {

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
         
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
           
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            deactive = 0;
        }
    }
}
