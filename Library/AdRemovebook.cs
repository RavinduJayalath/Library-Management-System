using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class AdRemovebook : Form
    {
        string cs = "datasource=localhost; user=root; password=; database=library";
        string borrowBtnTxt;
        public AdRemovebook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_title.Text == "")
            {
                pnl_Content.Controls.Clear();
            }
            else
            {
                pnl_Content.Controls.Clear();
                loadcontent();
            }
            
            
        }

        private void loadcontent()
        {
            
            pnl_Content.Controls.Add(btn_borrow);

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                string title=tb_title.Text;
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from book where title like @a", con);
                cmd.Parameters.AddWithValue("@a","%"+ title + "%");
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Label> l1= new List<Label>();
                int i = 0;
                while (dr.Read())
                {
                    l1.Add(new Label());
                    l1[i].AutoSize = false;
                    l1[i].Dock = DockStyle.Top;
                    l1[i].Height = 60;
                    l1[i].TextAlign = ContentAlignment.MiddleLeft;
                    l1[i].BorderStyle = BorderStyle.FixedSingle;
                    l1[i].Font = new Font("Arial", 12);
                    l1[i].Text = dr[0].ToString();
                    pnl_Content.Controls.Add(l1[i]);
                    i++;
                }
                con.Close();
                foreach (Label lnew in l1)
                {
                    lnew.Click += Label_Click;
                }
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLable = (Label)sender;
            borrowBtnTxt = clickedLable.Text;

            btn_borrow.Visible = true;
            int btnX = clickedLable.Right - 133;
            int btnY = clickedLable.Top;
            btn_borrow.Height = clickedLable.Height;
            btn_borrow.Location = new Point(btnX, btnY);

        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("delete from book where title='" + borrowBtnTxt + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Romoved " + borrowBtnTxt);

                tb_title.Text = "";
                btn_borrow.Visible=false;
                loadcontent();
            }
        }
    }
}
