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
    public partial class AdRegister : Form
    {
        string cs = "datasource=localhost; user=root; password=; database=library";
        public AdRegister()
        {
            InitializeComponent();
        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void addStudent()
        {
            if(tb_username.Text!="" && tb_name.Text!="" && tb_regno.Text!="" && tb_mail.Text != "")
            {
                string pw = tb_username.Text + "@123";
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("insert into student values('" + tb_username.Text + "','" + pw + "','" + tb_name.Text + "','" + tb_regno.Text + "','" + tb_mail.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SendMail ob = new SendMail(tb_mail.Text, "Library Registation", "Hi "+ tb_name.Text+". " +
                    "You had successfully registered to Library. Your password is: " + pw);
                ob.Mail();

                MessageBox.Show("Successfully Registered "+ tb_name.Text);
                tb_username.Text = "";
                tb_name.Text = "";
                tb_regno.Text = "";
                tb_mail.Text = "";

                
            }
            else
            {
                MessageBox.Show("Fill the all field");
            }
            
        }

        private void btn_updatemail_Click(object sender, EventArgs e)
        {
            updateMail();
        }
        private void updateMail()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("update student set email='" + tb_updateMail.Text + "' where username='" + tb_updateId.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                tb_updateMail.Text = "";
                tb_updateId.Text = "";
                MessageBox.Show("Updated E-mail");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
