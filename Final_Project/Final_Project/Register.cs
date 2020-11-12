using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Final_Project
{
    public partial class Register : Form
    {
     

        public Register()
        {
            InitializeComponent();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Tanvir.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            




            if (nameTxt.Text.Equals(string.Empty) || usernameTxt.Text.Equals(string.Empty) || passwordTxt.Text.Equals(string.Empty) || passwordTxt.Text.Equals(string.Empty))
            {
                MessageBox.Show(" Field cannot be empty ");

            }


            else
            {


                if (passwordTxt.Text != ConfirmpassTxt.Text)
                {

                    MessageBox.Show("Password & Confirm Password Must Match");

                }
                else
                {
                    if (GenderCombo.SelectedItem==null)
                    {
                        MessageBox.Show("Please Select Gender");
                    }
                    else if (dateTimePicker1.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Please select a valid Date Of Birth");
                    }
                    else if (JcTxt.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select a Job Category");
                    }
                    else if (JcTxt.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select a blood group");
                    }
                    
                    else if (checkBox1.Checked == false)
                    {
                        MessageBox.Show("Please Select The Agreement");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=BRG1;Integrated Security=True");

                        con.Open();

                        string newcon = "insert into BRG1(name,username,password,confirmpassword,email,jobcatagory,gender,phonenumber,dateofbirth,bloodgroup) VALUES('" + nameTxt.Text + "','" + usernameTxt.Text + "','" + passwordTxt.Text + "','" + ConfirmpassTxt.Text + "','" + mailTxt.Text + "','" + JcTxt.Text + "','" + GenderCombo.Text + "','" + PhonenumberTxt.Text + "','" + dateTimePicker1.Text + "','" + comboBoxBlood.Text + "')";


                        SqlCommand cmd = new SqlCommand(newcon, con);

                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Registration Successful");



                    }






                }
            }
        }

        private void Tanvir_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
