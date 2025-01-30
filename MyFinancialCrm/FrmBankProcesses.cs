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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        MyFinancialCrmEntities db = new MyFinancialCrmEntities();
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView4.DataSource = values;

        }

        private void btnProcessesList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView4.DataSource = values;

        }

        private void btnNewProcessesAdd_Click(object sender, EventArgs e)
        {
            int bankProcessId = int.Parse(txtProcessId.Text);
            string processName = txtProcessDescription.Text;
            string processType = txtProcessType.Text;
            decimal processAmount = decimal.Parse(txtProcessAmount.Text);
            DateTime processDate = DateTime.Parse(txtProcessDate.Text);
            int bankId = int.Parse(txtBankId.Text);

            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.BankProcessId = bankProcessId;
            bankProcesses.Description = processName;
            bankProcesses.ProcessType = processType;
            bankProcesses.Amount = processAmount;
            bankProcesses.ProcessDate = processDate;
            bankProcesses.BankId = bankId;

            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Sisteme Eklendi ", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.ToList();
            dataGridView4.DataSource = values;
        }

        private void btnbtnProcessDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessId.Text);
            var removeValue = db.Bills.Find(id);

            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi ", "Ödmeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView4.DataSource = values;
        }

        private void btnProcessesUpdate_Click(object sender, EventArgs e)
        {
            int bankProcessId = int.Parse(txtProcessId.Text);
            string processName = txtProcessDescription.Text;
            string processType = txtProcessType.Text;
            decimal processAmount = decimal.Parse(txtProcessAmount.Text);
            DateTime processDate = DateTime.Parse(txtProcessDate.Text);
            int bankId = int.Parse(txtBankId.Text);

            var values = db.Bills.Find(bankId);

            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.BankProcessId = bankProcessId;
            bankProcesses.Description = processName;
            bankProcesses.ProcessType = processType;
            bankProcesses.Amount = processAmount;
            bankProcesses.ProcessDate = processDate;
            bankProcesses.BankId = bankId;
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Bir Şekilde Sistemde Güncellendi ", "Ödmeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView4.DataSource = values2;
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

       
        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
