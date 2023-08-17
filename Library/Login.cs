using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Library
{
    public partial class Login : Form
    {
        string cs = "datasource=localhost; user=root; password=; database=library";
        string adminpw = "123";




        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private bool varyfyuser(string username,string password)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("select * from student where username='" + username + "' and password='" + password + "'", con);
                MySqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
            
        }

        public Form activeform = null;
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(activeform != null)
            {
                activeform = null;
            }


            if(tb_username.Text=="Admin"&& tb_password.Text == adminpw)
            {
                activeform = new adminHome();
                
                this.Hide();
                activeform.Show();
            }
            else
            {
                if (varyfyuser(tb_username.Text, tb_password.Text))
                {
                    activeform = new StHome(tb_username.Text);
                    //StHome ob = new StHome(tb_username.Text);
                    this.Hide();
                    activeform.Show();
                }
                else
                {
                    MessageBox.Show("Inavlid user name or password..");
                }
            }
            
        }
    }
}
