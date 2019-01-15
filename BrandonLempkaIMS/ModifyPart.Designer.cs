namespace BrandonLempkaIMS
{
    partial class ModifyPart
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.minBox = new System.Windows.Forms.TextBox();
            this.machineBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.machineLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.inhouseRadio = new System.Windows.Forms.RadioButton();
            this.modPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(276, 304);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(190, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(272, 207);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(79, 20);
            this.minBox.TabIndex = 37;
            // 
            // machineBox
            // 
            this.machineBox.Location = new System.Drawing.Point(200, 237);
            this.machineBox.Name = "machineBox";
            this.machineBox.Size = new System.Drawing.Size(100, 20);
            this.machineBox.TabIndex = 36;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(157, 207);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(79, 20);
            this.maxBox.TabIndex = 35;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(200, 177);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 34;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Location = new System.Drawing.Point(200, 147);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryBox.TabIndex = 33;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(200, 117);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 32;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(200, 87);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 31;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(242, 210);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 30;
            this.minLabel.Text = "Min";
            // 
            // machineLabel
            // 
            this.machineLabel.AutoSize = true;
            this.machineLabel.Location = new System.Drawing.Point(124, 240);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.machineLabel.Size = new System.Drawing.Size(62, 13);
            this.machineLabel.TabIndex = 29;
            this.machineLabel.Text = "Machine ID";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(124, 210);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 28;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(124, 180);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 13);
            this.priceLabel.TabIndex = 27;
            this.priceLabel.Text = "Price / Cost";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(124, 150);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 26;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(124, 120);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(124, 90);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 24;
            this.idLabel.Text = "ID";
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(243, 17);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadio.TabIndex = 23;
            this.outsourcedRadio.TabStop = true;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            // 
            // inhouseRadio
            // 
            this.inhouseRadio.AutoSize = true;
            this.inhouseRadio.Location = new System.Drawing.Point(124, 17);
            this.inhouseRadio.Name = "inhouseRadio";
            this.inhouseRadio.Size = new System.Drawing.Size(68, 17);
            this.inhouseRadio.TabIndex = 22;
            this.inhouseRadio.TabStop = true;
            this.inhouseRadio.Text = "In-House";
            this.inhouseRadio.UseVisualStyleBackColor = true;
            // 
            // modPartLabel
            // 
            this.modPartLabel.AutoSize = true;
            this.modPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.modPartLabel.Location = new System.Drawing.Point(13, 13);
            this.modPartLabel.Name = "modPartLabel";
            this.modPartLabel.Size = new System.Drawing.Size(100, 22);
            this.modPartLabel.TabIndex = 21;
            this.modPartLabel.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 351);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.machineBox);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.machineLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.inhouseRadio);
            this.Controls.Add(this.modPartLabel);
            this.MaximumSize = new System.Drawing.Size(390, 390);
            this.MinimumSize = new System.Drawing.Size(390, 390);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox machineBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label machineLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.RadioButton inhouseRadio;
        private System.Windows.Forms.Label modPartLabel;
    }
}