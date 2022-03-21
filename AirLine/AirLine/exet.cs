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
    public partial class exet : Form
    {
        public static string AirportBase = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Dell\\Documents\\Airline1.mdb";
        private OleDbConnection airport;
        public exet()
        {
            InitializeComponent();
            airport = new OleDbConnection(AirportBase);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exet_Load(object sender, EventArgs e)
        {

        }
    }
}
