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
    public partial class Home : Form

        
    {
        private string username = "";
        public Home()
        {
            InitializeComponent();
        }

        public Home(string un)
        {
            InitializeComponent();
            username = un;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Close();
        }

      

      

        private void ManageButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=BRG1;Integrated Security=True");
            con.Open();
            string query = String.Format("select jobcatagory from BRG1 where username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader data = cmd.ExecuteReader();
            data.Read();


            if (data["jobcatagory"].ToString() == "Manager")
            {
                Seller b = new Seller();
                b.Show();
                this.Close();
            }
            else { MessageBox.Show("You are not allowed to enter this section!"); }
        }

        private void SellBurgerButton_Click(object sender, EventArgs e)
        {
            BurgerList d = new BurgerList();
            d.Show();

            this.Close();
        }
    }
}
