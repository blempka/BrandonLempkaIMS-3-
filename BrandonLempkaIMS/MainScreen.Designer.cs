namespace BrandonLempkaIMS
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            this.productsSearchBox = new System.Windows.Forms.TextBox();
            this.productsSearchBtn = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partDeleteBtn = new System.Windows.Forms.Button();
            this.partsAddBtn = new System.Windows.Forms.Button();
            this.partsModBtn = new System.Windows.Forms.Button();
            this.productsModBtn = new System.Windows.Forms.Button();
            this.productsAddBtn = new System.Windows.Forms.Button();
            this.productsDeleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.partsLabel.Location = new System.Drawing.Point(30, 59);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(52, 22);
            this.partsLabel.TabIndex = 1;
            this.partsLabel.Text = "Parts";
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Location = new System.Drawing.Point(233, 57);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.partsSearchBtn.TabIndex = 2;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Location = new System.Drawing.Point(314, 59);
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(129, 20);
            this.partsSearchBox.TabIndex = 3;
            this.partsSearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // productsSearchBox
            // 
            this.productsSearchBox.Location = new System.Drawing.Point(801, 59);
            this.productsSearchBox.Name = "productsSearchBox";
            this.productsSearchBox.Size = new System.Drawing.Size(129, 20);
            this.productsSearchBox.TabIndex = 6;
            // 
            // productsSearchBtn
            // 
            this.productsSearchBtn.Location = new System.Drawing.Point(720, 57);
            this.productsSearchBtn.Name = "productsSearchBtn";
            this.productsSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.productsSearchBtn.TabIndex = 5;
            this.productsSearchBtn.Text = "Search";
            this.productsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.productsLabel.Location = new System.Drawing.Point(517, 59);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(81, 22);
            this.productsLabel.TabIndex = 4;
            this.productsLabel.Text = "Products";
            // 
            // partDeleteBtn
            // 
            this.partDeleteBtn.Location = new System.Drawing.Point(367, 270);
            this.partDeleteBtn.Name = "partDeleteBtn";
            this.partDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.partDeleteBtn.TabIndex = 7;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // partsAddBtn
            // 
            this.partsAddBtn.Location = new System.Drawing.Point(205, 270);
            this.partsAddBtn.Name = "partsAddBtn";
            this.partsAddBtn.Size = new System.Drawing.Size(75, 23);
            this.partsAddBtn.TabIndex = 8;
            this.partsAddBtn.Tag = "";
            this.partsAddBtn.Text = "Add";
            this.partsAddBtn.UseVisualStyleBackColor = true;
            this.partsAddBtn.Click += new System.EventHandler(this.partsAddBtn_Click);
            // 
            // partsModBtn
            // 
            this.partsModBtn.Location = new System.Drawing.Point(286, 270);
            this.partsModBtn.Name = "partsModBtn";
            this.partsModBtn.Size = new System.Drawing.Size(75, 23);
            this.partsModBtn.TabIndex = 9;
            this.partsModBtn.Text = "Modify";
            this.partsModBtn.UseVisualStyleBackColor = true;
            // 
            // productsModBtn
            // 
            this.productsModBtn.Location = new System.Drawing.Point(774, 270);
            this.productsModBtn.Name = "productsModBtn";
            this.productsModBtn.Size = new System.Drawing.Size(75, 23);
            this.productsModBtn.TabIndex = 12;
            this.productsModBtn.Text = "Modify";
            this.productsModBtn.UseVisualStyleBackColor = true;
            // 
            // productsAddBtn
            // 
            this.productsAddBtn.Location = new System.Drawing.Point(693, 270);
            this.productsAddBtn.Name = "productsAddBtn";
            this.productsAddBtn.Size = new System.Drawing.Size(75, 23);
            this.productsAddBtn.TabIndex = 11;
            this.productsAddBtn.Text = "Add";
            this.productsAddBtn.UseVisualStyleBackColor = true;
            this.productsAddBtn.Click += new System.EventHandler(this.productsAddBtn_Click);
            // 
            // productsDeleteBtn
            // 
            this.productsDeleteBtn.Location = new System.Drawing.Point(855, 270);
            this.productsDeleteBtn.Name = "productsDeleteBtn";
            this.productsDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.productsDeleteBtn.TabIndex = 10;
            this.productsDeleteBtn.Text = "Delete";
            this.productsDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(855, 317);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 367);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.productsModBtn);
            this.Controls.Add(this.productsAddBtn);
            this.Controls.Add(this.productsDeleteBtn);
            this.Controls.Add(this.partsModBtn);
            this.Controls.Add(this.partsAddBtn);
            this.Controls.Add(this.partDeleteBtn);
            this.Controls.Add(this.productsSearchBox);
            this.Controls.Add(this.productsSearchBtn);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsSearchBox);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(967, 406);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.TextBox partsSearchBox;
        private System.Windows.Forms.TextBox productsSearchBox;
        private System.Windows.Forms.Button productsSearchBtn;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button partDeleteBtn;
        private System.Windows.Forms.Button partsAddBtn;
        private System.Windows.Forms.Button partsModBtn;
        private System.Windows.Forms.Button productsModBtn;
        private System.Windows.Forms.Button productsAddBtn;
        private System.Windows.Forms.Button productsDeleteBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

