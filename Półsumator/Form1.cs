using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Półsumator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void bitA_CheckedChanged_1(object sender, EventArgs e)
        {
            sprawdz();
        }

        private void bitB_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz();
        }

        private void bitS_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz();
        }

        private void bitC_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz();
        }

        private void sprawdz()
        {
            if (bitA.Checked == false && bitB.Checked == false)
            {
                bitS.Checked = false;
                bitC.Checked = false;
            }
            else if (bitA.Checked == false && bitB.Checked == true)
            {
                bitS.Checked = true;
                bitC.Checked = false;
            }
            else if(bitA.Checked == true && bitB.Checked == false)
            {
                bitS.Checked = true;
                bitC.Checked = false;
            }
            else if(bitA.Checked == true && bitB.Checked == true)
            {
                bitS.Checked = false;
                bitC.Checked = true;
            }

            if(bitA.Checked == true || bitA.Checked == false || bitB.Checked == true || bitB.Checked == false)
            {
                this.Invalidate();
            }



        }





        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen Line1 = new Pen(Color.Black);
            Line1.Width = 5;
            if (bitA.Checked == false)
            {
                Line1.Color = Color.Red;
                Line1.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line1, 245, 161, 400, 161);  //207, 155      // y coordinates - 155 + 6,   number: 6,            x coordinates 207 + 38, number: 38,         x2 = +55
            }
            else
            {
                Line1.Color = Color.Blue;
                Line1.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line1, 245, 161, 400, 161);  //207, 155      // y coordinates - 155 + 6,   number: 6,            x coordinates 207 + 38, number: 38,         x2 = +55
            }




            Pen Line2 = new Pen(Color.Red);
            Line2.Width = 5;
            if (bitB.Checked == false)
            {
                Line2.Color = Color.Red;
                Line2.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line2, 245, 215, 400, 215);  // 207, 209
            }
            else
            {
                Line2.Color = Color.Blue;
                Line2.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line2, 245, 215, 400, 215);  // 207, 209

            }




            Pen Line3 = new Pen(Color.Red);
            Line3.Width = 5;
            if ((bitA.Checked == false && bitB.Checked == true) || (bitA.Checked == true && bitB.Checked == false))
            {
                Line3.Color = Color.Blue;
                Line3.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line3, 400, 188, 700, 188);
            }
            else
            {
                Line3.Color = Color.Red;
                Line3.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line3, 400, 188, 700, 188);
            }





            if (bitA.Checked == true && bitB.Checked == true)
            { 
                Pen Line4 = new Pen(Color.Red);
                Line4.Width = 5;
                Line4.Color = Color.Blue;
                Line4.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line4, 300, 161, 300, 321);  // 207, 209
                Pen Line5 = new Pen(Color.Red);
                Line5.Width = 5;
                Line5.Color = Color.Blue;
                g.DrawLine(Line5, 299, 318, 390, 318);  // 207, 209

                Pen Line6 = new Pen(Color.Red);
                Line6.Width = 5;
                Line6.Color = Color.Blue;
                Line6.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line6, 265, 215, 265, 360);  // 207, 209
                Pen Line7 = new Pen(Color.Red);
                Line7.Width = 5;
                Line7.Color = Color.Blue;
                g.DrawLine(Line7, 263, 359, 390, 359);  // 207, 209
            }
            else
            {
                Pen Line4 = new Pen(Color.Red);
                Line4.Width = 5;
                Line4.Color = Color.Red;
                Line4.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line4, 300, 161, 300, 321);  // 207, 209
                Pen Line5 = new Pen(Color.Red);
                Line5.Width = 5;
                Line5.Color = Color.Red;
                g.DrawLine(Line5, 299, 318, 390, 318);  // 207, 209

                Pen Line6 = new Pen(Color.Red);
                Line6.Width = 5;
                Line6.Color = Color.Red;
                Line6.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line6, 265, 215, 265, 360);  // 207, 209
                Pen Line7 = new Pen(Color.Red);
                Line7.Width = 5;
                Line7.Color = Color.Red;
                g.DrawLine(Line7, 263, 359, 390, 359);  // 207, 209
            }






            if(bitA.Checked == true && bitB.Checked == true)
            {
                Pen Line8 = new Pen(Color.Red);
                Line8.Width = 5;
                Line8.Color = Color.Blue;
                Line8.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line8, 500, 339, 700, 339);  // 207, 209
            }
            else
            {
                Pen Line8 = new Pen(Color.Red);
                Line8.Width = 5;
                Line8.Color = Color.Red;
                Line8.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                g.DrawLine(Line8, 500, 339, 700, 339);  // 207, 209
            }



        }

    }



}