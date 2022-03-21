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
    public partial class viewpassanger : Form
    {
        public static string AirportBase = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Dell\\Documents\\Temiryul.mdb";
        private OleDbConnection airport;
        public viewpassanger()
        {
            InitializeComponent();
            airport = new OleDbConnection(AirportBase);
        }
        private void populate()
        {
            airport.Open();
            string query = "select * from Passanger";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, airport);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            airport.Close();
        }
        private void viewpassanger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "")
            {
                MessageBox.Show("Id ni kiriting");

            }
            else
            {
                try
                {
                    airport.Open();
                    string query = "delete from Passanger where PassId=" + PidTb.Text ;
                    OleDbCommand cmd = new OleDbCommand(query, airport);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Passager");
                    airport.Close();
                    populate();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PidTb.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pNameTD.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PNumTb.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PAddrTd.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Millat.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Gender.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            PPhoneTd.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void Millat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Yolovchilar addpass = new Yolovchilar();
            addpass.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            pNameTD.Text = "";
            PNumTb.Text = "";
            PAddrTd.Text = "";
            Millat.SelectedItem = "";
            Gender.SelectedItem = "";
            PPhoneTd.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "" || pNameTD.Text == "" || PNumTb.Text == "")
            {
                MessageBox.Show("Ma`lumot keriting");
            }
            else
            {
                try
                {
                    airport.Open();
                    string query = "UPDATE Passanger SET PassName='" + pNameTD.Text + "',PassNum='" + PNumTb.Text + "',PassAdress='" + PAddrTd.Text + "',PassMillat='" + Millat.SelectedItem.ToString() + "',PassGender='" + Gender.SelectedItem.ToString() + "',PassPhone='" + PPhoneTd.Text + "'where PassId=" + PidTb.Text + ";";
                    OleDbCommand cmd = new OleDbCommand(query, airport);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update bo`ldi");
                    airport.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "")
            {
                MessageBox.Show("Id ni kiriting");

            }
            else
            {
                try
                {
                    airport.Open();
                    string query = "delete from Passanger where PassId=" + PidTb.Text;
                    OleDbCommand cmd = new OleDbCommand(query, airport);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Passager");
                    airport.Close();
                    populate();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Soha a = new Soha();
            a.Show();
            this.Hide();
            airport.Close();
        }
    }
    }

