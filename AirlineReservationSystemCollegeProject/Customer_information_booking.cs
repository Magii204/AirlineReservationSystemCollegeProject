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


namespace AirlineReservationSystemCollegeProject.Administrator
{
    public partial class Customer_information_booking : Form
    {
        public Customer_information_booking()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\NewAirlineReservationSystemProject\AirlineReservationSystemCollegeProject\AirlineReservationSystemCollegeProject\Login_Database.mdf;Integrated Security=True");
        //Save button code
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query="INSERT INTO CustomerTbl (CustNat,CustGend,CustPhone) VALUES ('"+CustID.Text+ "','" + CustName.Text + "','" + CustPassport.Text + "','" + CustAd.Text + "','" + NationalityCb.Text + "','" + GenderCb.Text + "','" + PhoneTb.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Suceessfully");
        }

       
    }    
}
