using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robert_Hardin_AbilityDemo
{
    public partial class Form1 : Form
    {
        UserControl1 UC1;
        UserControl2 UC2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Add UC1")
            {
                UserControl1 label = new UserControl1();
                UC1 = label;
                UC1.Location = new Point(85,30);
                this.Controls.Add(UC1);
                button1.Text = "Remove UC1";
            }
            else
            {
                this.Controls.Remove(UC1);
                UC1.Dispose();
                button1.Text = "Add UC1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Add UC2")
            {
                UserControl2 textbox = new UserControl2();
                UC2 = textbox;
                UC2.Location = new Point(85, 90);
                this.Controls.Add(UC2);
                button2.Text = "Remove UC2";
            }
            else
            {
                this.Controls.Remove(UC2);
                UC2.Dispose();
                button2.Text = "Add UC2";
            }
        }
    }
}
