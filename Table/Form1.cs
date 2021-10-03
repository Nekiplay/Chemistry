using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem();
            listViewSubItem.Text = "Водород";


            listViewItem.SubItems.Add(listViewSubItem);
            listView1.Items.Add(listViewItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
