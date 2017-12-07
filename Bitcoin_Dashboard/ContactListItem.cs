using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ContactList
{
    public partial class ContactListItem : UserControl
    {
        public ContactListItem()
        {
            InitializeComponent();
        }
        // This adds a new Contact control.
        public void Add( string name, string mailtext, bool selected, string _path)
        {
           // Set the texts for the two values.
            Contact_name.Text = name;
            email.Text = mailtext;
            this.Active = selected;

            if (_path != "")
            bunifuImageButton1.Image = Image.FromFile(_path);
        }
        //in the mousehover event set the backcolor
        private void contactList1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(48, 177, 175);
            bunifuImageButton1.BackColor = Color.FromArgb(48, 177, 175);
        }
        //in the mouseleave event set backcolor for both the image and control
        private void contactList1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(27, 36, 45);
            bunifuImageButton1.BackColor = Color.FromArgb(27, 36, 45);
        }

        private void ContactList_Load(object sender, EventArgs e)
        {

        }

        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        private bool active = false;
        [DefaultValue(false)]
        public bool Active
        {
            get { return active; }
            set
            {
                active = value;

                if (active==true)
                    this.BackColor = Color.FromArgb(48, 177, 175);
                //bunifuImageButton1.BackColor = Color.FromArgb(48, 177, 175);


            }
        }

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
        private void RecreateRegion()
        {
            var bounds = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
            bounds.Inflate(-1, -1);
            this.Region = new Region(GetRoundRectagle(bounds, this.Radius));
            this.Invalidate();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
    }
}
