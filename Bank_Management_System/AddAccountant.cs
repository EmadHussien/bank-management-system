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
    public partial class AddAccountant : Form
    {
        public AddAccountant()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminHome adm = new AdminHome();
            this.Hide();
            adm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                if (firstname.Text == string.Empty || lastname.Text == string.Empty || phonenumber.Text == string.Empty || adress.Text == string.Empty || email.Text == string.Empty || password.Text == string.Empty || gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill All Fields Correctly");

                    return;
                }
                SqlCommand cmd = new SqlCommand("addacc", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FName", firstname.Text));
                cmd.Parameters.Add(new SqlParameter("@LName", lastname.Text));
                cmd.Parameters.Add(new SqlParameter("@Phone", phonenumber.Text));
                cmd.Parameters.Add(new SqlParameter("@Addres", adress.Text));
                cmd.Parameters.Add(new SqlParameter("@email", email.Text));
                cmd.Parameters.Add(new SqlParameter("@Pass", password.Text));
                cmd.Parameters.Add(new SqlParameter("@gend", gender.Text));
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "accountantID";
                outparam.SqlDbType = System.Data.SqlDbType.Int;
                outparam.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                cmd.ExecuteNonQuery();
                string accid = outparam.Value.ToString();
                MessageBox.Show("Accountant_ID is : " + accid);
                firstname.Clear();
                lastname.Clear();
                phonenumber.Clear();
                adress.Clear();
                email.Clear();
                password.Clear();
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

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (char.IsDigit(charr))
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Numbers");
            }


        }


        private void AddAccountant_Load(object sender, EventArgs e)
        {

        }

        private void phonenumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }

        }

        private void lastname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (char.IsDigit(charr))
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Numbers");
            }
        }
    }
}
