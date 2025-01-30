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
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }
        MyFinancialCrmEntities db = new MyFinancialCrmEntities();
        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            var values = db.Expenses.ToList();
            dataGridViewExpenses.DataSource = values;

        }

        private void btntExpensesAdd_Click(object sender, EventArgs e)
        {
            int expenseId = int.Parse(txtExpensesId.Text);
            string expenseName = txtExpensesDescription.Text;
            decimal expenseAmount = decimal.Parse(txtExpensesAmount.Text);

            Expenses expenses = new Expenses();
            expenses.ExpensesId = expenseId;
            expenses.ExpensesDescription = expenseName;
            expenses.ExpensesAmount = expenseAmount;

            db.Expenses.Add(expenses);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sisteme Eklendi ", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Expenses.ToList();
            dataGridViewExpenses.DataSource = values;

        }

        private void btntExpensesDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtExpensesId.Text);
            var removeValue = db.Expenses.Find(id);
            db.Expenses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sistemden Silindi ", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btntExpensesUpdate_Click(object sender, EventArgs e)
        {

            int expenseId = int.Parse(txtExpensesId.Text);
            string expenseName = txtExpensesDescription.Text;
            decimal expenseAmount = decimal.Parse(txtExpensesAmount.Text);

            var updateValue = db.Expenses.Find(expenseId);

            Expenses expenses = new Expenses();
            expenses.ExpensesId = expenseId;
            expenses.ExpensesDescription = expenseName;
            expenses.ExpensesAmount = expenseAmount;

            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Güncellendi ", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Expenses.ToList();
            dataGridViewExpenses.DataSource = values;
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
