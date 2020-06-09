using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleet_and_Defense_Ratios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numLF_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(numLF.Text, "[^0-9]"))
            {
                
                numLF.Text = numLF.Text.Remove(numLF.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tLF = int.Parse(numLF.Text);
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tP = tLF / 10;
                int tB = tLF / 15;

                if (((TextBox)sender).Modified)
                {
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }


        }

        private void numHF_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numHF.Text, "[^0-9]"))
            {
                
                numHF.Text = numHF.Text.Remove(numHF.Text.Length - 1);
            }
            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tHF = int.Parse(numHF.Text);
                int tLF = tHF * 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tP = tLF / 10;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numC.Text, "[^0-9]"))
            {
                
                numC.Text = numC.Text.Remove(numC.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tC = int.Parse(numC.Text);
                int tLF = tC * 5;
                int tHF = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tP = tLF / 10;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numBS_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numBS.Text, "[^0-9]"))
            {
                
                numBS.Text = numBS.Text.Remove(numBS.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tBS = int.Parse(numBS.Text);
                int tLF = tBS * 30;
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tP = tLF / 10;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numP.Text, "[^0-9]"))
            {
                
                numP.Text = numP.Text.Remove(numP.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tP = int.Parse(numP.Text);
                int tLF = tP * 30;
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numBC_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numBC.Text, "[^0-9]"))
            {
                
                numBC.Text = numBC.Text.Remove(numBC.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tBC = int.Parse(numBC.Text);
                int tLF = tBC * 15;
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tP = tLF / 10;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numDS.Text = tDS.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numB.Text, "[^0-9]"))
            {
                
                numB.Text = numB.Text.Remove(numB.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tB = int.Parse(numB.Text);
                int tLF = tB * 15;
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tP = tLF / 10;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numD_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numD.Text, "[^0-9]"))
            {
                
                numD.Text = numD.Text.Remove(numD.Text.Length - 1);
            }
            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tD = int.Parse(numD.Text);
                int tLF = tD * 30;
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tBC = tLF / 15;
                int tDS = tLF / 1000;
                int tR = tLF / 30;
                int tP = tLF / 10;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numDS_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numDS.Text, "[^0-9]"))
            {
                
                numDS.Text = numDS.Text.Remove(numDS.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tDS = int.Parse(numDS.Text);
                int tLF = tDS * 1000;
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tR = tLF / 30;
                int tP = tLF / 10;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numP.Text = tR.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void numR_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numR.Text, "[^0-9]"))
            {
                numR.Text = numR.Text.Remove(numR.Text.Length - 1);
            }

            if (numD.Text != null && numD.Text.Length > 0)
            {
                int tR = int.Parse(numR.Text);
                int tLF = tR * 30;
                int tDS = tLF / 1000;
                int tHF = tLF / 5;
                int tC = tLF / 5;
                int tBS = tLF / 30;
                int tD = tLF / 30;
                int tBC = tLF / 15;
                int tP = tLF / 10;
                int tB = tLF / 15;
                if (((TextBox)sender).Modified)
                {
                    numLF.Text = tLF.ToString();
                    numHF.Text = tHF.ToString();
                    numC.Text = tC.ToString();
                    numBS.Text = tBS.ToString();
                    numD.Text = tD.ToString();
                    numBC.Text = tBC.ToString();
                    numDS.Text = tDS.ToString();
                    numR.Text = tP.ToString();
                    numB.Text = tB.ToString();
                    int tMet = (tLF * 3000) + (tHF * 6000) + (tC * 20000) + (tBS * 45000) + (tBC * 30000) + (tB * 50000) + (tD * 60000) + (tDS * 5000000);
                    int tCry = (tLF * 1000) + (tHF * 4000) + (tC * 7000) + (tBS * 15000) + (tBC * 40000) + (tB * 25000) + (tD * 50000) + (tDS * 4000000);
                    int tDeu = (tC * 7000) + (tBC * 15000) + (tB * 15000) + (tD * 15000) + (tDS * 1000000);
                    numMetCost.Text = tMet.ToString();
                    numCryCost.Text = tCry.ToString();
                    numDeuCost.Text = tDeu.ToString();
                }
            }
            else
            {
                numLF.Text = "";
                numHF.Text = "";
                numC.Text = "";
                numBS.Text = "";
                numBC.Text = "";
                numDS.Text = "";
                numD.Text = "";
                numP.Text = "";
                numR.Text = "";
                numB.Text = "";
                numMetCost.Text = "";
                numCryCost.Text = "";
                numDeuCost.Text = "";
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
