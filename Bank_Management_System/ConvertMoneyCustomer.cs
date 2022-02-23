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
    public partial class ConvertMoneyCustomer : Form
    {
        public ConvertMoneyCustomer()
        {
            InitializeComponent();
        }

        private void ConvertMoneyCustomer_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            CustomerHome cus = new CustomerHome(globalvariable.value);
            this.Hide();
            cus.Show();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                con.Open();
                if (txtmon.Text == string.Empty || txtidrecieve.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields Correctly");
                    return;
                }

                string customerquery = "select * from Customer where Customer_ID = '" + txtidrecieve.Text + "'";
                SqlDataAdapter dCustomer = new SqlDataAdapter(customerquery, con);
                DataTable dtblcus = new DataTable();
                dCustomer.Fill(dtblcus);
                if (dtblcus.Rows.Count == 0)
                {
                    MessageBox.Show("The Agent Not Found");
                    return;
                }

                string cuswith = "select* from Customer where Customer_ID = '" + globalvariable.value + "' and totalBalance >= '" + txtmon.Text + "'";
                SqlDataAdapter dwith = new SqlDataAdapter(cuswith, con);
                DataTable dtblwith = new DataTable();
                dwith.Fill(dtblwith);
                if (dtblwith.Rows.Count == 0)
                {
                    MessageBox.Show("your balance is not enough ");
                    return;
                }

                SqlCommand cmd = new SqlCommand("convertmon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id1", globalvariable.value);
                cmd.Parameters.AddWithValue("@mon", txtmon.Text);
                cmd.Parameters.AddWithValue("@id2", txtidrecieve.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Converting Sucessfully...!!");
                txtidrecieve.Clear();
                txtmon.Clear();
                txtmon.Focus();
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
