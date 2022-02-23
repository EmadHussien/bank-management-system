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

namespace BMS
{
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                if (id.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields Correctly");
                    return;
                }

                string customerquery = "select * from Customer where Customer_ID = '" + id.Text + "'";
                SqlDataAdapter dCustomer = new SqlDataAdapter(customerquery, con);
                DataTable dtblcus = new DataTable();
                dCustomer.Fill(dtblcus);
                if (dtblcus.Rows.Count == 0)
                {
                    MessageBox.Show("The Customer Not Found");
                    return;
                }

                SqlCommand cmd = new SqlCommand("select * from Customer where Customer_ID = '" + id.Text + "'", con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gridinfo.DataSource = dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminHome adm = new AdminHome();
            this.Hide();
            adm.Show();
        }

        private void deletecus_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                if (id.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields Correctly");
                    return;
                }

                string customerquery = "select * from Customer where Customer_ID = '" + id.Text + "'";
                SqlDataAdapter dCustomer = new SqlDataAdapter(customerquery, con);
                DataTable dtblcus = new DataTable();
                dCustomer.Fill(dtblcus);
                if (dtblcus.Rows.Count == 0)
                {
                    MessageBox.Show("The Customer Not Found");
                    return;
                }

                SqlCommand cmd = new SqlCommand("deletcus", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Has Been Delete.... !! ");
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }


        }

 

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }

        private void id_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }
    }
}
