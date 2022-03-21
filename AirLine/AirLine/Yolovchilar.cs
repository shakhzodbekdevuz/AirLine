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
    public partial class Yolovchilar : Form
    {
        public static string AirportBase = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Dell\\Documents\\Temiryul.mdb";
        private OleDbConnection airport;
        public Yolovchilar()
        {
            InitializeComponent();
            airport = new OleDbConnection(AirportBase);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
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

        private void Yolovchilar_Load(object sender, EventArgs e)
        {

        }

        private void PassMillat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassMillat.Text == "" || PassName.Text == "" || PassNum.Text == "" || PassPhone.Text == "" || PassAdress.Text == "" || PassGender.Text == "")
            {
                MessageBox.Show("Qaytadan kiriting");
            }
            else
            {

                try
                {
                    airport.Open();
                    string query = "INSERT INTO Passanger (PassId,PassName,PassNum,PassAdress, PassMillat, PassGender, PassPhone) VALUES ('" + PassId.Text + "','" + PassName.Text + "','" + PassNum.Text + "','" + PassAdress.Text + "','" + PassMillat.SelectedItem.ToString() + "','" + PassGender.SelectedItem.ToString() + "','" + PassPhone.Text + "' )";
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassNum.Text = "";
            PassMillat.SelectedItem = "";
            PassName.Text = "";
            PassPhone.Text = "";
            PassGender.SelectedItem = "";
            PassAdress.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            viewpassanger viewpass = new viewpassanger();
            viewpass.Show();
            this.Hide();
        }
    }
}