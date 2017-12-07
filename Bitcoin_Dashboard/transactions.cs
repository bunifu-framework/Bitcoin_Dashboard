using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class transactions : UserControl
    {
        public transactions()
        {
            InitializeComponent();
        }

        private void transactions_Load(object sender, EventArgs e)
        {
            

        }
        //create a method with the four parameters of type string
        public void AddTransaction(string ts_description, string linklabel, string ts_date, string ts_amount)
        {
            Descriptions.Text = ts_description;
            Link.Text = linklabel;
            Date.Text = ts_date;
            Amount.Text = ts_amount;
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }
    }
}
