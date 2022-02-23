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
    public partial class DepositeAcc : Form
    {
        public DepositeAcc()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AccountantHome acc = new AccountantHome();
            this.Hide();
            acc.Show();
        }

        private void deposite_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                if (txtid.Text == string.Empty || txtmoney.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields Correctly");
                    return;
                }
                con.Open();

                string customerquery = "select * from Customer where Customer_ID = '" + txtid.Text + "'";
                SqlDataAdapter dCustomer = new SqlDataAdapter(customerquery, con);
                DataTable dtblcus = new DataTable();
                dCustomer.Fill(dtblcus);
                if (dtblcus.Rows.Count == 0)
                {
                    MessageBox.Show("The Customer Not Found");
                    return;
                }

                SqlCommand cmd = new SqlCommand("deposites", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Depositmoney", txtmoney.Text);
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@total";
                outparam.SqlDbType = System.Data.SqlDbType.Int;
                outparam.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                cmd.ExecuteNonQuery();
                string total = outparam.Value.ToString();

                MessageBox.Show("Sucessfully!! total balance is :" + total);
                txtid.Clear();
                txtmoney.Clear();
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


        private void DepositeAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void txtmoney_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
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
