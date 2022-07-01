using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robert_Hardin_AbilityDemo
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            textBox1.Text = "User Control 2";
            textBox1.Size = new System.Drawing.Size(300, 50);
            textBox1.Font = new Font("Arial", 30, FontStyle.Bold);
        }
    }
}
