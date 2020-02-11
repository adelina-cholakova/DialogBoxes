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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNameBtn_Click(object sender, EventArgs e)
        {
            AddNameDialog addNameDialog = new AddNameDialog();
            if (addNameDialog.ShowDialog() == DialogResult.OK)
            {
                enteredNameTb.Text = addNameDialog.NameValue;
                namesListBox.Items.Add(addNameDialog.NameValue);
            }
        }

        private void addScolarshipBtn_Click(object sender, EventArgs e)
        {
            AddScolarshipDialog addScolarshipDialog = new AddScolarshipDialog();
            
            if (addScolarshipDialog.ShowDialog()==DialogResult.OK)
            {
                scolarshipsListBox.Items.Add(addScolarshipDialog.SalaryValue);
            }
        }
    }
}
