namespace MyFinancialCrm
{
    partial class FrmExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProcessesForm = new System.Windows.Forms.Button();
            this.btnExpensesForm = new System.Windows.Forms.Button();
            this.btnBillFrm = new System.Windows.Forms.Button();
            this.btnBankForm = new System.Windows.Forms.Button();
            this.btnCategoriesForm = new System.Windows.Forms.Button();
            this.dataGridViewExpenses = new System.Windows.Forms.DataGridView();
            this.btntExpensesUpdate = new System.Windows.Forms.Button();
            this.btntExpensesDelete = new System.Windows.Forms.Button();
            this.btntExpensesAdd = new System.Windows.Forms.Button();
            this.txtExpensesDescription = new System.Windows.Forms.TextBox();
            this.txtExpensesId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpensesAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(-1, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 47);
            this.panel3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giderler";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnSettingsForm);
            this.panel4.Controls.Add(this.btnDashboardForm);
            this.panel4.Controls.Add(this.btnBankProcessesForm);
            this.panel4.Controls.Add(this.btnExpensesForm);
            this.panel4.Controls.Add(this.btnBillFrm);
            this.panel4.Controls.Add(this.btnBankForm);
            this.panel4.Controls.Add(this.btnCategoriesForm);
            this.panel4.Location = new System.Drawing.Point(-1, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 538);
            this.panel4.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(11, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSettingsForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Location = new System.Drawing.Point(11, 360);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(174, 48);
            this.btnSettingsForm.TabIndex = 6;
            this.btnSettingsForm.Text = "Ayarlar";
            this.btnSettingsForm.UseVisualStyleBackColor = false;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Location = new System.Drawing.Point(11, 306);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(174, 48);
            this.btnDashboardForm.TabIndex = 5;
            this.btnDashboardForm.Text = "DashBoard";
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBankProcessesForm
            // 
            this.btnBankProcessesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBankProcessesForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessesForm.ForeColor = System.Drawing.Color.White;
            this.btnBankProcessesForm.Location = new System.Drawing.Point(11, 252);
            this.btnBankProcessesForm.Name = "btnBankProcessesForm";
            this.btnBankProcessesForm.Size = new System.Drawing.Size(174, 48);
            this.btnBankProcessesForm.TabIndex = 4;
            this.btnBankProcessesForm.Text = "Banka Hareketleri";
            this.btnBankProcessesForm.UseVisualStyleBackColor = false;
            this.btnBankProcessesForm.Click += new System.EventHandler(this.btnBankProcessesForm_Click);
            // 
            // btnExpensesForm
            // 
            this.btnExpensesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExpensesForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesForm.ForeColor = System.Drawing.Color.White;
            this.btnExpensesForm.Location = new System.Drawing.Point(11, 198);
            this.btnExpensesForm.Name = "btnExpensesForm";
            this.btnExpensesForm.Size = new System.Drawing.Size(174, 48);
            this.btnExpensesForm.TabIndex = 3;
            this.btnExpensesForm.Text = "Giderler";
            this.btnExpensesForm.UseVisualStyleBackColor = false;
            // 
            // btnBillFrm
            // 
            this.btnBillFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBillFrm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillFrm.ForeColor = System.Drawing.Color.White;
            this.btnBillFrm.Location = new System.Drawing.Point(11, 144);
            this.btnBillFrm.Name = "btnBillFrm";
            this.btnBillFrm.Size = new System.Drawing.Size(174, 48);
            this.btnBillFrm.TabIndex = 2;
            this.btnBillFrm.Text = "Faturalar";
            this.btnBillFrm.UseVisualStyleBackColor = false;
            this.btnBillFrm.Click += new System.EventHandler(this.btnBillFrm_Click);
            // 
            // btnBankForm
            // 
            this.btnBankForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBankForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankForm.ForeColor = System.Drawing.Color.White;
            this.btnBankForm.Location = new System.Drawing.Point(11, 90);
            this.btnBankForm.Name = "btnBankForm";
            this.btnBankForm.Size = new System.Drawing.Size(174, 48);
            this.btnBankForm.TabIndex = 1;
            this.btnBankForm.Text = "Bankalar";
            this.btnBankForm.UseVisualStyleBackColor = false;
            this.btnBankForm.Click += new System.EventHandler(this.btnBankForm_Click);
            // 
            // btnCategoriesForm
            // 
            this.btnCategoriesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCategoriesForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoriesForm.Location = new System.Drawing.Point(11, 36);
            this.btnCategoriesForm.Name = "btnCategoriesForm";
            this.btnCategoriesForm.Size = new System.Drawing.Size(174, 48);
            this.btnCategoriesForm.TabIndex = 0;
            this.btnCategoriesForm.Text = "Kategoriler";
            this.btnCategoriesForm.UseVisualStyleBackColor = false;
            this.btnCategoriesForm.Click += new System.EventHandler(this.btnCategoriesForm_Click_1);
            // 
            // dataGridViewExpenses
            // 
            this.dataGridViewExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenses.Location = new System.Drawing.Point(630, 51);
            this.dataGridViewExpenses.Name = "dataGridViewExpenses";
            this.dataGridViewExpenses.Size = new System.Drawing.Size(376, 538);
            this.dataGridViewExpenses.TabIndex = 24;
            // 
            // btntExpensesUpdate
            // 
            this.btntExpensesUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntExpensesUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btntExpensesUpdate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntExpensesUpdate.ForeColor = System.Drawing.Color.White;
            this.btntExpensesUpdate.Location = new System.Drawing.Point(392, 389);
            this.btntExpensesUpdate.Name = "btntExpensesUpdate";
            this.btntExpensesUpdate.Size = new System.Drawing.Size(188, 37);
            this.btntExpensesUpdate.TabIndex = 31;
            this.btntExpensesUpdate.Text = "Güncelle";
            this.btntExpensesUpdate.UseVisualStyleBackColor = false;
            this.btntExpensesUpdate.Click += new System.EventHandler(this.btntExpensesUpdate_Click);
            // 
            // btntExpensesDelete
            // 
            this.btntExpensesDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntExpensesDelete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btntExpensesDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntExpensesDelete.ForeColor = System.Drawing.Color.White;
            this.btntExpensesDelete.Location = new System.Drawing.Point(392, 346);
            this.btntExpensesDelete.Name = "btntExpensesDelete";
            this.btntExpensesDelete.Size = new System.Drawing.Size(188, 37);
            this.btntExpensesDelete.TabIndex = 30;
            this.btntExpensesDelete.Text = "Sil";
            this.btntExpensesDelete.UseVisualStyleBackColor = false;
            this.btntExpensesDelete.Click += new System.EventHandler(this.btntExpensesDelete_Click);
            // 
            // btntExpensesAdd
            // 
            this.btntExpensesAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntExpensesAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btntExpensesAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntExpensesAdd.ForeColor = System.Drawing.Color.White;
            this.btntExpensesAdd.Location = new System.Drawing.Point(392, 303);
            this.btntExpensesAdd.Name = "btntExpensesAdd";
            this.btntExpensesAdd.Size = new System.Drawing.Size(188, 37);
            this.btntExpensesAdd.TabIndex = 29;
            this.btntExpensesAdd.Text = "Ekle";
            this.btntExpensesAdd.UseVisualStyleBackColor = false;
            this.btntExpensesAdd.Click += new System.EventHandler(this.btntExpensesAdd_Click);
            // 
            // txtExpensesDescription
            // 
            this.txtExpensesDescription.Location = new System.Drawing.Point(392, 209);
            this.txtExpensesDescription.Name = "txtExpensesDescription";
            this.txtExpensesDescription.Size = new System.Drawing.Size(192, 20);
            this.txtExpensesDescription.TabIndex = 28;
            // 
            // txtExpensesId
            // 
            this.txtExpensesId.Location = new System.Drawing.Point(392, 165);
            this.txtExpensesId.Name = "txtExpensesId";
            this.txtExpensesId.Size = new System.Drawing.Size(192, 20);
            this.txtExpensesId.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(286, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Gider Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(221, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gider Açıklaması:";
            // 
            // txtExpensesAmount
            // 
            this.txtExpensesAmount.Location = new System.Drawing.Point(392, 252);
            this.txtExpensesAmount.Name = "txtExpensesAmount";
            this.txtExpensesAmount.Size = new System.Drawing.Size(192, 20);
            this.txtExpensesAmount.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(258, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Gider Tutarı:";
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1009, 594);
            this.Controls.Add(this.txtExpensesAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewExpenses);
            this.Controls.Add(this.btntExpensesUpdate);
            this.Controls.Add(this.btntExpensesDelete);
            this.Controls.Add(this.btntExpensesAdd);
            this.Controls.Add(this.txtExpensesDescription);
            this.Controls.Add(this.txtExpensesId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "FrmExpenses";
            this.Text = "FrmExpenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProcessesForm;
        private System.Windows.Forms.Button btnExpensesForm;
        private System.Windows.Forms.Button btnBillFrm;
        private System.Windows.Forms.Button btnBankForm;
        private System.Windows.Forms.Button btnCategoriesForm;
        private System.Windows.Forms.DataGridView dataGridViewExpenses;
        private System.Windows.Forms.Button btntExpensesUpdate;
        private System.Windows.Forms.Button btntExpensesDelete;
        private System.Windows.Forms.Button btntExpensesAdd;
        private System.Windows.Forms.TextBox txtExpensesDescription;
        private System.Windows.Forms.TextBox txtExpensesId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpensesAmount;
        private System.Windows.Forms.Label label3;
    }
}