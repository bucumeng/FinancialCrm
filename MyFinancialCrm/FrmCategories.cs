using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        MyFinancialCrmEntities db = new MyFinancialCrmEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridViewCategory.DataSource = values;
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;

            Categories categories = new Categories();
            categories.CategorId = categoryId;
            categories.CategoryName = categoryName;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi ", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridViewCategory.DataSource = values;
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(categoryId);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemden Silindi ", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            var values = db.Categories.ToList();
            dataGridViewCategory.DataSource = values;
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;

            var value = db.Categories.Find(categoryId);

            value.CategoryName = categoryName;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi ", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridViewCategory.DataSource = values;

        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
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
        private void btnBillFrm_Click_1(object sender, EventArgs e)
        {
            FrmBillings frm = new FrmBillings();
            frm.Show();
            this.Hide();
        }

        private void btnExpensesForm_Click_1(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcessesForm_Click_1(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click_1(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click_1(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
