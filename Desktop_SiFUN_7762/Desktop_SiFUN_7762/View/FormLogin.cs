using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_SiFUN_7762.Control;

namespace Desktop_SiFUN_7762.View
{
    public partial class FormLogin : Form
    {
        string user, pass;int role;
        public FormLogin()
        {
            InitializeComponent();
        }

        LoginControl lc = new LoginControl();
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = edUser.Text;
            pass = edUser.Text;

            if (lc.cekLogin(user, pass) == true) {
                role = lc.getRoleUser(user, pass);
                if (role == 1)
                {
                    this.Hide();
                    
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Maaf, username atau password salah");
            }
        }

        
    }
}
