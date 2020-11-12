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

namespace Final_Project
{
    public partial class Seller : Form
    {
      
        private string delete_usr = "";

        public Seller()
        {
            InitializeComponent();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            
        }

       

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home j = new Home();
            j.Show();

            this.Close();
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=BRG1;Integrated Security=True");

            con.Open();

            string newcon = "select Id from BRG1 where Id='" + textBox1.Text + "'and name ='" + textBox2.Text + "'";


            SqlDataAdapter adp = new SqlDataAdapter(newcon, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
             



                SqlCommand cmd = new SqlCommand("Select * from BRG1", con);
                DataTable dp = new DataTable();

              

                SqlDataReader sdr = cmd.ExecuteReader();
                dp.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dp;

                MessageBox.Show("Record Successful");




               
            }
            else
            {
                MessageBox.Show("Invalid");

            }





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=BRG1;Integrated Security=True");
            string query = String.Format("DELETE FROM BRG1 where username='{0}'", delete_usr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

          

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            dataGridView1.CurrentRow.Selected = true;
            delete_usr = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=BRG1;Integrated Security=True");

            con.Open();

            string newcon = "select Id from BRG1 where Id='" + textBox1.Text + "'and name ='" + textBox2.Text + "'";


            SqlDataAdapter adp = new SqlDataAdapter(newcon, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {




                SqlCommand cmd = new SqlCommand("Select * from BRG1", con);
                DataTable dp = new DataTable();



                SqlDataReader sdr = cmd.ExecuteReader();
                dp.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dp;

               





            }
            else
            {
               

            }




        }
    }
}
