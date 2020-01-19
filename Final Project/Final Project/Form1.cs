using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;

namespace Final_Project
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoPigLatin.Checked = true;           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtEnglish.Text))
            {
                if (rdoPigGreek.Checked)
                {
                    PigGreekTranslator pig = new PigGreekTranslator(txtEnglish.Text);
                    txtTranslation.Text = pig.Translate();

                }
                else if (rdoPigLatin.Checked)
                {
                    PigLatinTranslator pigLatin = new PigLatinTranslator(txtEnglish.Text);
                    txtTranslation.Text = pigLatin.Translate();
                }
            }
            else
            {
                MessageBox.Show("Please enter text to be translated", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnglish.Focus();
            }
        }

        private void rdoPigLatin_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslationType.Text = "Pig Latin translation";
        }

        private void rdoPigGreek_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslationType.Text = "Pig Greek translation";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clear = MessageBox.Show("Are you sure you want to clear? \r\n Once clear entry will be lost", "Delete Result?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


            if(clear == DialogResult.Yes)
            {
                txtEnglish.Text = string.Empty;
                txtTranslation.Text = string.Empty;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure you want to exit", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.No) e.Cancel = true;

        }
    }
}
