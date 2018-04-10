namespace MHUCA
{
    partial class FrmQuery
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.CmbMonster = new System.Windows.Forms.ComboBox();
            this.CmbWeapon = new System.Windows.Forms.ComboBox();
            this.lblCharmHeader = new System.Windows.Forms.Label();
            this.lblItemHeader = new System.Windows.Forms.Label();
            this.lblArmorHeader = new System.Windows.Forms.Label();
            this.lblWeaponHeader = new System.Windows.Forms.Label();
            this.lblMonsterListHeader = new System.Windows.Forms.Label();
            this.CmbArmor = new System.Windows.Forms.ComboBox();
            this.CmbItems = new System.Windows.Forms.ComboBox();
            this.cmbCharms = new System.Windows.Forms.ComboBox();
            this.CmbMap = new System.Windows.Forms.ComboBox();
            this.lblMapHeader = new System.Windows.Forms.Label();
            this.mnuTaskBar = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnConfirm.Location = new System.Drawing.Point(64, 359);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(181, 31);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm Selection";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CmbMonster
            // 
            this.CmbMonster.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CmbMonster.FormattingEnabled = true;
            this.CmbMonster.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CmbMonster.Location = new System.Drawing.Point(25, 118);
            this.CmbMonster.Name = "CmbMonster";
            this.CmbMonster.Size = new System.Drawing.Size(121, 31);
            this.CmbMonster.TabIndex = 2;
            this.CmbMonster.Text = "Select Here...";
            // 
            // CmbWeapon
            // 
            this.CmbWeapon.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CmbWeapon.FormattingEnabled = true;
            this.CmbWeapon.Items.AddRange(new object[] {
            "1"});
            this.CmbWeapon.Location = new System.Drawing.Point(180, 118);
            this.CmbWeapon.Name = "CmbWeapon";
            this.CmbWeapon.Size = new System.Drawing.Size(121, 31);
            this.CmbWeapon.TabIndex = 2;
            this.CmbWeapon.Text = "Select Here...";
            // 
            // lblCharmHeader
            // 
            this.lblCharmHeader.AutoSize = true;
            this.lblCharmHeader.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCharmHeader.Location = new System.Drawing.Point(40, 253);
            this.lblCharmHeader.Name = "lblCharmHeader";
            this.lblCharmHeader.Size = new System.Drawing.Size(80, 23);
            this.lblCharmHeader.TabIndex = 3;
            this.lblCharmHeader.Text = "Charms :";
            // 
            // lblItemHeader
            // 
            this.lblItemHeader.AutoSize = true;
            this.lblItemHeader.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblItemHeader.Location = new System.Drawing.Point(208, 172);
            this.lblItemHeader.Name = "lblItemHeader";
            this.lblItemHeader.Size = new System.Drawing.Size(63, 23);
            this.lblItemHeader.TabIndex = 4;
            this.lblItemHeader.Text = "Items :";
            // 
            // lblArmorHeader
            // 
            this.lblArmorHeader.AutoSize = true;
            this.lblArmorHeader.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblArmorHeader.Location = new System.Drawing.Point(47, 172);
            this.lblArmorHeader.Name = "lblArmorHeader";
            this.lblArmorHeader.Size = new System.Drawing.Size(73, 23);
            this.lblArmorHeader.TabIndex = 5;
            this.lblArmorHeader.Text = "Armor :";
            // 
            // lblWeaponHeader
            // 
            this.lblWeaponHeader.AutoSize = true;
            this.lblWeaponHeader.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWeaponHeader.Location = new System.Drawing.Point(195, 92);
            this.lblWeaponHeader.Name = "lblWeaponHeader";
            this.lblWeaponHeader.Size = new System.Drawing.Size(92, 23);
            this.lblWeaponHeader.TabIndex = 6;
            this.lblWeaponHeader.Text = "Weapons :";
            // 
            // lblMonsterListHeader
            // 
            this.lblMonsterListHeader.AutoSize = true;
            this.lblMonsterListHeader.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMonsterListHeader.Location = new System.Drawing.Point(38, 92);
            this.lblMonsterListHeader.Name = "lblMonsterListHeader";
            this.lblMonsterListHeader.Size = new System.Drawing.Size(91, 23);
            this.lblMonsterListHeader.TabIndex = 7;
            this.lblMonsterListHeader.Text = "Monsters :";
            // 
            // CmbArmor
            // 
            this.CmbArmor.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CmbArmor.FormattingEnabled = true;
            this.CmbArmor.Items.AddRange(new object[] {
            "1"});
            this.CmbArmor.Location = new System.Drawing.Point(25, 198);
            this.CmbArmor.Name = "CmbArmor";
            this.CmbArmor.Size = new System.Drawing.Size(121, 31);
            this.CmbArmor.TabIndex = 2;
            this.CmbArmor.Text = "Select Here...";
            // 
            // CmbItems
            // 
            this.CmbItems.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CmbItems.FormattingEnabled = true;
            this.CmbItems.Items.AddRange(new object[] {
            "1"});
            this.CmbItems.Location = new System.Drawing.Point(180, 198);
            this.CmbItems.Name = "CmbItems";
            this.CmbItems.Size = new System.Drawing.Size(121, 31);
            this.CmbItems.TabIndex = 2;
            this.CmbItems.Text = "Select Here...";
            // 
            // cmbCharms
            // 
            this.cmbCharms.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbCharms.FormattingEnabled = true;
            this.cmbCharms.Items.AddRange(new object[] {
            "1"});
            this.cmbCharms.Location = new System.Drawing.Point(25, 279);
            this.cmbCharms.Name = "cmbCharms";
            this.cmbCharms.Size = new System.Drawing.Size(121, 31);
            this.cmbCharms.TabIndex = 2;
            this.cmbCharms.Text = "Select Here...";
            // 
            // CmbMap
            // 
            this.CmbMap.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CmbMap.FormattingEnabled = true;
            this.CmbMap.Items.AddRange(new object[] {
            "1"});
            this.CmbMap.Location = new System.Drawing.Point(180, 279);
            this.CmbMap.Name = "CmbMap";
            this.CmbMap.Size = new System.Drawing.Size(121, 31);
            this.CmbMap.TabIndex = 2;
            this.CmbMap.Text = "Select Here...";
            // 
            // lblMapHeader
            // 
            this.lblMapHeader.AutoSize = true;
            this.lblMapHeader.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMapHeader.Location = new System.Drawing.Point(208, 253);
            this.lblMapHeader.Name = "lblMapHeader";
            this.lblMapHeader.Size = new System.Drawing.Size(55, 23);
            this.lblMapHeader.TabIndex = 3;
            this.lblMapHeader.Text = "Map :";
            // 
            // mnuTaskBar
            // 
            this.mnuTaskBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuTaskBar.Location = new System.Drawing.Point(0, 0);
            this.mnuTaskBar.Name = "mnuTaskBar";
            this.mnuTaskBar.Size = new System.Drawing.Size(326, 24);
            this.mnuTaskBar.TabIndex = 8;
            this.mnuTaskBar.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "&Clear";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // FrmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 402);
            this.Controls.Add(this.mnuTaskBar);
            this.Controls.Add(this.lblMapHeader);
            this.Controls.Add(this.lblCharmHeader);
            this.Controls.Add(this.lblItemHeader);
            this.Controls.Add(this.lblArmorHeader);
            this.Controls.Add(this.lblWeaponHeader);
            this.Controls.Add(this.CmbMap);
            this.Controls.Add(this.lblMonsterListHeader);
            this.Controls.Add(this.cmbCharms);
            this.Controls.Add(this.CmbItems);
            this.Controls.Add(this.CmbArmor);
            this.Controls.Add(this.CmbWeapon);
            this.Controls.Add(this.CmbMonster);
            this.Controls.Add(this.btnConfirm);
            this.Name = "FrmQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inquiry";
            this.mnuTaskBar.ResumeLayout(false);
            this.mnuTaskBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox CmbWeapon;
        private System.Windows.Forms.Label lblCharmHeader;
        private System.Windows.Forms.Label lblItemHeader;
        private System.Windows.Forms.Label lblArmorHeader;
        private System.Windows.Forms.Label lblWeaponHeader;
        private System.Windows.Forms.Label lblMonsterListHeader;
        private System.Windows.Forms.ComboBox CmbArmor;
        private System.Windows.Forms.ComboBox CmbItems;
        private System.Windows.Forms.ComboBox cmbCharms;
        private System.Windows.Forms.ComboBox CmbMap;
        private System.Windows.Forms.Label lblMapHeader;
        private System.Windows.Forms.MenuStrip mnuTaskBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ComboBox CmbMonster;
    }
}