using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class AccountantHome : Form
    {
        public AccountantHome()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }

        private void addcus_Click(object sender, EventArgs e)
        {
            AddCustomeracc addcus = new AddCustomeracc();
            this.Hide();
            addcus.Show();
        }

        private void delcus_Click(object sender, EventArgs e)
        {
            DeleteCustomeracc delcus = new DeleteCustomeracc();
            this.Hide();
            delcus.Show();
        }

        private void searchcus_Click(object sender, EventArgs e)
        {
            Search sea = new Search();
            this.Hide();
            sea.Show();
        }

        private void deposite_Click(object sender, EventArgs e)
        {
            DepositeAcc depo = new DepositeAcc();
            this.Hide();
            depo.Show();
        }

        private void withdrew_Click(object sender, EventArgs e)
        {
            Withdrewacc withacc = new Withdrewacc();
            this.Hide();
            withacc.Show();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            ConvertMoney conv = new ConvertMoney();
            this.Hide();
            conv.Show();
        }

        private void AccountantHome_Load(object sender, EventArgs e)
        {

        }
    }
}
