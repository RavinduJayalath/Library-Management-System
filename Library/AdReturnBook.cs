using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library
{
    public partial class AdReturnBook : Form
    {
        string cs = "datasource=localhost; user=root; password=; database=library";
        string borrowBtnTxt;
        
        
        public AdReturnBook()
        {
            InitializeComponent();
        }

        private void AdReturnBook_Load(object sender, EventArgs e)
        {
            btn_borrow.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadContent();


        }
        private void loadContent()
        {
            if (tb_username.Text != "")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(cs);
                    MySqlCommand cmd = new MySqlCommand("select bookname from borrowbook where username='" + tb_username.Text + "'", con);
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Label> l1 = new List<Label>();
                    pnl_content.Controls.Clear();
                    pnl_content.Controls.Add(btn_borrow);
                    int i = 0;
                    if (!dr.HasRows)
                    {
                        MessageBox.Show("This Student Not Borrow Book");
                    }
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
                        l1[i].Padding = new Padding(20);
                        pnl_content.Controls.Add(l1[i]);
                        i++;
                    }
                    con.Close();
                    foreach (Label lnew in l1)
                    {
                        lnew.Click += Label_Click;
                    }
                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                pnl_content.Controls.Clear();
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLable = (Label)sender;
            borrowBtnTxt = clickedLable.Text;


            btn_borrow.Visible = true;
            int btnX = clickedLable.Right - 165;
            int btnY = clickedLable.Top;
            btn_borrow.Height = clickedLable.Height;
            btn_borrow.Location = new Point(btnX, btnY);

        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_borrow_Click_1(object sender, EventArgs e)
        {
            if (borrowBtnTxt != null)
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("delete from borrowbook where username='" + tb_username.Text + "' and bookname='" + borrowBtnTxt + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Returned book " + borrowBtnTxt);
                btn_borrow.Visible=false;
                loadContent();
            }
        }
    }
}
