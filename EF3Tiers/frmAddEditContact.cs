using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF3Tiers
{
    public partial class frmAddEditContact : Form
    {
        public frmAddEditContact(Contacts obj)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            if (obj == null)
            {
                contactsBindingSource.DataSource = new Contacts();
                IsNew = true;
            }
            else
            {
                contactsBindingSource.DataSource = obj;
                IsNew = false;
            }
        }
        bool IsNew;
        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            AcceptButton = btnAdd;
        }

        private void frmAddEditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tboxContactName.Text))
                {
                    MessageBox.Show("Please enter contact name.","Message");
                    tboxContactName.Focus();
                    e.Cancel = true;
                    return;
                }
                if (IsNew)
                    ContactServices.Insert(contactsBindingSource.Current as Contacts);
                else
                    ContactServices.Update(contactsBindingSource.Current as Contacts);
            }
        }
    }
}
