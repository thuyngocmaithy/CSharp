using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RememberAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.nameUser != string.Empty)
            {
                txtName.Text = Properties.Settings.Default.nameUser;
                txtPass.Text = Properties.Settings.Default.passUser;
                if (Properties.Settings.Default.check == 1)
                {
                    ckbRemember.Checked = true;
                }
                else
                {
                    ckbRemember.Checked = false;
                }
            }
            else
            {
                txtName.Text = "";
                txtPass.Text = "";
            }    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (ckbRemember.Checked)
            {
                Properties.Settings.Default.nameUser = txtName.Text;
                Properties.Settings.Default.passUser = txtPass.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.check = 1;
            }
            else
            {
                Properties.Settings.Default.nameUser = "";
                Properties.Settings.Default.passUser = "";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.check = 0;
            }    
            ShowMyDialogBox();
        }

        public void ShowMyDialogBox()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ckbRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRemember.Checked)
            {
                Properties.Settings.Default.check = 1;
            }
            else
            {
                Properties.Settings.Default.check = 0;
            }
        }
    }
}
