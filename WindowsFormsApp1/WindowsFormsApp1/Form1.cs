using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Govedo insGovedo = new Govedo();
        private List<Govedo> govedo = new List<Govedo>();

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            string ime = txtBoxIme.Text;
            string spol = txtBoxSpol.Text;
            string boja = txtBoxBoja.Text;
            govedo.Add(new Govedo(ime, spol, boja));
            txtBoxIme.Clear();
            txtBoxSpol.Clear();
            txtBoxBoja.Clear();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            string uvjetBoja = txtUvjetBoja.Text;
            string uvjetSpol = txtUvjetSpol.Text;
            txtBoxIspis.Text = insGovedo.IspisGovedo(govedo, uvjetBoja, uvjetSpol);
            txtUvjetBoja.Clear();
            txtUvjetSpol.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
