using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FormatText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            this.CancelButton = btnExit;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLT.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    txtNhapTen.ForeColor = Color.Red;
                    txtLT.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    txtNhapTen.ForeColor = Color.Green;
                    txtLT.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    txtNhapTen.ForeColor = Color.Blue;
                    txtLT.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    txtNhapTen.ForeColor = Color.Black;
                    txtLT.ForeColor = Color.Black;
                    break;
            }    
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r = (CheckBox)sender;
            switch(r.Name)
            {
                case "chkBold":
                    txtLT.Font = new Font(txtLT.Font.Name, txtLT.Font.Size, txtLT.Font.Style ^ FontStyle.Bold);
                    break;
                case "chkItalic":
                    txtLT.Font = new Font(txtLT.Font.Name, txtLT.Font.Size, txtLT.Font.Style ^ FontStyle.Italic);
                    break;
                case "chkUnderline":
                    txtLT.Font = new Font(txtLT.Font.Name, txtLT.Font.Size, txtLT.Font.Style ^ FontStyle.Underline);
                    break;
            }    
        }
    }
}
