using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PurchaseManager
{
    public partial class PurchaseMan : Form
    {
        public PurchaseMan()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void newPurchase_Click(object sender, EventArgs e)
        {
            PurchaseEntry newPurchase = new PurchaseEntry();
            newPurchase.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendorDetails newVendor = new VendorDetails();
            newVendor.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ItemDetails newItem = new ItemDetails();
            newItem.ShowDialog();
        }
    }
}
