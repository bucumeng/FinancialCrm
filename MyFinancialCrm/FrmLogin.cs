using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        MyFinancialCrmEntities db = new MyFinancialCrmEntities();

        int userCount = 0;
        int userPaswordCount = 0;
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            

                if (db.Users.Any(x => x.UserName == userName))
                {
                    userCount = 1;
                }
                else
                {
                   
                    userCount = 0;
                
            }
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            var userPassword = txtUserPassword.Text;
            

                if (db.Users.Any(x => x.UserPassword == userPassword))
                {
                    userPaswordCount = 1;
                }
                else
                {
                    userPaswordCount = 0;
                    
                }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userCount == 1 && userPaswordCount == 1)
            {
                FrmBank frm = new FrmBank();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
