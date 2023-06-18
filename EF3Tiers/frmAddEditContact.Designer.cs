namespace EF3Tiers
{
    partial class frmAddEditContact
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.tboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(594, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Name:";
            // 
            // tboxContactName
            // 
            this.tboxContactName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "ContactName", true));
            this.tboxContactName.Location = new System.Drawing.Point(104, 34);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(565, 24);
            this.tboxContactName.TabIndex = 0;
            // 
            // tboxPhoneNumber
            // 
            this.tboxPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "PhoneNumber", true));
            this.tboxPhoneNumber.Location = new System.Drawing.Point(104, 64);
            this.tboxPhoneNumber.Name = "tboxPhoneNumber";
            this.tboxPhoneNumber.Size = new System.Drawing.Size(565, 24);
            this.tboxPhoneNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number:";
            // 
            // tboxEmail
            // 
            this.tboxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Email", true));
            this.tboxEmail.Location = new System.Drawing.Point(104, 94);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(565, 24);
            this.tboxEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // tboxAddress
            // 
            this.tboxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Address", true));
            this.tboxAddress.Location = new System.Drawing.Point(104, 124);
            this.tboxAddress.Multiline = true;
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(565, 130);
            this.tboxAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address:";
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataSource = typeof(Model.Contacts);
            // 
            // contactsBindingSource1
            // 
            this.contactsBindingSource1.DataSource = typeof(Model.Contacts);
            // 
            // contactsBindingSource2
            // 
            this.contactsBindingSource2.DataSource = typeof(Model.Contacts);
            // 
            // contactsBindingSource3
            // 
            this.contactsBindingSource3.DataSource = typeof(Model.Contacts);
            // 
            // frmAddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 317);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddEditContact";
            this.Text = "frmAddEditContact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditContact_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxContactName;
        private System.Windows.Forms.TextBox tboxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.BindingSource contactsBindingSource1;
        private System.Windows.Forms.BindingSource contactsBindingSource2;
        private System.Windows.Forms.BindingSource contactsBindingSource3;
    }
}