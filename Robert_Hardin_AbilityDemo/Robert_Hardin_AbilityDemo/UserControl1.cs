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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            label1.Text = "User Control 1";
            label1.Size = new System.Drawing.Size(500, 50);
            label1.Font = new Font("Arial", 35, FontStyle.Bold);
        }
    }
}
