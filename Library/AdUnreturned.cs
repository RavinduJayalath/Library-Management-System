using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library
{
    public partial class AdUnreturned : Form
    {
        string cs = "datasource=localhost; user=root; password=; database=library";
        public AdUnreturned()
        {
            InitializeComponent();
        }

        private void AdUnreturned_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 150);
            listView1.Columns.Add("Book Name", 250);
            listView1.Columns.Add("Borrowed Date", 210);
            listView1.Columns.Add("Return Date", 210);

            listView1.Font = new Font("Arial", 12);

            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand("select * from borrowbook where returndate < @currentDate", con);
            cmd.Parameters.AddWithValue("@currentDate", DateTime.Now);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem newItem = new ListViewItem(dr[0].ToString());
                newItem.SubItems.Add(dr[1].ToString());
                newItem.SubItems.Add(dr[2].ToString());
                newItem.SubItems.Add(dr[3].ToString());

                newItem.BackColor = Color.FromArgb(200, 200, 200);
                listView1.Items.Add(newItem);
            }
            con.Close();
        }
    }
}
