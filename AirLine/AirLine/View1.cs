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
    public partial class View1 : Form
    {
        public static string AirportBase = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Dell\\Documents\\Temiryul.mdb";
        private OleDbConnection airport;
        public View1()
        {
            InitializeComponent();
            airport = new OleDbConnection(AirportBase);
        }

        private void populate()
        {
            airport.Open();
            string query = "select * from Reyslar";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, airport);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            airport.Close();
        }
        private void Reysqunish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReNum.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ReAdress.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Reysqunish.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Reysdata.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            reyssoni.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (ReNum.Text == "" || ReAdress.Text == "" || Reysqunish.Text == "" || reyssoni.Text == "" || Reysdata.Text=="")
            {
                MessageBox.Show("Ma`lumot keriting");
            }
            else
            {
                try
                {
                    airport.Open();
                    string query = "UPDATE Reyslar SET Fcode='" + ReNum.Text + "',Fsrc='" + ReAdress.SelectedItem.ToString() + "',Fdest='" + Reysqunish.SelectedItem.ToString() + "',Fcap='" + reyssoni.Text + "',FDate=" + Reysdata.Text + ";";
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
            if (ReNum.Text == "")
            {
                MessageBox.Show("Id ni kiriting");

            }
            else
            {
                try
                {
                    airport.Open();
                    string query = "delete from Reyslar where Fcode=" + ReNum.Text;
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ReNum.Text = "";
            ReAdress.Text = "";
            Reysqunish.Text= "";
            Reysdata.Text = "";
            reyssoni.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Uchish addpass = new Uchish();
            addpass.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Soha a = new Soha();
            a.Show();
            this.Hide();
        }
    }
}
