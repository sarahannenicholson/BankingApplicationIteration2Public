
namespace BankingApplicationIteration2
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttManageCust = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.BtnAddCus = new System.Windows.Forms.Button();
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttManageCust
            // 
            this.buttManageCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttManageCust.Location = new System.Drawing.Point(29, 131);
            this.buttManageCust.Name = "buttManageCust";
            this.buttManageCust.Size = new System.Drawing.Size(275, 40);
            this.buttManageCust.TabIndex = 2;
            this.buttManageCust.Text = "Manage Customers";
            this.buttManageCust.UseVisualStyleBackColor = true;
            this.buttManageCust.Click += new System.EventHandler(this.buttManageCust_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttExit.Location = new System.Drawing.Point(29, 326);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(275, 40);
            this.buttExit.TabIndex = 3;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // BtnAddCus
            // 
            this.BtnAddCus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddCus.Location = new System.Drawing.Point(29, 68);
            this.BtnAddCus.Name = "BtnAddCus";
            this.BtnAddCus.Size = new System.Drawing.Size(275, 40);
            this.BtnAddCus.TabIndex = 4;
            this.BtnAddCus.Text = "Add Customer";
            this.BtnAddCus.UseVisualStyleBackColor = true;
            this.BtnAddCus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageAcc.Location = new System.Drawing.Point(29, 261);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(275, 40);
            this.btnManageAcc.TabIndex = 5;
            this.btnManageAcc.Text = "Manage Accounts";
            this.btnManageAcc.UseVisualStyleBackColor = true;
            this.btnManageAcc.Click += new System.EventHandler(this.btnManageAcc_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAcc.Location = new System.Drawing.Point(29, 198);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(275, 40);
            this.btnAddAcc.TabIndex = 6;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 419);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.btnManageAcc);
            this.Controls.Add(this.BtnAddCus);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttManageCust);
            this.Name = "MainMenuForm";
            this.Text = "Customer";
            this.Controls.SetChildIndex(this.buttManageCust, 0);
            this.Controls.SetChildIndex(this.buttExit, 0);
            this.Controls.SetChildIndex(this.BtnAddCus, 0);
            this.Controls.SetChildIndex(this.btnManageAcc, 0);
            this.Controls.SetChildIndex(this.btnAddAcc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttManageCust;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Button BtnAddCus;
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Button btnAddAcc;
    }
}

