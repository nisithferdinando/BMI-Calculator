using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name;
            float height;
            float weight;
            float bmi;
            name = textName.Text;
            height = float.Parse(textHeight.Text);
            weight = float.Parse(textWeight.Text);
            bmi = weight / (height * height);

            try
            {
                if (name == "")
                {
                    MessageBox.Show("Please enter your name");
                }

                else if (height == 0)
                {
                    MessageBox.Show("Please enter your height");
                }
                else if (weight == 0)
                {
                    MessageBox.Show("Please enter your weight");
                }
                else if (bmi < 18.5)
                {
                    textBmi.Text = bmi.ToString();
                    textRemarks.Text = "Hi " + name + "." + "\n You are underweight, so you may need to put on some weight.You are recommended to ask your doctor or a dietitian for advice.";
                }
                else if (bmi >= 18.5 && bmi < 25.0)
                {
                    textBmi.Text = bmi.ToString();
                    textRemarks.Text = "Hi " + name + "." + "\n You are at a healthy weight for your height. By maintaining a healthy weight, you lower your risk of developing serious health problems";
                }
                else if (bmi >= 25.0 && bmi < 30.0)
                {

                    textBmi.Text = bmi.ToString();
                    textRemarks.Text = "Hi " + name + "." + "\n You are slightly overweight. You may be advised to lose some weight for health reasons. You are recommended to talk to your doctor or a dietitian for advice.";
                }
                else if (bmi >= 30.0)
                {

                    textBmi.Text = bmi.ToString();
                    textRemarks.Text = "Hi " + name + "." + "\n You are heavily overweight. Your health may be at risk if you do not lose weight. You are recommended to talk to your doctor or a dietitian for advice.";
                }
                else
                {
                    MessageBox.Show("Please enter correct values", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textHeight.Clear();
            textName.Clear();
            textWeight.Clear();
            textBmi.Clear();
            textRemarks.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-7M6R0TH\\SQLEXPRESS03; database=bmi; integrated security=True"))
            {
                con.Open();
   
                string insertQuery = "INSERT INTO bmi_value (Name, Date, Bmi, Weight, Height) VALUES (@Name, @Date, @Bmi, @Weight, @Height)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {

                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Bmi", float.Parse(textBmi.Text));
                    cmd.Parameters.AddWithValue("@Weight", float.Parse(textWeight.Text));
                    cmd.Parameters.AddWithValue("@Height", float.Parse(textHeight.Text));

                   
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record saved successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save record");
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-7M6R0TH\\SQLEXPRESS03; database=bmi; integrated security=True"))
            {
                con.Open();

                string selectQuery = "SELECT * FROM bmi_value";
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dtRecords = new DataTable();
                        da.Fill(dtRecords);

                        dataGridView1.DataSource = dtRecords;
                    }
                }
            }
        }
    }
}
