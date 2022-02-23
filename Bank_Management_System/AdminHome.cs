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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }





        private void addcus_Click(object sender, EventArgs e)
        {
            AddCustomer adc = new AddCustomer();
            this.Hide();
            adc.Show();
        }

        private void deletecus_Click(object sender, EventArgs e)
        {
            DeleteCustomer dcus = new DeleteCustomer();
            this.Hide();
            dcus.Show();
        }

        private void updatecus_Click(object sender, EventArgs e)
        {
            UpdateCsutomer udcus = new UpdateCsutomer();
            this.Hide();
            udcus.Show();
        }

        private void addacc_Click(object sender, EventArgs e)
        {
            AddAccountant ada = new AddAccountant();
            this.Hide();
            ada.Show();
        }

        private void updateacc_Click(object sender, EventArgs e)
        {
            UpdateAccountant udacc = new UpdateAccountant();
            this.Hide();
            udacc.Show();
        }

        private void deleteacc_Click(object sender, EventArgs e)
        {
            DeleteAccountant delacc = new DeleteAccountant();
            this.Hide();
            delacc.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
