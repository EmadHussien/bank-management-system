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

    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();

        }
        int count;
        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                con.Open();
                string adminquery = "select * from Admin where adminID= '" + id.Text.Trim() + "' and password = '" + pass.Text.Trim() + "'";
                SqlDataAdapter dAdmin = new SqlDataAdapter(adminquery, con);
                DataTable dtblad = new DataTable();
                dAdmin.Fill(dtblad);
                string accountantquery = "select * from Accountant where accountantID = '" + id.Text.Trim() + "' and Password = '" + pass.Text.Trim() + "'";
                SqlDataAdapter dAccountant = new SqlDataAdapter(accountantquery, con);
                DataTable dtblacc = new DataTable();
                dAccountant.Fill(dtblacc);
                string customerquery = "select * from Customer where Customer_ID = '" + id.Text.Trim() + "' and Password = '" + pass.Text.Trim() + "'";
                SqlDataAdapter dCustomer = new SqlDataAdapter(customerquery, con);
                DataTable dtblcus = new DataTable();
                dCustomer.Fill(dtblcus);
                count = count + 1;
                if (count > 3)
                {
                    MessageBox.Show("Wrong !! ...System Will be Closed !!");
                    this.Close();
                }
                if (dtblad.Rows.Count == 1 && select.selectedValue == "Admin")
                {
                    AdminHome admin = new AdminHome();
                    this.Hide();
                    admin.Show();
                }
                else if (dtblad.Rows.Count == 0 && select.selectedValue == "Admin")
                {
                    MessageBox.Show("Check Your ID or Password");
                    id.Clear();
                    pass.Clear();
                    id.Focus();
                }
                if (dtblacc.Rows.Count == 1 && select.selectedValue == "Accountant")
                {
                    AccountantHome accountant = new AccountantHome();
                    this.Hide();
                    accountant.Show();
                }
                else if (dtblacc.Rows.Count == 0 && select.selectedValue == "Accountant")
                {
                    MessageBox.Show("Check Your ID or Password");
                    id.Clear();
                    pass.Clear();
                    id.Focus();
                }
                if (dtblcus.Rows.Count == 1 && select.selectedValue == "Customer")
                {
                    globalvariable.value = id.Text;
                    CustomerHome customer = new CustomerHome(id.Text);
                    this.Hide();
                    customer.Show();



                }
                else if (dtblcus.Rows.Count == 0 && select.selectedValue == "Customer")
                {
                    MessageBox.Show("Check Your ID or Password");
                    id.Clear();
                    pass.Clear();
                    id.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
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
