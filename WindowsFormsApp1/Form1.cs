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
            texbot = 12;
        }

        private void Add_Point_Click(object sender, EventArgs e)
        {
            MPoint point = new MPoint();
            point.X = Convert.ToInt32(textBoxX.Text);
            point.Y = Convert.ToInt32(textBoxY.Text);
            point.Z = Convert.ToInt32(textBoxZ.Text);
            //point = MPoint.Test(point);
            point.correct();
            _path.trajectory.Add(point);
            listBox1.Items.Add("X = " + point.X + "; Y = " + point.Y + ";  Z = " + point.Z);
        }

        private void Go_to_point_Click(object sender, EventArgs e)
        {
            MPoint point = new MPoint();
            point.X = Convert.ToInt32(textBoxX.Text);
            point.Y = Convert.ToInt32(textBoxY.Text);
            point.Z = Convert.ToInt32(textBoxZ.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test testServo = new Test();
            testServo.ShowDialog();
        }
    }
}
