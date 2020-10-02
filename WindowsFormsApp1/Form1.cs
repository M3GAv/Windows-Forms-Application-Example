using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String adress = txtAdress.Text;

            MessageBox.Show("Hello " + name + " " + adress);
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstCity.GetItemText(lstCity.SelectedItem);

            MessageBox.Show(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtAdress.Text = "";
            this.txtName.Text = "";
            this.lstCity.SelectedItem = "";
            this.rdFemale.Checked = false;
            this.rdMale.Checked = false;
            this.chkC.Checked = false;
            this.chkASP.Checked = false;
        }
    }
}
