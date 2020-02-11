using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueBoxes
{
    public partial class AddScolarshipDialog : Form
    {
        public double SalaryValue
        {
            get { return double.Parse(calculatedSalaryTb.Text); }
        }

        public AddScolarshipDialog()
        {
            InitializeComponent();
        }

        private void calcScolarshipBtn_Click(object sender, EventArgs e)
        {
            double scolarship=0;
            double euScolarship=0;
            double salary=0;
            double income=0;
            try
            {
                scolarship = double.Parse(enterScolarshipTb.Text.Trim());
                euScolarship = double.Parse(enterEUScolTb.Text.Trim());
                salary = double.Parse(enterSalaryTb.Text.Trim());
                income = double.Parse(incomeTb.Text.Trim());
            }
            catch (FormatException)
            {

                MessageBox.Show("Въведените данни са в некоректен формат","Невалидни данни");
            }
            double calculatedSalary = scolarship + euScolarship + salary + income;
            calculatedSalaryTb.Text = calculatedSalary.ToString();
            calculatedSalaryTb.Visible = true;
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
