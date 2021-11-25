using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator_Subtraktor___Praca_Dyplomowa
{


    public partial class SumatorSubtraktor : Form
    {

        public SumatorSubtraktor()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }


        private void Ai1_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz();
        }

        private void Bi2_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz();
        }

        private void Ci3_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz();
        }

        private void CiCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SiCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void sprawdz()
        {

            if (Ci3.Checked == false && Bi2.Checked == false && Ai1.Checked == false)    // 0
            { 
                Si1.Checked = false;
                Ci.Checked = false;
            }
            else if(Ci3.Checked == false && Bi2.Checked == false && Ai1.Checked == true)    // 1
            {
                Si1.Checked = true;
                Ci.Checked = false;
            }
            else if(Ci3.Checked == false && Bi2.Checked == true && Ai1.Checked == false)   // 2
            {
                Si1.Checked = true;
                Ci.Checked = false;
            }
            else if(Ci3.Checked == false && Bi2.Checked == true && Ai1.Checked == true)   // 3
            {
                Si1.Checked = false;
                Ci.Checked = true;
            }
            else if(Ci3.Checked == true && Bi2.Checked == false && Ai1.Checked == false)   // 4
            {
                Si1.Checked = true;
                Ci.Checked = false;
            }
            else if(Ci3.Checked == true && Bi2.Checked == false && Ai1.Checked == true)   // 5
            {
                Si1.Checked = false;
                Ci.Checked = true;
            }
            else if(Ci3.Checked == true && Bi2.Checked == true && Ai1.Checked == false)   // 6
            {
                Si1.Checked = false;
                Ci.Checked = true;
            }
            else if(Ci3.Checked == true && Bi2.Checked == true && Ai1.Checked == true)   // 7
            {
                Si1.Checked = true;
                Ci.Checked = true;
            }

            if (Ai1.Checked == true || Ai1.Checked == false || Bi2.Checked == true || Bi2.Checked == false || Ci3.Checked == true || Ci3.Checked == false)
            {
                this.Invalidate();
            }
        }




        protected override void OnPaint(PaintEventArgs e)
        {
            Color ColorOn = Color.Red;
            Color ColorOff = Color.Black;


            Pen Line1 = new Pen(Color.Black);
            if (Ai1.Checked == true)
            {
                Pen(e, Line1, ColorOn, 60, 32, 150, 32);
            }
            else if(Ai1.Checked == false)
            {
                Pen(e, Line1, ColorOff, 60, 32, 150, 32);
            }


            Pen Line2 = new Pen(Color.Black);
            if(Bi2.Checked == true)
            {
                Pen(e, Line2, ColorOn, 60, 66, 150, 66);
            }
            else if(Bi2.Checked == false)
            {
                Pen(e, Line2, ColorOff, 60, 66, 150, 66);
            }

            Pen Line3 = new Pen(Color.Black);
            {
                if (Ai1.Checked == true && Bi2.Checked == false || Ai1.Checked == false && Bi2.Checked == true)
                {
                    Pen(e, Line3, ColorOn, 190, 49, 330, 49);
                    Pen(e, Line3, ColorOn, 329, 49, 329, 55);
                    Pen(e, Line3, ColorOn, 329, 54, 350, 54);
                }
                else
                {
                    Pen(e, Line3, ColorOff, 190, 49, 330, 49);
                    Pen(e, Line3, ColorOff, 329, 49, 329, 55);
                    Pen(e, Line3, ColorOff, 329, 54, 350, 54);
                }
            }


            Pen Line4 = new Pen(Color.Black);
            if (Ci3.Checked == true)
            {
                Pen(e, Line4, ColorOn, 60, 88, 370, 88);
            }
            else if (Ci3.Checked == false)
            {
                Pen(e, Line4, ColorOff, 60, 88, 370, 88);
            }


            Pen Line5 = new Pen(Color.Black);
            if (Si1.Checked == true)
            {
                Pen(e, Line5, ColorOn, 390, 71, 518, 71);
            }
            else
            {
                Pen(e, Line5, ColorOff, 390, 71, 518, 71);
            }


            Pen Line6 = new Pen(Color.Black);
            if (Ai1.Checked == true)
            {
                PenStartCap(e, Line6, ColorOn, 80, 31, 80, 250);
                Pen(e, Line6, ColorOn, 80, 249, 150, 249);
            }
            else
            {
                PenStartCap(e, Line6, ColorOff, 80, 31, 80, 250);
                Pen(e, Line6, ColorOff, 80, 249, 150, 249);
            }


            Pen Line7 = new Pen(Color.Black);
            if (Ci3.Checked == true)
            {
                PenStartCap(e, Line7, ColorOn, 110, 87, 110, 277);
                Pen(e, Line7, ColorOn, 110, 276, 145, 276);
            }
            else
            {
                PenStartCap(e, Line7, ColorOff, 110, 87, 110, 277);
                Pen(e, Line7, ColorOff, 110, 276, 145, 276);
            }



            Pen Line8 = new Pen(Color.Black);
            if (Ci3.Checked == true)
            {
                PenStartCap(e, Line8, ColorOn, 110, 217, 150, 217);
            }
            else
            {
                PenStartCap(e, Line8, ColorOff, 110, 217, 150, 217);
            }


            Pen Line9 = new Pen(Color.Black);
            if (Bi2.Checked == true)
            {
                Pen(e, Line9, ColorOn, 95, 190, 150, 190);
                PenStartCap(e, Line9, ColorOn, 95, 65, 95, 190);
            }
            else
            {
                Pen(e, Line9, ColorOff, 95, 190, 150, 190);
                PenStartCap(e, Line9, ColorOff, 95, 65, 95, 190);
            }



            Pen Line10 = new Pen(Color.Black);
            if (Ai1.Checked == true)
            {
                PenStartCap(e, Line10, ColorOn, 79, 156, 150, 156);
            }
            else
            {
                PenStartCap(e, Line10, ColorOff, 79, 156, 150, 156);
            }


            Pen Line11 = new Pen(Color.Black);
            if (Bi2.Checked == true)
            {
                PenStartCap(e, Line11, ColorOn, 95, 129, 150, 129);
            }
            else
            {
                PenStartCap(e, Line11, ColorOff, 95, 129, 150, 129);
            }


            Pen Line12 = new Pen(Color.Black);
            if (Ai1.Checked == true && Bi2.Checked == true)
            {
                Pen(e, Line12, ColorOn, 200, 143, 300, 143);
                Pen(e, Line12, ColorOn, 299, 142, 299, 191);
                Pen(e, Line12, ColorOn, 298, 190, 350, 190);
            }
            else
            {
                Pen(e, Line12, ColorOff, 200, 143, 300, 143);
                Pen(e, Line12, ColorOff, 299, 142, 299, 191);
                Pen(e, Line12, ColorOff, 298, 190, 350, 190);
            }


            Pen Line13 = new Pen(Color.Black);
            if (Ci3.Checked == true && Bi2.Checked == true)
            {
                Pen(e, Line13, ColorOn, 220, 204, 370, 204);
            }
            else
            {
                Pen(e, Line13, ColorOff, 220, 204, 370, 204);
            }


            Pen Line14 = new Pen(Color.Black);
            if (Ai1.Checked == true && Ci3.Checked == true)
            {
                Pen(e, Line14, ColorOn, 220, 263, 300, 263);
                Pen(e, Line14, ColorOn, 299, 217, 299, 263);
                Pen(e, Line14, ColorOn, 300, 218, 340, 218);
            }
            else
            {
                Pen(e, Line14, ColorOff, 220, 263, 300, 263);
                Pen(e, Line14, ColorOff, 299, 217, 299, 263);
                Pen(e, Line14, ColorOff, 300, 218, 340, 218);
            }


            Pen Line15 = new Pen(Color.Black);
            if (Ci3.Checked == true && Bi2.Checked == true || Ci3.Checked == true && Ai1.Checked == true || Bi2.Checked == true && Ai1.Checked == true)
            {
                Pen(e, Line15, ColorOn, 400, 204, 518, 204);
            }
            else
            {
                Pen(e, Line15, ColorOff, 400, 204, 518, 204);
            }




            //// 4XOR
            Pen Line16 = new Pen(Color.Black);
            if(C0.Checked == true)
            {
                Pen(e, Line16, ColorOn, 50, 379, 280, 379);
            }
            else
            {
                Pen(e, Line16, ColorOff, 50, 379, 280, 379);
            }

            Pen Line17 = new Pen(Color.Black);
            if (b0.Checked == true)
            {
                Pen(e, Line17, ColorOn, 50, 426, 200, 426);
                Pen(e, Line17, ColorOn, 200, 355, 200, 427);
                Pen(e, Line17, ColorOn, 199, 355, 300, 355);
            }
            else
            {
                Pen(e, Line17, ColorOff, 50, 426, 200, 426);
                Pen(e, Line17, ColorOff, 200, 355, 200, 427);
                Pen(e, Line17, ColorOff, 199, 355, 300, 355);
            }


            Pen Line18 = new Pen(Color.Black);
            if (b1.Checked == true)
            {
                Pen(e, Line18, ColorOn, 50, 452, 240, 452);
                Pen(e, Line18, ColorOn, 239, 403, 239, 452);
                Pen(e, Line18, ColorOn, 239, 404, 280, 404);
            }
            else
            {
                Pen(e, Line18, ColorOff, 50, 452, 240, 452);
                Pen(e, Line18, ColorOff, 239, 403, 239, 452);
                Pen(e, Line18, ColorOff, 239, 404, 280, 404);
            }

            Pen Line19 = new Pen(Color.Black);
            if (C0.Checked == true)
            {
                Pen(e, Line19, ColorOn, 220, 428, 270, 428);
                PenStartCap(e, Line19, ColorOn, 221, 378, 221, 428);
            }
            else
            {
                Pen(e, Line19, ColorOff, 220, 428, 270, 428);
                PenStartCap(e, Line19, ColorOff, 221, 378, 221, 428);
            }

            Pen Line20 = new Pen(Color.Black);
            if (b2.Checked == true)
            {
                Pen(e, Line20, ColorOn, 60, 478, 270, 478);
            }
            else
            {
                Pen(e, Line20, ColorOff, 60, 478, 270, 478);
            }

            Pen Line21 = new Pen(Color.Black);
            if (C0.Checked == true)
            {
                Pen(e, Line21, ColorOn, 250, 454, 270, 454);
                Pen(e, Line21, ColorOn, 251, 440, 251, 454);
                Pen(e, Line21, ColorOn, 150, 440, 252, 440);
                PenStartCap(e, Line21, ColorOn, 151, 378, 151, 440);
            }
            else
            {
                Pen(e, Line21, ColorOff, 250, 454, 270, 454);
                Pen(e, Line21, ColorOff, 251, 440, 251, 454);
                Pen(e, Line21, ColorOff, 150, 440, 252, 440);
                PenStartCap(e, Line21, ColorOff, 151, 378, 151, 440);
            }

            Pen Line22 = new Pen(Color.Black);
            if (b3.Checked == true)
            {
                Pen(e, Line22, ColorOn, 50, 503, 270, 503);
            }
            else
            {
                Pen(e, Line22, ColorOff, 50, 503, 270, 503);
            }

            Pen Line23 = new Pen(Color.Black);
            if (C0.Checked == true)
            {
                Pen(e, Line23, ColorOn, 200, 527, 270, 527);
                PenStartCap(e, Line23, ColorOn, 201, 439, 201, 527);
            }
            else
            {
                Pen(e, Line23, ColorOff, 200, 527, 270, 527);
                PenStartCap(e, Line23, ColorOff, 201, 439, 201, 527);
            }

            Pen Line24 = new Pen(Color.Black);
            if (b0wyj.Checked == true)
            {
                Pen(e, Line24, ColorOn, 330, 367, 498, 367);
            }
            else
            {
                Pen(e, Line24, ColorOff, 330, 367, 498, 367);
            }

            Pen Line25 = new Pen(Color.Black);
            if (b1wyj.Checked == true)
            {
                Pen(e, Line25, ColorOn, 330, 416, 498, 416);
            }
            else
            {
                Pen(e, Line25, ColorOff, 330, 416, 498, 416);
            }

            Pen Line26 = new Pen(Color.Black);
            if (b2wyj.Checked == true)
            {
                Pen(e, Line26, ColorOn, 330, 466, 498, 466);
            }
            else
            {
                Pen(e, Line26, ColorOff, 330, 466, 498, 466);
            }

            Pen Line27 = new Pen(Color.Black);
            if (b3wyj.Checked == true)
            {
                Pen(e, Line27, ColorOn, 330, 515, 498, 515);
            }
            else
            {
                Pen(e, Line27, ColorOff, 330, 515, 498, 515);
            }

            Pen Line28 = new Pen(Color.Black);
            if (CnMinus1.Checked == true)
            {
                Pen(e, Line28, ColorOn, 50, 635, 180, 635);
            }
            else
            {
                Pen(e, Line28, ColorOff, 50, 635, 180, 635);
            }

            Pen Line29 = new Pen(Color.Black);
            if (Cn.Checked == true)
            {
                Pen(e, Line29, ColorOn, 50, 672, 140, 672);
                Pen(e, Line29, ColorOn, 139, 672, 139, 702);
                Pen(e, Line29, ColorOn, 138, 701, 270, 701);
            }
            else
            {
                Pen(e, Line29, ColorOff, 50, 672, 140, 672);
                Pen(e, Line29, ColorOff, 139, 672, 139, 702);
                Pen(e, Line29, ColorOff, 138, 701, 270, 701);
            }


            Pen Line30 = new Pen(Color.Black);
            if (Ofl.Checked == true)
            {
                Pen(e, Line30, ColorOn, 50, 706, 110, 706);
                Pen(e, Line30, ColorOn, 109, 659, 109, 705);
                Pen(e, Line30, ColorOn, 108, 659, 170, 659);
            }
            else
            {
                Pen(e, Line30, ColorOff, 50, 706, 110, 706);
                Pen(e, Line30, ColorOff, 109, 659, 109, 705);
                Pen(e, Line30, ColorOff, 108, 659, 170, 659);
            }


            Pen Line31 = new Pen(Color.Black);
            if((CnMinus1.Checked == true && Ofl.Checked == false) || (CnMinus1.Checked == false && Ofl.Checked == true))
            {
                Pen(e, Line31, ColorOn, 230, 647, 350, 647);
                Pen(e, Line31, ColorOn, 349, 646, 349, 653);
                Pen(e, Line31, ColorOn, 348, 654, 400, 654);
            }
            else
            {
                Pen(e, Line31, ColorOff, 230, 647, 350, 647);
                Pen(e, Line31, ColorOff, 349, 646, 349, 653);
                Pen(e, Line31, ColorOff, 348, 654, 400, 654);
            }


            Pen Line32 = new Pen(Color.Black);
            if (CnMinus1.Checked == true)
            {
                PenStartCap(e, Line32, ColorOn, 99, 635, 99, 690);
                Pen(e, Line32, ColorOn, 98, 689, 210, 689);
                Pen(e, Line32, ColorOn, 209, 674, 209, 689);
                Pen(e, Line32, ColorOn, 208, 674, 300, 674);
            }
            else
            {
                PenStartCap(e, Line32, ColorOff, 99, 635, 99, 690);
                Pen(e, Line32, ColorOff, 98, 689, 210, 689);
                Pen(e, Line32, ColorOff, 209, 674, 209, 689);
                Pen(e, Line32, ColorOff, 208, 674, 300, 674);
            }


            Pen Line33 = new Pen(Color.Black);
            if (CnMinus1.Checked == true && Cn.Checked == true)
            {
                Pen(e, Line33, ColorOn, 290, 688, 400, 688);
            }
            else
            {
                Pen(e, Line33, ColorOff, 290, 688, 400, 688);
            }


            Pen Line34 = new Pen(Color.Black);
            if (piatyBit.Checked == true)
            {
                Pen(e, Line34, ColorOn, 469, 671, 500, 671);
            }
            else
            {
                Pen(e, Line34, ColorOff, 469, 671, 500, 671);
            }





            // Sumator/Subtraktor
            // 4XOR

            Pen Line35 = new Pen(Color.Black);
            if (B0SUMR.Checked == true)
            {
                Pen(e, Line35, ColorOn, 1471, 50, 1471, 100);
            }
            else
            {
                Pen(e, Line35, ColorOff, 1471, 50, 1471, 100);
            }


            Pen Line36 = new Pen(Color.Black);
            if (B1SUMR.Checked == true)
            {
                Pen(e, Line36, ColorOn, 1492, 50, 1492, 100);
            }
            else
            {
                Pen(e, Line36, ColorOff, 1492, 50, 1492, 100);
            }

            Pen Line37 = new Pen(Color.Black);
            if (B2SUMR.Checked == true)
            {
                Pen(e, Line37, ColorOn, 1512, 50, 1512, 100);
            }
            else
            {
                Pen(e, Line37, ColorOff, 1512, 50, 1512, 100);
            }


            Pen Line38 = new Pen(Color.Black);
            if (B3SUMR.Checked == true)
            {
                Pen(e, Line38, ColorOn, 1532, 50, 1532, 100);
            }
            else
            {
                Pen(e, Line38, ColorOff, 1532, 50, 1532, 100);
            }



            //B3 XOR
            Pen Line39 = new Pen(Color.Black);
            if (BB3SUMR.Checked == true)
            {
                Pen(e, Line39, ColorOn, 1532, 120, 1532, 250);
                Pen(e, Line39, ColorOn, 1531, 249, 1650, 249);
                Pen(e, Line39, ColorOn, 1649, 249, 1649, 350);
            }
            else
            {
                Pen(e, Line39, ColorOff, 1532, 120, 1532, 250);
                Pen(e, Line39, ColorOff, 1531, 249, 1650, 249);
                Pen(e, Line39, ColorOff, 1649, 249, 1649, 350);
            }


            //B2 XOR
            Pen Line40 = new Pen(Color.Black);
            if (BB2SUMR.Checked == true)
            {
                Pen(e, Line40, ColorOn, 1512, 120, 1512, 250);
                Pen(e, Line40, ColorOn, 1502, 249, 1511, 249);
                Pen(e, Line40, ColorOn, 1501, 248, 1501, 350);
            }
            else
            {
                Pen(e, Line40, ColorOff, 1512, 120, 1512, 250);
                Pen(e, Line40, ColorOff, 1502, 249, 1511, 249);
                Pen(e, Line40, ColorOff, 1501, 248, 1501, 350);
            }

            //B1 XOR
            Pen Line41 = new Pen(Color.Black);
            if (BB1SUMR.Checked == true)
            {
                Pen(e, Line41, ColorOn, 1492, 120, 1492, 250);
                Pen(e, Line41, ColorOn, 1360, 249, 1492, 249);
                Pen(e, Line41, ColorOn, 1359, 248, 1359, 350);
            }
            else
            {
                Pen(e, Line41, ColorOff, 1492, 120, 1492, 250);
                Pen(e, Line41, ColorOff, 1360, 249, 1492, 249);
                Pen(e, Line41, ColorOff, 1359, 248, 1359, 350);
            }

            //B0 XOR
            Pen Line42 = new Pen(Color.Black);
            if (BB0SUMR.Checked == true)
            {
                Pen(e, Line42, ColorOn, 1471, 120, 1471, 235);
                Pen(e, Line42, ColorOn, 1210, 234, 1472, 234);
                Pen(e, Line42, ColorOn, 1211, 233, 1211, 350);
            }
            else
            {
                Pen(e, Line42, ColorOff, 1471, 120, 1471, 235);
                Pen(e, Line42, ColorOff, 1210, 234, 1472, 234);
                Pen(e, Line42, ColorOff, 1211, 233, 1211, 350);
            }


            //A3
            Pen Line43 = new Pen(Color.Black);
            if (A3SUMR.Checked == true)
            {
                Pen(e, Line43, ColorOn, 1345, 50, 1345, 280);
                Pen(e, Line43, ColorOn, 1344, 279, 1620, 279);
                Pen(e, Line43, ColorOn, 1619, 278, 1619, 350);
            }
            else
            {
                Pen(e, Line43, ColorOff, 1345, 50, 1345, 280);
                Pen(e, Line43, ColorOff, 1344, 279, 1620, 279);
                Pen(e, Line43, ColorOff, 1619, 278, 1619, 350);
            }


            //A2
            Pen Line44 = new Pen(Color.Black);
            if (A2SUMR.Checked == true)
            {
                Pen(e, Line44, ColorOn, 1326, 50, 1326, 290);
                Pen(e, Line44, ColorOn, 1325, 289, 1472, 289);
                Pen(e, Line44, ColorOn, 1471, 288, 1471, 350);
            }
            else
            {
                Pen(e, Line44, ColorOff, 1326, 50, 1326, 290);
                Pen(e, Line44, ColorOff, 1325, 289, 1472, 289);
                Pen(e, Line44, ColorOff, 1471, 288, 1471, 350);
            }

            //A1
            Pen Line45 = new Pen(Color.Black);
            if (A1SUMR.Checked == true)
            {
                Pen(e, Line45, ColorOn, 1307, 50, 1307, 300);
                Pen(e, Line45, ColorOn, 1307, 299, 1328, 299);
                Pen(e, Line45, ColorOn, 1329, 298, 1329, 330);
            }
            else
            {
                Pen(e, Line45, ColorOff, 1307, 50, 1307, 300);
                Pen(e, Line45, ColorOff, 1307, 299, 1328, 299);
                Pen(e, Line45, ColorOff, 1329, 298, 1329, 330);
            }



            //A0
            Pen Line46 = new Pen(Color.Black);
            if (A0SUMR.Checked == true)
            {
                Pen(e, Line46, ColorOn, 1286, 50, 1286, 300);
                Pen(e, Line46, ColorOn, 1179, 299, 1286, 299);
                Pen(e, Line46, ColorOn, 1180, 298, 1180, 350);
            }
            else
            {
                Pen(e, Line46, ColorOff, 1286, 50, 1286, 300);
                Pen(e, Line46, ColorOff, 1179, 299, 1286, 299);
                Pen(e, Line46, ColorOff, 1180, 298, 1180, 350);
            }


            //C0
            Pen Line47 = new Pen(Color.Black);
            if (C0SUM.Checked == true)
            {
                Pen(e, Line47, ColorOn, 1650, 360, 1731, 360);
            }
            else
            {
                Pen(e, Line47, ColorOff, 1650, 360, 1731, 360);
            }


            //C0 korektor
            Pen Line48 = new Pen(Color.Black);
            if (C03SUMR.Checked == true)
            {
                PenStartCap(e, Line48, ColorOn, 1700, 359, 1700, 117);
                Pen(e, Line48, ColorOn, 1500, 118, 1700, 118);
            }
            else
            {
                PenStartCap(e, Line48, ColorOff, 1700, 359, 1700, 117);
                Pen(e, Line48, ColorOff, 1500, 118, 1700, 118);
            }


            //Ci + 1 -> Ci  #1
            Pen Line49 = new Pen(Color.Black);
            if (FA1CI1.Checked == true)
            {
                Pen(e, Line49, ColorOn, 1500, 360, 1650, 360);
            }
            else
            {
                Pen(e, Line49, ColorOff, 1500, 360, 1650, 360);

            }


            //Ci + 1 -> Ci  #2
            Pen Line50 = new Pen(Color.Black);
            if (FA2CI1.Checked == true)
            {
                Pen(e, Line50, ColorOn, 1350, 360, 1600, 360);
            }
            else
            {
                Pen(e, Line50, ColorOff, 1350, 360, 1400, 360);
            }

            //Ci + 1 -> Ci  #3
            Pen Line51 = new Pen(Color.Black);
            if (FA3CI1.Checked == true)
            {
                Pen(e, Line51, ColorOn, 1200, 360, 1300, 360);
            }
            else
            {
                Pen(e, Line51, ColorOff, 1200, 360, 1300, 360);
            }


            //Ci + 1 -> Ci  #4
            Pen Line52 = new Pen(Color.Black);
            if (FA4CI1.Checked == true)
            {
                Pen(e, Line52, ColorOn, 1086, 360, 1200, 360);
                Pen(e, Line52, ColorOn, 1085, 359, 1085, 570);
            }
            else
            {
                Pen(e, Line52, ColorOff, 1086, 360, 1200, 360);
                Pen(e, Line52, ColorOff, 1085, 359, 1085, 570);
            }

            //OFL pomiedzy Ci, Ci + 1
            Pen Line53 = new Pen(Color.Black);
            if (FA3CI1.Checked == true)
            {
                PenStartCap(e, Line53, ColorOn, 1260, 360, 1260, 500);
                Pen(e, Line53, ColorOn, 1111, 499, 1260, 499);
                Pen(e, Line53, ColorOn, 1112, 499, 1112, 600);
            }
            else
            {
                PenStartCap(e, Line53, ColorOff, 1260, 360, 1260, 500);
                Pen(e, Line53, ColorOff, 1111, 499, 1260, 499);
                Pen(e, Line53, ColorOff, 1112, 499, 1112, 600);
            }


            //OFL 
            Pen Line54 = new Pen(Color.Black);
            if (bitWyjOFL.Checked == true)
            {
                Pen(e, Line54, ColorOn, 1098, 620, 1098, 725);
            }
            else
            {
                Pen(e, Line54, ColorOff, 1098, 620, 1098, 725);
            }


            //OFL 
            Pen Line55 = new Pen(Color.Black);
            if (bitWyjOFL.Checked == true)
            {
                PenStartCap(e, Line55, ColorOn, 1098, 670, 1200, 670);
                Pen(e, Line55, ColorOn, 1199, 600, 1199, 669);
                Pen(e, Line55, ColorOn, 1198, 599, 1376, 599);
                Pen(e, Line55, ColorOn, 1377, 598, 1377, 650);
            }
            else
            {
                PenStartCap(e, Line55, ColorOff, 1098, 670, 1200, 670);
                Pen(e, Line55, ColorOff, 1199, 600, 1199, 669);
                Pen(e, Line55, ColorOff, 1198, 599, 1376, 599);
                Pen(e, Line55, ColorOff, 1377, 598, 1377, 650);
            }



            //Cn
            Pen Line56 = new Pen(Color.Black);
            if (cnKorektor.Checked == true)
            {
                PenStartCap(e, Line56, ColorOn, 1085, 450, 1396, 450);
                Pen(e, Line56, ColorOn, 1397, 449, 1397, 670);
            }
            else
            {
                PenStartCap(e, Line56, ColorOff, 1085, 450, 1396, 450);
                Pen(e, Line56, ColorOff, 1397, 449, 1397, 670);
            }


            //Si4
            Pen Line57 = new Pen(Color.Black);
            if (FA4Si.Checked == true)
            {
                Pen(e, Line57, ColorOn, 1194, 390, 1194, 550);
                Pen(e, Line57, ColorOn, 1193, 549, 1417, 549);
                Pen(e, Line57, ColorOn, 1418, 548, 1418, 650);
            }
            else
            {
                Pen(e, Line57, ColorOff, 1194, 390, 1194, 550);
                Pen(e, Line57, ColorOff, 1193, 549, 1417, 549);
                Pen(e, Line57, ColorOff, 1418, 548, 1418, 650);
            }


            //8 Bit + SI4
            Pen Line58 = new Pen(Color.Black);
            if (bitWyj8.Checked == true)
            {
                PenStartCap(e, Line58, ColorOn, 1418, 600, 1443, 600);
                Pen(e, Line58, ColorOn, 1444, 599, 1444, 757);
            }
            else
            {
                PenStartCap(e, Line58, ColorOff, 1418, 600, 1443, 600);
                Pen(e, Line58, ColorOff, 1444, 599, 1444, 757);
            }


            //SI 4 bit
            Pen Line59 = new Pen(Color.Black);
            if (FA3Si.Checked == true)
            {
                Pen(e, Line59, ColorOn, 1342, 370, 1342, 480);
                Pen(e, Line59, ColorOn, 1341, 479, 1466, 479);
                Pen(e, Line59, ColorOn, 1465, 478, 1465, 757);
            }
            else
            {
                Pen(e, Line59, ColorOff, 1342, 370, 1342, 480);
                Pen(e, Line59, ColorOff, 1341, 479, 1466, 479);
                Pen(e, Line59, ColorOff, 1465, 478, 1465, 757);
            }


            //SI 2 bit
            Pen Line60 = new Pen(Color.Black);
            if (FA2Si.Checked == true)
            {
                Pen(e, Line60, ColorOn, 1484, 370, 1485, 757);
            }
            else
            {
                Pen(e, Line60, ColorOff, 1484, 370, 1485, 757);
            }


            //SI 1 bit
            Pen Line61 = new Pen(Color.Black);
            if (FA1Si.Checked == true)
            {
                Pen(e, Line61, ColorOn, 1632, 370, 1632, 600);
                Pen(e, Line61, ColorOn, 1504, 599, 1631, 599);
                Pen(e, Line61, ColorOn, 1505, 599, 1505, 757);
            }
            else
            {
                Pen(e, Line61, ColorOff, 1632, 370, 1632, 600);
                Pen(e, Line61, ColorOff, 1504, 599, 1631, 599);
                Pen(e, Line61, ColorOff, 1505, 599, 1505, 757);
            }


            //5bit korektor
            Pen Line62 = new Pen(Color.Black);
            if (KorektorBit.Checked == true)
            {
                Pen(e, Line62, ColorOn, 1397, 650, 1397, 757);
            }
            else
            {
                Pen(e, Line62, ColorOff, 1397, 650, 1397, 757);
            }
        }





        public void PenStartCap(PaintEventArgs e, Pen Line, Color color, int x1, int y1, int x2, int y2)
        {
            base.OnPaint(e);
            Graphics g;
            g = e.Graphics;

            Line = new Pen(Color.Gray);
            Line.Width = 2;
            Line.Color = color;
            Line.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            g.DrawLine(Line, x1, y1, x2, y2);
        }

        public void PenEndCap(PaintEventArgs e, Pen Line, Color color, int x1, int y1, int x2, int y2)
        {
            base.OnPaint(e);
            Graphics g;
            g = e.Graphics;

            Line = new Pen(Color.Gray);
            Line.Width = 2;
            Line.Color = color;
            Line.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            g.DrawLine(Line, x1, y1, x2, y2);
        }

        public void Pen(PaintEventArgs e, Pen Line, Color color, int x1, int y1, int x2, int y2)
        {
            base.OnPaint(e);
            Graphics g;
            g = e.Graphics;

            Line = new Pen(Color.Gray);
            Line.Width = 2;
            Line.Color = color;
            g.DrawLine(Line, x1, y1, x2, y2);
        }






        private void C0_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz4XOR();
        }


        private void b0_CheckedChanged_1(object sender, EventArgs e)
        {
            sprawdz4XOR();
        }

        private void b1_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz4XOR();
        }

        private void b2_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz4XOR();
        }

        private void b3_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz4XOR();
        }



        public void sprawdz4XOR()
        {

            //B0
            if(C0.Checked == false && b0.Checked == false)
            {
                b0wyj.Checked = false;
            }
            else if(C0.Checked == false && b0.Checked == true)
            {
                b0wyj.Checked = true;
            }
            else if (C0.Checked == true && b0.Checked == false)
            {
                b0wyj.Checked = true;
            }
            else if (C0.Checked == true && b0.Checked == true)
            {
                b0wyj.Checked = false;
            }

            //B1
            if (C0.Checked == false && b1.Checked == false)
            {
                b1wyj.Checked = false;
            }
            else if (C0.Checked == false && b1.Checked == true)
            {
                b1wyj.Checked = true;
            }
            else if (C0.Checked == true && b1.Checked == false)
            {
                b1wyj.Checked = true;
            }
            else if (C0.Checked == true && b1.Checked == true)
            {
                b1wyj.Checked = false;
            }


            //B2
            if (C0.Checked == false && b2.Checked == false)
            {
                b2wyj.Checked = false;
            }
            else if (C0.Checked == false && b2.Checked == true)
            {
                b2wyj.Checked = true;
            }
            else if (C0.Checked == true && b2.Checked == false)
            {
                b2wyj.Checked = true;
            }
            else if (C0.Checked == true && b2.Checked == true)
            {
                b2wyj.Checked = false;
            }

            //B3
            if (C0.Checked == false && b3.Checked == false)
            {
                b3wyj.Checked = false;
            }
            else if (C0.Checked == false && b3.Checked == true)
            {
                b3wyj.Checked = true;
            }
            else if (C0.Checked == true && b3.Checked == false)
            {
                b3wyj.Checked = true;
            }
            else if (C0.Checked == true && b3.Checked == true)
            {
                b3wyj.Checked = false;
            }



            if(C0.Checked == true || C0.Checked == false || b1.Checked == true || b1.Checked == false || b2.Checked == true || b2.Checked == false || b3.Checked == true || b3.Checked == false)
            {
                Invalidate();
            }
        }




        public void sprawdzKorektor()
        {
            if(CnMinus1.Checked == false && Cn.Checked == false && Ofl.Checked == false)
            {
                piatyBit.Checked = false;
            }
            else if(CnMinus1.Checked == false && Cn.Checked == false && Ofl.Checked == true)
            {
                piatyBit.Checked = true;
            }
            else if (CnMinus1.Checked == false && Cn.Checked == true && Ofl.Checked == false)
            {
                piatyBit.Checked = false;
            }
            else if (CnMinus1.Checked == false && Cn.Checked == true && Ofl.Checked == true)
            {
                piatyBit.Checked = true;
            }
            else if (CnMinus1.Checked == true && Cn.Checked == false && Ofl.Checked == false)
            {
                piatyBit.Checked = true;
            }
            else if (CnMinus1.Checked == true && Cn.Checked == false && Ofl.Checked == true)
            {
                piatyBit.Checked = false;
            }
            else if (CnMinus1.Checked == true && Cn.Checked == true && Ofl.Checked == false)
            {
                piatyBit.Checked = true;
            }
            else if (CnMinus1.Checked == true && Cn.Checked == true && Ofl.Checked == true)
            {
                piatyBit.Checked = true;
            }

            if (CnMinus1.Checked == true || CnMinus1.Checked == false || Cn.Checked == true || Cn.Checked == false || Ofl.Checked == true || Ofl.Checked == false)
            {
                Invalidate();
            }

        }
        


        private void CnMinus1_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzKorektor();
        }

        private void Cn_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzKorektor();
        }

        private void Ofl_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzKorektor();
        }

        private void piatyBit_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzKorektor();
        }



        // SUMATOR


        private void sprawdzSumator()
        {

            //Refresh
            if (B3SUMR.Checked == true || B3SUMR.Checked == false || B2SUMR.Checked == true || B2SUMR.Checked == false || B1SUMR.Checked == true || B1SUMR.Checked == false || B0SUMR.Checked == true || B0SUMR.Checked == false || A2SUMR.Checked == true || A2SUMR.Checked == false || A1SUMR.Checked == true || A1SUMR.Checked == false || A0SUMR.Checked == true || A0SUMR.Checked == false || C0SUM.Checked == true || C0SUM.Checked == false)
            {
                Invalidate();
            }

            // 4XOR
            //0
            if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }

            //1
            else if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //2
            else if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //3
            else if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //4
            else if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }

            //5
            else if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //6
            else if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //7
            else if (C0SUM.Checked == false && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //8
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }

            //9
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //10
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //11
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //12
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }

            //13
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //14
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //15
            else if (C0SUM.Checked == false && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //16
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //17
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //18
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //19
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }

            //20
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //21
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //22
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //23
            else if (C0SUM.Checked == true && B0SUMR.Checked == false && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = true;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }

            //24
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //25
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //26
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //27
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == false && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = true;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }

            //28
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = true;
            }

            //29
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == false && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = true;
                BB3SUMR.Checked = false;
            }

            //30
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == false)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = true;
            }

            //31
            else if (C0SUM.Checked == true && B0SUMR.Checked == true && B1SUMR.Checked == true && B2SUMR.Checked == true && B3SUMR.Checked == true)
            {
                BB0SUMR.Checked = false;
                BB1SUMR.Checked = false;
                BB2SUMR.Checked = false;
                BB3SUMR.Checked = false;
            }


            if(C0SUM.Checked == true)
            {
                C03SUMR.Checked = true;
            }
            else if(C0SUM.Checked == false)
            {
                C03SUMR.Checked = false;
            }

            sprawdzFA();
        }



        private void B0SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void B1SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void B2SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void B3SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void A0SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void A1SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void A2SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void A3SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }
        private void C0SUM_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void BB0SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void BB1SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void BB2SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void BB3SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }

        private void C03SUMR_CheckedChanged(object sender, EventArgs e)
        {
            sprawdzSumator();
        }








        //FA1
        private void FA1Ci_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA1Bi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA1Ai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA1CI1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA1Si_CheckedChanged(object sender, EventArgs e)
        {

        }





        public void sprawdzFA()
        {

            // FA1
            if(BB3SUMR.Checked == true)
            {
                FA1Bi.Checked = true;
            }
            else if(BB3SUMR.Checked == false)
            {
                FA1Bi.Checked = false;
            }


            if(A3SUMR.Checked == true)
            {
                FA1Ai.Checked = true;
            }
            else if(A3SUMR.Checked == false)
            {
                FA1Ai.Checked = false;
            }

            if(C0SUM.Checked == true)
            {
                FA1Ci.Checked = true;
            }
            else if(C0SUM.Checked == false)
            {
                FA1Ci.Checked = false;
            }


            if(FA1Ai.Checked == false && FA1Bi.Checked == false && FA1Ci.Checked == false)
            {
                FA1Si.Checked = false;
                FA1CI1.Checked = false;
            }
            else if(FA1Ai.Checked == false && FA1Bi.Checked == false && FA1Ci.Checked == true)
            {
                FA1Si.Checked = true;
                FA1CI1.Checked = false;
            }
            else if(FA1Ai.Checked == false && FA1Bi.Checked == true && FA1Ci.Checked == false)
            {
                FA1Si.Checked = true;
                FA1CI1.Checked = false;
            }
            else if(FA1Ai.Checked == false && FA1Bi.Checked == true && FA1Ci.Checked == true)
            {
                FA1Si.Checked = false;
                FA1CI1.Checked = true;
            }
            else if(FA1Ai.Checked == true && FA1Bi.Checked == false && FA1Ci.Checked == false)
            {
                FA1Si.Checked = true;
                FA1CI1.Checked = false;
            }
            else if(FA1Ai.Checked == true && FA1Bi.Checked == false && FA1Ci.Checked == true)
            {
                FA1Si.Checked = false;
                FA1CI1.Checked = true;
            }
            else if(FA1Ai.Checked == true && FA1Bi.Checked == true && FA1Ci.Checked == false)
            {
                FA1Si.Checked = false;
                FA1CI1.Checked = true;
            }
            else if(FA1Ai.Checked == true && FA1Bi.Checked == true && FA1Ci.Checked == true)
            {
                FA1Si.Checked = true;
                FA1CI1.Checked = true;
            }


            if(FA1CI1.Checked == true)
            {
                FA2Ci.Checked = true;
            }
            else if(FA1CI1.Checked == false)
            {
                FA2Ci.Checked = false;
            }

            if(FA1Si.Checked == true)
            {
                bitWyj1.Checked = true;
            }
            else if(FA1Si.Checked == false)
            {
                bitWyj1.Checked = false;
            }





            //FA2

            if (BB2SUMR.Checked == true)
            {
                FA2Bi.Checked = true;
            }
            else if (BB2SUMR.Checked == false)
            {
                FA2Bi.Checked = false;
            }


            if (A2SUMR.Checked == true)
            {
                FA2Ai.Checked = true;
            }
            else if (A2SUMR.Checked == false)
            {
                FA2Ai.Checked = false;
            }


            if (FA2Ai.Checked == false && FA2Bi.Checked == false && FA2Ci.Checked == false)
            {
                FA2Si.Checked = false;
                FA2CI1.Checked = false;
            }
            else if (FA2Ai.Checked == false && FA2Bi.Checked == false && FA2Ci.Checked == true)
            {
                FA2Si.Checked = true;
                FA2CI1.Checked = false;
            }
            else if (FA2Ai.Checked == false && FA2Bi.Checked == true && FA2Ci.Checked == false)
            {
                FA2Si.Checked = true;
                FA2CI1.Checked = false;
            }
            else if (FA2Ai.Checked == false && FA2Bi.Checked == true && FA2Ci.Checked == true)
            {
                FA2Si.Checked = false;
                FA2CI1.Checked = true;
            }
            else if (FA2Ai.Checked == true && FA2Bi.Checked == false && FA2Ci.Checked == false)
            {
                FA2Si.Checked = true;
                FA2CI1.Checked = false;
            }
            else if (FA2Ai.Checked == true && FA2Bi.Checked == false && FA2Ci.Checked == true)
            {
                FA2Si.Checked = false;
                FA2CI1.Checked = true;
            }
            else if (FA2Ai.Checked == true && FA2Bi.Checked == true && FA2Ci.Checked == false)
            {
                FA2Si.Checked = false;
                FA2CI1.Checked = true;
            }
            else if (FA2Ai.Checked == true && FA2Bi.Checked == true && FA2Ci.Checked == true)
            {
                FA2Si.Checked = true;
                FA2CI1.Checked = true;
            }


            if (FA2CI1.Checked == true)
            {
                FA3Ci.Checked = true;
            }
            else if (FA2CI1.Checked == false)
            {
                FA3Ci.Checked = false;
            }

            if (FA2Si.Checked == true)
            {
                bitWyj2.Checked = true;
            }
            else if (FA2Si.Checked == false)
            {
                bitWyj2.Checked = false;
            }



            //FA3

            if (BB1SUMR.Checked == true)
            {
                FA3Bi.Checked = true;
            }
            else if (BB1SUMR.Checked == false)
            {
                FA3Bi.Checked = false;
            }


            if (A1SUMR.Checked == true)
            {
                FA3Ai.Checked = true;
            }
            else if (A1SUMR.Checked == false)
            {
                FA3Ai.Checked = false;
            }


            if (FA3Ai.Checked == false && FA3Bi.Checked == false && FA3Ci.Checked == false)
            {
                FA3Si.Checked = false;
                FA3CI1.Checked = false;
            }
            else if (FA3Ai.Checked == false && FA3Bi.Checked == false && FA3Ci.Checked == true)
            {
                FA3Si.Checked = true;
                FA3CI1.Checked = false;
            }
            else if (FA3Ai.Checked == false && FA3Bi.Checked == true && FA3Ci.Checked == false)
            {
                FA3Si.Checked = true;
                FA3CI1.Checked = false;
            }
            else if (FA3Ai.Checked == false && FA3Bi.Checked == true && FA3Ci.Checked == true)
            {
                FA3Si.Checked = false;
                FA3CI1.Checked = true;
            }
            else if (FA3Ai.Checked == true && FA3Bi.Checked == false && FA3Ci.Checked == false)
            {
                FA3Si.Checked = true;
                FA3CI1.Checked = false;
            }
            else if (FA3Ai.Checked == true && FA3Bi.Checked == false && FA3Ci.Checked == true)
            {
                FA3Si.Checked = false;
                FA3CI1.Checked = true;
            }
            else if (FA3Ai.Checked == true && FA3Bi.Checked == true && FA3Ci.Checked == false)
            {
                FA3Si.Checked = false;
                FA3CI1.Checked = true;
            }
            else if (FA3Ai.Checked == true && FA3Bi.Checked == true && FA3Ci.Checked == true)
            {
                FA3Si.Checked = true;
                FA3CI1.Checked = true;
            }


            if (FA3CI1.Checked == true)
            {
                FA4Ci.Checked = true;
            }
            else if (FA3CI1.Checked == false)
            {
                FA4Ci.Checked = false;
            }

            if (FA3Si.Checked == true)
            {
                bitWyj4.Checked = true;
            }
            else if (FA3Si.Checked == false)
            {
                bitWyj4.Checked = false;
            }





            //FA4

            if (BB0SUMR.Checked == true)
            {
                FA4Bi.Checked = true;
            }
            else if (BB0SUMR.Checked == false)
            {
                FA4Bi.Checked = false;
            }


            if (A0SUMR.Checked == true)
            {
                FA4Ai.Checked = true;
            }
            else if (A0SUMR.Checked == false)
            {
                FA4Ai.Checked = false;
            }


            if (FA4Ai.Checked == false && FA4Bi.Checked == false && FA4Ci.Checked == false)
            {
                FA4Si.Checked = false;
                FA4CI1.Checked = false;
            }
            else if (FA4Ai.Checked == false && FA4Bi.Checked == false && FA4Ci.Checked == true)
            {
                FA4Si.Checked = true;
                FA4CI1.Checked = false;
            }
            else if (FA4Ai.Checked == false && FA4Bi.Checked == true && FA4Ci.Checked == false)
            {
                FA4Si.Checked = true;
                FA4CI1.Checked = false;
            }
            else if (FA4Ai.Checked == false && FA4Bi.Checked == true && FA4Ci.Checked == true)
            {
                FA4Si.Checked = false;
                FA4CI1.Checked = true;
            }
            else if (FA4Ai.Checked == true && FA4Bi.Checked == false && FA4Ci.Checked == false)
            {
                FA4Si.Checked = true;
                FA4CI1.Checked = false;
            }
            else if (FA4Ai.Checked == true && FA4Bi.Checked == false && FA4Ci.Checked == true)
            {
                FA4Si.Checked = false;
                FA4CI1.Checked = true;
            }
            else if (FA4Ai.Checked == true && FA4Bi.Checked == true && FA4Ci.Checked == false)
            {
                FA4Si.Checked = false;
                FA4CI1.Checked = true;
            }
            else if (FA4Ai.Checked == true && FA4Bi.Checked == true && FA4Ci.Checked == true)
            {
                FA4Si.Checked = true;
                FA4CI1.Checked = true;
            }


            if (FA3CI1.Checked == true)
            {
                FA4Ci.Checked = true;
            }
            else if (FA3CI1.Checked == false)
            {
                FA4Ci.Checked = false;
            }

            if (FA4Si.Checked == true)
            {
                bitWyj8.Checked = true;
            }
            else if (FA4Si.Checked == false)
            {
                bitWyj8.Checked = false;
            }



            //DALEJ XOR
            if((FA4CI1.Checked == true && FA3CI1.Checked == false) || (FA4CI1.Checked == false && FA3CI1.Checked == true))
            {
                bitWyjOFL.Checked = true;
            }
            else
            {
                bitWyjOFL.Checked = false;
            }



            //Korektor
            if(FA4CI1.Checked == true)
            {
                cnKorektor.Checked = true;
            }
            else
            {
                cnKorektor.Checked = false;
            }

            if(bitWyjOFL.Checked == true)
            {
                oflKorektor.Checked = true;
            }
            else
            {
                oflKorektor.Checked = false;
            }

            if (FA4Si.Checked == true)
            {
                Cn1Korektor.Checked = true;
            }
            else
            {
                Cn1Korektor.Checked = false;
            }


            // SAM KOREKTOR
            if(Cn1Korektor.Checked == false && cnKorektor.Checked == false && oflKorektor.Checked == false)
            {
                KorektorBit.Checked = false;
            }
            else if (Cn1Korektor.Checked == false && cnKorektor.Checked == false && oflKorektor.Checked == true)
            {
                KorektorBit.Checked = true;
            }
            else if (Cn1Korektor.Checked == false && cnKorektor.Checked == true && oflKorektor.Checked == false)
            {
                KorektorBit.Checked = false;
            }
            else if (Cn1Korektor.Checked == false && cnKorektor.Checked == true && oflKorektor.Checked == true)
            {
                KorektorBit.Checked = true;
            }
            else if (Cn1Korektor.Checked == true && cnKorektor.Checked == false && oflKorektor.Checked == false)
            {
                KorektorBit.Checked = true;
            }
            else if (Cn1Korektor.Checked == true && cnKorektor.Checked == false && oflKorektor.Checked == true)
            {
                KorektorBit.Checked = false;
            }
            else if (Cn1Korektor.Checked == true && cnKorektor.Checked == true && oflKorektor.Checked == false)
            {
                KorektorBit.Checked = true;
            }
            else if (Cn1Korektor.Checked == true && cnKorektor.Checked == true && oflKorektor.Checked == true)
            {
                KorektorBit.Checked = true;
            }


            if(KorektorBit.Checked == true)
            {
                bitWyj16.Checked = true;
            }
            else
            {
                bitWyj16.Checked = false;
            }


        }

        //FA2
        private void FA2Ci_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bitWyj1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA2Ai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA2Bi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA2CI1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA2Si_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FA3Ci_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bitWyj2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bitWyj4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bitWyj8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bitWyj16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bitWyjOFL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}