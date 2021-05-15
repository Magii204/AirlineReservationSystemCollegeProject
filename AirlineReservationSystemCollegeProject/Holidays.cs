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
    public partial class Holidays : Form
    {
        public Holidays()
        {
            InitializeComponent();
        }

        private void Holidays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_DatabaseDataSet3.TblHoliday' table. You can move, or remove it, as needed.
            this.tblHolidayTableAdapter.Fill(this.login_DatabaseDataSet3.TblHoliday);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
