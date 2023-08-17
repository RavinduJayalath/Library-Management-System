using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class StHome : Form
    {
        public string username;
        string cs = "datasource=localhost; user=root; password=; database=library";
        
       
        public StHome()
        {
            InitializeComponent();
        }
        public StHome(string name)
        {
            InitializeComponent();
            this.username = name;

        }
        private void StHome_Load(object sender, EventArgs e)
        {
            lbl_user.Text = setname(username);
        }

        private string setname(string name)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("select name from student where username='"+name+"'",con);
                MySqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    return dr[0].ToString();
                }
                else
                {
                    return "student";
                }
                
                con.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "student";
            }
            
        }

        private void btn_fob_MouseEnter(object sender, EventArgs e)
        {
            btn_fob.BackColor = Color.White;
        }

        private void btn_fob_MouseLeave(object sender, EventArgs e)
        {
            btn_fob.BackColor = Color.FromArgb(128, 255, 255);
        }

        private void btn_foa_MouseEnter(object sender, EventArgs e)
        {
            btn_foa.BackColor = Color.White;
        }

        private void btn_foa_MouseLeave(object sender, EventArgs e)
        {
            btn_foa.BackColor = Color.FromArgb(128, 255, 255);
        }

        private void btn_fot_MouseEnter(object sender, EventArgs e)
        {
            btn_fot.BackColor = Color.White;
        }

        private void btn_fot_MouseLeave(object sender, EventArgs e)
        {
            btn_fot.BackColor = Color.FromArgb(128, 255, 255);
        }

        private Form activeForm = null;
        private void openform(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnl_homecontent.Controls.Add(childForm);
            pnl_homecontent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            
        }

        private void btn_fob_Click(object sender, EventArgs e)
        {
            
            openform(new FOB(username));

        }

        private void btn_foa_Click(object sender, EventArgs e)
        {
            openform(new FOA(username));
        }

        private void btn_fot_Click(object sender, EventArgs e)
        {
            openform(new FOT(username));
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            setProfileContent();
            if (pnl_profile.Visible == false)
            {
                pnl_profile.Visible = true;
                pnl_buttons.Visible = false;
                pnl_profile.BringToFront();
            }
            else
            {
                pnl_profile.Visible = false;
                pnl_buttons.Visible = true;
            }
        }

        private void setProfileContent()
        {
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand("select name,regno,username,email from student where username='" + username + "'", con);
            con.Open();
            MySqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_profile_name.Text = dr[0].ToString();
                lbl_profile_regno.Text = dr[1].ToString();
                lbl_profile_username.Text = dr[2].ToString();
                lbl_profile_email.Text = dr[3].ToString();
            }
            con.Close();
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            if(pnl_profile_changepassword.Visible== false)
            {
                pnl_profile_changepassword.Visible = true;
            }
            else
            {
                pnl_profile_changepassword.Visible= false;
            }
        }

        private void btn_updatepassword_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand("select password from student where username='" + username + "'", con);
            con.Open();
            MySqlDataReader dr= cmd.ExecuteReader();
            dr.Read();
            string dbpasword = dr[0].ToString();
            con.Close();
            
            if(dbpasword == tb_pro_current_pw.Text)
            {
                if (tb_pro_new_pw.Text == tb_pro_new2_pw.Text)
                {
                    MySqlConnection con2 = new MySqlConnection(cs);
                    MySqlCommand cmd2 = new MySqlCommand("update student set password='" + tb_pro_new_pw.Text + "' where username='"+username+"'", con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    con2.Close();

                    tb_pro_current_pw.Text = "";
                    tb_pro_new_pw.Text = "";
                    tb_pro_new2_pw.Text = "";
                    pnl_profile_changepassword.Visible = false;
                    MessageBox.Show("changed password success");
                }
                else
                {
                    MessageBox.Show("Password not Matching");
                }
            }
            else
            {
                MessageBox.Show("Invalied Password");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login ob = new Login();
            ob.Show();
        }

        private void StHome_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void StHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
