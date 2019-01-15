namespace BrandonLempkaIMS
{
    partial class AddPart
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.radioInhouse = new System.Windows.Forms.RadioButton();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAdd.Location = new System.Drawing.Point(13, 13);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(80, 22);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add Part";
            // 
            // radioInhouse
            // 
            this.radioInhouse.AutoSize = true;
            this.radioInhouse.BackColor = System.Drawing.SystemColors.Control;
            this.radioInhouse.Location = new System.Drawing.Point(124, 17);
            this.radioInhouse.Name = "radioInhouse";
            this.radioInhouse.Size = new System.Drawing.Size(68, 17);
            this.radioInhouse.TabIndex = 1;
            this.radioInhouse.TabStop = true;
            this.radioInhouse.Text = "In-House";
            this.radioInhouse.UseVisualStyleBackColor = false;
            this.radioInhouse.CheckedChanged += new System.EventHandler(this.radioInhouse_CheckedChanged);
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Location = new System.Drawing.Point(243, 17);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioOutsourced.TabIndex = 2;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(124, 90);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(124, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(124, 150);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 5;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(124, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price / Cost";
            this.lblPrice.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(124, 210);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(124, 240);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMachine.Size = new System.Drawing.Size(62, 13);
            this.lblMachine.TabIndex = 8;
            this.lblMachine.Text = "Machine ID";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(242, 210);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 9;
            this.labelMin.Text = "Min";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(200, 87);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            this.txtId.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(200, 147);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(100, 20);
            this.txtInventory.TabIndex = 12;
            this.txtInventory.TextChanged += new System.EventHandler(this.txtInventory_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(200, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(157, 207);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(79, 20);
            this.txtMax.TabIndex = 14;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(200, 237);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(100, 20);
            this.txtMachine.TabIndex = 16;
            this.txtMachine.TextChanged += new System.EventHandler(this.txtMachine_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(272, 207);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(79, 20);
            this.txtMin.TabIndex = 18;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(190, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(124, 240);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 21;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(223, 237);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 22;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 351);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInhouse);
            this.Controls.Add(this.lblAdd);
            this.MaximumSize = new System.Drawing.Size(390, 390);
            this.MinimumSize = new System.Drawing.Size(390, 390);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.RadioButton radioInhouse;
        private System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
    }
}