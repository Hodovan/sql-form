namespace SqlForm
{
    partial class Main
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
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.mitContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.mitBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.mitWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mitWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mitWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mitWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mitExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitContacts,
            this.mitWindows});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(884, 24);
            this.mstMenu.TabIndex = 0;
            this.mstMenu.Text = "menuStrip1";
            // 
            // mitContacts
            // 
            this.mitContacts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitBusiness,
            this.mitExit});
            this.mitContacts.Name = "mitContacts";
            this.mitContacts.Size = new System.Drawing.Size(66, 20);
            this.mitContacts.Text = "Contacts";
            // 
            // mitBusiness
            // 
            this.mitBusiness.Name = "mitBusiness";
            this.mitBusiness.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mitBusiness.Size = new System.Drawing.Size(180, 22);
            this.mitBusiness.Text = "Business";
            this.mitBusiness.Click += new System.EventHandler(this.mitBusiness_Click);
            // 
            // mitWindows
            // 
            this.mitWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitWindowCascade,
            this.mitWindowVertical,
            this.mitWindowHorizontal});
            this.mitWindows.Name = "mitWindows";
            this.mitWindows.Size = new System.Drawing.Size(68, 20);
            this.mitWindows.Text = "Windows";
            // 
            // mitWindowCascade
            // 
            this.mitWindowCascade.Name = "mitWindowCascade";
            this.mitWindowCascade.Size = new System.Drawing.Size(180, 22);
            this.mitWindowCascade.Text = "Cascade";
            this.mitWindowCascade.Click += new System.EventHandler(this.mitWindowCascade_Click);
            // 
            // mitWindowVertical
            // 
            this.mitWindowVertical.Name = "mitWindowVertical";
            this.mitWindowVertical.Size = new System.Drawing.Size(180, 22);
            this.mitWindowVertical.Text = "Tile Vertical";
            this.mitWindowVertical.Click += new System.EventHandler(this.mitWindowVertical_Click);
            // 
            // mitWindowHorizontal
            // 
            this.mitWindowHorizontal.Name = "mitWindowHorizontal";
            this.mitWindowHorizontal.Size = new System.Drawing.Size(180, 22);
            this.mitWindowHorizontal.Text = "Tile Horizontal";
            this.mitWindowHorizontal.Click += new System.EventHandler(this.mitWindowHorizontal_Click);
            // 
            // mitExit
            // 
            this.mitExit.Name = "mitExit";
            this.mitExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mitExit.Size = new System.Drawing.Size(180, 22);
            this.mitExit.Text = "Exit";
            this.mitExit.Click += new System.EventHandler(this.mitExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mstMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMenu;
            this.Name = "Main";
            this.Text = "Contact Management";
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem mitContacts;
        private System.Windows.Forms.ToolStripMenuItem mitBusiness;
        private System.Windows.Forms.ToolStripMenuItem mitWindows;
        private System.Windows.Forms.ToolStripMenuItem mitWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mitWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem mitWindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mitExit;
    }
}

