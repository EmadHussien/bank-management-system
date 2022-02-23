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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                if (firstname.Text == string.Empty || lastname.Text == string.Empty || phonenumber.Text == string.Empty || adress.Text == string.Empty || email.Text == string.Empty || password.Text == string.Empty || totalbalance.Text == string.Empty || gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill All Fields Correctly");

                    return;
                }

                SqlCommand cmd = new SqlCommand("addcus", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@fname", firstname.Text));
                cmd.Parameters.Add(new SqlParameter("@lname", lastname.Text));
                cmd.Parameters.Add(new SqlParameter("@phone", phonenumber.Text));
                cmd.Parameters.Add(new SqlParameter("@adres", adress.Text));
                cmd.Parameters.Add(new SqlParameter("@email", email.Text));
                cmd.Parameters.Add(new SqlParameter("@pass", password.Text));
                cmd.Parameters.Add(new SqlParameter("@balance", totalbalance.Text));
                cmd.Parameters.Add(new SqlParameter("@gender", gender.Text));
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@CustomerId";
                outparam.SqlDbType = System.Data.SqlDbType.Int;
                outparam.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                cmd.ExecuteNonQuery();
                string cusid = outparam.Value.ToString();
                MessageBox.Show("Customer_ID is : " + cusid);
                firstname.Clear();
                lastname.Clear();
                phonenumber.Clear();
                adress.Clear();
                email.Clear();
                password.Clear();
                totalbalance.Clear();
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

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (char.IsDigit(charr))
            {
                e.Handled = true;
                MessageBox.Show("Cannot allowed Write Numbers ");
            }
        }



        private void phonenumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void totalbalance_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lastname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (char.IsDigit(charr))
            {
                e.Handled = true;
                MessageBox.Show("Cannot allowed Write Numbers ");
            }
        }

        private void totalbalance_KeyPress_1(object sender, KeyPressEventArgs e)
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
