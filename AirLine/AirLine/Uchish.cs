using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AirLine
{
    public partial class Uchish : Form
    {
        public static string AirportBase = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Dell\\Documents\\Airline1.mdb";
        private OleDbConnection airport;
        public Uchish()
        {
            InitializeComponent();
            airport = new OleDbConnection(AirportBase);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Uchish_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (fCode.Text == "" || fDate.Text == "" || fnum.Text == "" || fsrc.SelectedItem.ToString() == "" || fdest.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Qaytadan kiriting");
            }
            else
            {

                try
                {
                    airport.Open();
                    string query = "INSERT INTO Reyslar (FCode,Fsrc,Fdest, FDate , Fcap) VALUES(" + fCode.Text + ",'" + fsrc.SelectedItem.ToString() + "','" + fdest.SelectedItem.ToString() + "','" + fDate.Text + "'," + fnum.Text + " )";
                    OleDbCommand cmd = new OleDbCommand(query, airport);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ro`yhatdan otdingiz");
                    airport.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            View1 viewpass = new View1();
            viewpass.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            fCode.Text = "";
            fDate.Text = "";
            fdest.SelectedItem = "";
           
            fnum.Text = "";
            fsrc.SelectedItem = "";
           
        }
    }
}
