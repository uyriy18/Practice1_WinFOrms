using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_WinFOrms
{
    public partial class Form_Authorization : Form
    {
        Dictionary<string, string> UsersList = new Dictionary<string, string>();
        Dictionary<string, string> AdminsList = new Dictionary<string, string>();
        public Form_Authorization()
        {
            InitializeComponent();
        }

        private void txbx_Login_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbx_Login.Text) && !String.IsNullOrEmpty(txbx_Password.Text))
            {
                btn_Confirm.Enabled = true;
            }
            else btn_Confirm.Enabled = false;
        }

        private void txbx_Password_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbx_Login.Text) && !String.IsNullOrEmpty(txbx_Password.Text))
            {
                btn_Confirm.Enabled = true;
            }
            else btn_Confirm.Enabled = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            User user = new User { Login = txbx_Login.Text, Password = txbx_Password.Text };
            user.checkRole();
            if(UsersList.ContainsKey(user.Login) && UsersList.ContainsKey(user.Password))
            {
                Form_User fuser = new Form_User();
                this.Visible = false;
                fuser.ShowDialog();
                this.Close();
            }
            else if (AdminsList.ContainsKey(user.Login) && AdminsList.ContainsKey(user.Password))
            {
                Form_Admin fadmin = new Form_Admin();
                this.Visible = false;
                fadmin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrecrt login or password", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbx_Login.Text = "";
                txbx_Password.Text = "";
                return;
            }



        }

        private void Form_Authorization_Load(object sender, EventArgs e)
        {
            UsersList.Add("user", "user");
            AdminsList.Add("admin", "admin");
            MessageBox.Show("Admin accaunt login : admin; password : admin\nUser accaunt login : user; password : user", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
