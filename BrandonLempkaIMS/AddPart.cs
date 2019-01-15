using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonLempkaIMS
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            if (Inventory.AllParts.Count > 0)
            {
                txtId.Text = (Inventory.AllParts.Max(x => x.PartId) + 1).ToString();
            }

            else
            {
                txtId.Text = "1";
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Validation.ValidateString(txtName, btnSave);
            TestValidation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var inventory = txtInventory;
            var name = txtName;
            var price = txtPrice;
            var max = txtMax;
            var min = txtMin;
            var machineId = txtMachine;            
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {
            Validation.ValidateNumeric(txtInventory, btnSave);
            TestValidation();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Validation.ValidateNumeric(txtPrice, btnSave);
            TestValidation();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            Validation.ValidateNumeric(txtMax, btnSave);
            TestValidation();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            Validation.ValidateNumeric(txtMin, btnSave);
            TestValidation();
        }

        private void txtMachine_TextChanged(object sender, EventArgs e)
        {
            Validation.ValidateNumeric(txtMachine, btnSave);
            TestValidation();
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            Validation.ValidateString(txtCompanyName, btnSave);
            TestValidation();
        }

        private void radioInhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInhouse.Checked == true)
            {
                txtCompanyName.Visible = false;
                lblCompanyName.Visible = false;
                txtMachine.Visible = true;
                lblMachine.Visible = true;
            }
            else
            {
                txtMachine.Visible = false;
                lblMachine.Visible = false;
                txtCompanyName.Visible = true;
                lblCompanyName.Visible = true;
            }
        }

        private void TestValidation()
        {
            if (radioInhouse.Checked == true)
            {
                if (
                Validation.ValidateAllNumeric(txtMachine, btnSave) == false ||
                Validation.ValidateAllNumeric(txtMin, btnSave) == false ||
                Validation.ValidateAllNumeric(txtMax, btnSave) == false ||
                Validation.ValidateAllNumeric(txtPrice, btnSave) == false ||
                Validation.ValidateAllNumeric(txtPrice, btnSave) == false ||
                Validation.ValidateAllNumeric(txtInventory, btnSave) == false ||
                Validation.ValidateAllString(txtName, btnSave) == false)
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }

            }
            else
            {
                if (Validation.ValidateAllString(txtCompanyName, btnSave) == false ||
                Validation.ValidateAllNumeric(txtMin, btnSave) == false ||
                Validation.ValidateAllNumeric(txtMax, btnSave) == false ||
                Validation.ValidateAllNumeric(txtPrice, btnSave) == false ||
                Validation.ValidateAllNumeric(txtPrice, btnSave) == false ||
                Validation.ValidateAllNumeric(txtInventory, btnSave) == false ||
                Validation.ValidateAllString(txtName, btnSave) == false)
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }
        }

    }
}
