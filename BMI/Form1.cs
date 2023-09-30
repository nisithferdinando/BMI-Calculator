using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string name;
            float height;
            float weight;
            float bmi;
            name = txtName.Text;
            height = float.Parse(txtHeight.Text);
            weight = float.Parse(txtWeight.Text);
            bmi=weight / (height * height);
            //MessageBox.Show("Your BMI Value is " +bmi);
            if (bmi < 18.5)
            {
                MessageBox.Show("Hi " +name+"\n"+"Your BMI is " + bmi + "\nA BMI of less than 18.5 indicates that you are underweight, so you may need to put on some weight. You are recommended to ask your doctor or a dietitian for advice.", "BMI",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            else if(bmi>=18.5 && bmi<25.0)
            {
                MessageBox.Show("Hi " + name + "\n" + "Your BMI is " + bmi + "\nA BMI of 18.5-24.9 indicates that you are at a healthy weight for your height. By maintaining a healthy weight, you lower your risk of developing serious health problems","BMI",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            }
            else if(bmi>=25.0 && bmi<30.0)
            {
                MessageBox.Show("Hi " + name + "\n" + "Your BMI is " + bmi + "\nA BMI of 25-29.9 indicates that you are slightly overweight. You may be advised to lose some weight for health reasons. You are recommended to talk to your doctor or a dietitian for advice.","BMI",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            else if(bmi>=30.0)
            {
                MessageBox.Show("Hi " + name + "\n" + "Your BMI is " +bmi+ "\nA BMI of over 30 indicates that you are heavily overweight. Your health may be at risk if you do not lose weight. You are recommended to talk to your doctor or a dietitian for advice.", "BMI",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please enter correct values","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtName.Clear();
            txtWeight.Clear();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
