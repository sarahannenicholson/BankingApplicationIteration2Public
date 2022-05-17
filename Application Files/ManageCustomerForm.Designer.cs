
namespace BankingApplicationIteration2
{
    partial class ManageCustomerForm
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
            this.buttAddCust = new System.Windows.Forms.Button();
            this.buttEditCust = new System.Windows.Forms.Button();
            this.buttDeleteCust = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.listDispCust = new System.Windows.Forms.ListBox();
            this.buttDisplayCust = new System.Windows.Forms.Button();
            this.labdisplayCust = new System.Windows.Forms.Label();
            this.buttMenu = new System.Windows.Forms.Button();
            this.btnEditCustAcc = new System.Windows.Forms.Button();
            this.labCustOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttAddCust
            // 
            this.buttAddCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttAddCust.Location = new System.Drawing.Point(297, 46);
            this.buttAddCust.Name = "buttAddCust";
            this.buttAddCust.Size = new System.Drawing.Size(275, 40);
            this.buttAddCust.TabIndex = 2;
            this.buttAddCust.Text = "Add Customer";
            this.buttAddCust.UseVisualStyleBackColor = true;
            this.buttAddCust.Click += new System.EventHandler(this.buttAddCust_Click);
            // 
            // buttEditCust
            // 
            this.buttEditCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttEditCust.Location = new System.Drawing.Point(297, 105);
            this.buttEditCust.Name = "buttEditCust";
            this.buttEditCust.Size = new System.Drawing.Size(275, 40);
            this.buttEditCust.TabIndex = 3;
            this.buttEditCust.Text = "Edit Selected Customer";
            this.buttEditCust.UseVisualStyleBackColor = true;
            this.buttEditCust.Click += new System.EventHandler(this.buttEditCust_Click);
            // 
            // buttDeleteCust
            // 
            this.buttDeleteCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttDeleteCust.Location = new System.Drawing.Point(297, 163);
            this.buttDeleteCust.Name = "buttDeleteCust";
            this.buttDeleteCust.Size = new System.Drawing.Size(275, 40);
            this.buttDeleteCust.TabIndex = 4;
            this.buttDeleteCust.Text = "Delete Selected Customer";
            this.buttDeleteCust.UseVisualStyleBackColor = true;
            this.buttDeleteCust.Click += new System.EventHandler(this.buttDeleteCust_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttExit.Location = new System.Drawing.Point(297, 485);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(275, 40);
            this.buttExit.TabIndex = 5;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // listDispCust
            // 
            this.listDispCust.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listDispCust.FormattingEnabled = true;
            this.listDispCust.ItemHeight = 25;
            this.listDispCust.Location = new System.Drawing.Point(12, 46);
            this.listDispCust.Name = "listDispCust";
            this.listDispCust.Size = new System.Drawing.Size(267, 479);
            this.listDispCust.TabIndex = 6;
            // 
            // buttDisplayCust
            // 
            this.buttDisplayCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttDisplayCust.Location = new System.Drawing.Point(297, 278);
            this.buttDisplayCust.Name = "buttDisplayCust";
            this.buttDisplayCust.Size = new System.Drawing.Size(275, 40);
            this.buttDisplayCust.TabIndex = 7;
            this.buttDisplayCust.Text = "Display Selected Customer";
            this.buttDisplayCust.UseVisualStyleBackColor = true;
            this.buttDisplayCust.Click += new System.EventHandler(this.buttDisplayCust_Click);
            // 
            // labdisplayCust
            // 
            this.labdisplayCust.AutoSize = true;
            this.labdisplayCust.Location = new System.Drawing.Point(240, 255);
            this.labdisplayCust.Name = "labdisplayCust";
            this.labdisplayCust.Size = new System.Drawing.Size(0, 20);
            this.labdisplayCust.TabIndex = 8;
            // 
            // buttMenu
            // 
            this.buttMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttMenu.Location = new System.Drawing.Point(297, 426);
            this.buttMenu.Name = "buttMenu";
            this.buttMenu.Size = new System.Drawing.Size(275, 40);
            this.buttMenu.TabIndex = 9;
            this.buttMenu.Text = "Return To Menu";
            this.buttMenu.UseVisualStyleBackColor = true;
            this.buttMenu.Click += new System.EventHandler(this.buttMenu_Click);
            // 
            // btnEditCustAcc
            // 
            this.btnEditCustAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditCustAcc.Location = new System.Drawing.Point(297, 219);
            this.btnEditCustAcc.Name = "btnEditCustAcc";
            this.btnEditCustAcc.Size = new System.Drawing.Size(275, 40);
            this.btnEditCustAcc.TabIndex = 10;
            this.btnEditCustAcc.Text = "Edit Customers Accounts";
            this.btnEditCustAcc.UseVisualStyleBackColor = true;
            this.btnEditCustAcc.Click += new System.EventHandler(this.btnEditCustAcc_Click);
            // 
            // labCustOutput
            // 
            this.labCustOutput.AutoSize = true;
            this.labCustOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labCustOutput.Location = new System.Drawing.Point(6, 33);
            this.labCustOutput.Name = "labCustOutput";
            this.labCustOutput.Size = new System.Drawing.Size(0, 25);
            this.labCustOutput.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labCustOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // ManageCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 718);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditCustAcc);
            this.Controls.Add(this.buttMenu);
            this.Controls.Add(this.labdisplayCust);
            this.Controls.Add(this.buttDisplayCust);
            this.Controls.Add(this.listDispCust);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttDeleteCust);
            this.Controls.Add(this.buttEditCust);
            this.Controls.Add(this.buttAddCust);
            this.Name = "ManageCustomerForm";
            this.Text = "Manage Customer";
            this.Controls.SetChildIndex(this.buttAddCust, 0);
            this.Controls.SetChildIndex(this.buttEditCust, 0);
            this.Controls.SetChildIndex(this.buttDeleteCust, 0);
            this.Controls.SetChildIndex(this.buttExit, 0);
            this.Controls.SetChildIndex(this.listDispCust, 0);
            this.Controls.SetChildIndex(this.buttDisplayCust, 0);
            this.Controls.SetChildIndex(this.labdisplayCust, 0);
            this.Controls.SetChildIndex(this.buttMenu, 0);
            this.Controls.SetChildIndex(this.btnEditCustAcc, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttAddCust;
        private System.Windows.Forms.Button buttEditCust;
        private System.Windows.Forms.Button buttDeleteCust;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.ListBox listDispCust;
        private System.Windows.Forms.Button buttDisplayCust;
        private System.Windows.Forms.Label labdisplayCust;
        private System.Windows.Forms.Button buttMenu;
        private System.Windows.Forms.Button btnEditCustAcc;
        private System.Windows.Forms.Label labCustOutput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}