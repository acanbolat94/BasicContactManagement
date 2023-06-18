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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //contactsBindingSource.DataSource = ContactServices.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditContact frm = new frmAddEditContact(null))
            {
                if (frm.ShowDialog()==DialogResult.OK)
                {
                    contactsBindingSource.DataSource = ContactServices.GetAll();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (contactsBindingSource.Current == null)
                return;
            using (frmAddEditContact frm = new frmAddEditContact(contactsBindingSource.Current as Contacts))
            {
                if (frm.ShowDialog()==DialogResult.OK)
                {
                    contactsBindingSource.DataSource = ContactServices.GetAll();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (contactsBindingSource.Current ==null)
                return;
            if (MessageBox.Show("Want to delete ? ","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ContactServices.Delete(contactsBindingSource.Current as Contacts);
                contactsBindingSource.RemoveCurrent();
            }
        }
    }
}
