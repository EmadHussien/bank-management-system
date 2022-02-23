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
    public partial class ConvertMoney : Form
    {
        public ConvertMoney()
        {
            InitializeComponent();
        }

        private void ConvertMoney_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            AccountantHome acc = new AccountantHome();
            this.Hide();
            acc.Show();
        }

        private void withdrew_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                if (txtidsend.Text == string.Empty || txtidrecieve.Text == string.Empty || txtmon.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields Correctly");
                    return;
                }
                con.Open();

                string custsend = "select * from Customer where Customer_ID = '" + txtidsend.Text + "'";
                string custreciev = "select * from Customer where Customer_ID = '" + txtidrecieve.Text + "'";
                SqlDataAdapter dCustomerecive = new SqlDataAdapter(custreciev, con);
                SqlDataAdapter dCustomersend = new SqlDataAdapter(custsend, con);
                DataTable dtblcusrecieve = new DataTable();
                DataTable dtblcussend = new DataTable();
                dCustomerecive.Fill(dtblcusrecieve);
                dCustomersend.Fill(dtblcussend);
                if (dtblcussend.Rows.Count == 0)
                {
                    MessageBox.Show("The Customer Sender Not Found");
                    return;
                }
                if (dtblcusrecieve.Rows.Count == 0)
                {
                    MessageBox.Show("The Customer Reciever Not Found");
                    return;
                }
                string sendwithdrew = "select * from Customer where Customer_ID = '" + txtidsend.Text + "' and totalBalance >= '" + txtmon.Text + "'";
                SqlDataAdapter dcuswith = new SqlDataAdapter(sendwithdrew, con);
                DataTable dtblcuswith = new DataTable();
                dcuswith.Fill(dtblcuswith);
                if (dtblcuswith.Rows.Count == 0)
                {
                    MessageBox.Show("your balance is not enough to send ");
                    return;
                }
                SqlCommand cmd = new SqlCommand("convertmon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id1", txtidsend.Text);
                cmd.Parameters.AddWithValue("@mon", txtmon.Text);
                cmd.Parameters.AddWithValue("@id2", txtidrecieve.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Converting Sucessfully...!!");
                txtidsend.Clear();
                txtidrecieve.Clear();
                txtmon.Clear();
                txtidsend.Focus();
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


        private void txtidsend_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void txtidrecieve_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void txtidrecieve_KeyPress(object sender, KeyPressEventArgs e)
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
