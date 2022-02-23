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
    public partial class CustomerHome : Form
    {



        public CustomerHome(string idmain)
        {
            InitializeComponent();
            id.Text = idmain;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FGH57D;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select FirstName , LastName , PhoneNumber , address , totalBalance , Email , gender from Customer where Customer_ID = '" + idmain + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string fnamec = (string)rdr["FirstName"];
                    fname.Text = "First Name :" + fnamec;
                    string lnamec = (string)rdr["LastName"];
                    lname.Text = "Last Name :" + lnamec;
                    string genderc = (string)rdr["gender"];
                    gender.Text = "Gender :" + genderc;
                    int phonec = (int)rdr["PhoneNumber"];
                    phone.Text = "Phone Number :" + phonec;
                    string adresc = (string)rdr["address"];
                    adress.Text = "Address :" + adresc;
                    string emailc = (string)rdr["Email"];
                    email.Text = "E-Mail :" + emailc;
                    decimal totalc = (decimal)rdr["totalBalance"];
                    total.Text = "Balance :" + Convert.ToString(totalc);
                }
                rdr.Close();
                string depo = "select * from Deposit where CustID ='" + idmain + "'";
                SqlCommand cmddepo = new SqlCommand(depo, con);
                cmddepo.CommandType = CommandType.Text;
                SqlDataAdapter sdadepo = new SqlDataAdapter(cmddepo);
                DataTable tbldeposite = new DataTable();
                sdadepo.Fill(tbldeposite);
                griddeposite.DataSource = tbldeposite;
                string with = "select * from Withdraw where CustID = '" + idmain + "'";
                SqlCommand cmdwith = new SqlCommand(with, con);
                cmdwith.CommandType = CommandType.Text;
                SqlDataAdapter sdawith = new SqlDataAdapter(cmdwith);
                DataTable tblwithdrew = new DataTable();
                sdawith.Fill(tblwithdrew);
                gridwithdrew.DataSource = tblwithdrew;
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







        private void prof_Enter(object sender, EventArgs e)
        {


        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {

        }

        private void deposite_Click(object sender, EventArgs e)
        {
            DepositeCustomer depocus = new DepositeCustomer();
            this.Hide();
            depocus.Show();
        }

        private void withdrew_Click(object sender, EventArgs e)
        {
            WithdrewCustomer with = new WithdrewCustomer();
            this.Hide();
            with.Show();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            ConvertMoneyCustomer conv = new ConvertMoneyCustomer();
            this.Hide();
            conv.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }
    }
}
