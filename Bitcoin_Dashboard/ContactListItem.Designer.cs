namespace ContactList
{
    partial class ContactListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactListItem));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Contact_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(5, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(41, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.MouseLeave += new System.EventHandler(this.contactList1_MouseLeave);
            this.bunifuImageButton1.MouseHover += new System.EventHandler(this.contactList1_MouseHover);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(47, 20);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 2;
            this.email.Text = "EMAIL";
            this.email.MouseLeave += new System.EventHandler(this.contactList1_MouseLeave);
            this.email.MouseHover += new System.EventHandler(this.contactList1_MouseHover);
            // 
            // Contact_name
            // 
            this.Contact_name.AutoSize = true;
            this.Contact_name.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_name.ForeColor = System.Drawing.Color.White;
            this.Contact_name.Location = new System.Drawing.Point(46, 7);
            this.Contact_name.Name = "Contact_name";
            this.Contact_name.Size = new System.Drawing.Size(89, 13);
            this.Contact_name.TabIndex = 1;
            this.Contact_name.Text = "CONTACT NAME";
            this.Contact_name.MouseLeave += new System.EventHandler(this.contactList1_MouseLeave);
            this.Contact_name.MouseHover += new System.EventHandler(this.contactList1_MouseHover);
            // 
            // ContactListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.email);
            this.Controls.Add(this.Contact_name);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "ContactListItem";
            this.Size = new System.Drawing.Size(168, 41);
            this.Load += new System.EventHandler(this.ContactList_Load);
            this.MouseLeave += new System.EventHandler(this.contactList1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.contactList1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel email;
        private Bunifu.Framework.UI.BunifuCustomLabel Contact_name;
    }
}
