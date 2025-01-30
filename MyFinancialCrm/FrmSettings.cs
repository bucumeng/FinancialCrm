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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        MyFinancialCrmEntities db = new MyFinancialCrmEntities();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;

            var values = db.Users.Find(id);
            values.UserName = userName;
            values.UserPassword = userPassword;
            db.SaveChanges();

            MessageBox.Show("Kullanıcı Bilgileri Başarılı Bir Şekilde Güncellendi ", "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCategoriesForm_Click_1(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBank frm = new FrmBank();
            frm.Show();
            this.Hide();
        }

        private void btnBillFrm_Click(object sender, EventArgs e)
        {
            FrmBillings frm = new FrmBillings();
            frm.Show();
            this.Hide();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcessesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
