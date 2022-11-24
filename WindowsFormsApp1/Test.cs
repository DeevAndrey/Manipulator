using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxX.Text = Convert.ToString(trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBoxY.Text = trackBar2.Value.ToString();
        }
    }
}
