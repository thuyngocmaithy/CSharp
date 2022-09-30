using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace LAB4
{
    public partial class Form1 : Form
    {
        List<String> ds = new List<String>();
        Boolean AS;
        string group = "Restricted Access";
        string strDateTime = "";
        public Form1()
        {
            InitializeComponent();
            txtSC.PasswordChar = '*';

        }


       
        public void Enter()
        {
            string code = txtSC.Text;
            DateTime dateTime = DateTime.Now;
            strDateTime = dateTime.ToString("dd/MM/yyyy hh:mm:ss");
            switch(code)
            {
                case "1645":
                    AS = true;
                    group = "Technicians";
                    break;
                case "1689":
                    AS = true;
                    group = "Technicians";
                    break;
                case "8345":
                    AS = true;
                    group = "Custodians";
                    break;
                case "9998":
                    AS = true;
                    group = "Scientist";
                    break;
                case "1006":
                    AS = true;
                    group = "Scientist";
                    break;
                case "1008":
                    AS = true;
                    group = "Scientist";
                    break;
                default:
                    group = "Restricted Access";
                    break;
            }
            addList();
            ghiFile();
        }
        public void addList()
        {           
            lsb.Items.Add(strDateTime + "   " + group);
            ds.Add(lsb.Items[lsb.Items.Count-1].ToString());
        }
        public void ghiFile()
        {
            try
            {
                string path = Application.StartupPath + "\\text.txt";
                bool kq = luufile.FileLuu(ds,path);
                if(kq==true)
                {
                    MessageBox.Show("Bạn đã lưu thành công");
                }    
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            Enter();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSC.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            txtSC.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSC.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSC.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSC.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSC.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSC.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSC.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSC.Text += "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSC.Text += "0";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSC.Text = "";

        }
    }
}
