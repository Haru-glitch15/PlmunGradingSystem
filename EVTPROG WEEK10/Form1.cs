using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVTPROG_WEEK10
{
    public partial class Form1: Form
    {
        double MQ1Ave, MQ2Ave, MQ3Ave,MQ4Ave, MEAve;

        double FQ1Ave, FQ2Ave, FQ3Ave, FQ4Ave, FEAve;

        double MCP, MA, MidtermLecGrade, MidtermLabGrade, MidTermGrade;

        

        double FCP, FA, FinaltermLecGrade, FinaltermLabGrade, FinalTermGrade;

        
        public void computeGrades()
        {
            //Midterm
            double.TryParse(txtMCP.Text, out MCP);
            double.TryParse(txtMA.Text, out MA);

            double.TryParse(txtMQ1Ave.Text, out MQ1Ave);
            double.TryParse(txtMQ2Ave.Text, out MQ2Ave);
            double.TryParse(txtMQ3Ave.Text, out MQ3Ave);
            double.TryParse(txtMQ4Ave.Text, out MQ4Ave);

            double.TryParse(txtMEAve.Text, out MEAve);
            double.TryParse(txtMLabGrade.Text, out MidtermLabGrade);

            //Finals
            double.TryParse(txtFCP.Text, out FCP);
            double.TryParse(txtFA.Text, out FA);

            double.TryParse(txtFQ1Ave.Text, out FQ1Ave);
            double.TryParse(txtFQ2Ave.Text, out FQ2Ave);
            double.TryParse(txtFQ3Ave.Text, out FQ3Ave);
            double.TryParse(txtFQ4Ave.Text, out FQ4Ave);

            double.TryParse(txtFinalAve.Text, out FEAve);
            double.TryParse(txtFLabGrade.Text, out FinaltermLabGrade);

            //Midterm calculations
            MidtermLecGrade = (MA * .10) + (MCP * .20) + (((MQ1Ave + MQ2Ave + MQ3Ave + MQ4Ave) / 4) * .30) + (MEAve * .40);
            MidTermGrade = (MidtermLecGrade * .60) + (MidtermLabGrade * .40);

            txtMidtermGrade.Text = MidTermGrade.ToString("F2");

            //Finals calculations
            FinaltermLecGrade = (FA * .10) + (FCP * .20) + (((FQ1Ave + FQ2Ave + FQ3Ave + FQ4Ave) / 4) * .30) + (FEAve * .40);
            FinalTermGrade = (FinaltermLecGrade * .60) + (FinaltermLabGrade * .40);

            txtFinalGrade.Text = FinalTermGrade.ToString("F2");
        }

       

        public Form1()
        {
            InitializeComponent();
        }

        
        private void txtMQ1_TextChanged(object sender, EventArgs e)
        {
            string MItemsQ1 = cboMItemsQ1.SelectedItem.ToString();
            // (2/10)*60+40
            MQ1Ave = Convert.ToDouble(txtMQ1.Text) / Convert.ToDouble(MItemsQ1) * 60 + 40;

            txtMQ1Ave.Text = MQ1Ave.ToString("F2");
        }

        private void txtMQ2_TextChanged(object sender, EventArgs e)
        {
            String MItemsQ2 = cboMItemsQ2.SelectedItem.ToString();

            MQ2Ave = Convert.ToDouble(txtMQ2.Text) / Convert.ToDouble(MItemsQ2) * 60 + 40;

            txtMQ2Ave.Text = MQ2Ave.ToString("F2");
        }

        private void txtMQ3_TextChanged(object sender, EventArgs e)
        {
            String MItemsQ3 = cboMItemsQ3.SelectedItem.ToString();

            MQ3Ave = Convert.ToDouble(txtMQ3.Text) / Convert.ToDouble(MItemsQ3) * 60 + 40;

            txtMQ3Ave.Text = MQ3Ave.ToString("F2");
        }

        private void txtMQ4_TextChanged(object sender, EventArgs e)
        {
            String MItemsQ4 = cboMItemsQ4.SelectedItem.ToString();

            MQ4Ave = Convert.ToDouble(txtMQ4.Text) / Convert.ToDouble(MItemsQ4) * 60 + 40;

            txtMQ4Ave.Text = MQ4Ave.ToString("F2");
        }
        private void txtME_TextChanged(object sender, EventArgs e)
        {
            String MItemsME = cboMItemsME.SelectedItem.ToString();

            MEAve = Convert.ToDouble(txtME.Text) / Convert.ToDouble(MItemsME) * 60 + 40;

            txtMEAve.Text = MEAve.ToString("F2");
        }

        private void txtFQ1_TextChanged(object sender, EventArgs e)
        {
            string FItemsQ1 = cboFItemsQ1.SelectedItem.ToString();
            
            FQ1Ave = Convert.ToDouble(txtFQ1.Text) / Convert.ToDouble(FItemsQ1) * 60 + 40;

            txtFQ1Ave.Text = FQ1Ave.ToString("F2");
        }

        private void txtFQ2_TextChanged(object sender, EventArgs e)
        {
            string FItemsQ2 = cboFItemsQ2.SelectedItem.ToString();

            FQ2Ave = Convert.ToDouble(txtFQ2.Text) / Convert.ToDouble(FItemsQ2) * 60 + 40;

            txtFQ2Ave.Text = FQ2Ave.ToString("F2");
        }

        private void txtFQ3_TextChanged(object sender, EventArgs e)
        {
            string FItemsQ3 = cboFItemsQ3.SelectedItem.ToString();

            FQ3Ave = Convert.ToDouble(txtFQ3.Text) / Convert.ToDouble(FItemsQ3) * 60 + 40;

            txtFQ3Ave.Text = FQ3Ave.ToString("F2");
        }

        private void txtFQ4_TextChanged(object sender, EventArgs e)
        {
            string FItemsQ4 = cboFItemsQ4.SelectedItem.ToString();

            FQ4Ave = Convert.ToDouble(txtFQ4.Text) / Convert.ToDouble(FItemsQ4) * 60 + 40;

            txtFQ4Ave.Text = FQ4Ave.ToString("F2");
        }

        private void txtFEAve_TextChanged(object sender, EventArgs e)
        {
            String FItemsME = cboFItemsFE.SelectedItem.ToString();

            FEAve = Convert.ToDouble(txtFE.Text) / Convert.ToDouble(FItemsME) * 60 + 40;

            txtFEAve.Text = FEAve.ToString("F2");
        }
        private void txtMCP_TextChanged(object sender, EventArgs e)
        {
            computeGrades();
        }

        private void txtMA_TextChanged(object sender, EventArgs e)
        {
            computeGrades();
        }

        private void txtMLabGrade_TextChanged(object sender, EventArgs e)
        {
            computeGrades();
        }
        private void txtFLabGrade_TextChanged(object sender, EventArgs e)
        {
            computeGrades();
        }

        private void txtFA_TextChanged(object sender, EventArgs e)
        {
            computeGrades();
        }

        private void txtFCP_TextChanged(object sender, EventArgs e)
        {
            computeGrades();
        }

    }
}
