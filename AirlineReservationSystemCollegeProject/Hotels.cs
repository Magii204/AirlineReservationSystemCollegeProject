using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystemCollegeProject
{
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_DatabaseDataSet2.TblHotel' table. You can move, or remove it, as needed.
            this.tblHotelTableAdapter.Fill(this.login_DatabaseDataSet2.TblHotel);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
