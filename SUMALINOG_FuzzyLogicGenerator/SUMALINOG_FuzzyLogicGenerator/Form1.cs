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
        MembershipFunctionCollection speed, distance, carspeed;
        LinguisticVariable mySpeed, myDistance, myCarSpeed;
        FuzzyRuleCollection myRules;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void setMembers()
        {
            speed = new MembershipFunctionCollection();
            speed.Add(new MembershipFunction("Slow", 0.0, 0.0, 45.0, 50.0));
            speed.Add(new MembershipFunction("Medium", 45.0, 50.0, 50.0, 55.0));
            speed.Add(new MembershipFunction("Fast", 50.0, 55.0, 100.0, 100.0));
            mySpeed = new LinguisticVariable("SPEED", speed);

            distance = new MembershipFunctionCollection();
            distance.Add(new MembershipFunction("Close", 0.0, 0.0, 10.0, 20.0));
            distance.Add(new MembershipFunction("Far", 10.0, 20.0, 100.0, 100.0));
            myDistance = new LinguisticVariable("DISTANCE", distance);

            carspeed = new MembershipFunctionCollection();
            carspeed.Add(new MembershipFunction("Slow", 0.0, 0.0, 45.0, 50.0));
            carspeed.Add(new MembershipFunction("Medium", 45.0, 50.0, 50.0, 55.0));
            carspeed.Add(new MembershipFunction("Fast", 50.0, 55.0, 100.0, 100.0));
            myCarSpeed = new LinguisticVariable("CARSPEED", carspeed);

        }

        public void setRules()
        {
            myRules = new FuzzyRuleCollection();
            myRules.Add(new FuzzyRule("IF (DISTANCE IS Close) AND (SPEED IS Slow)  THEN CARSPEED IS Slow"));
            myRules.Add(new FuzzyRule("IF (DISTANCE IS Close) AND (SPEED IS Medium)  THEN CARSPEED IS Slow"));
            myRules.Add(new FuzzyRule("IF (DISTANCE IS Close) AND (SPEED IS Fast)  THEN CARSPEED IS Medium"));
            myRules.Add(new FuzzyRule("IF (DISTANCE IS Far) AND (SPEED IS Slow)  THEN CARSPEED IS Medium"));
            myRules.Add(new FuzzyRule("IF (DISTANCE IS Far) AND (SPEED IS Medium)  THEN CARSPEED IS Medium"));
            myRules.Add(new FuzzyRule("IF (DISTANCE IS Far) AND (SPEED IS Fast)  THEN CARSPEED IS Fast"));
        }

        public void setFuzzyEngine()
        {
            fe = new FuzzyEngine();
            fe.LinguisticVariableCollection.Add(mySpeed);
            fe.LinguisticVariableCollection.Add(myDistance);
            fe.LinguisticVariableCollection.Add(myCarSpeed);
            fe.FuzzyRuleCollection = myRules;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setMembers();
            setRules();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_speed.Text = trackBar1.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lbl_distance.Text = trackBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySpeed.InputValue = double.Parse(lbl_speed.Text);
            mySpeed.Fuzzify("Medium");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setFuzzyEngine();
            fe.Consequent = "CARSPEED";
            lbl_carspeed.Text = "" + fe.Defuzzify();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            myDistance.InputValue = trackBar2.Value;
            
        }

        public void FuzzifyValues()
        {
            mySpeed.InputValue = trackBar1.Value;
            mySpeed.Fuzzify("Slow");
            myDistance.InputValue = trackBar2.Value;
            myDistance.Fuzzify("Close");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myDistance.InputValue = double.Parse(lbl_distance.Text);
            myDistance.Fuzzify("Far");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
