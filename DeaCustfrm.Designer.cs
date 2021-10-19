
namespace BookStore.UI
{
    partial class DeaCustfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeaCustfrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTOP = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTYpe = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.cmbdealcust = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btmUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 57);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1350, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(45, 41);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTOP
            // 
            this.lblTOP.AutoSize = true;
            this.lblTOP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOP.Location = new System.Drawing.Point(598, 9);
            this.lblTOP.Name = "lblTOP";
            this.lblTOP.Size = new System.Drawing.Size(224, 28);
            this.lblTOP.TabIndex = 0;
            this.lblTOP.Text = "DEALER and CUSTOMER";
            this.lblTOP.Click += new System.EventHandler(this.lblTOP_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 82);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 23);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Customer ID";
            // 
            // lblTYpe
            // 
            this.lblTYpe.AutoSize = true;
            this.lblTYpe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTYpe.Location = new System.Drawing.Point(21, 149);
            this.lblTYpe.Name = "lblTYpe";
            this.lblTYpe.Size = new System.Drawing.Size(45, 23);
            this.lblTYpe.TabIndex = 3;
            this.lblTYpe.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 218);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 288);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(21, 430);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(21, 360);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(70, 23);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Contact";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(179, 82);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(454, 30);
            this.txtCustomerID.TabIndex = 8;
            // 
            // cmbdealcust
            // 
            this.cmbdealcust.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdealcust.FormattingEnabled = true;
            this.cmbdealcust.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbdealcust.Location = new System.Drawing.Point(179, 146);
            this.cmbdealcust.Name = "cmbdealcust";
            this.cmbdealcust.Size = new System.Drawing.Size(454, 31);
            this.cmbdealcust.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(179, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 30);
            this.textBox1.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(179, 288);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(454, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(179, 360);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(454, 30);
            this.txtContact.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(179, 430);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(454, 159);
            this.txtAddress.TabIndex = 13;
            // 
            // btmUpdate
            // 
            this.btmUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.btmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmUpdate.Location = new System.Drawing.Point(639, 628);
            this.btmUpdate.Name = "btmUpdate";
            this.btmUpdate.Size = new System.Drawing.Size(160, 74);
            this.btmUpdate.TabIndex = 16;
            this.btmUpdate.Text = "UPDATE";
            this.btmUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(817, 628);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 74);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE ";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(462, 628);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 74);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(740, 146);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(636, 443);
            this.dgvCategories.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(838, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(538, 30);
            this.txtSearch.TabIndex = 19;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(738, 82);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 23);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search";
            // 
            // DeaCustfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1406, 742);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btmUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbdealcust);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTYpe);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeaCustfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeaCustfrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTOP;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTYpe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ComboBox cmbdealcust;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btmUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}