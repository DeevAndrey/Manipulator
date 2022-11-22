using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manipulator;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        path _path = new path();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Add_Point_Click(object sender, EventArgs e)
        {
            MPoint point = new MPoint();
            point.X = Convert.ToInt32(textBoxX.Text);
            point.Y = Convert.ToInt32(textBoxY.Text);
            point.Z = Convert.ToInt32(textBoxZ.Text);
            _path.trajectory.Add(point);
            listBox1.Items.Add("X = " + textBoxX.Text + "; Y = " + textBoxY.Text + ";  Z = " + textBoxZ.Text);
        }

        private void Go_to_point_Click(object sender, EventArgs e)
        {

        }
    }
}
