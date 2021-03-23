using OpenQA.Selenium.Remote;
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
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.ForeColor = Color.Black;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.ForeColor = Color.Orange;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.ForeColor = Color.Black;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.ForeColor = Color.Orange;
            //Redirect to the Hotes.cs page
            Hotels H = new Hotels();
            H.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.ForeColor = Color.Black;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.ForeColor = Color.Orange;
            //Redirect to the Transfers.cs page
            Transfers T = new Transfers();
            T.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.ForeColor = Color.Black;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.ForeColor = Color.Orange;
            //Redirect to the Activities.cs page
            Activities A = new Activities();
            A.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.ForeColor = Color.Black;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.ForeColor = Color.Orange;
            //Redirect to the Insurance.cs page
            Insurance I = new Insurance();
            I.Show();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.ForeColor = Color.Black;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.ForeColor = Color.Orange;
            //Redirect to the Holidays.cs page
            Holidays Hd = new Holidays();
            Hd.Show();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            foreach (Control c in label9.Controls)
            {
                c.ForeColor = Color.White;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.BackColor = Color.Orange;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            foreach (Control c in label10.Controls)
            {
                c.ForeColor = Color.White;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.BackColor = Color.Orange;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            foreach (Control c in label11.Controls)
            {
                c.ForeColor = Color.White;
            }
            //set the clicked control to a different color
            Control o = (Control)sender;
            o.BackColor = Color.Orange;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Redirect to the login.cs page
            login L = new login();
            L.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
