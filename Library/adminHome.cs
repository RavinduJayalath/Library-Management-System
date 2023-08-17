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
    public partial class adminHome : Form
    {
        
        public adminHome()
        {
            InitializeComponent();
        }

        private void btn_returnbook_Click(object sender, EventArgs e)
        {
            openform(new AdReturnBook());

            
        }

        private Form activeform = null;
        private void openform(Form f1)
        {
            if(activeform!=null)
            {
                activeform = null;
            }
            activeform = f1;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(f1);
            pnl_content.Tag = f1;
            f1.BringToFront();
            f1.Show();
        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            openform(new AdReturnBook());
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            openform(new AdnewBook());
        }

        private void btn_studentregister_Click(object sender, EventArgs e)
        {
            openform(new AdRegister());
        }

        private void btn_unreturn_Click(object sender, EventArgs e)
        {
            openform(new AdUnreturned());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openform(new AdRemovebook());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Permission Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                Login ob = new Login();
                ob.Show();
            }
        }
    }
}
