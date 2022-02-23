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
    public partial class DepositeCustomer : Form
    {
        public DepositeCustomer()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

            CustomerHome cushome = new CustomerHome(globalvariable.value);
            this.Hide();
            cushome.Show();
        }

        private void depo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                con.Open();
                if (depmon.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields Correctly");
                    return;
                }
                SqlCommand cmd = new SqlCommand("deposites", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Depositmoney", depmon.Text);
                cmd.Parameters.AddWithValue("@id", globalvariable.value);
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@total";
                outparam.SqlDbType = System.Data.SqlDbType.Int;
                outparam.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                cmd.ExecuteNonQuery();
                string total = outparam.Value.ToString();
                MessageBox.Show("Sucessfully!! total balance is :" + total);
                depmon.Clear();
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

   

        private void DepositeCustomer_Load(object sender, EventArgs e)
        {

        }

        private void depmon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void depmon_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
