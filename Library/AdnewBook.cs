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
    public partial class AdnewBook : Form
    {
        string cs = "datasource=localhost; user=root; password=; database=library";
        public AdnewBook()
        {
            InitializeComponent();
        }

        private void btn_addnewbook_Click(object sender, EventArgs e)
        {
            addBook();
        }
        private void addBook()
        {
            if (int.TryParse(tb_newbookQty.Text, out int qty) && tb_newbooktitle.Text!="")
            {
                using(MySqlConnection con = new MySqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("select * from book where title='" + tb_newbooktitle.Text + "'", con);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            dr.Close();
                            MySqlCommand cmd2 = new MySqlCommand("update book set qty = qty + @newQty where title = @Title", con);
                            cmd2.Parameters.AddWithValue("@newQty", qty);
                            cmd2.Parameters.AddWithValue("@Title", tb_newbooktitle.Text);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Inserted " + tb_newbooktitle.Text);
                        }
                        else
                        {
                            dr.Close();
                            MySqlCommand cmd4 = new MySqlCommand("insert into book values('" + tb_newbooktitle.Text + "','" + tb_newbookFaculty.Text + "','" + tb_newbookAuthor.Text + "','" + qty + "')", con);
                            cmd4.ExecuteNonQuery();
                            MessageBox.Show("Inserted " + tb_newbooktitle.Text);

                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                tb_newbooktitle.Text = "";
                tb_newbookFaculty.Text = "";
                tb_newbookAuthor.Text = "";
                tb_newbookQty.Text = "";
            }
            else
            {
                MessageBox.Show("Qty should be in number format");
            }


            
            
            
        }
    }
}
