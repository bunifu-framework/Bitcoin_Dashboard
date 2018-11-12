using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AddContact(string Contact_name, string email, bool selected = false, string path="")
        {
            // Create a new ContactListItem and set the required parameters with the "Add" method.
            ContactListItem contact_item = new ContactListItem();
            contact_item.Add(Contact_name, email,selected,path);
            // Then set the ContactListItem's Dock property to "Top".
            contact_item.Dock = DockStyle.Top;
            // Add the ContactListItem to the Panel.
            panel1.Controls.Add(contact_item);
            // Finally, bring the ContactListItem to the front to avoid disarrangements.
            contact_item.BringToFront();

        }

        // Add a list of pre-defined ContactListItems.
        public void AddContacts()
        {
            AddContact("Visual Idiot", "Vi@su.al",false, @"C: \Users\Beckie\Pictures\avatars\avatar-one.jpg");
            AddContact("Kerem Suer", "Kerem@kerem.co",false, @"C:\Users\Beckie\Pictures\avatars\avatar-two.jpg");
            AddContact("Josh Hamsley", "Josh@hamsley.com",false, @"C:\Users\Beckie\Pictures\avatars\avatar-three.jpg");
            AddContact("Fabio", "fabio@ffabs.com",false, @"C:\Users\Beckie\Pictures\avatars\avatar-four.jpg");
            AddContact("Anthony Lagoon", "anthony@lagoon.co",false, @"C:\Users\Beckie\Pictures\avatars\avatar-five.png");
            AddContact("Jenny Shen", "jen@shen.co",false, @"C:\Users\Beckie\Pictures\avatars\avatar-six.png");
            AddContact("Charlie Waite", "charlie@focuslab.com",false, @"C:\Users\Beckie\Pictures\avatars\avatar-seven.png");
            AddContact("Ed Wellbrook", "El@wb.co",false, @"C:\Users\Beckie\Pictures\avatars\avatar-eight.png");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddContacts();
            AddList();
        }

        public void Addts(string description, string link, string date, string amount)
        {
            // Create a new transactionItem and set the required parameters with the "Add" method.
            transactions ts_item = new transactions();
            ts_item.AddTransaction(description, link,date,amount);
           // set autoscroll property to true
            flowLayoutPanel1.AutoScroll = true;
            // Add the transactionItem to the Panel.
            flowLayoutPanel1.Controls.Add(ts_item);
            // Finally, bring the transactionItem to the front to avoid disarrangements.
            ts_item.BringToFront();
        }
        // Add a list of pre-defined transactionItems using the Addts method
        public void AddList()
        {
            Addts("You received bitcoins from","Kerem Suer","25th May,2014","$320.000,00");
            Addts("You transferred bitcoins to","Facebook LCC","25th May, 2014","$20.080,24");
            Addts("You transferred bitcoins to", "Jenny Shen", "24th May, 2014", "$20.080,24");
            Addts("You received bitcoins from", "Anthony Lagoon", "24th May,2014", "$320.000,00");
            Addts("You transferred bitcoins to", "Jenny Shen", "25th May, 2014", "$20.080,24");
            Addts("You received bitcoins from", "Kerem Suer", "25th May,2014", "$320.000,00");
            Addts("You transferred bitcoins to", "Facebook LCC", "25th May, 2014", "$20.080,24");
            Addts("You received bitcoins from", "Jenny Shen", "25th May,2014", "$320.000,00");
            Addts("You transferred bitcoins to", "Facebook LCC", "25th May, 2014", "$20.080,24");
           
        }


      
        public void plotdata()
        {
            var canvas1 = new Bunifu.DataViz.WinForms.Canvas();
            var datapoints1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            datapoints1.addLabely("Apr","700");
            datapoints1.addLabely("May","430");
            datapoints1.addLabely("Jun","440");
            datapoints1.addLabely("Jul","750");
            datapoints1.addLabely("Aug","770");
            datapoints1.addLabely("Sep","600");
            datapoints1.addLabely("Oct","560");
            datapoints1.addLabely("Nov","200");
            datapoints1.addLabely("Dec", "750");

            //add the datapoints to the canvas
            canvas1.addData(datapoints1);
            //render te chart
            bunifuDataViz1.Render(canvas1);

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            plotdata();   
        }
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }
    }
}
