using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngineV2
{
    public partial class Form1 : Form
    {
        //Global variables

        int x = 0;
        double v;
        double a;
        int t;
        double g = 9.82;
        double y;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ProjectilePosLabel_Click(object sender, EventArgs e)
        {

        }

        private void TargetPosLabel_Click(object sender, EventArgs e)
        {

        }

        private void InitialVelocityLabel_Click(object sender, EventArgs e)
        {

        }

        private void InitialAngleLabel_Click(object sender, EventArgs e)
        {

        }

        private void IsTargetHitLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProjectilePosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TargetPosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitialVelocityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitialAngleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IsTargetHitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            GameLoopTimer.Start();
        }

        private void GameLoopTimer_Tick(object sender, EventArgs e)
        {
            x++;
            
            a = Convert.ToDouble(InitialAngleTextBox.Text);
            v = Convert.ToDouble(InitialVelocityTextBox.Text);
            
            if (x<100)
            {
                y = -g / (2 * Math.Pow(v, 2) * Math.Pow(Math.Cos(a), 2)) * Math.Pow(x, 2) + Math.Tan(a) * x;

            } else {

                GameLoopTimer.Stop();
            }

            ProjectilePosTextBox.Text = "Y: " + Convert.ToString(y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

