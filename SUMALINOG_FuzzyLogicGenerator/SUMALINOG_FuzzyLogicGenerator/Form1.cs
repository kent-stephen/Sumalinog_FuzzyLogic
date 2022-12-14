using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotFuzzy;

namespace SUMALINOG_FuzzyLogicGenerator
{
    public partial class Form1 : Form
    {
        FuzzyEngine fe;
        MembershipFunctionCollection speed, distance;
        LinguisticVariable mySpeed, myDistance;
        FuzzyRuleCollection myRules;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void setMembers()
        {
            speed = new MembershipFunctionCollection();
            speed.Add(new MembershipFunction("Slow", 0, 0, 10, 20);
            speed.Add(new MembershipFunction("Medium", 0, 10, 20, 100));
            speed.Add(new MembershipFunction("Fast", 10, 20, 100, 100));
            mySpeed = new LinguisticVariable("Speed", speed);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
