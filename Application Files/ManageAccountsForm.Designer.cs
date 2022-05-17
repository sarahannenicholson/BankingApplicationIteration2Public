
namespace BankingApplicationIteration2
{
    partial class ManageAccountsForm
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
            this.buttMenu = new System.Windows.Forms.Button();
            this.buttDisplayAcc = new System.Windows.Forms.Button();
            this.listDispAcc = new System.Windows.Forms.ListBox();
            this.buttExit = new System.Windows.Forms.Button();
            this.buttDeleteAcc = new System.Windows.Forms.Button();
            this.buttAddAcc = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtDollaValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labDispayAcc = new System.Windows.Forms.Label();
            this.btnIntrest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txxFromAccount = new System.Windows.Forms.TextBox();
            this.txtToAccount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttMenu
            // 
            this.buttMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttMenu.Location = new System.Drawing.Point(297, 440);
            this.buttMenu.Name = "buttMenu";
            this.buttMenu.Size = new System.Drawing.Size(275, 40);
            this.buttMenu.TabIndex = 17;
            this.buttMenu.Text = "Return To Menu";
            this.buttMenu.UseVisualStyleBackColor = true;
            this.buttMenu.Click += new System.EventHandler(this.buttMenu_Click);
            // 
            // buttDisplayAcc
            // 
            this.buttDisplayAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttDisplayAcc.Location = new System.Drawing.Point(297, 123);
            this.buttDisplayAcc.Name = "buttDisplayAcc";
            this.buttDisplayAcc.Size = new System.Drawing.Size(275, 40);
            this.buttDisplayAcc.TabIndex = 16;
            this.buttDisplayAcc.Text = "Display Selected Account";
            this.buttDisplayAcc.UseVisualStyleBackColor = true;
            this.buttDisplayAcc.Click += new System.EventHandler(this.buttDisplayAcc_Click);
            // 
            // listDispAcc
            // 
            this.listDispAcc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listDispAcc.FormattingEnabled = true;
            this.listDispAcc.ItemHeight = 25;
            this.listDispAcc.Location = new System.Drawing.Point(12, 62);
            this.listDispAcc.Name = "listDispAcc";
            this.listDispAcc.Size = new System.Drawing.Size(267, 479);
            this.listDispAcc.TabIndex = 15;
            this.listDispAcc.SelectedIndexChanged += new System.EventHandler(this.listDispAcc_SelectedIndexChanged);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttExit.Location = new System.Drawing.Point(297, 501);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(275, 40);
            this.buttExit.TabIndex = 14;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // buttDeleteAcc
            // 
            this.buttDeleteAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttDeleteAcc.Location = new System.Drawing.Point(297, 188);
            this.buttDeleteAcc.Name = "buttDeleteAcc";
            this.buttDeleteAcc.Size = new System.Drawing.Size(275, 40);
            this.buttDeleteAcc.TabIndex = 13;
            this.buttDeleteAcc.Text = "Delete Selected Account";
            this.buttDeleteAcc.UseVisualStyleBackColor = true;
            this.buttDeleteAcc.Click += new System.EventHandler(this.buttDeleteAcc_Click);
            // 
            // buttAddAcc
            // 
            this.buttAddAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttAddAcc.Location = new System.Drawing.Point(297, 62);
            this.buttAddAcc.Name = "buttAddAcc";
            this.buttAddAcc.Size = new System.Drawing.Size(275, 40);
            this.buttAddAcc.TabIndex = 11;
            this.buttAddAcc.Text = "New Account";
            this.buttAddAcc.UseVisualStyleBackColor = true;
            this.buttAddAcc.Click += new System.EventHandler(this.buttAddAcc_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.Location = new System.Drawing.Point(634, 62);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(275, 40);
            this.btnDeposit.TabIndex = 18;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.Location = new System.Drawing.Point(634, 125);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(275, 40);
            this.btnWithdraw.TabIndex = 19;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.Location = new System.Drawing.Point(9, 26);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(275, 40);
            this.btnTransfer.TabIndex = 20;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtDollaValue
            // 
            this.txtDollaValue.Location = new System.Drawing.Point(34, 37);
            this.txtDollaValue.Name = "txtDollaValue";
            this.txtDollaValue.Size = new System.Drawing.Size(235, 27);
            this.txtDollaValue.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDollaValue);
            this.groupBox1.Location = new System.Drawing.Point(634, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 81);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dollar Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labDispayAcc);
            this.groupBox2.Location = new System.Drawing.Point(12, 547);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 144);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Account";
            // 
            // labDispayAcc
            // 
            this.labDispayAcc.AutoSize = true;
            this.labDispayAcc.Location = new System.Drawing.Point(6, 34);
            this.labDispayAcc.Name = "labDispayAcc";
            this.labDispayAcc.Size = new System.Drawing.Size(0, 20);
            this.labDispayAcc.TabIndex = 25;
            // 
            // btnIntrest
            // 
            this.btnIntrest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIntrest.Location = new System.Drawing.Point(634, 188);
            this.btnIntrest.Name = "btnIntrest";
            this.btnIntrest.Size = new System.Drawing.Size(275, 40);
            this.btnIntrest.TabIndex = 25;
            this.btnIntrest.Text = "Calculate Interest";
            this.btnIntrest.UseVisualStyleBackColor = true;
            this.btnIntrest.Click += new System.EventHandler(this.btnIntrest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "From Account #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "To Account #";
            // 
            // txxFromAccount
            // 
            this.txxFromAccount.Location = new System.Drawing.Point(64, 112);
            this.txxFromAccount.Name = "txxFromAccount";
            this.txxFromAccount.Size = new System.Drawing.Size(50, 27);
            this.txxFromAccount.TabIndex = 28;
            // 
            // txtToAccount
            // 
            this.txtToAccount.Location = new System.Drawing.Point(194, 112);
            this.txtToAccount.Name = "txtToAccount";
            this.txtToAccount.Size = new System.Drawing.Size(50, 27);
            this.txtToAccount.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTransfer);
            this.groupBox3.Controls.Add(this.txtToAccount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txxFromAccount);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(634, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 160);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // ManageAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 703);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnIntrest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.buttMenu);
            this.Controls.Add(this.buttDisplayAcc);
            this.Controls.Add(this.listDispAcc);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttDeleteAcc);
            this.Controls.Add(this.buttAddAcc);
            this.Name = "ManageAccountsForm";
            this.Text = "ManageAccountsForm";
            this.Controls.SetChildIndex(this.buttAddAcc, 0);
            this.Controls.SetChildIndex(this.buttDeleteAcc, 0);
            this.Controls.SetChildIndex(this.buttExit, 0);
            this.Controls.SetChildIndex(this.listDispAcc, 0);
            this.Controls.SetChildIndex(this.buttDisplayAcc, 0);
            this.Controls.SetChildIndex(this.buttMenu, 0);
            this.Controls.SetChildIndex(this.btnDeposit, 0);
            this.Controls.SetChildIndex(this.btnWithdraw, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnIntrest, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttMenu;
        private System.Windows.Forms.Button buttDisplayAcc;
        private System.Windows.Forms.ListBox listDispAcc;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Button buttDeleteAcc;
        private System.Windows.Forms.Button buttAddAcc;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtDollaValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labDispayAcc;
        private System.Windows.Forms.Button btnIntrest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txxFromAccount;
        private System.Windows.Forms.TextBox txtToAccount;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}