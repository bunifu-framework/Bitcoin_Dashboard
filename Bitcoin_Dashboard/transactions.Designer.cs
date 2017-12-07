namespace ContactList
{
    partial class transactions
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
            this.Descriptions = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Amount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Descriptions
            // 
            this.Descriptions.AutoSize = true;
            this.Descriptions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Descriptions.Location = new System.Drawing.Point(8, 10);
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.Size = new System.Drawing.Size(66, 13);
            this.Descriptions.TabIndex = 0;
            this.Descriptions.Text = "Description";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.Amount.Location = new System.Drawing.Point(8, 27);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(58, 17);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "Amount";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Date.Location = new System.Drawing.Point(234, 10);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(89, 13);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Link
            // 
            this.Link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.Link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.Link.Location = new System.Drawing.Point(146, 10);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(28, 13);
            this.Link.TabIndex = 3;
            this.Link.TabStop = true;
            this.Link.Text = "Link";
            this.Link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Descriptions);
            this.Name = "transactions";
            this.Size = new System.Drawing.Size(333, 55);
            this.Load += new System.EventHandler(this.transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Descriptions;
        private Bunifu.Framework.UI.BunifuCustomLabel Amount;
        private Bunifu.Framework.UI.BunifuCustomLabel Date;
        private System.Windows.Forms.LinkLabel Link;
    }
}
