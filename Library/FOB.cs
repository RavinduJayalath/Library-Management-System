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
    public partial class FOB : Form
    {
        string cs = "datasource=localhost; user=root; password=; database=library";
        string borrowBtnTxt = "";
        string username;

        public FOB()
        {
            InitializeComponent();
            
        }
        public FOB(string name)
        {
            InitializeComponent();
            this.username = name;
        }
        
        private void MyButton_Click(object sender,EventArgs e)
        {
            
        }
        private void FOB_Load(object sender, EventArgs e)
        {
            loadcontent();
        }

        
        

        private void loadcontent()
        {

            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand("select title from book where faculty='Faculty Of Bussiness Studies'", con);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Label> l1 = new List<Label>();
            if (dr.HasRows)
            {
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
                    l1[i].Padding = new Padding(20);
                    Controls.Add(l1[i]);
                    i++;
                }  
                
            }
            con.Close();
            foreach (Label lnew in l1)
            {
                lnew.Click += Label_Click;
            }

        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLable=(Label)sender;
            borrowBtnTxt = clickedLable.Text;
            

            btn_borrow.Visible = true;
            int btnX = clickedLable.Right - 163;
            int btnY = clickedLable.Top;
            btn_borrow.Height = clickedLable.Height;
            btn_borrow.Location = new Point(btnX, btnY);
         
        }

        private void FOB_Click(object sender, EventArgs e)
        {
            
        }

        private void FOB_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
          
            if (username=="" && borrowBtnTxt == "")
            {
                MessageBox.Show("Error", "Book Borrowing Feild");
            }
            else
            {
                int currentqty = 0;
                MySqlConnection con2 = new MySqlConnection(cs);
                MySqlCommand cmd2 = new MySqlCommand("select qty from book where title='" + borrowBtnTxt + "'", con2);
                con2.Open();
                MySqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    currentqty = dr.GetInt32("qty");
                }
                con2.Close();
                if (currentqty > 0)
                {
                    int rowcount = 0;
                    MySqlConnection con3 = new MySqlConnection(cs);
                    MySqlCommand cmd3 = new MySqlCommand("select * from borrowbook where username='" + username + "' and bookname='" + borrowBtnTxt + "' ", con3);
                    MySqlDataReader dr3;
                    
                    con3.Open();
                    dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        rowcount++;
                    }
                    con3.Close();
                    
                    if (rowcount>0)
                    {
                        MessageBox.Show("Alraedy You Borrowed this book");
                        btn_borrow.Visible = false;
                    }
                    else
                    {
                        DateTime ab = DateTime.Now;
                        string currentdate = ab.ToString();
                        DateTime ac = ab.AddDays(14);
                        string returndate = ac.ToString();

                        MySqlConnection con = new MySqlConnection(cs);
                        MySqlCommand cmd = new MySqlCommand("insert into borrowbook values('" + username + "','" + borrowBtnTxt + "','" + currentdate + "',@a)", con);
                        MySqlCommand cmdup = new MySqlCommand("update book set qty='" + (currentqty - 1) + "' where title='" + borrowBtnTxt + "'", con);
                        
                        con.Open();
                        cmd.Parameters.AddWithValue("@a", ac);
                        cmd.ExecuteNonQuery();
                        cmdup.ExecuteNonQuery();
                        con.Close();
                        btn_borrow.Visible = false;
                        MessageBox.Show("Successfully borrowed book " + borrowBtnTxt);

                        MySqlCommand cmd4 = new MySqlCommand("select email from student where username='" + username + "'", con);
                        con.Open();
                        MySqlDataReader dr1=cmd4.ExecuteReader();
                        string mail = "";
                        while (dr1.Read())
                        {
                            mail = dr1[0].ToString();
                        }
                        SendMail ob = new SendMail(mail, "Borrowed Book", "You had successfully borrowed "+ borrowBtnTxt);
                        ob.Mail();
                    }


                }
                else
                {
                    MessageBox.Show("All Books Borrowed");
                    btn_borrow.Visible = false;
                }

                
            }
            
            

        }
    }
}
